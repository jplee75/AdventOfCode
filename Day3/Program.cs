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
           // DotOne();
            DotTwo();
        }

        static void DotTwo()
        {
            List<Matrix> theGrid = new List<Matrix>();
            int puzzleInput = 289326;
            int valueToStore = 1;
            int currentX = 0;
            int currentY = 0;
            int loopCount = 0;

            int theAnswer = 0;
            bool answerFound = false;

            theGrid.Add(new Matrix { X = currentX, Y = currentY, StoredValue = valueToStore });

            while (!answerFound)
            {
                loopCount += 1;

                //step right
                for(int moveRight = 0; moveRight < loopCount; moveRight++)
                {
                    currentX += 1;
                    valueToStore = CalculateValue(currentX, currentY, theGrid);
                    if (valueToStore > puzzleInput)
                    {
                        theAnswer = valueToStore;
                        answerFound = true;
                        break;
                    }
                    theGrid.Add(new Matrix { X = currentX, Y = currentY, StoredValue = valueToStore });
                }
                if (answerFound) break;

                //step up
                for(int moveUp = 0; moveUp < loopCount; moveUp++)
                {
                    currentY += 1;
                    valueToStore = CalculateValue(currentX, currentY, theGrid);
                    if (valueToStore > puzzleInput)
                    {
                        theAnswer = valueToStore;
                        answerFound = true;
                        break;
                    }
                    theGrid.Add(new Matrix { X = currentX, Y = currentY, StoredValue = valueToStore });
                }
                if (answerFound) break;

                loopCount += 1;

                //step left
                for (int moveLeft = 0; moveLeft < loopCount; moveLeft++)
                {
                    currentX -= 1;
                    valueToStore = CalculateValue(currentX, currentY, theGrid);
                    if (valueToStore > puzzleInput)
                    {
                        theAnswer = valueToStore;
                        answerFound = true;
                        break;
                    }
                    theGrid.Add(new Matrix { X = currentX, Y = currentY, StoredValue = valueToStore });
                }
                if (answerFound) break;

                //step down
                for (int moveDown = 0; moveDown < loopCount; moveDown++)
                {
                    currentY -= 1;
                    valueToStore = CalculateValue(currentX, currentY, theGrid);
                    if (valueToStore > puzzleInput)
                    {
                        theAnswer = valueToStore;
                        answerFound = true;
                        break;
                    }
                    theGrid.Add(new Matrix { X = currentX, Y = currentY, StoredValue = valueToStore });
                }

            }
            Console.Write(theAnswer);
            Console.ReadKey();
        }

        static int CalculateValue(int currentX, int currentY, List<Matrix> theGrid)
        {
            int? leftValue = 0;
            int? leftUpValue = 0;
            int? leftDownValue = 0;
            int? rightValue = 0;
            int? rightUpValue = 0;
            int? rightDownValue = 0;
            int? upValue = 0;
            int? downValue = 0;
            int valueToReturn = 0;

            leftValue = theGrid.FirstOrDefault(m => m.X == currentX - 1 && m.Y == currentY)?.StoredValue;
            leftUpValue = theGrid.FirstOrDefault(m => m.X == currentX - 1 && m.Y == currentY+1)?.StoredValue;
            leftDownValue = theGrid.FirstOrDefault(m => m.X == currentX - 1 && m.Y == currentY-1)?.StoredValue;
            rightValue = theGrid.FirstOrDefault(m => m.X == currentX + 1 && m.Y == currentY)?.StoredValue;
            rightUpValue = theGrid.FirstOrDefault(m => m.X == currentX + 1 && m.Y == currentY+1)?.StoredValue;
            rightDownValue = theGrid.FirstOrDefault(m => m.X == currentX + 1 && m.Y == currentY-1)?.StoredValue;
            upValue = theGrid.FirstOrDefault(m => m.X == currentX && m.Y == currentY + 1)?.StoredValue;
            downValue = theGrid.FirstOrDefault(m => m.X == currentX && m.Y == currentY - 1)?.StoredValue;
            valueToReturn = leftValue.GetValueOrDefault() + rightValue.GetValueOrDefault() + upValue.GetValueOrDefault() + downValue.GetValueOrDefault() 
                + rightUpValue.GetValueOrDefault() + rightDownValue.GetValueOrDefault() + leftDownValue.GetValueOrDefault() + leftUpValue.GetValueOrDefault();

            return valueToReturn;
        }

        public class Matrix
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int StoredValue { get; set; }
        }
        static void DotOne()
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
            while (walkTheLine < puzzleInput)
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

            if (puzzleInput <= currentPosition["East"])
            {
                Int64 closestSouth = numbersSouth[numbersSouth.Count - 1];
                Int64 distanceToSouth = Math.Abs(puzzleInput - closestSouth);
                Int64 distanceToEast = Math.Abs(puzzleInput - currentPosition["East"]);
                if (distanceToEast < distanceToSouth)
                {
                    answer = distanceToEast + numbersEast.Count();
                }
                else
                {
                    answer = distanceToSouth + numbersSouth.Count();
                }

            }
            else if (puzzleInput <= currentPosition["North"])
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
            else if (puzzleInput <= currentPosition["West"])
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
            else if (puzzleInput <= currentPosition["South"])
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
