using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
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
            List<Int32> puzzleInput = File.ReadAllLines("~/../../../Input").ToList().Select(int.Parse).ToList();
            int answerSteps = 0;
            Boolean inList = true;
            int currentPosition = 0;
            int move = 0;
            while (inList)
            {
                move = puzzleInput[currentPosition];
                puzzleInput[currentPosition] += 1;
                currentPosition += move;
                if (currentPosition > puzzleInput.Count - 1)
                {
                    inList = false;
                }
                answerSteps += 1;
            }

            Console.WriteLine(answerSteps);
            Console.ReadKey();
        }

        static void DotTwo()
        {
            List<Int32> puzzleInput = File.ReadAllLines("~/../../../Input").ToList().Select(int.Parse).ToList();
            int answerSteps = 0;
            Boolean inList = true;
            int currentPosition = 0;
            int move = 0;
            while (inList)
            {
                move = puzzleInput[currentPosition];
                if(move>=3)
                {
                    puzzleInput[currentPosition] -= 1;
                }
                else
                {
                    puzzleInput[currentPosition] += 1;
                }
                currentPosition += move;
                if (currentPosition > puzzleInput.Count - 1)
                {
                    inList = false;
                }
                answerSteps += 1;
            }

            Console.WriteLine(answerSteps);
            Console.ReadKey();
        }
    }
}
