using System;

namespace CSharpIntro {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World! \n");

            // make bool, string, and int variables (with values)
            bool boolVar = true;
            string stringVar = new string ("Hello World");
            int intVar = 1;

            // change their values to something else
            boolVar = false;
            stringVar = new string ("Hi World");
            intVar = 5;

            // print their values with Console
            Console.WriteLine ("bool variable = " + boolVar);
            Console.WriteLine ("string variable = " + stringVar);
            Console.WriteLine ("int variable = " + intVar);

            // do something in a for loop
            Console.WriteLine ("\n do something in a for loop");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine ("for loop iteration = " + i);
            }

            // do something in a while loop
            Console.WriteLine ("\n do something in a while loop");

            int whileLoopCount = 5;
            while (whileLoopCount > 0) {
                Console.WriteLine ("while loop iteration = " + whileLoopCount);
                whileLoopCount--;
            }

            // do something with a switch statement
            Console.WriteLine ("\n do something with a switch statement");
            int switchCaseType = 0;
            switch (switchCaseType) {
                case 0:
                    Console.WriteLine ("switch case = 0");
                    break;
                case 1:
                    Console.WriteLine ("switch case = 1");
                    break;
                default:
                    Console.WriteLine ("switch case = default");
                    break;
            }

            // do something with if, else if, else
            Console.WriteLine ("\n do something with if, else if, else");

            int ifType = 0;
            if (ifType == 0) {
                Console.WriteLine ("if case = true");
            } else if (ifType == 1) {
                Console.WriteLine ("else if case = true");
            } else {
                Console.WriteLine ("else case = true");
            }

            // figure out how to make multi-line comments in C#
            /*
                this
                is a
                multi-line
                comment
            */

            // figure out how to format your document in VS Code
            // shift + alt + 'f'

            // extra: make a new static method to do something and call it
            Console.WriteLine ("\n make and call a static method");
            Program.StaticMethode ();

            // extra: learn what "var" means in C# and try it out.
            /*
                -the "var" type implicitly sets the type of a variable
                -compiler determins the type
            */
        }

        // example of a static method
        static void StaticMethode () {
            Console.WriteLine ("static method called");
        }
    }
}