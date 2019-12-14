using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoadeleD2
{
    class Between
    {
        public String BetweenStrings(String text, String start, String end)
        {
            if (!text.Contains(start))
                return "";
            var matn = text.Split(new[] { start }, StringSplitOptions.None)[1];
            if (!matn.Contains(end))
                return "";
            var result = matn.Split(new[] { end }, StringSplitOptions.None)[0];
            return result;

        }
    }
}
