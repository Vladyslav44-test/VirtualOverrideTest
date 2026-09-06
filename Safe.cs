using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideTest
{
    internal class Safe
    {
        private string contents = "precious jewels";
        private string safeCombination = "12345";

        public string Open(string combinatiopn)
        {
            if (combinatiopn == safeCombination) return contents;
            return "";
        }
        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.Combination = safeCombination;
        }
    }
}
