using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayExercise2
    {


        public void arrayStringMin(string[] arr)
        {
            int minLength = int.MaxValue;
            string minString = "";

            foreach (string str in arr)
            {
                if (str.Length < minLength)
                {
                    minLength = str.Length;
                    minString = str;
                }
            }

            Console.WriteLine($"Cel mai mic String: {minString} cu lungimea: {minLength}");
        }

        public void arrayStringMax(String[] maxArr)
        {
            int max = int.MaxValue;
            String maxString = "";

            foreach (String str in maxArr)
            {
                if(str.Length > maxString.Length)
                {
                     max = str.Length;
                      maxString = str;
                }
            }
            Console.WriteLine($"Cel mai mare String:{maxString} cu lungimea : {max}");

        }
    }
}
               



    
