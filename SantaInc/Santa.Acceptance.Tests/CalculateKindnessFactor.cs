using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Santa.Business;

namespace Santa.Acceptance.Tests
{
    public class CalculateKindnessFactor
    {
        public List<Deed> deeds = new List<Deed>(); 

        public bool KidDidWhichIsByAFactorOfOnDate(string title, Kind kind, int factor, DateTime date)
        {
            deeds.Add(new Deed { Title = title, Kind = kind, Force = factor, Date = date });
            return true;
        }

        public int kindnessfactorfor(int year)
        {
            int result = KindnessCalculator.Calculate(deeds, year);
            return result;
        }
    }
}

