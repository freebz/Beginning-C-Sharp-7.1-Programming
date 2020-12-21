// 예제 6.44 DataReader를 이용한 테이블 내용 조회

// ... [생략: SELECT * FROM MemberInfo 쿼리를 수행하는 SqlCommand] ...
SqlDataReader reader = cmd.ExecuteReader();

while (reader.Read()) // 읽어야 할 데이터가 남아 있다면 true, 없다면 false를 반환
{
    string name = reader.GetString(0);
    DateTime birth = reader.GetDateTime(1);
    string email = reader.GetString(2);
    byte family = reader.getByte(3);

    Console.WriteLine("{0}, {1}, {2}, {3}", name, birth, email, family);
}

reader.Close();