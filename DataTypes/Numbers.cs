using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.DataTypes
{
    internal class Numbers
    {
        public Numbers()
        {
            int shortSize = sizeof(short);
            int intSize = sizeof(int);
            int longSize = sizeof(long);
            int decimalSize = sizeof(decimal);
            int ushortSize = sizeof(ushort);
            int uintSize = sizeof(uint);
            int ulongSize = sizeof(ulong);

            int floatSize = sizeof(float);
            int doubleSize = sizeof(double);

            Console.WriteLine("Size of int:- {0}", intSize);
            Console.WriteLine("Size of float:- {0}", floatSize);
            Console.WriteLine("Size of short:- {0}", shortSize);
            Console.WriteLine("Size of long:- {0}", longSize);
            Console.WriteLine("Size of decimal:- {0}", decimalSize);
            Console.WriteLine("Size of double:- {0}", doubleSize);
            Console.WriteLine("Size of ushort:- {0}", ushortSize);
            Console.WriteLine("Size of uint:- {0}", uintSize);
            Console.WriteLine("Size of ulong:- {0}", ulongSize);

            // Integers Numbers

            Console.WriteLine();
            Console.WriteLine("Integers Numbers");

            short minshortValue = short.MinValue;
            short maxshortValue = short.MaxValue;

            Console.WriteLine("int Min short Value:- {0}", minshortValue);
            Console.WriteLine("int Max short Value:- {0}", maxshortValue);

            int minIntValue = int.MinValue;
            int maxIntValue = int.MaxValue;

            Console.WriteLine("int Min int Value:- {0}", minIntValue);
            Console.WriteLine("int Max int Value:- {0}", maxIntValue);

            long minlongValue = long.MinValue;
            long maxlongValue = long.MaxValue;

            Console.WriteLine("int Min long Value:- {0}", minlongValue);
            Console.WriteLine("int Max long Value:- {0}", maxlongValue);

            decimal mindecimalValue = decimal.MinValue;
            decimal maxdecimalValue = decimal.MaxValue;

            Console.WriteLine("int Min decimal Value:- {0}", mindecimalValue);
            Console.WriteLine("int Max decimal Value:- {0}", maxdecimalValue);

            // Decimals
            Console.WriteLine();
            Console.WriteLine("Decimals");

            float minFloatValue = float.MinValue;
            float maxFloatValue = float.MaxValue;

            Console.WriteLine("int Min Float Value:- {0}", minFloatValue);
            Console.WriteLine("int Max Float Value:- {0}", maxFloatValue);

            double mindoubleValue = double.MinValue;
            double maxdoubleValue = double.MaxValue;

            Console.WriteLine("int Min double Value:- {0}", mindoubleValue);
            Console.WriteLine("int Max double Value:- {0}", maxdoubleValue);

            ushort minushortValue = ushort.MinValue;
            ushort maxushortValue = ushort.MaxValue;

            Console.WriteLine("int Min ushort Value:- {0}", minushortValue);
            Console.WriteLine("int Max ushort Value:- {0}", maxushortValue);

            uint minuintValue = uint.MinValue;
            uint maxuintValue = uint.MaxValue;

            Console.WriteLine("int Min uint Value:- {0}", minuintValue);
            Console.WriteLine("int Max uint Value:- {0}", maxuintValue);

            ulong minulongValue = ulong.MinValue;
            ulong maxulongValue = ulong.MaxValue;

            Console.WriteLine("int Min ulong Value:- {0}", minulongValue);
            Console.WriteLine("int Max ulong Value:- {0}", maxulongValue);
        }
    }
}
