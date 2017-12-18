using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Day11
{
    class Program
    {
        static int xCoordinate = 0;
        static int yCoordinate = 0;
        static int zCoordinate = 0;
        static void Main(string[] args)
        {
            DotOne();
        }

        static void DotOne()
        {
            var puzzleInput = GetInput();
            int answer = 0;
            foreach (string step in puzzleInput)
            {
                switch (step)
                {
                    case "n":
                        yCoordinate += 1;
                        zCoordinate -= 1;
                        break;
                    case "ne":
                        xCoordinate += 1;
                        zCoordinate -= 1;
                        break;
                    case "nw":
                        yCoordinate += 1;
                        xCoordinate -= 1;
                        break;
                    case "s":
                        yCoordinate -= 1;
                        zCoordinate += 1;
                        break;
                    case "se":
                        yCoordinate -= 1;
                        xCoordinate += 1;
                        break;
                    case "sw":
                        xCoordinate -= 1;
                        zCoordinate += 1;
                        break;
                    default:
                        Console.WriteLine("You Messed Up");
                        break;
                }
                List<int> coordinates = new List<int> { Math.Abs(xCoordinate), Math.Abs(yCoordinate), Math.Abs(zCoordinate) };
                if(coordinates.Max()>answer)
                {
                    answer = coordinates.Max();
                }
            }

            Console.WriteLine(answer);
            Console.ReadKey();

        }

        static List<String> GetInput()
        {
            return File.ReadAllLines("~/../../../Input")[0].Split(',').ToList();
        }
    }

}
