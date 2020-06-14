using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_Balkaran
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var loginID = "balkaran";
            var password = "balkaran123";
            string expectedString = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            SqlConnection con = new SqlConnection(expectedString);
            SqlDataAdapter da = new SqlDataAdapter("userLogin", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@userid", SqlDbType.VarChar).Value = loginID;
            da.SelectCommand.Parameters.Add("@pwd", SqlDbType.VarChar).Value = password;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
                Assert.IsTrue(true);
            else
                Assert.IsFalse(false);
        }
    }
}
