using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1_i_2
{
    class Dataset
    {
        private List<List<double>> data;

        public List<List<double>> Data { get => data; private set => data = value; }

        public Dataset()
        {
            this.Data = new List<List<double>>();
        }

        public void LoadDataFromCSV(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach(string line in lines)
            {
                List<double> row = new List<double>(Array.ConvertAll(line.Split(','), double.Parse));
                this.Data.Add(row);
            }
        }

        public IList<List<double>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<double>>(this.Data);
        }

    }
}
