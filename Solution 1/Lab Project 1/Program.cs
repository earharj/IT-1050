

namespace Lab_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.Write("What is your first name?");
            String firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial?");
            String middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name?");
            String lastName = System.Console.ReadLine();
            
            System.Console.Write("What is your height in feet?");
            int heightFeet;
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many extra inches?");
            double heightInches;
            heightInches = double.Parse(System.Console.ReadLine());

            double heightInInches = heightFeet * 12;
            double totalInches = heightInInches + heightInches;
            double heightInCM = totalInches * 2.54;

            System.Console.Write("What is your age?");
            int age;
            age = int.Parse(System.Console.ReadLine());
            bool atLeast18 = (age >= 18);

            System.Console.Write("Are you a US Citizen(True or False)?");
            bool isCitizen;                  
            isCitizen = bool.Parse(System.Console.ReadLine());
          
            bool canVote = (isCitizen && atLeast18);
               
            String fullName = firstName + " " + middleInitial + ". " + lastName;
            System.Console.WriteLine("Your full name is: " + fullName);

            System.Console.WriteLine("Your height in centimeters is: " + heightInCM);

            System.Console.WriteLine("You can vote: " + canVote);

            System.Console.ReadKey();



           
        }
    }
}
