using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {

        static void Main(string[] args)
        {
            ArrayExercise1 arrayExercise1 = new ArrayExercise1();
            arrayExercise1.arrayInt();


            ArrayExercise2 arrayExercise2 = new ArrayExercise2();
            String[] stringFive = { "Volvo", "BMW", "Mercedes", "Dacia", "Hummer" };
            String[] stringTen = { "Mar", "Para", "Pruna", "Portocala", "Capsuna", "Piersica", "Kiwi", "Clementina", "Agude","Caisa"};
            arrayExercise2.arrayStringMax(stringTen);
            arrayExercise2.arrayStringMin(stringTen);
            arrayExercise2.arrayStringMax(stringFive);
            arrayExercise2.arrayStringMin(stringFive);
        }
    }
}
