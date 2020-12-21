// 예제 6.18 Move의 덮어 쓰기 구현

string target = "c:\\temp\\test.dat";
if (FileLogger.Exists(target) == true)
{
    FileLogger.Delete(target);
}
FileLogger.Move("test.log", target);