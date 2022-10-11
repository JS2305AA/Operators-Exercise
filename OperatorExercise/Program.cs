namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;

            int b = 4;

            int quotient = a / b;

            int remainder = a % b;

           
            

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            
            
          
            

        }

        public static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

    }
}