// 예제 6.53 DataSet을 사용한 데이터베이스 연동

static void Main(string[] args)
{
    string connectionString =
                ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

    using (SqlConnection sqlCon = new SqlConnection(connectionString))
    {
        sqlCon.Open();

        MemberInfoDAC dac = new MemberInfoDAC(sqlCon);

        DataRow newItem = dac.NewRow();
        newItem["Name"] = "Jennifer";
        newItem["Birth"] = new DateTime(1985, 5, 6);
        newItem["Email"] = "jennifer@jennifersoft.com";
        newItem["Family"] = 0;

        dac.Insert(newItem);

        newItem["Name"] = "Jenny";
        dac.Update(newItem);

        DataSet ds = dac.SelectAll();
        foreach (DataRow member in ds.Tables["MemberInfo"].Rows)
        {
            Console.WriteLine(member["Email"]);
        }

        dac.Delete(newItem);
    }   
}