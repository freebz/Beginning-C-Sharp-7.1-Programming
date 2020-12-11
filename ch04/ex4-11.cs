// 예제 4.11 배열 요소에서의 암시적 형변환

Computer[] machines =
new Computer[] { new Notebook(), new Desktop(), new Netbook() }; // 암시적 형변환

DeviceManager manager = new DeviceManager();

foreach (Computer device in machines)
{
    manager.TurnOff(device);
}