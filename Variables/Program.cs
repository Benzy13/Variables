using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte (byte): {0}\t{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Int16 (short): {0}\t{1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Int32 (int): {0}\t{1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Int64 (long): {0}\t{1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Single (float): {0}\t{1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Double (double): {0}\t{1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Decimal (deciaml): {0}\t{1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("Boolean (bool): {0}\t{1}", bool.TrueString, bool.FalseString);

            try
            {
                var number = "true";
                bool b = Convert.ToBoolean(number);
                //   i = i + 1;
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception occured");
            }
        }
    }
}
