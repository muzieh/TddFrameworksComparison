using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sut;

namespace nUnit
{
	[TestFixture]
	public class SutTests
	{
		private SutLibrary globalSutLibrary;

		[SetUp]
		public void SetUp()
		{
			this.globalSutLibrary = new SutLibrary();
		}


		[TearDown]
		public void TearDown()
		{
			this.globalSutLibrary = null;
		}

		[TestCase]
		public void CreateInstsnce_InstanceCreated()
		{
			//Arange
			//Act
			var sut = new SutLibrary();

			//Assert
			Assert.NotNull(sut);
		}

		[TestCase]
		public void CreateInstanceInSetup_InstanceCreated()
		{
			//Arange
			//Act
			var sut = this.globalSutLibrary;

			//Assert
			Assert.NotNull(sut);
		}

		[TestCase]
		public void AddNumbers_1_2_result3()
		{
			//Arange
			var sut = this.globalSutLibrary;
			//Act
			var result = sut.Add(1, 2);

			//Assert
			Assert.AreEqual(3, result);
		}

		[TestCase(1, 2, 3)]
		[TestCase(3, 3, 6)]
		[TestCase(2, 3, 5)]
		public void AddNumbers_SetOfCases_ValidResult(int a, int b, int expectedResult)
		{
			//Arange
			var sut = this.globalSutLibrary;
			//Act
			var actualResult = sut.Add(a, b);

			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestCase]
		public void AddNumbers_Zero_Exception()
		{
			//Arange
			var sut = this.globalSutLibrary;
			//Act
			//Assert
			Assert.That(() => { sut.Add(0,1); }, Throws.TypeOf<ArgumentNullException>());
		}

	}
}
