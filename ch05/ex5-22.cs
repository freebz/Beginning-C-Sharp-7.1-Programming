// 예제 5.22 try/finally를 이용한 Dispose 메서드 호출

FileLogger log = null;
try
{
    log = new FileLogger("sample.log");
    log.Write("Start");
    log.Write("End");
}
finally
{
    log.Dispose();
}