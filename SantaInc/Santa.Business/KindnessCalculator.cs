using System.Collections.Generic;
using System.Linq;

namespace Santa.Business
{
    public class KindnessCalculator
    {
        public static int Calculate(IEnumerable<Deed> deeds,int year)
        {
            return deeds.Sum(d => d.GetKindnessFactor());
        }
    }
}