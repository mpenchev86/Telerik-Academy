using System;
using System.Text;

namespace Point3D
{
	public struct Point3D
	{
		private static readonly Point3D O = new Point3D(0, 0, 0);

		public Point3D(int x, int y, int z)
			: this()
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public static Point3D returnO
		{
			get
			{
				return O;
			}
		}

		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }

		public override string ToString()
		{
			string pointPrint = String.Format("Coordinates of the point: {0} {1} {2}", this.X, this.Y, this.Z);

			return pointPrint;
		}

		public static Point3D ParsePoint(string line)
		{
			var tempCoordinate = new StringBuilder();
			int[] coordinates = new int[3];
			int j = 0;

			for (int i = 0; i < line.Length; i++)
			{
				if (Char.IsDigit(line[i]) || line[i] == '-')
				{
					tempCoordinate.Append(line[i]);
				}
				else
				{
					int coord = int.Parse(tempCoordinate.ToString());
					coordinates[j] = coord;
					j++;
					tempCoordinate.Clear();
				}
			}

			return new Point3D(coordinates[0], coordinates[1], coordinates[2]);
		}

	}
}
