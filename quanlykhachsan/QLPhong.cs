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
    public partial class QLPhong : Form
    {
        // file này đã được sửa

        public QLPhong()
        {
            InitializeComponent();
        }

        Connection con = new Connection();
        private void ketnoi()
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Open();
                string sql1 = "select*from tbl_phong";
                SqlCommand commandsql1 = new SqlCommand(sql1, kn1);
                SqlDataAdapter com = new SqlDataAdapter(commandsql1);
                DataTable table1 = new DataTable();
                com.Fill(table1);
                dgvPhong.DataSource = table1;
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

        private void QLPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_phong' table. You can move, or remove it, as needed.
            //this.tbl_phongTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_phong);
            ketnoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string them;

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Open();
                them = @"INSERT INTO tbl_phong(MAPHONG,LOAIPHONG,GIAPHONG,TINHTRANG)
VALUES (N'" + txtMaphong.Text + @"',N'" + cbLoaiphong.Text + @"',N'" + txtGiaphong.Text + @"',N'" + cbTinhtrang.Text + @"')";
                SqlCommand commandthem = new SqlCommand(them, kn1);
                commandthem.ExecuteNonQuery();
                ketnoi();
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
        int index;

        private void dgvPhong_Click(object sender, EventArgs e)
        {
            index = dgvPhong.CurrentRow.Index;
            txtMaphong.Text = dgvPhong.Rows[index].Cells[0].Value.ToString();
            txtGiaphong.Text = dgvPhong.Rows[index].Cells[2].Value.ToString();
            cbLoaiphong.Text = dgvPhong.Rows[index].Cells[1].Value.ToString();
            cbTinhtrang.Text = dgvPhong.Rows[index].Cells[4].Value.ToString();
        }
        string sua;

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Open();
                sua = @"UPDATE tbl_Phong set
                MAPHONG=N'" + txtMaphong.Text + @"',LOAIPHONG=N'" + cbLoaiphong.Text + @"',GIAPHONG=N'" + txtGiaphong.Text + @"',TINHTRANG=N'" + cbTinhtrang.Text + @"'
                WHERE (MAPHONG=N'" + txtMaphong.Text + @"')";
                SqlCommand commandsua = new SqlCommand(sua, kn1);
                commandsua.ExecuteNonQuery();
                ketnoi();
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
        string xoa;

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(con._connectionString);
                kn1.Open();
                xoa = @"DELETE FROM tbl_phong WHERE (MAPHONG=N'" + txtMaphong.Text + @"')";
                SqlCommand commandxoa = new SqlCommand(xoa, kn1);
                commandxoa.ExecuteNonQuery();
                ketnoi();
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
    }
}
