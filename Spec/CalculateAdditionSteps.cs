using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Spec
{
	[Binding]
	public class CalculateAdditionSteps
	{
		private Calculator _calculator = new Calculator();

		[Given(@"I have entered (.*) into the calculator")]
		public void GivenIHaveEnteredIntoTheCalculator(int p0)
		{
			_calculator.Enter(p0);
		}

		[Given(@"I press add")]
		public void GivenIPressAdd()
		{
			_calculator.Add();
		}


		[When(@"I press equals")]
		public void WhenIPressEquals()
		{
			_calculator.Eqls();
		}

		[Then(@"the result should be (.*) on the screen")]
		public void ThenTheResultShouldBeOnTheScreen(int p0)
		{
			Assert.AreEqual(p0, _calculator.Result());
		}

		[Then(@"result (.*) on the screen")]
		public void ThenResultOnTheScreen(int p0)
		{
			Assert.AreEqual(p0, _calculator.Result()); ;
		}




	}

	public class Calculator

	{
		private List<int> numbers = new List<int>();

		public void Add()
		{
		}

		public void Enter(int number)
		{
			numbers.Add(number);
		}

		public void Eqls()
		{
		}

		public int Result()
		{
			return numbers.Sum();

		}
	}
}
