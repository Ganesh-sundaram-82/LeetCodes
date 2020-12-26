using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges.Easy
{

    public class GraphProblem
    {
        public GraphProblem()
        {

        }



        /// <summary>
        /// find the distance between two given endpoints - using graph method
        /// create a two dimentional array 
        /// create a graph(e, v) with distance and it is a unidirectional. Based on the input parameter return the value
        /// </summary>
        /// <param name="datas">input parameter</param>
        /// <param name="startpoint">Starting data-point</param>
        /// <param name="endpoint">Ending data-point</param>
        /// <returns>distance between two data-points</returns>
        public int Process(string[] datas, string startpoint, string endpoint)
        {
            int[,] graphData = new int[datas.Length, datas.Length];
            var dicData = new Dictionary<KeyValuePair<string, string>, int>();

            for(int i =0;i<datas.Length; i++)
            {
                for(int j=i; j< datas.Length; j++)
                {
                    if (i == j)
                        dicData.Add(new KeyValuePair<string, string>(datas[i], datas[j]), 0);
                    else
                    {
                        dicData.Add(new KeyValuePair<string, string>(datas[i], datas[j]), j);
                        dicData.Add(new KeyValuePair<string, string>(datas[j], datas[i]), j);
                    }
                }
            }

            if(dicData.Keys.Contains<KeyValuePair<string, string>>(new KeyValuePair<string, string>(startpoint, endpoint)))
            {
                
            }

            return int.MaxValue;
        }
    }
}
