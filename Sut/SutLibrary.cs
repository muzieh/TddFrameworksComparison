using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut
{
	public class SutLibrary
	{
		public int Add(int a, int b)
		{
			if (a == 0 || b == 0)
			{
				throw new ArgumentNullException();
			}
			return a + b;
		}
	}
}
