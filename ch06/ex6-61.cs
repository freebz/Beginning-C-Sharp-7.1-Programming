// 예제 6.61 어셈블리를 참조하지 않고 다른 DLL의 클래스 사용

using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("ClassLibrary1.dll");

            Type systemInfoType = asm.GetType("ClassLibrary1.SystemInfo");

            ConstructorInfo ctorInfo = systemInfoType.GetConstructor(Type.EmptyTypes);
            object objInstance = ctorInfo.Invoke(null);

            MethodInfo methodInfo = systemInfoType.GetMethod("WriteInfo");
            methodInfo.Invoke(objInstance, null);

            FieldInfo fieldInfo = systemInfoType.GetField("_is64Bit",
                                    BindingFlags.NonPublic | BindingFlags.Instance);
            object oldValue = fieldInfo.GetValue(objInstance);
            fieldInfo.SetValue(objInstance, !Environment.Is64BitOperatingSystem);

            methodInfo.Invoke(objInstance, null);
        }
    }
}