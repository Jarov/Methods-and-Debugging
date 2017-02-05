using System;
using System.Linq;
using System.Numerics;

public class SequenceOfCommands_broken
{
	public static void Main()
	{
		byte numbersCount = byte.Parse(Console.ReadLine());

        char[] ArgumentsDelimiter = { ' ' };
        BigInteger[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

        string command = "";

		while (command != "stop")
		{
			string[] line = Console.ReadLine().ToLower().Split(ArgumentsDelimiter,  StringSplitOptions.RemoveEmptyEntries);
			int[] args = new int[2];

            if (line.Length > 1)
            {
                for (int i = 0; i < 2; i++)
                    args[i] = int.Parse(line[i + 1]);
            }

            command = line[0];

			PerformAction(array, command, args);

            if (command != "stop") PrintArray(array);
		}
	}

	static void PerformAction(BigInteger[] arr, string action, int[] args)
	{
		int position = args[0] - 1;
		int value = args[1];

		switch (action)
		{
			case "multiply":
                arr[position] *= value;
				break;
			case "add":
                arr[position] += value;
				break;
			case "subtract":
                arr[position] -= value;
				break;
            case "divide":
                arr[position] /= value;
                break;
			case "lshift":
				ArrayShiftLeft(arr);
				break;
			case "rshift":
				ArrayShiftRight(arr);
				break;
		}
	}

	static void ArrayShiftRight(BigInteger[] array)
	{
        BigInteger lastNumber = array.Last();
        for (int o = array.Length - 1; o > 0; o--)
        {
            array[o] = array[o - 1];
        }
        array[0] = lastNumber;
    }

	static void ArrayShiftLeft(BigInteger[] array)
	{
        BigInteger firstNumber = array.First();
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = firstNumber;
	}

	static void PrintArray(BigInteger[] array)
	{
        Console.WriteLine(string.Join(" ", array));
    }
}
