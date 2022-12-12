using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication
{
    internal class KnapsackManager
    {
        int knapsackSize;
        int[] _weights;
        int[] _values;
        int[,] results;

        public KnapsackManager(int[] weightsArray, int[] amountsArray, int size)
        {
            _weights = weightsArray;
            _values = amountsArray;
            knapsackSize = size;
        }

        public int CreateSolution()
        {
            results = new int[_weights.Length + 1, knapsackSize + 1];

            for (int i = 0; i < _weights.Length; i++)   // item 1 to n
            {
                for (int j = 1; j <= knapsackSize; j++) //weight 1 to m
                {
                    if (_weights[i] > j)
                    {
                        //if item weight is grater than knapsack capacity
                        results[i + 1, j] = results[i, j];

                    }

                    else
                    {
                        if (results[i, j] > (_values[i] + results[i, j - _weights[i]]))
                        {
                            //if previously calculated value only is grater
                            results[i + 1, j] = results[i, j];
                        }
                        else
                        {
                            //if including current item gives more value
                            results[i + 1, j] = _values[i] + results[i, j - _weights[i]];

                        }
                    }
                }
            }
            return results[_weights.Length, knapsackSize]; // index (n, m) will be max value
        }
    }
}
