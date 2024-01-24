namespace Script
{
    public class SkillSet
    {
        public SkillSet(PassiveSkill passive,
            ActiveSkill one,
            ActiveSkill two,
            ActiveSkill three,
            ActiveSkill four)
        {
            this.passive = passive;
            this.one = one;
            this.two = two;
            this.three = three;
            this.four = four;   
        }
        
        private PassiveSkill passive;
        private ActiveSkill one;
        private ActiveSkill two;
        private ActiveSkill three;
        private ActiveSkill four;
    }
}