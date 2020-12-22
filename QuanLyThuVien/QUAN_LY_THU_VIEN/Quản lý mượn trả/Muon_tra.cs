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
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors.Controls;

namespace QUAN_LY_THU_VIEN
{
    public partial class Muon_tra : DevExpress.XtraEditors.XtraForm
    {

        private int status = 0;    //trang thai sua hay them  (them = 1, sua = 2)
        private List<string> list_sach = new List<string>();
        public Muon_tra()
        {
            InitializeComponent();
        }

        private void Muon_tra_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllInfo().Tables[0];

            DataSet dataSach = GetAllSach();
            tb_ten_sach.Properties.DataSource = dataSach.Tables[0];
            tb_ten_sach.Properties.DisplayMember = "Ten_sach";
            tb_ten_sach.Properties.ValueMember = "Ma_sach";
            tb_ten_sach.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            list_sach = new List<string>();
            list_sach = DSMa(dataSach, "Ma_sach");
        }


        private void HienThongTinLenGridLookUpEditValue(GridLookUpEdit grid, List<string> list, string ma)
        {
            int index = list.BinarySearch(ma);
            grid.EditValue = grid.Properties.GetKeyValue(index);
        }

        public List<string> DSMa(DataSet data, string field)
        {
            List<string> list = new List<string>();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;
        }

 

