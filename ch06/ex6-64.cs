// 예제 6.64 레지스트리 값 읽기

using System;
using Microsoft.Win32;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string regPath = @"HARDWARE\DESCRIPTION\System\BIOS";

            using (RegistryKey systemKey = Registry.LocalMachine.OpenSubKey(regPath))
            {
                string biosDate = (string)systemKey.GetValue("BIOSReleaseDate");
                string biosMaker = (string)systemKey.GetValue("BIOSVendor");

                Console.WriteLine("BIOS 날짜: " + biosDate);
                Console.WriteLine("BIOS 제조사: " + biosMaker);
            }

            using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey(regPath, true))
            {
                regKey.SetValue("TestValue1", 5);       // REG_DWORD로 기록됨
                regKey.SetValue("TestValue2", "Test");  // REG_SZ로 기록됨
            }
        }
    }
}