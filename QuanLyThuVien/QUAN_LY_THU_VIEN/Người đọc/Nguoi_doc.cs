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

namespace QUAN_LY_THU_VIEN.Người_đọc
{
    public partial class Nguoi_doc : DevExpress.XtraEditors.XtraForm
    {


        private int status = 0;    //trang thai sua hay them  (them = 1, sua = 2)
        public Nguoi_doc()
        {
            InitializeComponent();
        }

        private void Nguoi_doc_Load(object sender, EventArgs e)
        {
            dataGridView_doc_gia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_doc_gia.DataSource = GetAllDocgia().Tables[0];

        }

        DataSet GetAllDocgia()
        {
            DataSet data = new DataSet();
            SqlCommand a = new SqlCommand();
            a.CommandText = "";

            string query = "SELECT Ma_Doc_gia, Ten_Doc_gia, Dia_chi, Doc_gia.So_the, Ngay_bat_dau, Ngay_het_han, Ghi_chu FROM dbo.Doc_gia JOIN dbo.The_thu_vien ON The_thu_vien.So_the = Doc_gia.So_the";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))  //goi conectionstring
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void dataGridView_doc_gia_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            ////an cai cap nhat di
            //bt_cap_nhat.Visible = false;

            //tb_ma_doc_gia.Text = dataGridView_doc_gia.CurrentRow.Cells["Ma_doc_gia"].Value.ToString();
            //tb_ten_doc_gia.Text = dataGridView_doc_gia.CurrentRow.Cells["Ten_doc_gia"].Value.ToString();
            //tb_dia_chi.Text = dataGridView_doc_gia.CurrentRow.Cells["Dia_chi"].Value.ToString();
            //tb_so_the.Text = dataGridView_doc_gia.CurrentRow.Cells["So_the"].Value.ToString();
            //tb_ngay_bat_dau.Text = dataGridView_doc_gia.CurrentRow.Cells["Ngay_bat_dau"].Value.ToString();
            //tb_ngay_ket_thuc.Text = dataGridView_doc_gia.CurrentRow.Cells["Ngay_het_han"].Value.ToString();
            //tb_ghi_chu.Text = dataGridView_doc_gia.CurrentRow.Cells["Ghi_chu"].Value.ToString();


            //tb_ma_doc_gia.ReadOnly = true;
            //tb_ten_doc_gia.ReadOnly = true;
            //tb_dia_chi.ReadOnly = true;
            //tb_so_the.ReadOnly = true;
            //tb_ngay_bat_dau.ReadOnly = true;
            //tb_ngay_ket_thuc.ReadOnly = true;
            //tb_ghi_chu.ReadOnly = true;




        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            //hien button cap nhat
            bt_cap_nhat.Visible = true;

            //cap nhat trang thai
            status = 1;


            //go bo readonly  tb_Mabs.ReadOnly = true;
            tb_ma_doc_gia.ReadOnly = true;
            tb_ten_doc_gia.ReadOnly =false;
            tb_dia_chi.ReadOnly =false;
            tb_so_the.ReadOnly =false;
            tb_ngay_bat_dau.ReadOnly =false;
            tb_ngay_ket_thuc.ReadOnly =false;
            tb_ghi_chu.ReadOnly =false;


