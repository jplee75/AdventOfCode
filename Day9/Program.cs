using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            DotOne();
        }
        static void DotOne()
        {
            var puzzleInput = GetInput();

            int answer = 0;
            int groupDepth = 0;
            Char currentChar = '\0';
            bool isInputGarbage = false;
            int garbageCount= 0;

            for (int i = 0;i<puzzleInput.Count();i++)
            {
                currentChar = puzzleInput[i];
                if (currentChar.Equals('!'))
                {
                    //! ignore next input and jump ahead
                    i += 1;
                    continue;
                }
                if (!isInputGarbage)
                {
                    //we aren't inside garbage so we can go ddeper
                    if (currentChar == '{')
                    {
                        groupDepth += 1;
                    }
                    //this means we ended a group - score and then decrement I think
                    if (currentChar == '}')
                    {
                        answer += groupDepth;
                        if (groupDepth > 0)
                        {
                            groupDepth -= 1;
                        }

                    }
                    if (currentChar == '<')
                    {
                        isInputGarbage = true;
                    }
                }
                else
                {
                    
                    if(currentChar=='>')
                    {
                        isInputGarbage = false;
                    }
                    else
                    {
                        garbageCount += 1;
                    }
                }

            }

            answer = garbageCount;
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        static List<Char> GetInput()
        {
            return File.ReadAllLines("~/../../../Input")[0].ToList<Char>();
        }
    }
}
