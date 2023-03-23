class BMI
{
    static void Main(string[] args)
    {
        // declaring variables
        double heightInMeters;
        double weightInKilograms;
        double bmi;

        // prompting user to get input for heightInMeters
        Console.Write("Enter Your Height In Meters:  ");
        heightInMeters = Convert.ToDouble(Console.ReadLine());

        // prompting user to get input for weightInKilograms
        Console.Write("Enter Your Weight In Kilograms:  ");
        weightInKilograms = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // calculating Body Mass Index
        bmi = weightInKilograms / (heightInMeters * heightInMeters);

        // bmi values
        if (bmi >= 30)
        {
            Console.WriteLine("Your BMI Value Is " + Math.Round(bmi) + " And You Fall In The Category Of Obese");
        }

        else if (bmi >= 25 && bmi <= 29.9)
        {
            Console.WriteLine("Your BMI Value Is " + Math.Round(bmi) + " And You Fall In The Category Of Overweight");
        }

        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Your BMI Value Is " + Math.Round(bmi) + " And You Fall In The Category Of Normal");
        }

        else if (bmi < 18.5)
        {
            Console.WriteLine("Your BMI Value Is " + Math.Round(bmi) + " And You Fall In The Category Of Underweight");
        }

    }
    // end of Main method
}
// end of BMI class
