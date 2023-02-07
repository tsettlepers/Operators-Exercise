namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int v1 = ReadInt("Enter the first integer...");
            int v2 = ReadInt("Enter the second integer...");
            try
            {
                Console.WriteLine("---");
                Console.WriteLine($"{v1}+{v2} = {v1 + v2}");
                Console.WriteLine($"{v1}-{v2} = {v1 - v2}");
                Console.WriteLine($"{v1}*{v2} = {v1 * v2}");
                Console.WriteLine($"{v1}/{v2} = {v1 / v2} remainder {v1 % v2}");
            }
            catch 
            { 
                Console.WriteLine("An error occurred--most likely divide-by-zero.");
            }
            Console.WriteLine("---");
            double rad = ReadDub("Enter the radius of a circle...");
            Console.WriteLine($"The area of a circle w/ radius of {rad} is {AreaOfCircle(rad)}.");
            Console.WriteLine("---");
            Console.WriteLine("The value of k in the thought exercise = 16");
        }

        static int ReadInt(string prompt) 
        {
            Console.WriteLine(prompt);
            string newVal = Console.ReadLine();
            try
            { 
                return int.Parse(newVal ?? "0");
            }
            catch 
            {
                return 0;   // I realize we're not trapping errors yet, so we'll simply return a zero if the user enters something other than an integer.
            }
        }

        static double ReadDub(string prompt)
        {
            Console.WriteLine(prompt);
            string newVal = Console.ReadLine();
            try
            {
                return double.Parse(newVal ?? "0.0");
            }
            catch
            {
                return 0.0;   // I realize we're not trapping errors yet, so we'll simply return a zero if the user enters something other than an integer.
            }
        }

        static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

    }
}
