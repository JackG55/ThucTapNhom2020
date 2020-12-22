using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QUAN_LY_THU_VIEN.Sách
{
    public partial class Them_NXB : DevExpress.XtraEditors.XtraForm
    {
        public Them_NXB()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(connectionString.connectionstring);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("them_NXB", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //try
            //{
            //    //them parameter 
            //    cmd.Parameters.Add(new SqlParameter("@maNXB", tb_ma_NXB.Text));
            //    cmd.Parameters.Add(new SqlParameter("@tenNXB", tb_ten_NXB.Text));
            //    cmd.Parameters.Add(new SqlParameter("@diachi", tb_dia_chi.Text));
            //    cmd.Parameters.Add(new SqlParameter("@email", tb_email.Text));
            //    cmd.Parameters.Add(new SqlParameter("@ttndd", tb_ndd.Text));

            //    //chay
            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException)
            //{
            //    System.Windows.Forms.DialogResult d;
            //    d = MessageBox.Show("Khong them duoc");
            //}
            //finally
            //{
            //    con.Close();
            //    cmd.Dispose();
            //}
            //this.Close();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}