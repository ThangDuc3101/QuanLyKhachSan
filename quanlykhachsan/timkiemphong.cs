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
    public partial class timkiemphong : Form
    {      
        public timkiemphong()
        {
            InitializeComponent();
        }

        //đã sửa xong

        public SqlConnection cn = new SqlConnection();
        Connection con = new Connection();
        public void ketnoi()
        {
            try
            {
                cn.ConnectionString = con._connectionString;
                if (cn.State==0 )
                {                   
                    cn.Open();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void ngatketnoi()
        {
            if (cn.State!=0)
            {
                cn.Close();
            }
        }
        public DataTable xemdl (string sql)
        {
            ketnoi();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTK.Text=="Tình trạng phòng")
            {
                dataGridView1.DataSource = xemdl(@"select *  from tbl_phong where TINHTRANG like '%" + txtKey.Text.Trim() + "%'");
            }
            if (cbTK.Text == "Loại phòng")
            {
                dataGridView1.DataSource = xemdl(@"select *  from tbl_phong where LOAIPHONG like '%" + txtKey.Text.Trim() + "%'");
            }
        }
        private void timkiemphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_phong' table. You can move, or remove it, as needed.
            //this.tbl_phongTableAdapter1.Fill(this.quanlykhachsandemo2304DataSet.tbl_phong);
            cbTK.Text = "Tình trạng phòng";
            xemdl("select * from tbl_phong");
        }
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            if (cbTK.Text == "Tình trạng phòng")
            {
                dataGridView1.DataSource = xemdl(@"select*from tbl_phong where TINHTRANG like '%" + txtKey.Text.Trim() + "%'");
            }
            if (cbTK.Text == "Loại phòng")
            {
                dataGridView1.DataSource = xemdl(@"select *  from tbl_phong where LOAIPHONG like '%" + txtKey.Text.Trim() + "%'");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}     