            //go bo readonly  tb_Mabs.ReadOnly = true;
            tb_ma_doc_gia.Text = danh_ma_tu_dong();
            tb_ten_doc_gia.Text = "";
            tb_dia_chi.Text = "";
            tb_so_the.Text = "";
            tb_ngay_bat_dau.Text = "";
            tb_ngay_ket_thuc.Text = "";
            tb_ghi_chu.Text = "";

        }

        private string danh_ma_tu_dong()
        {
            string querry = "SELECT MAX(Ma_Doc_gia) FROM dbo.Doc_gia";
            using (SqlConnection con = new SqlConnection(connectionString.connectionstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                int a;
                a = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                con.Close();

                string ma;
                ma = a.ToString();
                return ma;
            }

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            //hien button cap nhat
            bt_cap_nhat.Visible = true;

            //cap nhat trang thai
            status = 2;


            tb_ma_doc_gia.ReadOnly = true;
            tb_ten_doc_gia.ReadOnly = false;
            tb_dia_chi.ReadOnly = false;
            tb_so_the.ReadOnly = false;
            tb_ngay_bat_dau.ReadOnly = false;
            tb_ngay_ket_thuc.ReadOnly = false;
            tb_ghi_chu.ReadOnly = false;
        }

        private void bt_cap_nhat_Click(object sender, EventArgs e)
        {
            //int giatri = 0;

            ////hien message box 
            //if (giatri == 0)
            //{
            //    System.Windows.Forms.DialogResult result = MessageBox.Show("Bạn có chắc cập người đọc này", "Alert Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (result == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        MessageBox.Show("ban chon yess");
            //        if (status == 1)
            //        {
            //            Insert_Doc_gia();
            //        }
            //        else if (status == 2)
            //        {
            //            Update_Doc_gia();
            //        }

            //        //reload
            //        Nguoi_doc_Load(panel2, e);

            //    }
            //    else if (result == System.Windows.Forms.DialogResult.No)
            //    {
            //        MessageBox.Show("ban chon no");
            //    }
            //}
        }

        public void Insert_Doc_gia()
        {
            //SqlConnection con = new SqlConnection(connectionString.connectionstring);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("them_doc_gia", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //try
            //{
            //    //them parameter 
            //    cmd.Parameters.Add(new SqlParameter("@sothe", tb_so_the.Text));
            //    cmd.Parameters.Add(new SqlParameter("@madocgia", tb_ma_doc_gia.Text));
            //    cmd.Parameters.Add(new SqlParameter("@tendocgia", tb_ten_doc_gia.Text));
            //    cmd.Parameters.Add(new SqlParameter("@diachi", tb_dia_chi.Text));
            //    cmd.Parameters.Add(new SqlParameter("@nbd",Convert.ToDateTime(tb_ngay_bat_dau.Text)));
            //    cmd.Parameters.Add(new SqlParameter("@nhh", Convert.ToDateTime(tb_ngay_ket_thuc.Text)));


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


        }

        public void Update_Doc_gia()
        {
            //SqlConnection con = new SqlConnection(connectionString.connectionstring);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("sua_doc_gia", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //try
            //{
            //    //them parameter 
            //    cmd.Parameters.Add(new SqlParameter("@sothe", tb_so_the.Text));
            //    cmd.Parameters.Add(new SqlParameter("@madocgia", tb_ma_doc_gia.Text));
            //    cmd.Parameters.Add(new SqlParameter("@tendocgia", tb_ten_doc_gia.Text));
            //    cmd.Parameters.Add(new SqlParameter("@diachi", tb_dia_chi.Text));
            //    cmd.Parameters.Add(new SqlParameter("@nbd", Convert.ToDateTime(tb_ngay_bat_dau.Text)));
            //    cmd.Parameters.Add(new SqlParameter("@nhh", Convert.ToDateTime(tb_ngay_ket_thuc.Text)));


            //    //chay
            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException)
            //{
            //    System.Windows.Forms.DialogResult d;
            //    d = MessageBox.Show("Khong sua duoc");
            //}
            //finally
            //{
            //    con.Close();
            //    cmd.Dispose();
            //}


        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString.connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("xoa_doc_gia", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("@madocgia", tb_ma_doc_gia.Text));
                cmd.Parameters.Add(new SqlParameter("@mathe", tb_so_the.Text));
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                System.Windows.Forms.DialogResult d;
                d = MessageBox.Show("Thao tác không thành công", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }

            //reload 
            Nguoi_doc_Load(panel2, e);
        }

    }
}