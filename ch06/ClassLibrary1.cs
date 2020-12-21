using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1()
        {
            Console.WriteLine(typeof(Class1).FullName + ": Created");
        }
    }

    public class SystemInfo
    {
        bool _is64Bit;

        public SystemInfo()
        {
            _is64Bit = Environment.Is64BitOperatingSystem;
            Console.WriteLine("SystemInfo created.");
        }

        public void WriteInfo()
        {
            Console.WriteLine("OS = {0}bits", (_is64Bit == true) ? "64" : "32");
        }
    }
}