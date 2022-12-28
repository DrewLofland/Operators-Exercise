namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            Console.WriteLine(sum);
            int diff = a - b;
            Console.WriteLine(diff);    
            int product = a * b;
            Console.WriteLine(product);


            int quotient = a / b;

            int remainder = a % b;
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");


            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine(AreaOfCircle(radius));


        }
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;    
        }
    }
}       




