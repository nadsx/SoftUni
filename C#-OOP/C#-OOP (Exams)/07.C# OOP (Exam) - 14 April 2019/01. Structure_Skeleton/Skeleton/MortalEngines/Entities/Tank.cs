namespace MortalEngines.Entities
{
    using System;

    using MortalEngines.Entities.Contracts;

    public class Tank : BaseMachine, ITank
    {
        private const int Initial_Health_Points = 100;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, Initial_Health_Points)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if(this.DefenseMode == false)
            {
                this.DefenseMode = true;
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
            else
            {
                this.DefenseMode = false;
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
        }

        public override string ToString()
        {
            string isModeOnOrOff = this.DefenseMode == true ? "ON" : "OFF";

            return base.ToString() + Environment.NewLine + $" *Defense: {isModeOnOrOff}";
        }
    }
}