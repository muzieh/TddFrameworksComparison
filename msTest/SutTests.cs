using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut;

namespace msTest
{
	[TestClass]
	public class SutTests
	{
		[TestMethod]
		public void CreateInstsnce_InstanceCreated()
		{
			//Arange
			//Act
			var sut = new SutLibrary();

			//Assert
			Assert.IsNotNull(sut);
		}
	}
}
