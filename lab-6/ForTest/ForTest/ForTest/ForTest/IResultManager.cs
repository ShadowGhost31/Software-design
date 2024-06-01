using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest.ForTest
{
	internal interface IResultManager
	{
		void SaveResult(string name, int errors, double timeInSeconds);

		void PrintResults();
	}
}
