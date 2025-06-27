// This is the C# solution for the assignment.

using System;

public class AssignmentSolution
{
    public static void Main(string[] args)
    {

        #region 1- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
        Console.WriteLine("\n--- Question 1: Collinear Points ---");
        Console.WriteLine("Enter x1:");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter y1:");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter x2:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter y2:");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter x3:");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter y3:");
        double y3 = Convert.ToDouble(Console.ReadLine());

        // Using the slope formula: (y2 - y1) / (x2 - x1) == (y3 - y2) / (x3 - x2)
        // To avoid division by zero and floating point inaccuracies, use cross-multiplication:
        // (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1)
        double val1 = (y2 - y1) * (x3 - x2);
        double val2 = (y3 - y2) * (x2 - x1);

        // Compare with a small epsilon for floating point numbers
        if (Math.Abs(val1 - val2) < 0.00001)
        {
            Console.WriteLine("The three points lie on a single straight line.");
        }
        else
        {
            Console.WriteLine("The three points do not lie on a single straight line.");
        }
        #endregion

        #region 2- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker\"s efficiency level is determined as follows: - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. - If the worker takes 3 to 4 hours, they are instructed to increase their speed. - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. - If the worker takes more than 5 hours, they are required to leave the company. To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
        Console.WriteLine("\n--- Question 2: Worker Efficiency ---");
        Console.WriteLine("Enter the time taken by the worker in hours:");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        if (timeTaken >= 2 && timeTaken <= 3)
        {
            Console.WriteLine("Highly efficient.");
        }
        else if (timeTaken > 3 && timeTaken <= 4)
        {
            Console.WriteLine("Instructed to increase speed.");
        }
        else if (timeTaken > 4 && timeTaken <= 5)
        {
            Console.WriteLine("Provided with training to enhance speed.");
        }
        else if (timeTaken > 5)
        {
            Console.WriteLine("Required to leave the company.");
        }
        else
        {
            Console.WriteLine("Invalid time input."); // For times less than 2 hours, though not explicitly defined in problem
        }
        #endregion

        #region 26- Given a list of space separated words, reverse the order of the words.
        // 26- Given a list of space separated words, reverse the order of the words.
        // Input: this is a test        Output: test a is this
        // Input: all your base        Output: base your all
        // Input: Word            Output: Word
        // Note : 
        // Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine Statement
        Console.WriteLine("\n--- Question 26: Reverse Words ---");
        Console.WriteLine("Enter a sentence to reverse the words:");
        string inputSentence = Console.ReadLine();

        string reversedSentence = "";
        int wordEnd = inputSentence.Length;

        for (int i = inputSentence.Length - 1; i >= 0; i--)
        {
            if (inputSentence[i] == ' ')
            {
                // Found a space, so the word is from i+1 to wordEnd-1
                for (int j = i + 1; j < wordEnd; j++)
                {
                    reversedSentence += inputSentence[j];
                }
                reversedSentence += ' ';
                wordEnd = i;
            }
        }

        // Add the first word (or the only word if no spaces)
        for (int j = 0; j < wordEnd; j++)
        {
            reversedSentence += inputSentence[j];
        }

        Console.WriteLine("Output: " + reversedSentence);
        #endregion

    }
}

