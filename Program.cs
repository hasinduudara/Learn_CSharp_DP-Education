// Unit 03 | Syntax

// using System;

// namespace Result
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello DP Education!");
//             Console.ReadLine();
//         }
//     }
// }




// Outputs & Comments

// using System;

// namespace Result
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello DP Education!");
//             Console.WriteLine("Hello DP Education!");
//             Console.WriteLine("Hello DP Education!");
//         }
//     }
// }

// using System;

// namespace Result
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Hello DP Education!");
//             Console.Write("Hello DP Education!");
//             Console.Write("Hello DP Education!");
//         }
//     }
// }




// Variables

// using System;

// namespace Variable
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string name = "John";
//             Console.WriteLine(name);
//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace Variable
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string fName = "Hasindu";
//             string LName = "Hasindu";
//             string fullName = fName + " " + LName;

//             Console.WriteLine(fullName);
//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace Variable
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int x, y, z;
//             x = y = z = 50;
//             Console.WriteLine(x + y + z);
//             Console.ReadLine();
//         }
//     }
// }




// Type Casting

// using System;

// namespace TypeCasting
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int myInt = 10;
//             double myDouble = myInt;

//             Console.WriteLine(myInt);
//             Console.WriteLine(myDouble);

//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace TypeCasting
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double myDouble = 10.5;
//             int myInt = (int)myDouble;

//             Console.WriteLine(myDouble);
//             Console.WriteLine(myInt);

//             Console.ReadLine();
//         }
//     }
// }

using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            double myDouble = 5.61;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));

            Console.ReadLine();
        }
    }
}