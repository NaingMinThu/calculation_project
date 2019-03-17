using MultipleNumber.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleNumberTDDProject
{
    class MultipleNumber
    {
          static void Main(string[] args)
        {
            MultipleResult obj_result = new MultipleResult();
            int num1, num2;
            Console.WriteLine("Type a first number range to calculate. eg. 1 ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a second number range to calculate. eg. 100");
            num2 = Convert.ToInt32(Console.ReadLine());
            while (num1 <= num2)
            {
                Console.WriteLine("Number " + num1 + "= > " + obj_result.GetValue_OfMultipleNumber(num1));
                num1 += 1;
            }
            Console.ReadLine();
        }
    }
}
