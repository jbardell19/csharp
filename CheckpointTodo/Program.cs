using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckPoint2_ToDo
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				App app1 = new App();
				app1.CallsMethods();
			} while (App.EndProgram());
		}
	}
}
