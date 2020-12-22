using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_THU_VIEN.NguoiDung
{
    public class User
    {
        string username;
        string password;
        public enum UserFields
        {
            tendangnhap,
            matkhau,
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
