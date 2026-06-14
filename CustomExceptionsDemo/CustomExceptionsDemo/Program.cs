namespace CustomExceptionsDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            string doAnother;
            do
            {
                try
                {
                    Console.Write("Please enter a social security number: ");
                    string userInput = Console.ReadLine();
                    SocialSecurityNumber ssn = new SocialSecurityNumber();
                    ssn.SSN = userInput;

                }
                catch (Exception exc)
                {
                    Console.WriteLine($"Error! {exc.Message}\nException type: {exc.GetType()}");
                }
                finally
                {
                    Console.WriteLine("This section always executes!");
                }

                Console.Write("Do another (y/n): ");
                doAnother = Console.ReadLine();
            } while (doAnother.ToLower() == "y");
        }
    }
}