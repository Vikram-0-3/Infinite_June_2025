using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static SqlConnection con;
    static SqlCommand cmd;

    static SqlConnection getConnection()
    {
        // Only open the connection here
        con = new SqlConnection("Data Source=ICS-LT-8F8LQ73;Initial Catalog=InfiniteDB;" +
            "User ID=sa; Password=63744724052906");
        return con;
    }

    public static void GetAvgSalAndEmpCount()
    {
        con = getConnection();
        con.Open(); // Open only once here

        Console.WriteLine("Enter Department ID:");
        int did = int.Parse(Console.ReadLine());

        cmd = new SqlCommand("sp_getavgsal_empcount", con);
        cmd.CommandType = CommandType.StoredProcedure;

        // Input parameter
        SqlParameter paramDid = new SqlParameter("@did", SqlDbType.Int);
        paramDid.Value = did;
        cmd.Parameters.Add(paramDid);

        // Output parameter
        SqlParameter paramAvgSal = new SqlParameter("@avgsal", SqlDbType.Float);
        paramAvgSal.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(paramAvgSal);

        // Return value
        SqlParameter paramEmpCount = new SqlParameter();
        paramEmpCount.ParameterName = "@returnVal";
        paramEmpCount.Direction = ParameterDirection.ReturnValue;
        paramEmpCount.SqlDbType = SqlDbType.Int;
        cmd.Parameters.Add(paramEmpCount);

        cmd.ExecuteNonQuery();

        // Retrieve output and return values
        float avgSalary = Convert.ToSingle(cmd.Parameters["@avgsal"].Value);
        int empCount = Convert.ToInt32(cmd.Parameters["@returnVal"].Value);

        Console.WriteLine($"Average Salary: {avgSalary}");
        Console.WriteLine($"Employee Count: {empCount}");

        con.Close(); // Close the connection properly
    }

    static void Main(string[] args)
    {
        try
        {
            GetAvgSalAndEmpCount();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine();
    }
}