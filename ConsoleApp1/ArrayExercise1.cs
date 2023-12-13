using System;

class ArrayExercise1
{
  public void arrayInt()
    {

        int[] array = { 199, 5, 7, 28, 4, 38, 3, 1 };
        Array.Sort(array);
        int dimension = array.Length;
        Console.WriteLine("dimension:" + dimension);
        Console.Write("Elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine();
        Console.WriteLine("first element" + array[0]);
        int lastElement = array.Length - 1;
        Console.WriteLine("last element" + array[lastElement]);

    }
}


