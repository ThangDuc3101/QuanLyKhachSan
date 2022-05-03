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
    public partial class TKDOANHTHUDV : Form
    {
        public TKDOANHTHUDV()
        {
            InitializeComponent();
        }

        // đã sửa xong file này

        Connection con = new Connection();
        private void ketnoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(con._connectionString);
                kn.Open();
                string sql = @"SELECT MAKHACHHANG as 'Mã khách hàng',MAHOADONDICHVU as 'Mã hóa đơn',THOIGIANLAP as 'Thời gian lập',TONGTIENDICHVU as 'Tổng tiền' FROM tbl_hoadondichvu
WHERE THOIGIANLAP BETWEEN N'" + txtTungay.Text + @"'AND'" + txtDenngay.Text + @"'
group by MAHOADONDICHVU,MAKHACHHANG,THOIGIANLAP,TONGTIENDICHVU";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dataGridView1.DataSource = table;
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
        private void thanhtien()
        {
            int sc = dataGridView1.Rows.Count;
            float tien = 0;
            for (int m = 0; m < sc - 1; m++)
            {
                tien += float.Parse(dataGridView1.Rows[m].Cells["Tổng tiền"].Value.ToString());
            }
            txtDT.Text = tien.ToString();
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            ketnoi();
            thanhtien();
        }

        private void TKDOANHTHUDV_Load(object sender, EventArgs e)
        {
            ketnoi();
            thanhtien();
            DateTime tn = DateTime.Now;
            txtTungay.Text = tn.ToString("MM/dd/yyyy");
            txtDenngay.Text = tn.ToString("MM/dd/yyyy");
        }       
    }
}
