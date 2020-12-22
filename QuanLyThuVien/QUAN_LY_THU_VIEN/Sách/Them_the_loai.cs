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
    public partial class Them_the_loai : DevExpress.XtraEditors.XtraForm
    {
        public Them_the_loai()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString.connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("them_the_loai", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                //them parameter 
                cmd.Parameters.Add(new SqlParameter("@matheloai", tb_ma_the_loai.Text));
                cmd.Parameters.Add(new SqlParameter("@tentheloai", tb_ten_the_loai.Text));


                //chay
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                System.Windows.Forms.DialogResult d;
                d = MessageBox.Show("Khong them duoc");
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            this.Close();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}