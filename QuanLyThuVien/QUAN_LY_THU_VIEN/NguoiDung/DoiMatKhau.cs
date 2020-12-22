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
    public partial class DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtReNewPass.Text == "")
                XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Error???");
            else if (txtReNewPass.Text != txtNewPass.Text)
                XtraMessageBox.Show("Mật khẩu xác nhận không đúng!", "Error???");
            else if (Program.lg.UserLogin.Password != txtOldPass.Text)
            {
                XtraMessageBox.Show("Mật khẩu cũ không đúng!", "Error???");
            }
            else
            {
                if (Program.userSql.DoiMatKhau(Program.lg.UserLogin, txtNewPass.Text) == true)
                    XtraMessageBox.Show("Đổi mật khẩu thành công!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}