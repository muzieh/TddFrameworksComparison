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
			var sut = new SutLibrary();
			Assert.IsNotNull(sut);
		}
	}
}
