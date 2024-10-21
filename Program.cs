
public class Program
{
    public static void Main(string[] args)
    {
        //FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(-1);
        FindMinimum(1, 3, 2);
        Findmaximum(2, 3, 2);
        IsDivisibleBy5(6);
        CheckEvenOrOdd(3);
        CheckVowelOrConstant('e');
        DisplayDayOfWeek(5);
    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int number){
        switch(number){
            case -1:
            Console.WriteLine("Your number is negative.");
            break;
            case 0:
            Console.WriteLine("Your number is zero.");
            break;
            case 1:
            Console.WriteLine("Your number is positive.");
            break;

        }
    }
    public static void FindMinimum(int num1, int num2, int num3){
        if(num1 < num2 && num1 < num3){
            Console.WriteLine("The minimum value is " + num1 + ".");
        }else if(num2 < num1 && num2 < num3){
                    Console.WriteLine("The minimum value is " + num2 + ".");
        }else{
            Console.WriteLine("The minimum value is " + num3 + ".");
        }
    }
    public static void Findmaximum(int num1, int num2, int num3){
         if(num1 > num2 && num1 > num3){
            Console.WriteLine("The maximum value is " + num1 + ".");
        }else if(num2 > num1 && num2 > num3){
                    Console.WriteLine("The maximum value is " + num2 + ".");
        }else{
            Console.WriteLine("The maximum value is " + num3 + ".");
        }
    }
    public static void IsDivisibleBy5(int number){
        if(number % 5 == 0){
            Console.WriteLine(number + " is divisible by 5.");
        }else{
            Console.WriteLine(number + " isn't divisible by 5.");
        }
    }
    public static void CheckEvenOrOdd(int number){
        if(number % 2 ==2){
            Console.WriteLine(number + " is an even number.");
        }else{
            Console.WriteLine(number + " is an odd number.");
        }
    }
    public static void CheckVowelOrConstant(char letter){
        switch(letter){
            case('a'):
            case('A'):
            case('e'):
            case('E'):
            case('i'):
            case('I'):
            case('o'):
            case('O'):
            case('u'):
            case('U'):
            Console.WriteLine(letter + " is a vowel.");
            break;
            default:
            Console.WriteLine(letter + " is not a vowel.");
            break;
            }
    }
    public static void DisplayDayOfWeek(int number){
        switch(number){
            case 0:
            Console.WriteLine("Sunday");
            break;
            case 1:
            Console.WriteLine("Monday");
            break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            case 3:
            Console.WriteLine("Wednesday");
            break;
            case 4:
            Console.WriteLine("Thursday");
            break;
            case 5:
            Console.WriteLine("Friday");
            break;
            case 6:
            Console.WriteLine("Saturday");
            break;
        }
    }
}
