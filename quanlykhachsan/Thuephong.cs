using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlykhachsan
{
    public partial class Thuephong : Form
    {
        public Thuephong()
        {
            InitializeComponent();
        }  
        private void button1_Click(object sender, EventArgs e)
        {
            QL_Khachhang f = new QL_Khachhang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        public SqlConnection cn = new SqlConnection();
        Connection con = new Connection();
        public void ketnoi()
        {
            try
            {
                cn.ConnectionString = con._connectionString;
                if (cn.State != ConnectionState.Open)
                {                   
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ngatketnoi()
        {
            cn.Close();
        }
        public DataTable xemdl(string sql)
        {
            
            ketnoi();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            ngatketnoi();
            return dt;           
        }
        public SqlCommand thucthidl(string sql)
        {
            ketnoi();
            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            ngatketnoi();
            return cm;
            
        }                                     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvKhach.DataSource = xemdl(@"select*from tbl_khachhang where TENKHACHHANG like '%" + textBox1.Text.Trim() + "%'");
        }       
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dgvPhong.DataSource = xemdl(@"select*from tbl_phong where LOAIPHONG like '%" + textBox2.Text.Trim() + "%'");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ketnoi1()
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Open();
                string sql1 = "select*from tbl_phieuthuephong";
                SqlCommand commandsql1 = new SqlCommand(sql1, kn1);
                SqlDataAdapter com = new SqlDataAdapter(commandsql1);
                DataTable table1 = new DataTable();
                com.Fill(table1);
                dgvThuephong.DataSource = table1;
                DateTime tn = DateTime.Now;
                txtNgayden.Text = tn.ToShortDateString();
                // txtNgaydi.Text = tn.ToString("yyyy/MM/dd");
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Close();
            }
        }         
        string them;
        string sua;
        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgvThuephong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvThuephong.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
                txtMaphieu.Text = "PTP0" + (chuoi2 + 1).ToString();
            else
                txtMaphieu.Text = "PTP" + (chuoi2 + 1).ToString();
            try
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Open();
                them = @"INSERT INTO tbl_phieuthuephong(MAPHIEUTHUE,MANHANVIEN,MAKHACHHANG,NGAYDEN,MAPHONG)
VALUES (N'" + txtMaphieu.Text + "',N'" + txtManv.Text + "',N'" + txtMaKH.Text + "',N'" + txtNgayden.Text + "',N'" + txtMaphong.Text + "')";
              
                {
                    sua = @"UPDATE tbl_phong SET
                TINHTRANG=N' Có khách '
                WHERE (MAPHONG=N'" + txtMaphong.Text + @"')";
                    SqlCommand commandsua = new SqlCommand(sua, kn1);
                    commandsua.ExecuteNonQuery();
                    SqlCommand commandthem = new SqlCommand(them, kn1);
                    commandthem.ExecuteNonQuery();
                    ketnoi1();

                    MessageBox.Show("Thuê phòng thành công!");
                }          
            }
            catch
            {              
                MessageBox.Show("Lỗi!");
            }
            finally
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Close();
            }
        }
        int index;
        private void dgvKhach_Click(object sender, EventArgs e)
        {
            index = dgvKhach.CurrentRow.Index;
            txtMaKH.Text = dgvKhach.Rows[index].Cells[0].Value.ToString();          
        }

        private void dgvPhong_Click(object sender, EventArgs e)
        {
            index = dgvPhong.CurrentRow.Index;
            txtMaphong.Text = dgvPhong.Rows[index].Cells[0].Value.ToString();
            txtGiaphong.Text = dgvPhong.Rows[index].Cells[2].Value.ToString();
        }          
        private void Thuephong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_nhanvien' table. You can move, or remove it, as needed.
            //this.tbl_nhanvienTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_nhanvien);
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_phieuthuephong' table. You can move, or remove it, as needed.
            //this.tbl_phieuthuephongTableAdapter1.Fill(this.quanlykhachsandemo2304DataSet.tbl_phieuthuephong);
            dgvPhong.DataSource = xemdl("select *  from tbl_phong where TINHTRANG = N'Trống'");
            dgvKhach.DataSource = xemdl(@"select*from tbl_khachhang");
            ketnoi1();
        }
        //int index1;
        private void dgvThuephong_Click(object sender, EventArgs e)
        {
            //index = dgvThuephong.CurrentRow.Index;
            //txtMaphieu.Text = dgvPhong.Rows[index1].Cells[0].Value.ToString();
        }
        string xoa;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Open();
                xoa = @"DELETE FROM tbl_phieuthuephong WHERE (MAPHIEUTHUE=N'" + txtMaphieu.Text + @"')";
                SqlCommand commandxoa = new SqlCommand(xoa, kn1);
                commandxoa.ExecuteNonQuery();
                ketnoi1();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Close();
            }
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = xemdl("select *  from tbl_phong where TINHTRANG = N'Trống'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvKhach.DataSource = xemdl(@"select*from tbl_khachhang");
        }

        private void dgvKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }  
}