        DataSet GetAllInfo()
        {
            DataSet data = new DataSet();
            SqlCommand a = new SqlCommand();
            a.CommandText = "";

            string query = "SELECT Muon_tra.So_the,Ten_Doc_gia,CT_Muon_tra.Ma_muon_tra,CT_Muon_tra.Ma_sach,Ten_sach, Ngay_muon, Ngay_tra FROM dbo.Doc_gia JOIN dbo.Muon_tra ON Muon_tra.So_the = Doc_gia.So_the JOIN dbo.CT_Muon_tra ON CT_Muon_tra.Ma_muon_tra = Muon_tra.Ma_muon_tra JOIN dbo.Sach ON Sach.Ma_sach = CT_Muon_tra.Ma_sach";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))  //goi conectionstring
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            ////an cai cap nhat di
            //bt_cap_nhat.Visible = false;

            //tb_ma_phieu_muon.Text = dataGridView1.CurrentRow.Cells["Ma_muon_tra"].Value.ToString();
            //tb_ten_doc_gia.Text = dataGridView1.CurrentRow.Cells["Ten_doc_gia"].Value.ToString();
            //tb_so_the.Text = dataGridView1.CurrentRow.Cells["So_the"].Value.ToString();
            //tb_ma_sach.Text = dataGridView1.CurrentRow.Cells["Ma_sach"].Value.ToString();
            //HienThongTinLenGridLookUpEditValue(tb_ten_sach, list_sach, tb_ma_sach.Text);
            ////tb_ten_sach.Text = dataGridView1.CurrentRow.Cells["Ten_sach"].Value.ToString();
            //tb_ngay_muon.Text = dataGridView1.CurrentRow.Cells["Ngay_muon"].Value.ToString();
            //tb_ngay_tra.Text = dataGridView1.CurrentRow.Cells["Ngay_tra"].Value.ToString();


            //tb_ma_phieu_muon.ReadOnly = true;
            //tb_ten_doc_gia.ReadOnly = true;
            //tb_so_the.ReadOnly = true;
            //tb_ma_sach.ReadOnly = true;
            //tb_ten_sach.ReadOnly = true;
            //tb_ngay_muon.ReadOnly = true;
            //tb_ngay_tra.ReadOnly = true;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            ////hien button cap nhat
            //bt_cap_nhat.Visible = true;

            ////cap nhat trang thai
            //status = 1;


            ////go bo readonly  tb_Mabs.ReadOnly = true;
            //tb_ma_phieu_muon.ReadOnly = true;
            //tb_ten_doc_gia.ReadOnly = true;
            //tb_so_the.ReadOnly = true;
            //tb_ma_sach.ReadOnly = true;
            //tb_ten_sach.ReadOnly = false;
            //tb_ngay_muon.ReadOnly = false;
            //tb_ngay_tra.ReadOnly = false;


            //tb_ma_phieu_muon.Text = danh_ma_tu_dong();
            //tb_ten_sach.Text = "";
            //tb_ngay_muon.Text = "";
            //tb_ngay_tra.Text = "";
        }


        private string danh_ma_tu_dong()
        {
            string querry = "SELECT MAX(Ma_muon_tra) FROM dbo.Muon_tra ";
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


            //go bo readonly  tb_Mabs.ReadOnly = true;
            tb_ma_phieu_muon.ReadOnly = true;
            tb_ten_doc_gia.ReadOnly = true;
            tb_so_the.ReadOnly = true;
            tb_ma_sach.ReadOnly = true;
            tb_ten_sach.ReadOnly = false;
            tb_ngay_muon.ReadOnly = false;
            tb_ngay_tra.ReadOnly = false;



            tb_ten_sach.Text = "";
            tb_ngay_muon.Text = "";
            tb_ngay_tra.Text = "";
        }

        private void bt_cap_nhat_Click(object sender, EventArgs e)
        {
            //int giatri = 0;

            ////hien message box
            //if (giatri == 0)
            //{
            //    System.Windows.Forms.DialogResult result = MessageBox.Show("Bạn có chắc cập phiếu mượn này", "Alert Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (result == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        MessageBox.Show("ban chon yess");
            //        if (status == 1)
            //        {
            //            Insert_Phieu_muon();
            //        }
            //        else if (status == 2)
            //        {
            //            //Update_Phieu_muon();
            //        }

                  
            //        //reload
            //        Muon_tra_Load(panel2, e);

            //    }
            //    else if (result == System.Windows.Forms.DialogResult.No)
            //    {
            //        MessageBox.Show("ban chon no");
            //    }
            //}
        }

        public void Insert_Phieu_muon()
        {
            //SqlConnection con = new SqlConnection(connectionString.connectionstring);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("them_phieu_muon", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //try
            //{
            //    //them parameter 
            //    cmd.Parameters.Add(new SqlParameter("@maphieumuon", tb_ma_phieu_muon.Text));
            //    cmd.Parameters.Add(new SqlParameter("@sothe", tb_so_the.Text));
            //    cmd.Parameters.Add(new SqlParameter("@masach", tb_ma_sach.Text));
            //    cmd.Parameters.Add(new SqlParameter("@manhanvien", Program.lg.UserLogin.Username));
            //    cmd.Parameters.Add(new SqlParameter("@ngaymuon", Convert.ToDateTime(tb_ngay_muon.Text)));
            //    cmd.Parameters.Add(new SqlParameter("@ngaytra", Convert.ToDateTime(tb_ngay_tra.Text)));


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

        public void Update_Doc_gia()
        {
           


        }


        public DataSet GetAllSach()
        {
            DataSet data = new DataSet();
            SqlCommand a = new SqlCommand();
            a.CommandText = "";

            string query = "SELECT Ma_sach, Ten_sach FROM dbo.Sach";
            using (SqlConnection connection = new SqlConnection(connectionString.connectionstring))  //goi conectionstring
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        private void tb_ten_sach_BeforePopup(object sender, EventArgs e)
        {
            DataSet dataSach = GetAllSach();
            tb_ten_sach.Properties.DataSource = dataSach.Tables[0];
            tb_ten_sach.Properties.DisplayMember = "Ten_sach";
            tb_ten_sach.Properties.ValueMember = "Ma_sach";
            tb_ten_sach.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            list_sach = new List<string>();
            list_sach = DSMa(dataSach, "Ma_sach");
        }


        private void tb_ten_sach_EditValueChanged(object sender, EventArgs e)
        {
            if (status == 1 || status == 2)
            {
                tb_ma_sach.Text = tb_ten_sach.EditValue.ToString();
            }
        }
    }
}