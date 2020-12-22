using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QUAN_LY_THU_VIEN.NguoiDung
{
    class UserSql : connection
    {
        public bool DoiMatKhau(User user, string new_pass)
        {
            string query = "DoiMK";
            string[] para;
            para = new string[2];
            para[0] = "@tendangnhap";
            para[1] = "@matkhau";   
            object[] values;
            values = new object[2];
            values[0] = user.Username;
            values[1] = new_pass;
            try
            {
                int a = connection.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                //DialogResult d;
                //d = MessageBox.Show("Thông tin thêm không hợp lệ!");
                return false;
            }
            finally
            {
                connection.close();
            }
        }

        public List<User> LayDSNguoiDung()
        {
            SqlConnection con = new SqlConnection();
            con = Getconnection();
            con.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "LayThongTinNguoiDung";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = con;
            //SqlCommand command = new SqlCommand("SELECT * FROM dbo.NguoiDung", connection.Getconnection());
            //command.CommandType = CommandType.Text;
            try
            {
                
                IDataReader data = command.ExecuteReader();
                return PopulateObjectFromReader(data);
            }
            catch (Exception ex)
            {
                connection.Getconnection().Close();
                command.Dispose();
                throw new Exception("user::SelectAll::Error occured.", ex);
            }
            finally
            {
                connection.Getconnection().Close();
                command.Dispose();
            }
        }

        
        internal void PopulatePlayerFromReader(User user, IDataReader data)
        {
            user.Username = data.GetString(data.GetOrdinal(User.UserFields.tendangnhap.ToString()));

            if (!data.IsDBNull(data.GetOrdinal(User.UserFields.matkhau.ToString())))
            {
                user.Password = data.GetString(data.GetOrdinal(User.UserFields.matkhau.ToString()));
            }
        }


        internal List<User> PopulateObjectFromReader(IDataReader data)
        {
            List<User> list = new List<User>();
            while (data.Read())
            {
                User user = new User();
                PopulatePlayerFromReader(user, data);
                list.Add(user);
            }
            return list;
        }
    }
}
