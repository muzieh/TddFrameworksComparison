using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Sut;

namespace xUnit
{
	public class SutTests
	{
		[Fact]
		public void CreateInstance_InstanceCreated()
		{
			//Arange
			//Act
			var sut = new SutLibrary();

			//Assert
			Assert.NotNull(sut);
		}
	}
}
