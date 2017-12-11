using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int64> numbersNorth = new List<Int64>();
            List<Int64> numbersEast = new List<Int64>();
            List<Int64> numbersSouth = new List<Int64>();
            List<Int64> numbersWest = new List<Int64>();
            Int64 puzzleInput = 289326;
            Int64 answer = 0;

            Dictionary<string, int> currentPosition = new Dictionary<string, int>
            {
                { "North", 1 },
                { "East", 1 },
                { "South", 1 },
                { "West", 1 }
            };
            int walkTheLine = currentPosition.Values.Max();
            int northWalk = 3;
            int eastWalk = 1;
            int southWalk = 7;
            int westWalk = 5;
            //Lets fill up those lists
            while (walkTheLine< puzzleInput)
            {
                int moveNorth = currentPosition["North"] + northWalk;
                numbersNorth.Add(moveNorth);
                currentPosition["North"] = moveNorth;
                northWalk += 8;

                int moveEast = currentPosition["East"] + eastWalk;
                numbersEast.Add(moveEast);
                currentPosition["East"] = moveEast;
                eastWalk += 8;

                int moveSouth = currentPosition["South"] + southWalk;
                numbersSouth.Add(moveSouth);
                currentPosition["South"] = moveSouth;
                southWalk += 8;

                int moveWest = currentPosition["West"] + westWalk;
                numbersWest.Add(moveWest);
                currentPosition["West"] = moveWest;
                westWalk += 8;

                walkTheLine = currentPosition.Values.Max();
            }

            if(puzzleInput <= currentPosition["East"])
            {
                Int64 closestSouth = numbersSouth[numbersSouth.Count - 1];
                Int64 distanceToSouth = Math.Abs(puzzleInput - closestSouth);
                Int64 distanceToEast = Math.Abs(puzzleInput - currentPosition["East"]);
                if (distanceToEast<distanceToSouth)
                {
                    answer = distanceToEast + numbersEast.Count();
                }
                else
                {
                    answer = distanceToSouth + numbersSouth.Count();
                }

            }
            else if(puzzleInput <= currentPosition["North"])
            {
                Int64 closestEast = currentPosition["East"];
                Int64 distanceToEast = Math.Abs(puzzleInput - closestEast);
                Int64 distanceToNorth = Math.Abs(puzzleInput - currentPosition["North"]);
                if (distanceToNorth < distanceToEast)
                {
                    answer = distanceToNorth + numbersNorth.Count();
                }
                else
                {
                    answer = distanceToEast + numbersEast.Count();
                }

            }
            else if(puzzleInput <= currentPosition["West"])
            {
                Int64 distanceWest = Math.Abs(puzzleInput - currentPosition["West"]);
                Int64 distanceToNorth = Math.Abs(puzzleInput - currentPosition["North"]);
                if (distanceWest < distanceToNorth)
                {
                    answer = distanceWest + numbersWest.Count();
                }
                else
                {
                    answer = distanceToNorth + numbersNorth.Count();
                }
            }
            else if(puzzleInput <= currentPosition["South"])
            {
                Int64 distanceWest = Math.Abs(puzzleInput - currentPosition["West"]);
                Int64 distanceSouth = Math.Abs(puzzleInput - currentPosition["South"]);
                if (distanceSouth < distanceWest)
                {
                    answer = distanceSouth + numbersSouth.Count();
                }
                else
                {
                    answer = distanceWest + numbersWest.Count();
                }
            }


            Console.Write(answer);
            Console.ReadKey();
        }
    }
}
