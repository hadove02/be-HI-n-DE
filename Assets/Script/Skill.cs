namespace Script
{
    public class Skill
    {
        public Skill(string skill_name, bool is_passive, int damage, int cost_mana)
        {
            this.skill_name = skill_name;
            this.is_passive = is_passive;
            this.damage = damage;
            this.cost_mana = cost_mana;
        }
        private string skill_name;
        private bool is_passive;
        private int damage, cost_mana;

        public bool isPassive()
        {
            return is_passive;
        }

        public string ToString()
        {
            return "skill name > " + skill_name +
                   "\ndamage > " + damage +
                   ", cost_mana > " + cost_mana;
        }
    }
}