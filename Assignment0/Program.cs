using System;

namespace Assignment0
{
    public class Program
    {

        static void Main(string[] args){
            try{
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 1582 && IsLeapYear(year) == true){Console.WriteLine("yay");}
            if (year > 1582 && IsLeapYear(year) == false) {Console.WriteLine("nay");}
            if (year < 1582) Console.WriteLine("Run the program again and type a year after 1582");
            } catch (Exception e){Console.WriteLine(e);}
        }

        static bool IsLeapYear(int year){
            if ((year % 400) == 0) 
                return true;
            else if ((year % 4) == 0) 
                return true;
            else if ((year % 100) == 0) 
                return false;
            else return false; 
        }
    

}
}
