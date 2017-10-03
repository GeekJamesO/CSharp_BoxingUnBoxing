using System;
using System.Collections.Generic;

namespace BoxingUnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var thisList = new List<object>();
			thisList.Add(7);
			thisList.Add(28);
			thisList.Add(-1);
			thisList.Add(true);
			thisList.Add("chair");
			//thisList.Add(false);

			var sum = 0;
			foreach(object o in thisList) {
                sum += PrintObject(o);
            }
            Console.WriteLine("The sum is: " + sum);
		}
        private static int PrintObject(object k) {
            if (k is string)
                Console.WriteLine("\"" + k.ToString() + "\"");
            else if (k is int)
            {
                Console.WriteLine((int)k);
                return (int)k;
            }
			else if (k is Boolean)
            if ((Boolean) k)
				Console.WriteLine("true");
            else
				Console.WriteLine("false");

            return 0;
		}
    }
}
