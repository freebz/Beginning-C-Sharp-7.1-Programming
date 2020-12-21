// 예제 6.43 모든 회원 정보를 반환하는 SQL 쿼리 실행

SqlCommand cmd = new SqlCommand();
cmd.Connection = sqlCon;
cmd.CommandText = "SELECT * FROM MemberInfo";
SqlDataReader reader= cmd.ExecuteReader();

// ... [reader를 이용해 레코드를 하나씩 조회] ...