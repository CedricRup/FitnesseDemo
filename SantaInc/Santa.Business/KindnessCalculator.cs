using System.Collections.Generic;
using System.Linq;

namespace Santa.Business
{
    public class KindnessCalculator
    {
        public static int Calculate(IEnumerable<Deed> deeds)
        {
            return deeds.Sum(d => d.GetKindnessFactor());
        }
    }
}