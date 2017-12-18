using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Day10
{
    class Program
    {
        static int currentIndex = 0;
        static int skipSize = 0;
        static List<int> circularList = Enumerable.Range(0, 256).ToList();
        static int listSize = circularList.Count();

        static void Main(string[] args)
        {
            //DotOne();
            DotTwo();
        }

        static void DotTwo()
        {
            var puzzleInput = GetInput2();

            //lets hash for 64 rounds
            for (int z = 0; z < 64; z++)
            {
                KnotHashPrimitive(puzzleInput);
            }

            List<int> myDenseHash = new List<int>();
            for(int xyz = 0; xyz< circularList.Count; xyz+=16)
            {
                myDenseHash.Add( ExclusiveOrSixteen(circularList.GetRange(xyz, 16)));
            }

            StringBuilder buildHexDash = new StringBuilder();
            foreach(int hexMe in myDenseHash)
            {
                buildHexDash.Append(hexMe.ToString("x2"));
            }

            Console.WriteLine(buildHexDash.ToString());
            Console.ReadKey();

        }
        static void DotOne()
        {
            var puzzleInput = GetInput();


            KnotHashPrimitive(puzzleInput);

            int answer = circularList[0] * circularList[1];
            Console.WriteLine(answer);
            Console.ReadKey();
        }
        
        static int ExclusiveOrSixteen(List<int> sixteenNumbers)
        {
            int returnMe = sixteenNumbers[0];

            for(int x = 1;x<sixteenNumbers.Count;x++)
            {
                returnMe ^= sixteenNumbers[x];
            }

            return returnMe;

        }
        static void KnotHashPrimitive(List<int> lengthSequence)
        {
            foreach (int length in lengthSequence)
            {
                List<int> subList = new List<int>();

                for (int i = currentIndex; i < currentIndex + length; i++)
                {
                    subList.Add(circularList[i % listSize]);
                }
                subList.Reverse();
                int x = 0;
                //replace old with new
                for (int i = currentIndex; i < currentIndex + length; i++)
                {
                    circularList[i % listSize] = subList[x];
                    x++;
                }
                currentIndex = (currentIndex + length + skipSize) % listSize;
                skipSize++;
            }
        }

        static List<int> GetInput()
        {
            return File.ReadAllLines("~/../../../Input")[0].Split(',').Select(x => int.Parse(x)).ToList();
        }

        static List<int> GetInput2()
        {
            var wutwut = File.ReadAllLines("~/../../../Input")[0].ToCharArray();
            List<int> indabutt = new List<int>();

            foreach(char currentChar in wutwut)
            {
                indabutt.Add((int)currentChar);
            }

            List<int> mergeMe = new List<int>() { 17, 31, 73, 47, 23 };
            indabutt.AddRange(mergeMe);

            return indabutt;
        }
    }
}
