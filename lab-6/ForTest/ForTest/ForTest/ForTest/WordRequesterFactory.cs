using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.ForTest
{
	internal class WordRequesterFactory
	{
		public IWordRequester CreateWordRequester(int mode)
		{
			switch (mode)
			{
				case 1:
					return new SingleWordRequester();
				case 2:
					return new MultiWordRequester();
				default:
					throw new ArgumentException("Invalid mode");
			}
		}
	}
}
