//using System.Collections.Generic;
//using NUnit.Framework;
//using Santa.Business;
//using TechTalk.SpecFlow;
//using TechTalk.SpecFlow.Assist;

//namespace Santa.Acceptance.Tests
//{
//    [Binding]
//    public class KindnessFactorCalculationSteps
//    {
//        [Given(@"child with this record")]
//        public void GivenChildWithThisRecord(IEnumerable<Deed> deeds)
//        {
//            Deeds = deeds;
//        }

//        [When(@"I calculate his/her kindness factor for (.*)")]
//        public void WhenICalculateHisHerKindnessFactorFor(int year)
//        {
//            Result = KindnessCalculator.Calculate(Deeds);
//        }

//        protected int Result { get; set; }


//        protected IEnumerable<Deed> Deeds { get; set; }
        
//        [StepArgumentTransformation]
//        public IEnumerable<Deed> ToDeeds(Table table)
//        {
//            return table.CreateSet<Deed>();
//        }

//        [Then(@"the result should be (.*)")]
//        public void ThenTheResultShouldBe(int kindnessFactor)
//        {
//            Assert.That(Result, Is.EqualTo(kindnessFactor));
//        }


//    }
//}
