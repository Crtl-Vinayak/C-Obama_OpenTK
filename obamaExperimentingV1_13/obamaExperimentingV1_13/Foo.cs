using System;

namespace obamaExperimentingV1_13
{
    class Foo
    {
        public static void foo()
        {
            Program.foo = "asdfghjkl";
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(Program.foo);
            }
            Console.ReadLine();
        }
    }
}