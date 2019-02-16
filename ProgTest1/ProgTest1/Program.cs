using System;

namespace ProgTest1
{
        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine("Please enter a number x:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("exp({0}) = " + CalculateExp(x), x);

                Console.Read();
            }



            static double CalculateExp(double x)
            {

                double answer = 0; //holds and returns the final answer

                double oldanswer = 0; //is used to hold the previous answer and will be used to stop the taylor series

                double k = 0;

                while (true)
                {

                    answer += Math.Pow(x, k) / Factorial(k);

                    if (answer == oldanswer)
                    {
                        break; // once the previous answer and new answer are the same there is no need to continue the taylor series
                    }
                    else
                    {
                        oldanswer = answer;
                        k++; // is used to track the iterations
                    }

                }

                return answer;
            }



            static double Factorial(double x)
            {

                double answer = 1;
                double counter = 1;

                while (counter <= x)
                {
                    answer = answer * counter;
                    counter++;

                }

                return answer;
            }

        }
    }

