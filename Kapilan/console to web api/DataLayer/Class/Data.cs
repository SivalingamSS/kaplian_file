using Common.EncryptClass;
using Common.Modal;
using DataLayer.Interface;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DataLayer.Class
{
    public class Data : IData
    {
        public async Task<object> Register(ViewModal use)
        {
            try
            {
                using (SqlConnection sqlServerConnection = new SqlConnection("Server=192.168.0.252;Database=Training2023;User Id=sa;Password=local@vaf@123;TrustServerCertificate=True;"))
                {
                    sqlServerConnection.Open();

                    using (SqlCommand commands = new SqlCommand("Main_Details", sqlServerConnection))
                    {
                        commands.CommandType = CommandType.StoredProcedure;
                        commands.Parameters.AddWithValue("@FirstName", use.FirstName);
                        commands.Parameters.AddWithValue("@LastName", use.LastName);
                        commands.Parameters.AddWithValue("@Age", use.Age);
                        commands.Parameters.AddWithValue("@DOB", use.DOB);
                        commands.Parameters.AddWithValue("@PostalCode", use.PostalCode);
                        commands.Parameters.AddWithValue("@Password",EncryptExtension.Encrypt(use.Password));
                        commands.Parameters.AddWithValue("@Address", use.Address);
                        commands.Parameters.AddWithValue("@Email", use.Email);
                        commands.Parameters.AddWithValue("@City", use.City);
                        commands.Parameters.AddWithValue("@State", use.State);
                        commands.Parameters.AddWithValue("@Country", use.Country);
                        commands.Parameters.AddWithValue("@MobileNumber", use.MobileNumber);
                        commands.Parameters.AddWithValue("@Role", use.Role);
                        commands.Parameters.AddWithValue("CreatedDate", use.CreatedDate);
                        commands.Parameters.AddWithValue("@IsActive", use.IsActive);
                        commands.ExecuteNonQuery();
                    }
                    sqlServerConnection.Close();
                }
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
            return use.CreatedDate;
        }
    }
}