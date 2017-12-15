using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Expressive;

namespace Day8
{
    class Program
    {
        static List<string> puzzleInput;
        static int ultimateMax = 0;
        static void Main(string[] args)
        {
            puzzleInput = GetInput();
            DotOne();

        }
        static void DotOne()
        {
            Dictionary<string, int> registers = new Dictionary<string, int>();
            List<String> boolOperators = new List<string>() { ">", "<", ">=", "<=", "==", "!=" };

            foreach(string command in puzzleInput)
            {
                string registerKey = command.Substring(0, command.IndexOf(" ")).Trim();
                string registerAction = command.Split(' ').FirstOrDefault(x => x.Equals("dec") || x.Equals("inc")).Trim();
                string registerJumpAmount = command.Substring(command.IndexOf(registerAction) + 4, command.IndexOf("if")- (command.IndexOf(registerAction)+4)).Trim();
                string registerJumpCondition = command.Substring(command.IndexOf("if"), command.Length - command.IndexOf("if")).Trim();
                int registerValue = 0;
                int registerJumpKeyValue = 0;
                if (registers.ContainsKey(registerKey))
                {
                    registerValue = registers[registerKey];
                }
                else
                {
                    registers.Add(registerKey, registerValue);
                }

                string registerJumpKey = registerJumpCondition.Substring(3, registerJumpCondition.IndexOf(' ', 3)-3).Trim();
                string registerJumpBool = registerJumpCondition.Substring(3, registerJumpCondition.Length - 3);
                if(registers.ContainsKey(registerJumpKey))
                {
                    registerJumpKeyValue = registers[registerJumpKey];
                }
                else
                {
                    registers.Add(registerJumpKey, registerJumpKeyValue);
                }
                registerJumpBool = registerJumpBool.Replace (registerJumpKey, registerJumpKeyValue.ToString());

                var evaluatedBool = new Expression(registerJumpBool).Evaluate();

                if (Boolean.Parse(evaluatedBool.ToString()))
                {

                    if(registerAction.Equals("dec"))
                    {
                        registerValue -= int.Parse(registerJumpAmount);
                    }
                    else
                    {
                        registerValue += int.Parse(registerJumpAmount);
                    }
                    if(registerValue>ultimateMax)
                    {
                        ultimateMax = registerValue;
                    }
                    registers[registerKey] = registerValue;
                }
            }

            var answer = registers.Max(x=>x.Value);
            Console.WriteLine(ultimateMax);
            Console.ReadKey();
        }
        static List<String> GetInput()
        {
            return  File.ReadAllLines("~/../../../Input").ToList<String>();
        }
    }
}
