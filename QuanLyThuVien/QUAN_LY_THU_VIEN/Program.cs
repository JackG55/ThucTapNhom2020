using QUAN_LY_THU_VIEN.Sách;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUAN_LY_THU_VIEN.NguoiDung;


namespace QUAN_LY_THU_VIEN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static UserSql userSql;
        public static frmLogin lg;
        [STAThread]
        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            lg = new frmLogin();
            userSql = new UserSql();
            Application.Run(lg);
        }
    }
}
