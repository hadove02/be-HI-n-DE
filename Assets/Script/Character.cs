namespace Script
{
    public class Character
    {
        public Character(string className, int maxHealth, int maxMana, SkillSet skillSet)
        {
            this.className = className;
            this.maxHealth = maxHealth;
            this.maxMana = maxMana;
            this.skillSet = skillSet;
        }
        
        private string className;
        private int maxHealth;
        private int maxMana;
        private SkillSet skillSet;
        
        public string ToString()
        {
            return "class > " + className + 
                   "\nmaxHealth > " + maxHealth +
                   ", maxMana > " + maxMana;
        }
    }
}