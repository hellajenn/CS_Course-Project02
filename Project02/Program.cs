namespace Project02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Your friend from Newfoundland will be going on a trip soon. 
             * They only know how to dress for the weather in Celsius. Help
             * them pack for their trip by writing an application that converts
             * C to/from F.
             */

            Console.WriteLine("Welcome to the temp converter!");
            Console.WriteLine("Enter 1 to convert from C to F.");
            Console.WriteLine("Enter 2 to convert from F to C.");
            Console.WriteLine("Enter 3 to quit.");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 3 ) {
                Console.WriteLine("Bye!");
                return;
            }

            Console.WriteLine("Enter temperature to convert");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                double newTemp = temp * (9.0 / 5) + 32;
                Console.WriteLine($"{temp} C is {newTemp} F");
            } else
            {
                double newTemp = (temp-32) * (5.0 / 9);
                Console.WriteLine($"{temp} F is {newTemp} C");
            }

        }
    }
}