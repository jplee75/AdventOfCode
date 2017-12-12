using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            //DotOne();
            DotTwo();
        }

        static void DotOne()
        {
            var puzzleInput = File.ReadAllLines("~/../../../Input").ToList<String>()[0].Split('\t').ToList().Select(int.Parse).ToList();
            int bankSize = puzzleInput.Count();
            List<String> previousConfigs = new List<String>();
            previousConfigs.Add(string.Join(",", puzzleInput.Select(x => x.ToString()).ToArray()));

            while (previousConfigs.Distinct().Count() == previousConfigs.Count())
            {
                int maxBankIndex = puzzleInput.FindIndex(x => x == puzzleInput.Max());
                int redistribute = puzzleInput[maxBankIndex];
                puzzleInput[maxBankIndex] = 0;
                for(int i = maxBankIndex+1;redistribute > 0; i++ )
                {
                    puzzleInput[i % bankSize] += 1;
                    redistribute -= 1;
                }
                previousConfigs.Add(string.Join(",", puzzleInput.Select(x => x.ToString()).ToArray()));
            }

            Console.WriteLine(previousConfigs.Count()-1);
            Console.ReadKey();
        }

        static void DotTwo()
        {
            var puzzleInput = File.ReadAllLines("~/../../../Input").ToList<String>()[0].Split('\t').ToList().Select(int.Parse).ToList();
            int bankSize = puzzleInput.Count();
            List<String> previousConfigs = new List<String>();
            previousConfigs.Add(string.Join(",", puzzleInput.Select(x => x.ToString()).ToArray()));

            while (previousConfigs.Distinct().Count() == previousConfigs.Count())
            {
                int maxBankIndex = puzzleInput.FindIndex(x => x == puzzleInput.Max());
                int redistribute = puzzleInput[maxBankIndex];
                puzzleInput[maxBankIndex] = 0;
                for (int i = maxBankIndex + 1; redistribute > 0; i++)
                {
                    puzzleInput[i % bankSize] += 1;
                    redistribute -= 1;
                }
                previousConfigs.Add(string.Join(",", puzzleInput.Select(x => x.ToString()).ToArray()));
            }

            int firstTime = previousConfigs.IndexOf(previousConfigs[previousConfigs.Count() - 1]);

            Console.WriteLine(previousConfigs.Count()-1 - firstTime);
            Console.ReadKey();
        }
    }
}
