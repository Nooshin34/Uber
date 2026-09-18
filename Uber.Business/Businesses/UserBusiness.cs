using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Text;
using Uber.Business.Interfaces;
using UberApp.Domain;

namespace Uber.Business.Businesses
{
    public class UserBusiness : IUser
    {
        string connectionString = "Data Source=NIKZAD\\TUTORIAL;Initial Catalog=UberAdo;Integrated Security=True;";

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM [dbo].[User] WHERE IsDeleted = 0 ORDER BY CreatedAt DESC";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User(
                            id: Convert.ToInt64(reader["Id"]),
                            firstName: reader["FirstName"].ToString() ?? string.Empty,
                            lastName: reader["LastName"].ToString() ?? string.Empty,
                            phone: reader["PhoneNumber"].ToString() ?? string.Empty
                            );

                        user.UserName = reader["UserName"].ToString() ?? string.Empty;
                        user.PasswordHash = reader["PasswordHash"].ToString() ?? string.Empty;
                        user.IsActive = reader["IsActive"] != DBNull.Value && Convert.ToBoolean(reader["IsActive"]);
                        user.CreatedAt = reader["CreatedAt"] == DBNull.Value ? DateTime.UtcNow : Convert.ToDateTime(reader["CreatedAt"]);
                        user.LastLoginAt = reader["LastLoginAt"] == DBNull.Value ? null : Convert.ToDateTime(reader["LastLoginAt"]);
                        user.IsDeleted = reader["IsDeleted"] != DBNull.Value && Convert.ToBoolean(reader["IsDeleted"]);
                        user.DeletedAt = reader["DeletedAt"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["DeletedAt"]);

                        users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                //Log File , Database , ELK
                throw;
            }
            return users;
        }

        public bool Add(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO [dbo].[User] (UserName, PasswordHash, FirstName, LastName, PhoneNumber, IsActive, CreatedAt, LastLoginAt, IsDeleted, DeletedAt)
                                 VALUES (@UserName, @PasswordHash, @FirstName, @LastName, @PhoneNumber, @IsActive, @CreatedAt, @LastLoginAt, @IsDeleted, @DeletedAt);
                                 SELECT CAST(SCOPE_IDENTITY() AS BIGINT);";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", user.UserName ?? string.Empty);
                command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash ?? string.Empty);
                command.Parameters.AddWithValue("@FirstName", user.FirstName ?? string.Empty);
                command.Parameters.AddWithValue("@LastName", user.LastName ?? string.Empty);
                command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber ?? string.Empty);
                command.Parameters.AddWithValue("@IsActive", user.IsActive);
                command.Parameters.Add("@CreatedAt", SqlDbType.DateTime2).Value = user.CreatedAt;
                command.Parameters.Add("@LastLoginAt", SqlDbType.DateTime2).Value = (object?)user.LastLoginAt ?? DBNull.Value;
                command.Parameters.AddWithValue("@IsDeleted", user.IsDeleted);
                command.Parameters.Add("@DeletedAt", SqlDbType.DateTime2).Value =
                    user.DeletedAt < new DateTime(1753, 1, 1) ? new DateTime(1900, 1, 1) : user.DeletedAt;

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    user.Id = Convert.ToInt64(result);

                return user.Id > 0;
            }
        }
        public bool Delete(User item)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }


        public bool Update(User item)
        {
            throw new NotImplementedException();
        }

        public bool Register()
        {
            throw new NotImplementedException();
        }
    }
}
