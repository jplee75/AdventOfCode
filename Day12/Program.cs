using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Program
    {

        static List<int> visitedNode = new List<int>();
        static List<AoCProcess> cleanInput;
        static int groupCount = 0;
        static void Main(string[] args)
        {
            //DotOne();
            DotTwo();
        }

        static void DotOne()
        {
            var puzzleInput = GetInput();
            cleanInput = parseInput(puzzleInput);

            AoCProcess blah = cleanInput.First(x => x.Id == 0);
            Strut(blah);

            int answer = visitedNode.Count;
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        static void DotTwo()
        {
            var puzzleInput = GetInput();
            cleanInput = parseInput(puzzleInput);

            while(cleanInput.Count>0)
            {
                groupCount += 1;
                Strut(cleanInput[0]);
                foreach(int removeNode in visitedNode)
                {
                    cleanInput.Remove(cleanInput.First(x=>x.Id == removeNode));
                }
                visitedNode.Clear();
            }

            int answer = groupCount;
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        static void Strut(AoCProcess blah)
        {
            visitedNode.Add(blah.Id);
            foreach (int visitMe in blah.connected)
            {
                if(!visitedNode.Contains(visitMe))
                {
                    Strut(cleanInput.First(x => x.Id == visitMe));
                }
                
            }
        }
        static List<AoCProcess> parseInput(List<String> rawInput)
        {
            List<AoCProcess> processList = new List<AoCProcess>();
            foreach(string inputLine in rawInput)
            {
                int id = int.Parse(inputLine.Substring(0,inputLine.IndexOf("<->")));
                List<int> connected = inputLine.Substring(inputLine.IndexOf("<->") + 3, inputLine.Length - (inputLine.IndexOf("<->") + 3)).Split(',').ToList().Select(x => int.Parse(x)).ToList();
                processList.Add(new AoCProcess { Id=id, connected= connected });
            }
            //foreach(AoCProcess updateMe in processList)
            //{
            //    var blah = processList.Where(x => updateMe.connected.Contains(x.Id)).ToList();
            //    updateMe.ConnectedProcess = blah;
            //}
            return processList;
        }
        static List<String> GetInput()
        {
            return File.ReadAllLines("~/../../../Input").ToList();
        }
    }

    class AoCProcess
    {
        public int Id { get; set; }
        public List<int> connected { get; set; }
        //public List<AoCProcess> ConnectedProcess { get; set; }
    }

}
