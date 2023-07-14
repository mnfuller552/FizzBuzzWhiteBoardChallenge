using System;

namespace FizzBuzzWhiteBoardChallenge
{
   public  class Program
    {

        
            static void Main(string[] args)
        {
            Console.WriteLine("Please enter a nunber");
            var answer = Convert.ToInt32(Console.ReadLine());

            static string FizzBuzz(int number)
            {

                var answer = "";

                if (number % 3 == 0)
                {
                    answer = "Fizz";
                }
                if (number % 5 == 0)
                {
                    answer += "Buzz";
                }
                return answer;

            }

            Console.WriteLine(FizzBuzz(answer));


        }


    }



}

