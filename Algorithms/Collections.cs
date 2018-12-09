using System;
using System.Collections.Generic;
using System.Linq;
namespace Algorithms
{
    public class Collections
    {
        public static T FindKthElement<T>(List<T> list, int k)
        {
            if (k < 1 || k > list.Count)
                throw new ArgumentOutOfRangeException("k", "Parameter k is out of range.");
            var sorted = list.OrderBy(el => el).ToList();
            return sorted[k - 1];
        }
    }
}
