using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10952444Assignment1
{
    internal class GradeCalculator
    {
        public static void Main(string[] args)
        {
            int grade;

            
            while (true)
            {
                Console.Write("Enter a numerical grade (0-100): ");
                string input = Console.ReadLine();

                
                if (int.TryParse(input, out grade))
                {
                    
                    if (grade >= 0 && grade <= 100)
                    {
                        break; 
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a grade between 0 and 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid numerical grade.");
                }
            }

            char letterperGrade;
            if (grade >= 90)
            {
                letterperGrade = 'A';
            }
            else if (grade >= 80)
            {
                letterperGrade = 'B';
            }
            else if (grade >= 70)
            {
                letterperGrade = 'C';
            }
            else if (grade >= 60)
            {
                letterperGrade = 'D';
            }
            else
            {
                letterperGrade = 'F';
            }

            Console.WriteLine($"The score {grade} you entered corresponds to grade {letterperGrade}.");
            Console.WriteLine($"Your letter grade is: {letterperGrade}");
        }
    }
}
