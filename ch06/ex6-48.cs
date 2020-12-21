// 예제 6.48 MemberInfoDAC + POCO를 이용한 데이터베이스 연동

static void Main(string[] args)
{
    string connectionString =
                ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;

    MemberInfo item = new MemberInfo();
    item.Name = "Jennifer";
    item.Birth = new DateTime(1985, 5, 6);
    item.Email = "jennifer@jennifersoft.com";
    item.Family = 0;

    using (SqlConnection sqlCon = new SqlConnection(connectionString))
    {
        sqlCon.Open();

        MemberInfoDAC dac = new MemberInfoDAC(sqlCon);
        dac.Insert(item); // 신규 데이터를 추가하고

        item.Name = "Jenny";
        dac.Update(item); // 데이터 내용을 업데이트하고

        MemberInfo[] list = dac.SelectAll(); // 데이터를 조회하고
        foreach (MemberInfo member in list)
        {
            Console.WriteLine(member.Email);
        }

        dac.Delete(item); // 데이터를 삭제한다.
    }   
}