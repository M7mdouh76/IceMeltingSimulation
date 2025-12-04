using System;
using System.Collections.Generic;

namespace IceMeltingSimulation
{
    class Program
    {
        static int MeltIce(string input)
        {
            char[] s = input.ToCharArray();
            int meltedTotal = 0;

            while (true)
            {
                List<int> meltIndices = new List<int>();

                for (int i = 0; i < s.Length - 3; i++)
                {
                    if (s[i] == '_' && s[i + 1] == '_' && s[i + 2] == '_' && s[i + 3] == 'I')
                    {
                        meltIndices.Add(i + 3);
                        i += 2;
                    }
                }

                if (meltIndices.Count == 0)
                    break;

                foreach (int idx in meltIndices)
                {
                    s[idx] = '_';
                    meltedTotal++;
                }
            }

            return meltedTotal;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Example 1:");
            Console.WriteLine(MeltIce("I___I_I"));  // Output: 2

            Console.WriteLine("Example 2:");
            Console.WriteLine(MeltIce("III"));  // Output: 0
        }
    }
}