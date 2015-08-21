namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

    public class MineSweeper
    {
        public static void Main()
        {
            const int MaxPoints = 35;
            const int PlayfieldRows = 5;
            const int PlayfieldCols = 10;
            char[,] playfield = GenerateNewPlayfield(PlayfieldRows, PlayfieldCols);
            char[,] mines = GenerateMines();
            List<PlayerScoreGenerator> highScores = new List<PlayerScoreGenerator>(6);
            string userCommand = string.Empty;
            int pointsCounter = 0;
            int currentRow = 0;
            int currentCol = 0;
            bool isMine = false;
            bool hasGameEnded = false;
            bool hasGameStarted = true;

            do
            {
                if (hasGameStarted)
                {
                    Console.WriteLine("Let's play \"Minesweeper\". Test your luck finding all squares without a mine." +
                                      "enter 'top'to see the highscores, 'restart' - to start a new game, 'exit' - to getta hell out!");
                    DrawPlayfield(playfield);
                    hasGameStarted = false;
                }
                
                Console.Write("Enter row and column of a square : ");
                userCommand = Console.ReadLine().Trim();
                if (userCommand.Length >= 3)
                {
                    if (int.TryParse(userCommand[0].ToString(), out currentRow) &&
                        int.TryParse(userCommand[2].ToString(), out currentCol) &&
                        currentRow <= playfield.GetLength(0) && 
                        currentCol <= playfield.GetLength(1))
                    {
                        userCommand = "turn";
                    }
                }
                
                switch (userCommand)
                {
                    case "top": 
                        PrintScoreBoard(highScores); 
                        break;
                    case "restart": 
                        playfield = GenerateNewPlayfield(PlayfieldRows, PlayfieldCols);
                        mines = GenerateMines();
                        DrawPlayfield(playfield);
                        isMine = false;
                        hasGameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("farewell!");
                        break;
                    case "turn":
                        if (mines[currentRow, currentCol] != '*')
                        {
                            if (mines[currentRow, currentCol] == '-')
                            {
                                MakeNextMove(playfield, mines, currentRow, currentCol);
                                pointsCounter++;
                            }

                            if (MaxPoints == pointsCounter)
                            {
                                hasGameEnded = true;
                            }
                            else
                            {
                                DrawPlayfield(playfield);
                            }
                        }
                        else
                        {
                            isMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nOops! Invalid command.\n");
                        break;
                }

                if (isMine)
                {
                    DrawPlayfield(mines);
                    Console.Write("\nHrrrrrr! You died a hero with {0} points. " + "Enter your name: ", pointsCounter);
                    string playerName = Console.ReadLine();
                    PlayerScoreGenerator t = new PlayerScoreGenerator(playerName, pointsCounter);
                    if (highScores.Count < 5)
                    {
                        highScores.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].PlayerPoints < t.PlayerPoints)
                            {
                                highScores.Insert(i, t);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((PlayerScoreGenerator x, PlayerScoreGenerator y) => y.PlayerName.CompareTo(x.PlayerName));
                    highScores.Sort((PlayerScoreGenerator x, PlayerScoreGenerator y) => y.PlayerPoints.CompareTo(x.PlayerPoints));
                    PrintScoreBoard(highScores);

                    playfield = GenerateNewPlayfield(PlayfieldRows, PlayfieldCols);
                    mines = GenerateMines();
                    pointsCounter = 0;
                    isMine = false;
                    hasGameStarted = true;
                }

                if (hasGameEnded)
                {
                    Console.WriteLine("\nYoo-hooooo! You uncovered 35 squares and you're still in one piece.");
                    DrawPlayfield(mines);
                    Console.WriteLine("Enter your name, dude: ");
                    string playerName = Console.ReadLine();
                    PlayerScoreGenerator playerScore = new PlayerScoreGenerator(playerName, pointsCounter);
                    highScores.Add(playerScore);
                    PrintScoreBoard(highScores);
                    playfield = GenerateNewPlayfield(PlayfieldRows, PlayfieldCols);
                    mines = GenerateMines();
                    pointsCounter = 0;
                    hasGameEnded = false;
                    hasGameStarted = true;
                }
            } 
            while (userCommand != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("Toodaloo, moth*rf*ckerRrRrRrRrRrRrR.");
            Console.Read();
        }

        private static void PrintScoreBoard(List<PlayerScoreGenerator> highScores)
        {
            Console.WriteLine("\nHigh Scores:");
            if (highScores.Count > 0)
            {
                for (int i = 0; i < highScores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} squares", i + 1, highScores[i].PlayerName, highScores[i].PlayerPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty scoreboard!\n");
            }
        }

        private static void MakeNextMove(char[,] playfield, char[,] mines, int currentRow, int currentCol)
        {
            char numberOfMines = CountMinesAroundEmptySquare(mines, currentRow, currentCol);
            mines[currentRow, currentCol] = numberOfMines;
            playfield[currentRow, currentCol] = numberOfMines;
        }

        private static void DrawPlayfield(char[,] playfield)
        {
            int numberOfRows = playfield.GetLength(0);
            int numberOfCols = playfield.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < numberOfCols; j++)
                {
                    Console.Write(string.Format("{0} ", playfield[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateNewPlayfield(int playfieldRows, int playfieldCols)
        {
            char[,] playfield = new char[playfieldRows, playfieldCols];
            for (int i = 0; i < playfieldRows; i++)
            {
                for (int j = 0; j < playfieldCols; j++)
                {
                    playfield[i, j] = '?';
                }
            }

            return playfield;
        }

        private static char[,] GenerateMines()
        {
            int numberOfRows = 5;
            int numberOfCols = 10;
            char[,] playfield = new char[numberOfRows, numberOfCols];

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfCols; j++)
                {
                    playfield[i, j] = '-';
                }
            }

            // A mine's code is the sum of the its position's row and column.
            List<int> codesOfMinesOnPlayfield = new List<int>();
            while (codesOfMinesOnPlayfield.Count < (numberOfRows + numberOfCols))
            {
                Random randomNum = new Random();
                int currentCode = randomNum.Next(numberOfRows * numberOfCols);
                if (!codesOfMinesOnPlayfield.Contains(currentCode))
                {
                    codesOfMinesOnPlayfield.Add(currentCode);
                }
            }

            foreach (int code in codesOfMinesOnPlayfield)
            {
                int column = code / numberOfCols;
                int row = code % numberOfCols;
                if (row == 0 && code != 0)
                {
                    column--;
                    row = numberOfCols;
                }
                else
                {
                    row++;
                }

                playfield[column, row - 1] = '*';
            }

            return playfield;
        }

        private static void AssignEmptySquares(char[,] playfield)
        {
            int numberOfCols = playfield.GetLength(0);
            int numberOfRows = playfield.GetLength(1);

            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    if (playfield[i, j] != '*')
                    {
                        char numberOfMines = CountMinesAroundEmptySquare(playfield, i, j);
                        playfield[i, j] = numberOfMines;
                    }
                }
            }
        }

        private static char CountMinesAroundEmptySquare(char[,] playfield, int squareCol, int squareRow)
        {
            int minesCounter = 0;
            int numberOfRows = playfield.GetLength(0);
            int numberOfCols = playfield.GetLength(1);

            if (squareCol - 1 >= 0)
            {
                if (playfield[squareCol - 1, squareRow] == '*')
                {
                    minesCounter++;
                }
            }

            if (squareCol + 1 < numberOfRows)
            {
                if (playfield[squareCol + 1, squareRow] == '*')
                {
                    minesCounter++;
                }
            }

            if (squareRow - 1 >= 0)
            {
                if (playfield[squareCol, squareRow - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if (squareRow + 1 < numberOfCols)
            {
                if (playfield[squareCol, squareRow + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((squareCol - 1 >= 0) && (squareRow - 1 >= 0))
            {
                if (playfield[squareCol - 1, squareRow - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((squareCol - 1 >= 0) && (squareRow + 1 < numberOfCols))
            {
                if (playfield[squareCol - 1, squareRow + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((squareCol + 1 < numberOfRows) && (squareRow - 1 >= 0))
            {
                if (playfield[squareCol + 1, squareRow - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((squareCol + 1 < numberOfRows) && (squareRow + 1 < numberOfCols))
            {
                if (playfield[squareCol + 1, squareRow + 1] == '*')
                {
                    minesCounter++;
                }
            }

            return char.Parse(minesCounter.ToString());
        }

        public class PlayerScoreGenerator
        {
            private string playerName;
            private int collectedPoints;

            public PlayerScoreGenerator()
            {
            }

            public PlayerScoreGenerator(string playerName, int collectedPoints)
            {
                this.playerName = playerName;
                this.collectedPoints = collectedPoints;
            }

            public string PlayerName
            {
                get
                {
                    return this.playerName;
                }

                set
                {
                    this.playerName = value;
                }
            }

            public int PlayerPoints
            {
                get
                {
                    return this.collectedPoints;
                }

                set
                {
                    this.collectedPoints = value;
                }
            }
        }
    }
}