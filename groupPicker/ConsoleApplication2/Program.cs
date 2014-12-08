using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {groupPicker4000(4,22);}

        static void groupPicker4000 (int group, int classSize)
        {
            int aStudent = 0, groupNum = 1;
            Random rng = new Random();
            List<int> classList = new List<int>();
            List<int> groupList = new List<int>();
            for (int i = 0; i < classSize; i++)
			{classList.Add(i + 1);};
            while (classList.Count() > 0)
            {
                aStudent = classList[rng.Next(0,classList.Count())];
                groupList.Add(aStudent);
                classList.Remove(aStudent);
                if (groupList.Count() == group)
                {
                    Console.WriteLine("\r\nGroup Number {0}\r\n", groupNum);
                    for (int i = 0; i < groupList.Count; i++)
                    {Console.Write(groupList[i] + " ");}
                    Console.WriteLine("\r\n");
                    groupList.Clear();
                    groupNum++;
                }
            }
            if (classList.Count == 0 && groupList.Count != 0 && groupList.Count <= group/2)
            {
                Console.WriteLine("\r\nJoin Group {0}", (groupNum - 1));
                for (int i = 0; i < groupList.Count; i++)
                {Console.Write(groupList[i] + " ");}
            }
            else
            {
                Console.WriteLine("\r\nGroup Number {0}\r\n", groupNum);
                for (int i = 0; i < groupList.Count; i++)
                {Console.Write(groupList[i] + " ");}
            }
            Console.ReadLine();
        }
    }
}
