//  예제 6.50 칼럼 정보를 포함하는 DataTable 정의

DataTable table = new DataTable("MemberInfo");

table.Columns.Add(nameCol);
table.Columns.Add(birthCol);
table.Columns.Add(emailCol);
table.Columns.Add(familyCol);