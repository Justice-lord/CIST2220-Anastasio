namespace CollectionsDemo
{
    class Program
    {
        private static void DisplayNames(List<string> Names)
        {
            for (int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine(i + 1 + "; " + Names[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();
            Names.Add("Linus Torvalds");
            Names.Add("Donald Knuth");
            Names.Add("Grace Hopper");

            string doAnother;
            do
            {
                DisplayNames(Names);
                Console.Write("(A)dd, (R)emove, (S)earch: ");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "A":
                        Console.Write("Name: ");
                        Names.Add(Console.ReadLine());
                        break;

                    case "R":
                        Console.Write("Index or Name: ");
                        string nameOrIndex = Console.ReadLine();
                        int index;
                        if (int.TryParse(nameOrIndex, out index))
                        {
                            Names.RemoveAt(index);
                        }
                        else
                        {
                            Names.Remove(nameOrIndex);
                        }
                        break;

                    case "S":
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Index is " + (Names.IndexOf(name) + 1));
                        break;
                }

                Console.Write("Do another (y/n)? ");
                doAnother = Console.ReadLine();

            } while (doAnother == "y");
        }
    }
}
