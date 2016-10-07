using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _406_QueueReconstructionByHeight
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int[,] ReconstructQueue(int[,] people)
        {
            var newPeople = new int[people.GetLength(0)][];
            for (int i = 0; i < people.GetLength(0); i++)
            {
                newPeople[i] = new int[] { people[i, 0], people[i, 1] };
            }
            Array.Sort(newPeople, (a, b) => a[0] != b[0] ? b[0] - a[0] : a[1] - b[1]);
            var list = new List<int[]>(newPeople.Count());
            foreach (var item in newPeople)
            {
                list.Insert(item[1], item);
            }
            var array = list.ToArray();
            for (int i = 0; i < array.Count(); i++)
            {
                people[i, 0] = array[i][0];
                people[i, 1] = array[i][1];
            }
            return people;
        }

    }
}
