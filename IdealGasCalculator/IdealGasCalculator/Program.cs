/* Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 * Program: Ideal Gas Calculator
 * Date: 5/30/2026*/
namespace IdealGasCalculator
{
    class IdealGasCalculator
    {
        static void WriteHeader()
        {
            // header creation and format
            Console.WriteLine("Programmer: Tucker Anastasio\nProgram: Ideal Gas Calculator\n" +
                "Objective: Find pressure using the ideal gas equation.\n");
        }
        static void GetMoleWeights(string filePath, out string[] gasNames, out double[] moleWeights, out int count)
        {
            // load csv data into arrays
            // using lists to not force an array size
            List<string> names = new List<string>();
            List<double> moles = new List<double>();

            // open and read the file <filepath>
            using (StreamReader reader = new StreamReader(filePath))
            {
                // skip first line of data (column names)
                reader.ReadLine();

                string line;
                count = 0;

                // read line by line until the end of data
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    // add values pairs into lists
                    names.Add(parts[0]);
                    moles.Add(double.Parse(parts[1]));

                    // track number of entries in data
                    count++;
                }
            }

            // list to arrays for out
            gasNames = names.ToArray();
            moleWeights = moles.ToArray();
        }

        private static void DisplayGasNames(string[] gasNames, int countGases)
        {
            // sets number of entries per row
            for (int i = 0; i < countGases; i += 3)
            {
                // adds entries to rows
                for (int j = i; j < i + 3 && j < countGases; j++)
                {
                    Console.Write($"{gasNames[j],-20}");
                }

                // moves to next row
                Console.WriteLine();
            }
        }
        private static double GetMoleWeightFromName(string gasName, string[] gasNames, double[] moleWeights, int countGases)
        {
            // search through Gas names array to find match to user input
            for (int i = 0; i < countGases; i++)
            {
                // allows search to be in any case to match
                if (string.Equals(gasNames[i], gasName, StringComparison.OrdinalIgnoreCase))
                {
                    return moleWeights[i];
                }
            }
            // return if gas not found
            return -1;
        }

        private static void DisplayPressure(double pressure)
        {
            // display pressure results to the user
            double psi = PaToPsi(pressure);
            Console.WriteLine($"\nThe pressure in Pascals is {pressure} and the pressure in PSI is {psi}");
        }

        static double PaToPsi(double pascals)
        {
            // convert pascals to psi
            return pascals / 6894.757;
        }

        static void Main(string[] args)
        {
            WriteHeader();

            // variables for GetMoleWeights
            string filePath = "MolecularWeightsGasesAndVapors.csv";
            string[] gasNames;
            double[] moleWeights;
            int count;

            GetMoleWeights(filePath, out gasNames, out moleWeights, out count);

            DisplayGasNames(gasNames, count);

            /* test
            string userGas = "butane";
            double userMole =GetMoleWeightFromName(userGas, gasNames,moleWeights, count);
            // expected result 58.124
            Console.WriteLine($"\n{userMole}");*/

            // do another loop for user to retry with different inputs
            string doAnother;
            do
            {
                // catch exceptions thrown
                try
                {                
                    // prompt user to enter gas
                    Console.Write("\nEnter Gas name from list above: ");
                    string userGas = Console.ReadLine();

                    double userMole = GetMoleWeightFromName(userGas, gasNames, moleWeights, count);

                    // check to make sure gas is on list
                    if (userMole == -1)
                    {
                        Console.WriteLine("Error: Gas not found.");
                        continue;
                    }

                    // place user input into OBJ
                    IdealGas UserGas = new IdealGas();
                    UserGas.SetMoleWeight(userMole);

                    Console.Write("Enter Volume: ");
                    UserGas.SetVolume(double.Parse(Console.ReadLine()));

                    Console.Write("Enter Mass: ");
                    UserGas.SetMass(double.Parse(Console.ReadLine()));

                    Console.Write("Enter Temperature: ");
                    UserGas.SetTemp(double.Parse(Console.ReadLine()));

                    DisplayPressure(UserGas.GetPressure());

                }
                catch (FormatException exc)
                {
                    Console.WriteLine($"Error! Improper value entered: {exc.Message}");
                }
                catch (OverflowException exc)
                {
                    Console.WriteLine($"Error! Value entered too high or low: {exc.Message}");
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"Error!: {exc.Message}");
                }
                finally
                {
                    // ensure program can keep executing
                    Console.Write("\nDo another (Y/N)? ");
                    doAnother = Console.ReadLine();
                }

            } while (doAnother.ToUpper() == "Y");

            Console.WriteLine("\nThanks for using my program.");
        }
    }
}