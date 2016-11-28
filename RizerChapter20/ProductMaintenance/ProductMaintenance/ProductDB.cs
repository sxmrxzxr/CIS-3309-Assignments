using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductMaintenance
{
    public class ProductDB
    {
        public static Product GetProduct(string productCode)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement = "SELECT ProductCode, Description, Price " +
                                     "FROM Products " +
                                     "WHERE ProductCode = @ProductCode";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductCode", productCode);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.Read())
                {
                    Product p = new Product();

                    p.Code = reader["ProductCode"].ToString();
                    p.Description = reader["Description"].ToString();
                    p.Price = Convert.ToDecimal(reader["UnitPrice"]);

                    return p;
                }
                else
                {
                    return null;
                }                   
            }
            catch (SqlException s)
            {
                throw s;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string updateStatement = "UPDATE Products SET " +
                                     "ProductCode = @NewProductCode, " +
                                     "Description = @NewDescription, " +
                                     "UnitPrice = @NewUnitPrice " +
                                     "WHERE ProductCode = @OldProductCode " +
                                     "AND Description = @NewDescription " +
                                     "AND UnitPrice = @NewUnitPrice";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewProductCode", newProduct.Code);
            updateCommand.Parameters.AddWithValue("@NewDescription", newProduct.Description);
            updateCommand.Parameters.AddWithValue("@NewUnitPrice", newProduct.Price);
            updateCommand.Parameters.AddWithValue("@OldProductCode", oldProduct.Code);
            updateCommand.Parameters.AddWithValue("@OldDescription", oldProduct.Description);
            updateCommand.Parameters.AddWithValue("@OldUnitPrice", oldProduct.Price);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException s)
            {
                throw s;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool AddProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string insertStatement = "INSERT Products" +
                                     "(ProductCode, Description, UnitPrice)" +
                                     "VALUES (@ProductCode, @Description, @UnitPrice)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@ProductCode", product.Code);
            insertCommand.Parameters.AddWithValue("@Description", product.Description);
            insertCommand.Parameters.AddWithValue("@UnitPrice", product.Price);

            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
                return count > 0;
            }
            catch (SqlException s)
            {
                throw s;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool DeleteProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string deleteStatement = "DELETE FROM Products" +
                                     "WHERE ProductCode = @ProductCode" +
                                     "AND Description = @Description" +
                                     "AND UnitPrice = @UnitPrice";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@ProductCode", product.Code);
            deleteCommand.Parameters.AddWithValue("@Description", product.Description);
            deleteCommand.Parameters.AddWithValue("@UnitPrice", product.Price);

            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                return count > 0;
            }
            catch (SqlException s)
            {
                throw s;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
