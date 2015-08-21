using System;
using System.IO;

namespace Point3D
{
    static class PathStorage
    {
        public static void SavePath(Path path, string fileLocation) 
        {
            using (var sw = new StreamWriter("..//..//path" + fileLocation + ".txt"))
            {
                for (int i = 0; i < path.Sequence.Count; i++)
                {
                    sw.WriteLine(path.Sequence[i]);
                }
            }
        }

        public static Path LoadPath(string fileLocation)
        {
            var path = new Path();

            using (var sr = new StreamReader(fileLocation))
            {
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine().Trim();
                    Point3D nextPoint = Point3D.ParsePoint(line);
                    path.Sequence.Add(nextPoint);
                }
            }

            return path;
        }
    }
}
