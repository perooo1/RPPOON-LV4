using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1_i_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset();
            dataset.LoadDataFromCSV("C:/Users/korisnik/source/repos/RPPOON LV4/CSVFile.txt");

            Analyzer3rdParty analyzer3rd = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer3rd);

            double[] averagePerRow = adapter.CalculateAveragePerRow(dataset);
            double[] averagePerColumn = adapter.CalculateAveragePerColumn(dataset);

            Console.WriteLine("Row average: ");
            PrintAverage(averagePerRow);
            Console.WriteLine("Column average:");
            PrintAverage(averagePerColumn);

        }

        public static void PrintAverage(double[] average)
        {
            for(int i = 0; i < average.Length; i++)
            {
                Console.WriteLine((average[i]).ToString() +"\t" );
            }
        }

    }
}
