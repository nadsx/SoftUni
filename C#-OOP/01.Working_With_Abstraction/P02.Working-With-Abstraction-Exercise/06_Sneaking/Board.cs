using System;
using System.Linq;

namespace Sneaking
{
    public class Board
    {
        private char[][] jaggedArray;
        private int[] playerSam = new int[2];
        private int[] enemy = new int[2];

        public Board(int size)
        {
            jaggedArray = new char[size][];
            this.FillMatrix();
        }

        public void FillMatrix()
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console.ReadLine().ToCharArray();
            }
        }

        public void EnamiesMoving()
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (jaggedArray[row][col] == 'b')
                    {
                        if (col == jaggedArray[row].Length - 1)
                        {
                            jaggedArray[row][col] = 'd';
                        }
                        else
                        {
                            jaggedArray[row][col] = '.';
                            jaggedArray[row][++col] = 'b';
                        }
                    }
                    else if (jaggedArray[row][col] == 'd')
                    {
                        if (col == 0)
                        {
                            jaggedArray[row][col] = 'b';
                        }
                        else
                        {
                            jaggedArray[row][col] = '.';
                            jaggedArray[row][--col] = 'd';
                        }
                    }
                }
            }
        }

        public void FindPlayer()
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (jaggedArray[row][col] == 'S')
                    {
                        playerSam[0] = row;
                        playerSam[1] = col;
                    }
                }
            }
        }

        public void CheckEnemyPosition()
        {
            int playerRow = playerSam[0];

            for (int col = 0; col < jaggedArray[playerRow].Length; col++)
            {
                if (jaggedArray[playerRow][col] != '.' && jaggedArray[playerRow][col] != 'S')
                {
                    enemy[0] = playerRow; // Enemies should be d or b
                    enemy[1] = col;
                }
            }
        }

        public void CheckIfSamIsDead()
        {
            int playerRow = playerSam[0], playerCol = playerSam[1];
            int enemyRow = enemy[0], enemyCol = enemy[1];

            if (playerCol < enemyCol && jaggedArray[enemyRow][enemyCol] == 'd' && enemyRow == playerRow)
            {
                jaggedArray[playerRow][playerCol] = 'X';

                Console.WriteLine($"Sam died at {playerRow}, {playerCol}");

                PrintMatrix();
            }
            else if (enemyCol < playerCol && jaggedArray[enemyRow][enemyCol] == 'b' && enemyRow == playerRow)
            {
                jaggedArray[playerRow][playerCol] = 'X';

                Console.WriteLine($"Sam died at {playerRow}, {playerCol}");

                PrintMatrix();
            }
        }

        public void MoveSam(char command)
        {
            int playerRow = playerSam[0], playerCol = playerSam[1];
            jaggedArray[playerRow][playerCol] = '.';

            switch (command)
            {
                case 'U':
                    playerRow--;
                    break;
                case 'D':
                    playerRow++;
                    break;
                case 'L':
                    playerCol--;
                    break;
                case 'R':
                    playerCol++;
                    break;
                default:
                    break;
            }

            jaggedArray[playerRow][playerCol] = 'S';
        }

        public void CheckNikoladze()
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                if (jaggedArray[row].Contains('N') && jaggedArray[row].Contains('S'))
                {
                    int colNikoladze = Array.IndexOf(jaggedArray[row], 'N');
                    jaggedArray[row][colNikoladze] = 'X';
                    Console.WriteLine($"Nikoladze killed!");
                    PrintMatrix();
                }
            }
        }

        public void PrintMatrix()
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join("", jaggedArray[row]));
            }

            Environment.Exit(0);
        }
    }
}

