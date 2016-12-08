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
		[TestCase]
		public void CreateInstsnce_InstanceCreated()
		{
			//Arange
			//Act
			var sut = new SutLibrary();

			//Assert
			Assert.NotNull(sut);
		}
	}
}
