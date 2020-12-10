.assembly ConsoleApplication2
{
}

.module ConsoleApplication2.exe

.class private auto ansi beforefieldinit Program extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    .maxstack  2
    .locals init ([0] int32 a, [1] int32 b, [2] int32 c)
    IL_0000:  nop
    IL_0001:  ldc.i4.5
    IL_0002:  stloc.0
    IL_0003:  ldc.i4.6
    IL_0004:  stloc.1
    IL_0005:  ldloc.0
    IL_0006:  ldloc.1
    IL_0007:  add
    IL_0008:  stloc.2
    IL_0009:  ret
  }
}