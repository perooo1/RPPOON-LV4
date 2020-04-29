using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1_i_2
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;

        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }

        private double[][] ConvertData(Dataset dataset)
        {
            int rowCout = dataset.GetData().Count;
            int columnCount;
            double[][] datasetArray = new double[rowCout][];

            for(int i =0;i< rowCout; i++)
            {
                columnCount = (dataset.GetData()[i]).Count;
                datasetArray[i] = new double[columnCount];
                for(int j = 0; j < columnCount; j++)
                {
                    datasetArray[i][j] = (dataset.GetData())[i][j];
                }
            }

            return datasetArray;
            
        }

        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }

        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }

    }
}
