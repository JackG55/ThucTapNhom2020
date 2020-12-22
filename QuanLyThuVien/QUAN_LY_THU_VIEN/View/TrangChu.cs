using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QUAN_LY_THU_VIEN.Sách;
using QUAN_LY_THU_VIEN.Người_đọc;
using QUAN_LY_THU_VIEN.NguoiDung;
using DevExpress.XtraEditors;

namespace QUAN_LY_THU_VIEN
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int chk = 0;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void bt_dang_xuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                chk = 1;
                Program.lg = new frmLogin();
                Program.lg.Show();
                this.Hide();
            }
        }

        private void bt_sach_ItemClick(object sender, ItemClickEventArgs e)
        {
            //hien panel Sach
            Sach m = new Sach();
            m.TopLevel = false;

            //xoa cac control hien thoi
            panel_main.Controls.Clear();

            panel_main.Controls.Add(m);
            m.Dock = DockStyle.Fill;
            m.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            m.Show();
        }

        private void bt_nguoi_doc_ItemClick(object sender, ItemClickEventArgs e)
        {
            //hien panel Nguoi doc
            Nguoi_doc m = new Nguoi_doc();
            m.TopLevel = false;

            //xoa cac control hien thoi
            panel_main.Controls.Clear();

            panel_main.Controls.Add(m);
            m.Dock = DockStyle.Fill;
            m.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            m.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            //hien panel Nguoi doc
            Muon_tra m = new Muon_tra();
            m.TopLevel = false;

            //xoa cac control hien thoi
            panel_main.Controls.Clear();

            panel_main.Controls.Add(m);
            m.Dock = DockStyle.Fill;
            m.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            m.Show();
        }

        private void bt_doi_mat_khau_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chk == 0)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.lg.Close();
                }
            }
            else
            {
                Program.lg.Close();
            }
        }
    }
}