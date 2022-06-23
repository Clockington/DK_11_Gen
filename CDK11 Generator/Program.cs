using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDK11_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ckd11 = 7, StartNumber, QuantitySerials, PreMathPrefix = 0, PreMathSerial, PreMathCkd11, Counter0 = 1, Counter1 = 1, Counter2 = 1, Counter3 = 1;
            string Prefix, FormatSerial, SerialNumber;

            Console.WriteLine("Write in the Prefix of the Serial Number. Leave empty if none apply");
            Prefix = Console.ReadLine();
            Console.WriteLine("Write in the number of digits for the serial number: (Example: ### for 3 digits)");
            FormatSerial = Console.ReadLine();
            Console.WriteLine("Type in the starting serial number. Number can't be less than 0.");
            StartNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Write in the number of serial numbers to generate. Maximum of 1.000.000");
            QuantitySerials = int.Parse(Console.ReadLine());

            char[,] array0 = new char[,] { { '1', 'B', 'L', 'V' }, { '0', 'A', 'U', 'K' }, { '2', 'C', 'M', 'N' }, { '3', 'D', 'N', 'X' }, { '4', 'E', 'O', 'Y' }, { '5', 'F', 'P', 'Z' }, { '6', 'G', 'Q', 'Q' }, { '7', 'H', 'R', 'R' }, { '8', 'I', 'S', 'S' }, { '9', 'J', 'T', 'T' } };

            /*            if (Prefix.Length > 0)
                            Prefix = '';*/
            //PreMath Prefix
            {
                do
                {
                    Counter1 = Prefix.Length;
                    Counter1++;
                }
                while (Counter1 < Prefix.Length);
            }
            //PreMath Serial
            {
                do
                {
                    Counter2++;
                }
                while (Counter2 < SerialNumber.Length);

            }
            //PreMath Ckd11
            {
                if (PreMathPrefix < 2 && PreMathPrefix > 9)
                    Ckd11 = 11 - PreMathCkd11;
            }


            do
            {
                SerialNumber = StartNumber.ToString().PadLeft(FormatSerial.Length, '0');
                Console.WriteLine("{0}{1}{2}", Prefix, SerialNumber, Ckd11);
                StartNumber++;
                Counter0++;
            }
            while (Counter0 < QuantitySerials);

            /*
                        if (PreMathPrefix != 0 || PreMathPrefix != 1)
                            Ckd11=11-PreMath;*/


            //            Console.WriteLine("{0}{1}{2}", Prefix, SerialNumber, Ckd11);


        }
    }
}
