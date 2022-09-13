using System;
using System.Collections.Generic;
using System.Text;

namespace GraphReport
{
    public class DisplayGraph : IGraph
    {
        public void ShowGraph(string jSonData)
        {
            Console.WriteLine(jSonData);
        }
    }
}
