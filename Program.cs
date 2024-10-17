namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value:" );
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number <= 1)
            {
                Console.WriteLine("This number is neither composite nor prime.");
                return;
            }

            for (int i = 2; i < number; i++) { 
            
            if (number%i==0) {

                    Console.WriteLine("It is a composite number.");
                    isPrime = false;
                    break;
                }    

            }


            if (isPrime) {
                Console.WriteLine("It is a prime number."); 
            }




        }
    }
}