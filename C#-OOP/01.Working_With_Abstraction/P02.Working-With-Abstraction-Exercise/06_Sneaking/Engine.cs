using System;

namespace Sneaking
{
    public class Engine
    {
        public void Run()
        {
            int size = int.Parse(Console.ReadLine());

            Board board = new Board(size);
            char[] commands = Console.ReadLine().ToCharArray();

            foreach (var command in commands)
            {
                board.EnamiesMoving();
                board.FindPlayer();
                board.CheckEnemyPosition();
                board.CheckIfSamIsDead();
                board.MoveSam(command);
                board.CheckNikoladze();
            }

            board.PrintMatrix();
        }
    }
}
