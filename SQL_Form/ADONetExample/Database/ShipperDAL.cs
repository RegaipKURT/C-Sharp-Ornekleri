using ADONetExample.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ADONetExample.Database
{
    class ShipperDAL
    {
        string sql = string.Empty;
        SqlConnection conn = new SqlConnection(Database.GetConnectionString);
        SqlCommand cmd;
        bool result;

        public bool Add(string CompanyName, string PhoneNumber)
        {
            sql = "INSERT INTO Shippers VALUES('" + CompanyName + "','" + PhoneNumber + "')";
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int sonuc = cmd.ExecuteNonQuery(); // etkilenen sonuc sayısının döner.
                if (sonuc > 0)
                {
                    result = true;
                }

            }
            catch (Exception ex)
            { }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public bool Update(int Id, string CompanyName, string PhoneNumber)
        {
            sql = "UPDATE Shippert SET CompanyName='" + CompanyName + "', " +
                "PhoneNumer='" + PhoneNumber + "' " +
                "WHERE ShipperId='" + Id; // Hatalı olabilir Kontrol et!
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int sonuc = cmd.ExecuteNonQuery(); // etkilenen sonuc sayısının döner.
                if (sonuc > 0)
                {
                    result = true;
                }

            }
            catch (Exception ex)
            { }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public bool Delete(int Id)
        {
            sql = "DELETE FROM Shippers WHERE ShipperId='" + Id; // Hatalı olabilir Kontrol et!
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int sonuc = cmd.ExecuteNonQuery(); // etkilenen sonuc sayısının döner.
                if (sonuc > 0)
                {
                    result = true;
                }

            }
            catch (Exception ex)
            { }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public string GetCompanyNameById(int Id)
        {
            sql = "SELECT CompanyName FROM Shippers WHERE ShipperId='" + Id; // Hatalı olabilir Kontrol et!
            cmd = new SqlCommand(sql, conn);
            string CompanyName = string.Empty;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                CompanyName = cmd.ExecuteScalar().ToString(); // etkilenen sonuc sayısının döner.


            }
            catch (Exception ex)
            { }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return CompanyName;
        }

        public List<Shipper> GetShippers(int Id)
        {
            sql = "SELECT CompanyName, ShipperId, PhoneNumber FROM Shipeprs";
            cmd = new SqlCommand(sql, conn);
            List<Shipper> shippers = new List<Shipper>();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    shippers.Add(new Shipper((int)dr[0], dr[1].ToString(), dr[2].ToString()));
                }


            }
            catch (Exception ex)
            { }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return shippers;
        }
    }
}
