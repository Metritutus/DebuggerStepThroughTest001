using System.Diagnostics;

namespace DebuggerStepThroughTest001
{
    [DebuggerStepThrough]
    //[DebuggerNonUserCode]
    internal class ClassA
    {
        private ClassC ClassC
        {
            [DebuggerHidden] // Skips the "Your step-into request resulted in an automatic step-over" notification window.
                             // Doesn't have any bearing on the issue.
            get;
        }

        public ClassA(ClassC classC)
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
