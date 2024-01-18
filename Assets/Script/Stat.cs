using UnityEngine.Rendering;

namespace Script
{
    public class Stat
    {
        private int atk;
        private int def;
        private int spd;

        public Stat(int atk, int def, int spd)
        {
            this.atk = atk;
            this.def = def;
            this.spd = spd;
        }

        public string ToString()
        {
            return "atk : " + atk + " def : " + def + " spd : " + spd;
        }
    }
}