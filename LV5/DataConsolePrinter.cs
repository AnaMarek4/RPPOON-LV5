using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class DataConsolePrinter
    {
        public void PrintDataConsole(IDataset data)
        {
            if(data.GetData() == null)
            {
                Console.WriteLine("Error 404");
                return;
            }

            foreach (List<string> dataConsole in data.GetData())
            {
                foreach(string dataConsolePrinter in dataConsole)
                {
                    Console.WriteLine(dataConsolePrinter + ", ");
                }
                Console.WriteLine();
            } 
        }
    }
}
