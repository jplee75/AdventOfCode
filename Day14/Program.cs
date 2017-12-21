using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day14
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
            string testInput = "flqrgnkx";
            string input = "xlqgujun";
            string puzzleInput = input;
            int answer = 0;
            for(int i = 0; i<128; i++)
            {
                string hashInput = puzzleInput + "-" + i.ToString();
                var blah = KnotHash(hashInput);
                string binarystring = String.Join(String.Empty, blah.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
                answer += binarystring.Count(x => x.Equals('1'));
            }

            Console.WriteLine(answer);
            Console.ReadKey();

        }
        static void DotTwo()
        {
            string puzzleInput = "xlqgujun";
            List<String> binaryGrid = new List<string>();
            Dictionary<int[,], int> gridLabels = new Dictionary<int[,], int>();
            Dictionary<int, List<int>> regionEquivs = new Dictionary<int, List<int>>();
            int regionLabel = 1;
            int answer = 0;

            for (int i = 0; i < 128; i++)
            {
                string hashInput = puzzleInput + "-" + i.ToString();
                var blah = KnotHash(hashInput);
                string binarystring = String.Join(String.Empty, blah.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
                binaryGrid.Add(binarystring);
            }

            for(int y = 127;y >=0;y--)
            {
                for (int x = 0; x <= 127; x++)
                {
                    //only if > 0
                    if (IsUsedBit(binaryGrid, x, y))
                    {
                        
                        if(IsWestSameValue(binaryGrid, x, y))
                        {
                            //Same Region Same Label as west
                            if(gridLabels.ContainsKey(new int[x - 1, y]))
                            {
                                gridLabels[new int[x, y]] = gridLabels[new int[x - 1, y]];
                            }
                            else
                            {
                                gridLabels[new int[x, y]] = regionLabel;
                            }
                        }
                        else if(IsNorthAndWestAndCurrentSameValueDifferentLabel(binaryGrid, x, y))
                        {

                        }
                        else if(false)
                        {

                        }
                        else
                        {
                            regionLabel += 1;
                            gridLabels[new int[x, y]] = regionLabel;
                        }

                    }

                }
            }

            for (int y = 127; y >= 0; y--)
            {
                for (int x = 0; x < 128; x++)
                {
                }
            }

            answer = gridLabels.Distinct().Count();
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        static bool IsUsedBit(List<String>binaryGrid,int xCoord,int yCoord)
        {
            var checkMe = binaryGrid[yCoord].Select(bs => bs).ToList()[xCoord];

            return !checkMe.Equals('0');
        }

        static bool IsWestSameValue(List<String> binaryGrid, int xCoord, int yCoord)
        {
            var currentBitVal = int.Parse(binaryGrid[yCoord].Select(bs => bs).ToList()[xCoord].ToString());
            var westBitVal = int.Parse(binaryGrid[yCoord].Select(bs => bs).ToList()[Math.Max(0, xCoord - 1)].ToString());

            return currentBitVal == westBitVal;
        }

        static bool IsNorthAndWestAndCurrentSameValueDifferentLabel(List<String> binaryGrid, int xCoord, int yCoord)
        {
            return true;
        }

        static bool IsWestDifferentNorthSame(List<String> binaryGrid, int xCoord, int yCoord)
        {
            return true;
        }


        static string KnotHash(string input)
        {
            List<int> circularList = Enumerable.Range(0, 256).ToList();
            int skipAmount = 0;
            int currentTakeIndex = 0;

            //turn input into list of instructions for knotting
            List<int> knotInstructions = input.ToCharArray().Select(x => (int)x).ToList();
            knotInstructions.AddRange(new List<int>(){17,31,73,47,23});
            for (int i = 0; i<64; i++)
            {
                //Twisting Logic
                foreach(int takeAmount in knotInstructions)
                {
                    var wutthis = circularList.CircleSkipTake(currentTakeIndex, takeAmount).Reverse().ToList();
                    circularList = circularList.CircleInsert(wutthis, currentTakeIndex).ToList();
                    currentTakeIndex = (currentTakeIndex + skipAmount + takeAmount) % circularList.Count();
                    skipAmount++;
                }
            }

            //Have sparse do XOR
            List<int> myDenseHash = new List<int>();
            for(int s = 0; s<16;s++)
            {
                 myDenseHash.Add(circularList.Skip(s * 16).Take(16).ToList().Aggregate((x,y)=>x^y));
            }
            
            //have dense turn in to Hex
            StringBuilder buildHexDash = new StringBuilder();
            foreach (int hexMe in myDenseHash)
            {
                buildHexDash.Append(hexMe.ToString("x2"));
            }
            
            return buildHexDash.ToString();
        }
    }

    public static class MyListExtension
    {
        public static IEnumerable<T> CircleSkipTake<T>(this IEnumerable<T> list, int startIndex,int takeAmount)
        {
            var localList = list.ToList();
            //Fuck there has to be a better way - Modulo Math?
            int firstTake = 0;
            if ((localList.Count()-startIndex)< takeAmount)
            {
                firstTake = (localList.Count() - startIndex);
            }
            else
            {
                firstTake = takeAmount;
            }
            var tempList = localList.GetRange(startIndex, firstTake);
            int moreToTake = takeAmount - firstTake;
            if (moreToTake>0)
            {
                tempList.InsertRange(firstTake,localList.GetRange(0, moreToTake));
            }
            return tempList;
        }

        public static IEnumerable<T> CircleInsert<T>(this IEnumerable<T> list, IEnumerable<T> insertList, int insertStart)
        {
            var localList = list.ToList();
            int firstRemove;
            if ((localList.Count()-insertStart)< insertList.Count())
            {
                firstRemove = (localList.Count() - insertStart);
            }
            else
            {
                firstRemove = insertList.Count();
            }
            localList.RemoveRange(insertStart, firstRemove);
            localList.InsertRange(insertStart, insertList.ToList().GetRange(0,firstRemove));
            int moreToRemove = insertList.Count() - firstRemove;
            if (moreToRemove>0)
            {
                localList.RemoveRange(0, moreToRemove);
                localList.InsertRange(0, insertList.ToList().GetRange(insertList.Count() - moreToRemove, moreToRemove));
            }

            return localList;
        }
    }
}
