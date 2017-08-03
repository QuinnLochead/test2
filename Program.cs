using System;

namespace testt
{
    class Program
    {
        static void Main(string[] args)
        {//get the user to input a number (and it must be a number otherwise crash)
        //create a forloop that uses that number and print the times 
        //table up to the number 12 on the screen

            Console.WriteLine("input a number and ill times that number up to 12");
             
            
            var input1 = Console.ReadLine();
            var number1 = 0;
            var isNumber = int.TryParse(input1,out number1);
            
            
           

            for(var count = 0; count <13; count++){


                Console.WriteLine(number1 + " Times " + count + " = " +
                number1*count);


            }




            
         
        }
    }
}
