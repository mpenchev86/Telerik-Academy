namespace RefactorIfStatements
{
    using System;
    using Kitchen;

    public class RefactorIfStatements
    {
        public static void Main(string[] args)
        {
            RefactorPotatoStatements();
            RefactorMazeStatements();
        }

        public static void RefactorPotatoStatements()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                bool notPeeled = !potato.IsPeeled;
                bool notRotten = !potato.IsRotten;

                if (notPeeled && notRotten)
                {
                    potato.Cook();
                }
            }
        }

        public static void RefactorMazeStatements()
        {
            const int MIN_X = 0;
            const int MAX_X = 20;
            const int MIN_Y = 0;
            const int MAX_Y = 20;

            int x = 3;
            int y = 16;

            bool shouldVisitCell = true;

            if (shouldVisitCell && 
                IsValidCoordinate(x, MIN_X, MAX_X) && 
                IsValidCoordinate(y, MIN_Y, MAX_Y))
            {
                VisitCell();
            }
        }

        public static void VisitCell()
        {
        }

        public static bool IsValidCoordinate(int coordinate, int min, int max)
        {
            bool result = min <= coordinate && coordinate <= max;

            return result;
        }
    }
}
