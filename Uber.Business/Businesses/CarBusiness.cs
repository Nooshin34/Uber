using System.Data;
using System.Data.SqlClient;
using Uber.Business.Interfaces;
using UberApp.Domain;

namespace Uber.Business.Businesses
{
    public class CarBusiness : ICar
    {
        string connectionString = "Data Source=NIKZAD\\TUTORIAL;Initial Catalog=UberAdo;Integrated Security=True;";

        public List<Car> GetAll()
        {
            List<Car> cars = new List<Car>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT c.Id, c.UserId, c.Brand, c.Model, c.Color, c.PlateNumber, c.Year, c.CreatedAt,
                                            u.FirstName, u.LastName
                                     FROM [dbo].[Car] c
                                     INNER JOIN [dbo].[User] u ON u.Id = c.UserId
                                     WHERE c.IsDeleted = 0
                                     ORDER BY c.CreatedAt DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cars.Add(MapCar(reader));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cars;
        }

        public List<Car> GetByUserId(long userId)
        {
            List<Car> cars = new List<Car>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT c.Id, c.UserId, c.Brand, c.Model, c.Color, c.PlateNumber, c.Year, c.CreatedAt,
                                            u.FirstName, u.LastName
                                     FROM [dbo].[Car] c
                                     INNER JOIN [dbo].[User] u ON u.Id = c.UserId
                                     WHERE c.IsDeleted = 0 AND c.UserId = @UserId
                                     ORDER BY c.CreatedAt DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cars.Add(MapCar(reader));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cars;
        }

        public bool Add(Car car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO [dbo].[Car] (UserId, Brand, Model, Color, PlateNumber, Year, CreatedAt, IsDeleted, DeletedAt)
                                     VALUES (@UserId, @Brand, @Model, @Color, @PlateNumber, @Year, @CreatedAt, @IsDeleted, @DeletedAt);
                                     SELECT CAST(SCOPE_IDENTITY() AS BIGINT);";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", car.UserId);
                    command.Parameters.AddWithValue("@Brand", car.Brand);
                    command.Parameters.AddWithValue("@Model", car.Model);
                    command.Parameters.AddWithValue("@Color", car.Color);
                    command.Parameters.AddWithValue("@PlateNumber", car.PlateNumber);
                    command.Parameters.AddWithValue("@Year", car.Year);
                    command.Parameters.Add("@CreatedAt", SqlDbType.DateTime2).Value = car.CreatedAt;
                    command.Parameters.AddWithValue("@IsDeleted", car.IsDeleted);
                    command.Parameters.Add("@DeletedAt", SqlDbType.DateTime2).Value =
                        car.DeletedAt < new DateTime(1753, 1, 1) ? new DateTime(1900, 1, 1) : car.DeletedAt;

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        car.Id = Convert.ToInt64(result);

                    return car.Id > 0;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Delete(Car item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"UPDATE [dbo].[Car]
                                     SET IsDeleted = 1, DeletedAt = @DeletedAt
                                     WHERE Id = @Id AND IsDeleted = 0";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", item.Id);
                    command.Parameters.AddWithValue("@DeletedAt", DateTime.UtcNow);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public Car GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT c.Id, c.UserId, c.Brand, c.Model, c.Color, c.PlateNumber, c.Year, c.CreatedAt,
                                        u.FirstName, u.LastName
                                 FROM [dbo].[Car] c
                                 INNER JOIN [dbo].[User] u ON u.Id = c.UserId
                                 WHERE c.IsDeleted = 0 AND c.Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    return MapCar(reader);

                return null!;
            }
        }

        public bool Update(Car item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"UPDATE [dbo].[Car]
                                     SET Brand = @Brand,
                                         Model = @Model,
                                         Color = @Color,
                                         PlateNumber = @PlateNumber,
                                         Year = @Year
                                     WHERE Id = @Id AND IsDeleted = 0";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", item.Id);
                    command.Parameters.AddWithValue("@Brand", item.Brand);
                    command.Parameters.AddWithValue("@Model", item.Model);
                    command.Parameters.AddWithValue("@Color", item.Color);
                    command.Parameters.AddWithValue("@PlateNumber", item.PlateNumber);
                    command.Parameters.AddWithValue("@Year", item.Year);

                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private static Car MapCar(SqlDataReader reader)
        {
            Car car = new Car(
                id: Convert.ToInt64(reader["Id"]),
                userId: Convert.ToInt64(reader["UserId"]),
                brand: reader["Brand"].ToString() ?? string.Empty,
                model: reader["Model"].ToString() ?? string.Empty,
                color: reader["Color"].ToString() ?? string.Empty,
                plateNumber: reader["PlateNumber"].ToString() ?? string.Empty,
                year: Convert.ToInt32(reader["Year"]));

            car.CreatedAt = reader["CreatedAt"] == DBNull.Value
                ? DateTime.UtcNow
                : Convert.ToDateTime(reader["CreatedAt"]);
            car.OwnerName = $"{reader["FirstName"]} {reader["LastName"]}".Trim();
            return car;
        }
    }
}
