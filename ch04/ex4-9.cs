// 예제 4.9 상속을 이용한 클래스 정의

public class Computer
{
    bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class Notebook : Computer
{
    bool fingerScan;    // Notebook 타입에 해당하는 멤버만 추가
    public bool HasFingerScanDevice() { return fingerScan; }
}

public class Desktop : Computer
{
}

public class Netbook : Computer
{
}