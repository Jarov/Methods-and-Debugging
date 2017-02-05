using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class BePositive_broken
{
	public static void Main()
	{
		int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
		{
            char[] split = { ' ' };
			int[] input = Console.ReadLine().Trim().Split(split, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            bool writeSpace = false;

            for (int j = 0; j < input.Length; j++)
			{
				int currentNum = input[j];

                if (currentNum >= 0)
                {
                    if (writeSpace)
                        Console.Write(" ");
                    Console.Write(currentNum);
                    writeSpace = true;
                }
                else
                {
                    try
                    {
                        currentNum += input[j + 1];
                    }
                    catch
                    {
                        currentNum = input[j];
                    }

                    if (currentNum >= 0)
                    {
                        if (writeSpace)
                            Console.Write(" ");
                        Console.Write(currentNum);
                        writeSpace = true;
                    }
                    j++;
                }
            }

            if (!writeSpace)
                Console.WriteLine("(empty)");
            else
                Console.WriteLine();
        }
    }
}