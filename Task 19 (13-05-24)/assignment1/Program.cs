using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Program
    {
        SqlConnection conn = new SqlConnection("data source=DESKTOP-6K77UK\\SQLEXPRESS; database=Piyush; integrated security=SSPI");
        public void createTable()
        {
            try
            {
                string query = "CREATE TABLE AdvantureWorks2019 ( ID INT PRIMARY KEY, NAME VARCHAR(20) )";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Table created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void getTable()
        {
            try
            {
                string query = "SELECT * FROM AdvantureWorks2019";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("---------------------");
                Console.Write("{0,-10}", "ID");
                Console.Write("|");
                Console.Write("{0,-10}", "Name");
                Console.WriteLine("|");
                Console.WriteLine("---------------------");
                while (reader.Read())
                {
                    Console.Write("{0,-10}",reader["id"]);
                    Console.Write("|");
                    Console.Write("{0,-10}", reader["name"]);
                    Console.WriteLine("|");
                }
                Console.WriteLine("--------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void insertData(int id, string name)
        {
            try
            {
                string query = "INSERT INTO AdvantureWorks2019 VALUES(@id, @name)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data inserted successfylly");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void updateData(int id, string name)
        {
            try
            {
                string query = "UPDATE AdvantureWorks2019 SET NAME = @name where id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data updated successfylly");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void deleteData(int id)
        {
            try
            {
                string query = "DELETE FROM AdvantureWorks2019 WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Row Deleted successfylly");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void getDataById(int id)
        {
            try
            {
                string query = "SELECT * FROM AdvantureWorks2019 WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0,-30}{1,-30}", reader["ID"], reader["NAME"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void executeProcedure()
        {
            SqlConnection conn1 = null;
            try
            {
                conn1 = new SqlConnection("data source=DESKTOP-6K77UK\\SQLEXPRESS; database=AdventureWorks2022; integrated security=SSPI");
                SqlCommand cmd = new SqlCommand("getEmployeeDetails", conn1)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                conn1.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("{0,-40}{1,-40}{2,-40}", "First Name","Last Name","Phone No");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                while (reader.Read())
                {
                    Console.WriteLine("{0,-40}{1,-40}{2,-40}",reader[0], reader[1], reader[2]);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }

        public void findSalesPerson(string productNo)
        {
            SqlConnection conn2 = null;
            try
            {
                conn2 = new SqlConnection("data source=DESKTOP-6K77UK\\SQLEXPRESS; database=AdventureWorks2022; integrated security=SSPI");
                string query = "select distinct(fullName) from (select concat(p.FirstName,' ', p.LastName)as fullName from production.product as pr inner join sales.SalesOrderDetail as sod on pr.ProductID = sod.ProductID inner join sales.SalesOrderHeader as soh on sod.SalesOrderID = soh.SalesOrderID inner join person.person as p on p.BusinessEntityID = soh.SalesPersonID where pr.ProductNumber = @No) as t";
                SqlCommand cmd = new SqlCommand(query, conn2);
                cmd.Parameters.AddWithValue("@No", productNo);
                conn2.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("{0,-30}", "FullName");
                Console.WriteLine("---------------------");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn2.Close();
            }
        }

        public void createProcedure()
        {
            SqlConnection conn3 = null;
            try
            {
                conn3 = new SqlConnection("data source=DESKTOP-6K77UK\\SQLEXPRESS; database=AdventureWorks2022; integrated security=SSPI");
                string query = "create procedure getPersonData as begin select * from person.Person end;";
                SqlCommand cmd = new SqlCommand(query, conn3);
                conn3.Open();
                int change = cmd.ExecuteNonQuery();
                Console.WriteLine("Stored Procedure Created successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn3.Close();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.createTable();                      //No 1 -- Create table
            //p.findSalesPerson("BK-M82B-42");      //No 2 -- Find sales person name
            //p.executeProcedure();                 //No 3 -- Retrive data from stored Procedure
            //p.createProcedure();                  //No 4 -- Create procedure


            //Assignment 5 - CRUD Operationdo
            int no;
            do
            {
                Console.WriteLine("Enter the Nuber:");
                Console.WriteLine("=============================");
                Console.WriteLine("Enter 0 to exit");
                Console.WriteLine("Press 1 to add Data");
                Console.WriteLine("Press 2 to modify Data");
                Console.WriteLine("Press 3 to Delete data");
                Console.WriteLine("Press 4 to get data");
                no = Convert.ToInt32(Console.ReadLine());
                switch (no)
                {
                    case 0:
                        Console.WriteLine("Loged Out Successfylly");
                        break;
                    case 1:
                        Console.WriteLine("Enter the id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name");
                        string name = Console.ReadLine();
                        p.insertData(id, name);
                        break;
                    case 2:
                        Console.WriteLine("Enter the id you want to modify");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the updated name");
                        name = Console.ReadLine();
                        p.updateData(id, name);
                        break;
                    case 3:
                        Console.WriteLine("Enter the id you want to Delete");
                        id = Convert.ToInt32(Console.ReadLine());
                        p.deleteData(id);
                        break;
                    case 4:
                        ;
                        p.getTable();
                        break;
                    default:
                        Console.WriteLine("Please enter the valid number");
                        break;
                }
            } while (no != 0);



            //p.getDataById(1);                     //No 6 -- usign parameter
            //Console.WriteLine("Working...");
            Console.ReadKey();
        }
    }
}
