//Task 1 creating variabales

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.IO;
using System.Globalization;

public class Program
{
    int var1;
    int var2;
    static int diff;

    public static void Main(string[] args)
    {
        Program obj = new Program();

        obj.TakeInput();                                      //Tasks 1 and 2 put together 

        diff = obj.Difference(obj.var1, obj.var2);

        Console.WriteLine("The Difference between the two numbers is " + diff);

        int[] numbers = CreateArray(diff, obj.var1);                //Task 3 creating array

        obj.createFile(numbers);                                   //Task 4 creating file
    }

    private void TakeInput()  //have combined task 1 and 2 into this method.
    {
        while (true)
        {
            Console.WriteLine("Enter smaller number: ");
            var1 = Int32.Parse(Console.ReadLine());

            if (var1 >= 0) //ensures that the number is positive
            {
                break;
            }
        }

        while (true)
        {
            Console.WriteLine("Enter larger number: ");
            var2 = Int32.Parse(Console.ReadLine());

            if (var2 > var1)
            {
                break;
            }
        }
    }

    private int Difference(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1 - n2;
        }
        else  //not needed since TakeInput() method ensures that n1 < n2

        {
            return n2 - n1;
        }


    }

    private static int[] CreateArray(int d1, int start)
    {
        int arraySize = d1 + 1;
        int[] numbers = new int[arraySize]; //calculate size and create array

        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = start + i;

        }
        //output in reverse
        Console.WriteLine("Array in reverse order:");
        for (int i = arraySize - 1; i >= 0; i--) //Starts at the end of the array, stops when index reaches 0, decreases index by 1)
        {
            Console.WriteLine(numbers[i]);
        }
        return numbers;
    }
    private void createFile(int[] numbers)
    {
        string path = "C:\\C# Projects\\Basics of C#\\Basics of C#\\output.txt";

        using (StreamWriter writer = new StreamWriter(path))
        {
            for (int i = numbers.Length -1; i >= 0; i--)
            {
                writer.WriteLine(numbers[i]);
            }
        }  
    }
}
