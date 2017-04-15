using UnityEngine;
using System.Collections;

namespace foxfluff.GridSystem
{
	public struct Point
	{
		public int X { get; private set; }
		public int Y { get; private set; }
		public int Z { get; private set; }

		public Point(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
			this.Z = 0;
		}

		public Point(int X, int Y, int Z)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
		}
	}
}