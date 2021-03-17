namespace PlayersAndMonsters.Models.BattleFields
{
    using System;
    using System.Linq;

    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Models.Players;
    using PlayersAndMonsters.Models.Players.Contracts;

    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if(attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            CheckForBeginners(attackPlayer, enemyPlayer);

            BonusHealthPoints(attackPlayer);
            BonusHealthPoints(enemyPlayer);

            while (true)
            {
                int attackerDamagePoints = attackPlayer.CardRepository.Cards.Sum(c => c.DamagePoints);

                enemyPlayer.TakeDamage(attackerDamagePoints);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                int enemyDamagePoints = enemyPlayer.CardRepository.Cards.Sum(c => c.DamagePoints);

                attackPlayer.TakeDamage(enemyDamagePoints);

                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }

        private static void BonusHealthPoints(IPlayer player)
        {
            player.Health += player.CardRepository.Cards.Sum(c => c.HealthPoints);
        }

        private static void CheckForBeginners(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if(attackPlayer.GetType() == typeof(Beginner))
            {
                attackPlayer.Health += 40;

                foreach(var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            if(enemyPlayer.GetType() == typeof(Beginner))
            {
                enemyPlayer.Health += 40;

                foreach(var card in enemyPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }
        }
    }
}