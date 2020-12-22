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
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Extensions;
using DevExpress.ClipboardSource.SpreadsheetML;

namespace QUAN_LY_THU_VIEN.Sách
{
    public partial class Sach : DevExpress.XtraEditors.XtraForm
    {
        private List<string> list_matacgia = new List<string>();
        private List<string> list_manxb= new List<string>();
        private List<string> list_matheloai = new List<string>();

        private int status = 0;    //trang thai sua hay them  (them = 1, sua = 2)
        public Sach()
        {
            InitializeComponent();
        }


        public List<string> DSMa(DataSet data,string field)
        {
            List<string> list = new List<string>();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;
        }

        private void HienThongTinLenGridLookUpEditValue(GridLookUpEdit grid, List<string> list, string ma)
        {
            int index = list.BinarySearch(ma);
            grid.EditValue = grid.Properties.GetKeyValue(index);
        }

        private void Sach_Load(object sender, EventArgs e)
        {

            //Load GridView
            dataGridView1_sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1_sach.DataSource = GetAllSach().Tables[0];

            LoadGrid();
        }

        public void LoadGrid()
        {
            //Load loockup tacgia
            DataSet dataTacGia = GetAllTacgia();
            tb_Ten_tac_gia.Properties.DataSource = dataTacGia.Tables[0];
            tb_Ten_tac_gia.Properties.DisplayMember = "Ten_tac_gia";
            tb_Ten_tac_gia.Properties.ValueMember = "Ma_tac_gia";
            tb_Ten_tac_gia.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            list_matacgia = new List<string>();
            list_matacgia = DSMa(dataTacGia, "Ma_tac_gia");

            //load loockup NXB
            tb_Ten_NXB.Properties.DataSource = GetAllNXB().Tables[0];
            tb_Ten_NXB.Properties.DisplayMember = "Ten_NXB";
            tb_Ten_NXB.Properties.ValueMember = "Ma_NXB";
            tb_Ten_NXB.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            list_manxb = new List<string>();
            list_manxb = DSMa(GetAllNXB(), "Ma_NXB");

            //load loockup Theloai
            tb_Ten_the_loai.Properties.DataSource = GetAllTheloai().Tables[0];
            tb_Ten_the_loai.Properties.DisplayMember = "Ten_the_loai";
            tb_Ten_the_loai.Properties.ValueMember = "Ma_the_loai";
            tb_Ten_the_loai.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            list_matheloai = new List<string>();
            list_matheloai = DSMa(GetAllTheloai(), "Ma_the_loai");
        }

