/* Programmer: Tucker Anastasio (tanastasio@student.cnm.edu)
 * Program: Ideal Gas Calculator
 * Date: 5/30/2026*/

class IdealGasCalculator
{
    // header creation and format
    static void WriteHeader()
    {
        Console.WriteLine("Programmer: Tucker Anastasio\nProgram: Ideal Gas Calculator\n" +
            "Objective: Find pressure using the ideal gas equation.\n");
    }

    // load csv data into arrays
    static void GetMoleWeights(string filePath, out string[] gasNames, out double[] moleWeights, out int count)
    {
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
        for (int i = 0; i < countGases; i +=3)
        {
            // adds entries to rows
            for (int j = i; j < i +3 && j < countGases; j++)
            {
                Console.Write($"{gasNames[j],-20}");
            }

            // moves to next row
            Console.WriteLine();
        }
    }
    private static double GetMoleWeightFromName(string gasName, string[] gasNames, double[] moleWeights, int countGases)
    {
        for (int i =0; i < countGases; i++)
        {
            if (string.Equals(gasNames[i], gasName, StringComparison.OrdinalIgnoreCase))
            {
                return moleWeights[i];
            }
        }

        return -1;
    }

    private static double GetPressure(double mass)
    {

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
    }
}