namespace MortalEngines.Entities
{
    using System;

    using MortalEngines.Entities.Contracts;

    public class Fighter : BaseMachine, IFighter
    {
        private const int Initial_Health_Points = 200;

        public Fighter(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, Initial_Health_Points)
        {
            this.ToggleAggressiveMode();
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode() 
        {
            if (this.AggressiveMode == false)
            {
                this.AggressiveMode = true;
                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
            else
            {
                this.AggressiveMode = false;
                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
        }

        public override string ToString()
        {
            string isModeOnOrOff = this.AggressiveMode == true ? "ON" : "OFF";

            return base.ToString() + Environment.NewLine + $" *Aggressive: {isModeOnOrOff}";
        }
    }
}