        public DataSet GetAllSach()
        {
            DataSet data = new DataSet();
            SqlCommand a = new SqlCommand();
            a.CommandText = "";

            string query = "SELECT * FROM dbo.Sach";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))  //goi conectionstring
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        public DataSet GetAllTacgia()
        {
            DataSet data = new DataSet();
            SqlCommand a = new SqlCommand();
            a.CommandText = "";

            string query = "SELECT * FROM dbo.Tac_gia";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))  //goi conectionstring
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        public DataSet GetAllNXB()
        {
            DataSet data = new DataSet();
            SqlCommand a = new SqlCommand();
            a.CommandText = "";

            string query = "SELECT * FROM dbo.NXB";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))  //goi conectionstring
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }


        DataSet GetAllTheloai()
        {
            DataSet data = new DataSet();
            SqlCommand a = new SqlCommand();
            a.CommandText = "";

            string query = "SELECT * FROM dbo.The_loai";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))  //goi conectionstring
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }



        
        private void dataGridView1_sach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            ////an cai cap nhat di
            //bt_cap_nhat.Visible = false;

            ////an cac cai them di
            //bt_them_tac_gia.Visible = false;
            //bt_them_NXB.Visible = false;
            //bt_them_the_loai.Visible = false;

            //tb_Ma_sach.Text = dataGridView1_sach.CurrentRow.Cells["Ma_sach"].Value.ToString();
            //tb_Ten_sach.Text = dataGridView1_sach.CurrentRow.Cells["Ten_sach"].Value.ToString();
            //tb_Ma_tac_gia.Text = dataGridView1_sach.CurrentRow.Cells["Ma_tac_gia"].Value.ToString();

            //HienThongTinLenGridLookUpEditValue(tb_Ten_tac_gia, list_matacgia, tb_Ma_tac_gia.Text);
            //string cmd = "SELECT Ten_tac_gia FROM dbo.Tac_gia WHERE Ma_tac_gia = " + "'" + tb_Ma_tac_gia.Text + "'";

            //tb_Ma_NXB.Text = dataGridView1_sach.CurrentRow.Cells["Ma_NXB"].Value.ToString();
            ////tb_Ten_NXB.Text = dataGridView1_sach.CurrentRow.Cells["GIOITINH"].Value.ToString();
            //HienThongTinLenGridLookUpEditValue(tb_Ten_NXB, list_manxb, tb_Ma_NXB.Text);
            //cmd = "SELECT Ten_NXB FROM dbo.NXB WHERE Ma_NXB = " + "'" + tb_Ma_NXB.Text + "'";


            //tb_Ma_the_loai.Text = dataGridView1_sach.CurrentRow.Cells["Ma_the_loai"].Value.ToString();
            ////tb_Ten_the_loai.Text = dataGridView1_sach.CurrentRow.Cells["LUONG"].Value.ToString();
            //HienThongTinLenGridLookUpEditValue(tb_Ten_the_loai, list_matheloai, tb_Ma_the_loai.Text);
            //cmd = "SELECT Ma_the_loai FROM dbo.The_loai WHERE Ma_the_loai = " + "'" + tb_Ma_the_loai.Text + "'";

            //tb_nam_XB.Text = dataGridView1_sach.CurrentRow.Cells["Nam_xuat_ban"].Value.ToString();

            //tb_Ma_sach.ReadOnly = true;
            //tb_Ten_sach.ReadOnly = true;
            //tb_Ma_tac_gia.ReadOnly = true;
            //tb_Ten_tac_gia.ReadOnly = true;
            //tb_Ma_NXB.ReadOnly = true;
            //tb_Ten_NXB.ReadOnly = true;
            //tb_Ma_the_loai.ReadOnly = true;
            //tb_Ten_the_loai.ReadOnly = true;
            //tb_nam_XB.ReadOnly = true;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            ////hien button cap nhat
            //bt_cap_nhat.Visible = true;

            ////hien button them cac thanh phan lien quan
            //bt_them_tac_gia.Visible = true;
            //bt_them_NXB.Visible = true;
            //bt_them_the_loai.Visible = true;

            ////cap nhat trang thai
            //status = 1;


            ////go bo readonly  tb_Mabs.ReadOnly = true;
            //tb_Ma_sach.ReadOnly = true; //phuc vu danh ma tu doong
            //tb_Ten_sach.ReadOnly = false;
            //tb_Ma_tac_gia.ReadOnly = true;  //tu cap nhat ma
            //tb_Ten_tac_gia.ReadOnly = false;
            //tb_Ma_NXB.ReadOnly = true;    //tu cap nhat ma
            //tb_Ten_NXB.ReadOnly = false;
            //tb_Ma_the_loai.ReadOnly = true;  //tu cap nhat ma
            //tb_Ten_the_loai.ReadOnly = false;
            //tb_nam_XB.ReadOnly = false;


            ////xoa cac thong tin co trong box di
            //tb_Ma_sach.Text = danh_ma_tu_dong(); //phuc vu danh ma tu doong
            //tb_Ten_sach.Text = "";
            //tb_Ma_tac_gia.Text = "";
            //tb_Ten_tac_gia.Text = "";
            //tb_Ma_NXB.Text = "";
            //tb_Ten_NXB.Text = "";
            //tb_Ma_the_loai.Text = "";
            //tb_Ten_the_loai.Text = "";
            //tb_nam_XB.Text = "";

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            //hien button cap nhat
            bt_cap_nhat.Visible = true;

            //cap nhat trang thai
            status = 2;


            tb_Ma_sach.ReadOnly = true;
            tb_Ten_sach.ReadOnly = false;
            tb_Ma_tac_gia.ReadOnly = false;
            tb_Ten_tac_gia.ReadOnly = false;
            tb_Ma_NXB.ReadOnly = false;
            tb_Ten_NXB.ReadOnly = false;
            tb_Ma_the_loai.ReadOnly = false;
            tb_Ten_the_loai.ReadOnly = false;
            tb_nam_XB.ReadOnly = false;
        }

        //cap nhat ma theo ten

        private void tb_Ten_tac_gia_EditValueChanged(object sender, EventArgs e)
        {
            if(status == 1||status==2)
            {
                tb_Ma_tac_gia.Text = tb_Ten_tac_gia.EditValue.ToString();
            }    
            
        }

        private void tb_Ten_NXB_EditValueChanged(object sender, EventArgs e)
        {
            if (status == 1 || status == 2)
            {
                tb_Ma_NXB.Text = tb_Ten_NXB.EditValue.ToString();
            }
        }

        private void tb_Ten_the_loai_EditValueChanged(object sender, EventArgs e)
        {
            if (status == 1 || status == 2)
            {
                tb_Ma_the_loai.Text = tb_Ten_the_loai.EditValue.ToString();
            }
        }

        private void bt_cap_nhat_Click(object sender, EventArgs e)
        {
            //int giatri = 0;

            ////hien message box 
            //if (giatri == 0)
            //{
            //    System.Windows.Forms.DialogResult result = MessageBox.Show("Bạn có chắc cập nhật cuốn sách này", "Alert Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (result == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        MessageBox.Show("ban chon yess");
            //        if (status == 1)
            //        {
            //            Insert_Sach();
            //        }
            //        else if (status == 2)
            //        {
            //            Update_Sach();
            //        }

            //        //reload
            //        Sach_Load(panel1, e);

            //    }
            //    else if (result == System.Windows.Forms.DialogResult.No)
            //    {
            //        MessageBox.Show("ban chon no");
            //    }
            //}
        }


        public void Insert_Sach()
        {
            //SqlConnection con = new SqlConnection(connectionString.connectionstring);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("them_Sach", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //try
            //{
            //    //them parameter 
            //    cmd.Parameters.Add(new SqlParameter("@masach", tb_Ma_sach.Text));
            //    cmd.Parameters.Add(new SqlParameter("@tensach", tb_Ten_sach.Text));
            //    cmd.Parameters.Add(new SqlParameter("@ma_tacgia", tb_Ma_tac_gia.Text));
            //    cmd.Parameters.Add(new SqlParameter("@ma_NXB", tb_Ma_NXB.Text));
            //    cmd.Parameters.Add(new SqlParameter("@ma_theloai", tb_Ma_the_loai.Text));
            //    cmd.Parameters.Add(new SqlParameter("@namXB", tb_nam_XB.Text));
               

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



        public void Update_Sach()
        {
            //SqlConnection con = new SqlConnection(connectionString.connectionstring);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("sua_Sach", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //try
            //{
            //    //them parameter
            //    cmd.Parameters.Add(new SqlParameter("@masach", tb_Ma_sach.Text));
            //    cmd.Parameters.Add(new SqlParameter("@tensach", tb_Ten_sach.Text));
            //    cmd.Parameters.Add(new SqlParameter("@ma_tacgia", tb_Ma_tac_gia.Text));
            //    cmd.Parameters.Add(new SqlParameter("@ma_NXB", tb_Ma_NXB.Text));
            //    cmd.Parameters.Add(new SqlParameter("@ma_theloai", tb_Ma_the_loai.Text));
            //    cmd.Parameters.Add(new SqlParameter("@namXB", tb_nam_XB.Text));

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

        private string danh_ma_tu_dong()
        {
            string querry = "SELECT MAX(Ma_sach) FROM dbo.Sach";
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


        private void searchControl1_TextChanged(object sender, EventArgs e)
        {
            //DataView DV = new DataView(GetAllSach().Tables[0]);
            //if (searchControl1.Text != "")
            //{
            //    DV.RowFilter = string.Format("Ten_sach LIKE '%{0}%'", searchControl1.Text);
            //    dataGridView1_sach.DataSource = DV;
            //    dataGridView1_sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //}
            //else
            //{
            //    dataGridView1_sach.DataSource = GetAllSach().Tables[0];
            //    dataGridView1_sach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //}
        }

        private void bt_them_tac_gia_Click(object sender, EventArgs e)
        {
            Them_tac_gia themTG = new Them_tac_gia();
            themTG.ShowDialog();
        }

        private void bt_them_NXB_Click(object sender, EventArgs e)
        {
            Them_NXB themNXB = new Them_NXB();
            themNXB.ShowDialog();
        }

        private void bt_them_the_loai_Click(object sender, EventArgs e)
        {
            Them_the_loai themTL = new Them_the_loai();
            themTL.ShowDialog();
        }

        private void tb_Ten_tac_gia_BeforePopup(object sender, EventArgs e)
        {
            //Load loockup tacgia
            DataSet dataTacGia = GetAllTacgia();
            tb_Ten_tac_gia.Properties.DataSource = dataTacGia.Tables[0];
            tb_Ten_tac_gia.Properties.DisplayMember = "Ten_tac_gia";
            tb_Ten_tac_gia.Properties.ValueMember = "Ma_tac_gia";
            tb_Ten_tac_gia.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            list_matacgia = new List<string>();
            list_matacgia = DSMa(dataTacGia, "Ma_tac_gia");
        }

        private void tb_Ten_NXB_BeforePopup(object sender, EventArgs e)
        {
            //load loockup NXB
            tb_Ten_NXB.Properties.DataSource = GetAllNXB().Tables[0];
            tb_Ten_NXB.Properties.DisplayMember = "Ten_NXB";
            tb_Ten_NXB.Properties.ValueMember = "Ma_NXB";
            tb_Ten_NXB.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            list_manxb = new List<string>();
            list_manxb = DSMa(GetAllNXB(), "Ma_NXB");
        }

        private void tb_Ten_the_loai_BeforePopup(object sender, EventArgs e)
        {
            //load loockup Theloai
            tb_Ten_the_loai.Properties.DataSource = GetAllTheloai().Tables[0];
            tb_Ten_the_loai.Properties.DisplayMember = "Ten_the_loai";
            tb_Ten_the_loai.Properties.ValueMember = "Ma_the_loai";
            tb_Ten_the_loai.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            list_matheloai = new List<string>();
            list_matheloai = DSMa(GetAllTheloai(), "Ma_the_loai");
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(connectionString.connectionstring);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("xoa_sach", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //try
            //{
            //    cmd.Parameters.Add(new SqlParameter("@masach", tb_Ma_sach.Text));
            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException ex)
            //{

            //    System.Windows.Forms.DialogResult d;
            //    d = MessageBox.Show("Thao tác không thành công", "Warning message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //finally
            //{
            //    con.Close();
            //}

            ////reload
            //Sach_Load(panel1, e);
        }

   
    }
}