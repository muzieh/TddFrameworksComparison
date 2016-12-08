using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Sut;

namespace xUnit
{
	public class SutTests : IDisposable
	{
		private SutLibrary globalSutLibrary;

		public SutTests()
		{
			this.globalSutLibrary = new SutLibrary();
		}
		public void Dispose()
		{
			this.globalSutLibrary = null;
		}

		[Fact]
		public void CreateInstance_InstanceCreated()
		{
			//Arange
			//Act
			var sut = new SutLibrary();

			//Assert
			Assert.NotNull(sut);
		}

		[Fact]
		public void CreateInstanceInSetup_InstanceCreated()
		{
			//Arange
			//Act
			var sut = this.globalSutLibrary;

			//Assert
			Assert.NotNull(sut);
		}

		[Fact]
		public void AddNumbers_1_2_result3()
		{
			//Arange
			var sut = this.globalSutLibrary;
			//Act
			var result = sut.Add(1, 2);

			//Assert
			Assert.Equal(3, result);
		}

		[Theory]
		[InlineData(1, 2, 3)]
		[InlineData(3, 3, 6)]
		[InlineData(2, 3, 5)]
		public void AddNumbers_SetOfCases_ValidResult(int a, int b, int expectedResult)
		{
			//Arange
			var sut = this.globalSutLibrary;
			//Act
			var actualResult = sut.Add(a, b);

			//Assert
			Assert.Equal(expectedResult, actualResult);
		}


	}
}
