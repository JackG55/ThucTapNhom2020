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


namespace QUAN_LY_THU_VIEN.NguoiDung
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        User userLogin;
        internal User UserLogin { get => userLogin; set => userLogin = value; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_MouseMove(object sender, MouseEventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.ForestGreen;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.Peru;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.Peru;
        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.ForestGreen;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
                XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
            else
            {

                if (CheckLogin(txtUser.Text, txtPass.Text) == 1)
                {
                    if (checkEditNhoMatKhau.Checked == true)
                    {
                        Properties.Settings.Default.UserName = txtUser.Text;
                        Properties.Settings.Default.Password = txtPass.Text;
                        Properties.Settings.Default.Save();
                    }
                    if (checkEditNhoMatKhau.Checked == false)
                    {
                        Properties.Settings.Default.UserName = "";
                        Properties.Settings.Default.Password = "";
                        Properties.Settings.Default.Save();
                    }
                    this.Hide();
                    // Program.detail_user = new ThongTinNguoiDung();

                    //  Program.detail_userSql.Select_Detail(Program.detail_user, userLogin.MaDangNhapNguoiDung);
                    TrangChu trangChu = new TrangChu();
                    trangChu.Show();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập sai!", "Error");
                }

            }
        }

        int CheckLogin(string _name, string _pass)
        {
            int check = 0;
            List<User> list = new List<User>();
            list = Program.userSql.LayDSNguoiDung();
            foreach (var value in list)
            {
                string struser = value.Username.Trim();
                string strpass = value.Password.Trim();
                if (struser.ToLower() == _name.ToLower() && _pass.ToLower() == strpass.ToLower())
                {
                    check = 1;
                    this.userLogin = new User();
                    this.userLogin.Username = value.Username;
                    this.userLogin.Password = value.Password;
                    break;
                }
            }
            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUser.Text = Properties.Settings.Default.UserName;
                txtPass.Text = Properties.Settings.Default.Password;
            }
        }

        private void checkEditHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditHienMatKhau.Checked == true)

                txtPass.Properties.UseSystemPasswordChar = false;
            else
            {
                txtPass.Properties.UseSystemPasswordChar = true;

            }
        }
    }
}