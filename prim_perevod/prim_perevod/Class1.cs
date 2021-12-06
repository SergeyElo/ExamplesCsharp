using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim_perevod
{
    class Class1
    {
        private Dictionary<int, string> nums = new Dictionary<int, string>
            {
                {10, "A"}, {11, "B"}, {12, "C"},
                {13, "D"}, {14, "E"}, {15, "F"}
            };
        public Class1()
        {   
            for (int i = 0; i < 10; i++)
                nums.Add(i, i.ToString());
        }
        public string DecInNum(int num, int osn)
        {             
            string s = "";
            while (num !=0)
            {
                s = nums[num % osn] + s;
                num /= osn;
            }
            return s;
        }
    }
}
