using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceinGeometry {
	public class Square : Parallelogram {

		public void SetAllSides (int side1) {
			SetAllSides(side1, side1);
		}

		public Square() : base() { }
		public Square (int side) : base(side, side) {
			//SetAllSides(side);
		}
	}
}
