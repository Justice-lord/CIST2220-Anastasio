namespace DelegatesDemo
{
    class Program
    {
        delegate void DispStrDelegate(string param);

        static void Capitalize(string text)
        {
            Console.WriteLine("Your input capitalized --> " + text.ToUpper());
        }

        static void LowerCased(string text)
        {
            Console.WriteLine("Your input lower cased --> " + text.ToLower());
        }

        static void RunMyDelegate(DispStrDelegate del, string textParam)
        {
            del(textParam);
        }

        public static void Main(string[] args)
        {
            Console.Write("Please enter some text: ");
            string text = Console.ReadLine();

            DispStrDelegate saying1 = new DispStrDelegate(Capitalize);
            DispStrDelegate saying2 = new DispStrDelegate(LowerCased);
            DispStrDelegate saying3 = new DispStrDelegate(Console.WriteLine);

            saying1 (text);
            saying2 (text);
            saying3 (text);

            Console.Write("Please enter some text: ");
            string newText = Console.ReadLine();

            DispStrDelegate sayings = new DispStrDelegate(Capitalize);
            sayings += new DispStrDelegate(LowerCased);
            sayings += new DispStrDelegate(Console.WriteLine);

            Console.WriteLine("Running multi cast directly: ");
            sayings (newText);

            Console.WriteLine("Running by passing delegate to another method: ");
            RunMyDelegate(sayings, text);

            Console.WriteLine("Running by passing in a lambda expression: ");
            RunMyDelegate((string t) => { Console.WriteLine("Lamba: " + t); }, newText);

            Console.WriteLine("Lambda without type: ");
            RunMyDelegate((t) => { Console.WriteLine("Lambda2: " + t); }, newText);

            Console.WriteLine("Lambda without parenthesis: ");
            RunMyDelegate(t => { Console.WriteLine("Lambda3: " + t); }, newText);

            sayings += t => { Console.WriteLine("Lambda4: " + t); };
            Console.WriteLine("Three Delegates and a lambda: ");
            RunMyDelegate(sayings, text);
        }
    }
}
