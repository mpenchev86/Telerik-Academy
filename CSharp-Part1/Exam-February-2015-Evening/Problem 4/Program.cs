using System;

class Program
{
	static void Main(string[] args)
	{
		int N = int.Parse(Console.ReadLine());
		int D = int.Parse(Console.ReadLine());

		char[,] line = new char[2 * N + 1, 2 * N + 1];

		for (int j = 0; j < 2 * N + 1; j++)
		{
			for (int i = 0; i < 2 * N + 1; i++)
			{
				line[j,i] = '#';			 
			}
		}

		if (D < 2 * N + 1)
		{
			int positionX = ((2*N + 1) - D) / 2;
			line[N,positionX - 1] = 'X';
			line[N,positionX + D] = 'X';

			int tempX = positionX - 1;
			for (int i = 0; i > N - positionX; i--)
			{
				for (int j = 0; j < tempX - 1; j++)
				{
					line[N - i, j] = line[N + i, j] = line[N + i, tempX + D + j] = line[N - i, tempX + D + j] = '.';
				}
				line[N - i, tempX] = line[N + i, tempX + D] = '\\';
				line[N + i, tempX] = line[N - i, tempX + D] = '/';
				tempX--;
			}
		}

		for (int j = 0; j < 2 * N + 1; j++)
		{
			for (int i = 0; i < 2 * N + 1; i++)
			{
				Console.Write(line[j, i]); 
			}
			Console.WriteLine();
		}

		
	}
}