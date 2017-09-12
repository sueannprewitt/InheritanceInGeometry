using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceinGeometry; //using data from InheritanceinGeometry

namespace TestInheritanceinGeometry {
	class Program {

		void Run() {
			Quadrilateral quad1 = new Quadrilateral(3,4,5,6);
			//set the length, so call the method:
			//quad1.SetAllSides(3, 4, 5, 6);
			//create a variable:
			var perimeter = quad1.CalculatePerimeter();
			//print out the perimeter:
			Console.WriteLine($"The perimeter is {perimeter}");


			Parallelogram p1 = new Parallelogram(7,3);
			//p1.SetAllSides(7, 3);
			perimeter = p1.CalculatePerimeter();
			var area = p1.CalculateArea();
			Console.WriteLine($"The perimeter is {perimeter}; the area is {area}");

			Square sqr = new Square();
			sqr.SetAllSides(6);
			perimeter = sqr.CalculatePerimeter();
			area = sqr.CalculateArea();
			Console.WriteLine($"The perimeter is {perimeter}; the area is {area}");

		}
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
