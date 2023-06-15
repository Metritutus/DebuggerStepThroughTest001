using System.Diagnostics;

namespace DebuggerStepThroughTest001
{
    [DebuggerStepThrough]
    //[DebuggerNonUserCode]
    internal class ClassB
    {
        private readonly ClassC ClassC;

        public ClassB(ClassC classC)
        {
            ClassC = classC;
        }

        //[DebuggerHidden]
        public void TestMethod()
        {
            ClassC.TestMethod();
        }
    }
}
