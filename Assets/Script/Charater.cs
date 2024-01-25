namespace Script
{
    public class Charater
    {
        public Charater(string name, int maxMana, int maxHealth)
        {
            this.name = name;
            this.maxMana = maxMana;
            this.maxHealth = maxHealth;
        }
        
        private string name;
        private int maxMana, maxHealth;

        public string ToString()
        {
            return "name > " + name +
                   "\nmaxHealth > " + maxHealth +
                   " maxMana > " + maxMana;
        }
    }
}