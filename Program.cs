using System;
using System.Data.SqlClient;
class Program
{
    static void Main()
    {
        SqlConnection myConnection = new SqlConnection(
            "user id=d0265bcb;" +
            "password=Test123456;" +
            "server=dd40202.kasserver.com;" +
            "Trusted_Connection=yes;" +
            "database=d0265bcb; " +
            "connection timeout=30");

        SqlDataReader rdr = null;

        try
        {
            // 2. Open the connection
            conn.Open();

            // 3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand("select * from T_Fragebogen_Funk_UBI", conn);

            //
            // 4. Use the connection
            //

            // get query results
            rdr = cmd.ExecuteReader();

            // print the CustomerID of each record
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0]);
            }
        }
        finally
        {
            // close the reader
            if (rdr != null)
            {
                rdr.Close();
            }

            // 5. Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}

