﻿using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xunit;

namespace Pickles.TestHarness.xunit
{
    [Binding]
    public class AdditionSteps
    {
      private List<int> numbersList;
      private int result;

      [Given(@"the calculator has clean memory")]
      public void GivenTheCalculatorHasCleanMemory()
      {
        this.numbersList = new List<int>();
        this.result = 0;
      }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(Decimal p0)
        {
          numbersList.Add((int)p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
          foreach (var i in numbersList)
          {
            result += i;
          }
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(Decimal p0)
        {
          Assert.Equal(p0, result);
        }
    }
}
