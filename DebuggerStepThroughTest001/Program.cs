namespace DebuggerStepThroughTest001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classA = new ClassA(new ClassC());
            var classB = new ClassB(new ClassC());

            // With "Step over properties and operators (Managed only)" checked...

            classA.TestMethod(); // When stepping in, steps over the whole thing.
            classB.TestMethod(); // When stepping in, steps straight to ClassC.TestMethod();
        }
    }
}