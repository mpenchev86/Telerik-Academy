using System;

namespace Point3D
{
    class MainClass
    {
        static void Main()
        {
            Path filePath = PathStorage.LoadPath("../../Testpaths.txt");

            for (int i = 0; i < filePath.Sequence.Count; i++)
            {
                Console.WriteLine(filePath.Sequence[i]);
            }

        }
    }
}
