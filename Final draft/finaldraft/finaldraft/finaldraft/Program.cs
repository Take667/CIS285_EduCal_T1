/* Lab1 Assigment 1 (no loop & gui)
 * Tyas Chaney
 * 02/11/2023
 */

using System;

class Lab1
{
    static void Main()
    {
        const int x = 10;
        const double rate1 = 0.1;
        const double incrRate = 0.10;
        const string empId = "Y45690";
        const int y = 25;
        // -------------declare variables for interactive i/p & calc-------------
        int age, z;
        string ssno, fname, lname, empstatus, insocde, iracode;
        double payrate, amtira;
        double newRate, bonus, money1, money2;
        char shift;

        //-----------------------------------------------------
        Console.Write("Enter the soc sec no 568-78-9991");
        fname = Console.ReadLine();

        Console.Write("Enter the first name Jonathon");
        fname = Console.ReadLine();

        Console.WriteLine("Enter the Last Name Johnson");
        lname = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        age = Convert.ToInt16(Console.ReadLine());

        
        Console.WriteLine("Enter the amount : ");
        money1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n What shift do you want to sign for (use N for Night Shift - or - D for DAY Shift) : ");
        shift = Console.ReadLine()[0];

        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        // Calculate- any detail values (z and money2)
        z = x + y + age;
        money2 = rate1 * money1+ incrRate;

        display- DETAIL 0/payrate (values from INPUT, DETAIL CALCULATIONS might be printed here)
            Console.WriteLine("\n INPUT VALUES: \t First \t Last \t Age \t Money-IP ]\t Age \t Money-IP \t Shift");
        Console.WriteLine("\n                 \t" \t \t \t"" + lname + "\t" + age + "\t" + age + "\t" + money1 + "\t \t \t" + shift);
        Console.Write("\n ************************************");
        // -----------------------------------------------------
        Console.WriteLine("\n DETAIL CALCULATED VALUES: \t Z VALUE \t Money-Calc (2)");
        Console.WriteLine("\n                   \t \t \t \t" + z + "\t \t \t " + money2);
        Console.WriteLine("\n ************************************");
        //---------------------------------------------------------

    } 
}



           

        

        

         

        

       
    
       
 
