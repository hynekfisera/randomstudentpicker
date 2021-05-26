using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPicker
{
    static class Extension
    {
        static Random rng = new Random();
        public static T Pick<T>(this List<T> item)
        {
            return item.Count > 0 ? item[rng.Next(0, item.Count)] : default;
        }
    }
}
