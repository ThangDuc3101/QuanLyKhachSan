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
    public partial class hoadondichvu : Form
    {
        //đã sửa xong

        public hoadondichvu()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(con._connectionString);
                kn.Open();
                string sql = "select * from tbl_hoadondichvu";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dgvhoadondv.DataSource = table;
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(con._connectionString);
                kn.Close();
            }
        }
        private void btnTao_Click(object sender, EventArgs e)
        {            
            int count = 0;
            count = dgvhoadondv.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgvhoadondv.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 4)));
            if (chuoi2 + 1 < 10)
                txtMahd.Text = "HDDV0" + (chuoi2 + 1).ToString();
            else
                txtMahd.Text = "HDDV" + (chuoi2 + 1).ToString();
            try
            {
                SqlConnection kn = new SqlConnection(con._connectionString);
                kn.Open();
                string tao = @"INSERT INTO tbl_hoadondichvu(MAHOADONDICHVU,MAKHACHHANG,THOIGIANLAP)
            VALUES (N'" + txtMahd.Text + @"',N'" + txtMaKH.Text + @"',N'" + txtNgay.Text + @"')";
                SqlCommand commandthem = new SqlCommand(tao, kn);
                commandthem.ExecuteNonQuery();
                ketnoi();
            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(con._connectionString);
                kn.Close();
            }
        }
        private void btnChitiet_Click(object sender, EventArgs e)
        {
            testdv.MAHOADONDICHVU = txtMahd.Text.Trim();       
            testdv m = new testdv();
            m.ShowDialog();
            this.Close();           
        }
        private void dgvhoadondv_Click(object sender, EventArgs e)
        {
            int index = dgvhoadondv.CurrentRow.Index;
            txtMahd.Text = dgvhoadondv.Rows[index].Cells[0].Value.ToString();
            txtMaKH.Text = dgvhoadondv.Rows[index].Cells[1].Value.ToString();
            txtNgay.Text = dgvhoadondv.Rows[index].Cells[2].Value.ToString();          
        }
        public SqlConnection cn = new SqlConnection();
        public void ketnoi1()
        {
            try
            {
                cn.ConnectionString = con._connectionString;
                if (cn.State == 0)
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
            if (cn.State != 0)
            {
                cn.Close();
            }
        }
        public DataTable xemdl(string sql)
        {
            ketnoi1();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            ngatketnoi();
            return dt;           
        }
        public SqlCommand thucthidl(string sql)
        {
            ketnoi1();
            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();
            ngatketnoi();
            return cm;          
        }        
        private void hoadondichvu_Load(object sender, EventArgs e)
        {
            //this.tbl_khachhangTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_khachhang);
            ketnoi();
            DateTime tn = DateTime.Now;
            txtNgay.Text = tn.ToShortDateString();           
            ketnoi1();
        }
        private void txtTKKH_TextChanged(object sender, EventArgs e)
        {
            dgvKH.DataSource = xemdl(@"select*from tbl_khachhang where TENKHACHHANG like '%" + txtTKKH.Text.Trim() + "%'");
        }
        private void dgvKH_Click(object sender, EventArgs e)
        {
            int index = dgvKH.CurrentRow.Index;
            txtMaKH.Text = dgvKH.Rows[index].Cells[0].Value.ToString();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
