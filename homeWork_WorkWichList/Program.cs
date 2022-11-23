using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_WorkWichList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSum = "sum";
            const string CommandExit = "exit";

            List<int> numbers = new List<int>(); 
            bool isExit = false;            

            while (isExit == false) 
            {
                Console.WriteLine($"Введите числа для нахождения их суммы" +
                  $"\n{CommandSum} - для вывода суммы всех введенных чисел" +
                  $"\n{CommandExit} - для выхода из программы");
                string userInput = Console.ReadLine();

                switch (userInput) 
                {
                    case CommandSum:
                        Console.Write("Введенные вами числа: ");
                        ShowList(numbers);
                        int sum = FindSumInList(numbers);
                        Console.WriteLine($"\nСумма введеных чисел: {sum}");
                        break;

                    case CommandExit:
                        isExit = true;
                        break;
                    
                    default:
                        int number = Convert.ToInt32(userInput);
                        numbers.Add(number);
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

    
        static int FindSumInList(List<int> numbers) 
        {
            int sum = 0;

            foreach (int number in numbers) 
            {
                sum += number;
            }

            return sum;
        }

        static void ShowList(List<int> numbers) 
        {
            foreach (int number in numbers) 
            {
                Console.Write(number + " ");
            }
        }
        
    }
}
