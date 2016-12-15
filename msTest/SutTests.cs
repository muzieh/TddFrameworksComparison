using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut;

namespace msTest
{
	[TestClass]
	public class SutTests
	{
		public SutLibrary globalSutLibrary { get; set; }

		[TestInitialize]
		public void SetUp()
		{
			this.globalSutLibrary = new SutLibrary();
		}

		[TestCleanup]
		public void TearDown()
		{
			this.globalSutLibrary = null;
		}

		[TestMethod]
		public void CreateInstsnce_InstanceCreated()
		{
			//Arange
			//Act
			var sut = new SutLibrary();

			//Assert
			Assert.IsNotNull(sut);
		}

		[TestMethod]
		public void CreateInstanceInSetup_InstanceCreated()
		{
			//Arange
			//Act
			var sut = this.globalSutLibrary;

			//Assert
			Assert.IsNotNull(sut);
		}

		[TestMethod]
		public void AddNumbers_1_2_result3()
		{
			//Arange
			var sut = this.globalSutLibrary;
			//Act
			var result = sut.Add(1, 2);

			//Assert
			Assert.AreEqual(3, result);
		}

		//TODO: look for parameter based testing in mstest
		//[TestMethod]
		//[Row(1, 2, 3)]
		//[TestCase(3, 3, 6)]
		//[TestCase(2, 3, 5)]
		//public void AddNumbers_SetOfCases_ValidResult(int a, int b, int expectedResult)
		//{
		//	//Arange
		//	var sut = this.globalSutLibrary;
		//	//Act
		//	var actualResult = sut.Add(a, b);

		//	//Assert
		//	Assert.AreEqual(expectedResult, actualResult);
		//}


		[ExpectedException(typeof(ArgumentNullException))]
		[TestMethod]
		public void AddNumbers_Zero_Exception()
		{
			//Arange
			var sut = this.globalSutLibrary;
			//Act
			sut.Add(0, 1);
		}
	}
}
