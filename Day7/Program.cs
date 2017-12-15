using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Program
    {
        static List<Node> bigOlTree = GetMeTheTree();
        static void Main(string[] args)
        {
            //DotOne();
            DotTwo();
        }

        static void DotTwo()
        {
            //Walk The Tree and check weights - start at the bottom
            string bottomNode = DotOne();
            Node bottom = bigOlTree.First(x => x.Name == bottomNode);
            WalkTheTree(bottom, 0);

            for(int i = bigOlTree.Max(x => x.Depth)-1; i > 0; i--)
            {
                var checkBalance = bigOlTree.Where(b => b.Depth == i).ToList();
                foreach(Node balance in checkBalance)
                {
                    if(balance.WeightOfAllDescendants > 0 )
                    {
                        var blah = balance.ChildrenNodes.GroupBy(g => g.Weight + g.WeightOfAllDescendants).Select(group => new { key= group.Key, gCount = group.Count() });
                        if(blah.Count() > 1)
                        {
                            var badTotalWeight = blah.Where(z => z.gCount == 1).Select(y=>(y.key)).First();
                            var goodTotalWeight = blah.Where(z => z.gCount != 1).Select(y => (y.key)).First();
                            var badNode = balance.ChildrenNodes.FirstOrDefault(x=>x.Weight+x.WeightOfAllDescendants == badTotalWeight);
                            int answer = badNode.Weight + (goodTotalWeight-badTotalWeight);
                            Console.WriteLine(answer);
                            Console.ReadKey();
                            return;
                        }
                    }
                }
            }
        }

        static void WalkTheTree(Node currentNode, int depth)
        {
            var childNodes = bigOlTree.Where(x => currentNode.ChildrenNodeNames.Contains(x.Name)).ToList();
            currentNode.ChildrenNodes = childNodes;
            foreach(Node newCurrentNode in childNodes)
            {
                newCurrentNode.ParentNodeName = currentNode.Name;
                WalkTheTree(newCurrentNode,depth+1);
            }
            currentNode.WeightOfAllDescendants = childNodes.Sum(x => x.WeightOfAllDescendants + x.Weight);
            currentNode.Depth = depth;
        }

        static String DotOne()
        {
            List<Node> bigOlTree = GetMeTheTree();

            //Populate parents
            foreach(Node node in bigOlTree)
            {
                foreach(String child in node.ChildrenNodeNames)
                {
                    if(bigOlTree.Exists(x=>x.Name == child)) {
                        bigOlTree.First(x => x.Name == child).ParentNodeName = node.Name;
                    }
                    
                }
            }

            string answer = bigOlTree.FirstOrDefault(x => x.ParentNodeName == null).Name;

            return answer;
            //Console.WriteLine(answer);
            //Console.ReadKey();
        }

        static List<Node>GetMeTheTree()
        {
            var puzzleInput = File.ReadAllLines("~/../../../Input").ToList<String>();
            List<Node> bigOlTree = new List<Node>();

            foreach (string line in puzzleInput)
            {
                string name = line.Substring(0, line.IndexOf('(')).Trim();
                int weight = int.Parse(line.Substring(line.IndexOf('(') + 1, line.IndexOf(')') - (line.IndexOf('(') + 1)));
                List<String> children = new List<string>();
                if (line.IndexOf('>') != -1)
                {
                    children = line.Substring(line.IndexOf('>') + 1, line.Length - (line.IndexOf('>') + 1)).Split(',').Select(s => s.Trim()).ToList();
                }

                bigOlTree.Add(new Node() { Name = name, Weight = weight, ChildrenNodeNames = children });
            }

            return bigOlTree;
        }
    }


    class Node
    {
        public string Name { get; set; }
        public string ParentNodeName { get; set; }
        public int Weight { get; set; }
        public int Depth { get; set; }
        public List<String> ChildrenNodeNames { get; set; }
        public List<Node> ChildrenNodes { get; set; }
        public int WeightOfAllDescendants { get; set; }
    }
}
