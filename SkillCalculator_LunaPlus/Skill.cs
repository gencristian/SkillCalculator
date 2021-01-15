using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCalculator_LunaPlus
{
    class Skill
    {
        private string nombre;
        private int lvl = 0;
        private int danioBase;
        private int cdBase;
        private int lvlReq;
        private int spReq;
        private int cast;
        // private string statEffect; (falta analizar como completar el string)

        public Skill(string name, int dBase,int CDBase, int levelReq, int SPReq, int casteo)
        {
            nombre = name;            
            danioBase = dBase;
            cdBase = CDBase;
            lvlReq = levelReq;
            spReq = SPReq;
            cast = casteo;
        }

        public int dmg()
        {
            return danioBase + (lvl * 20);
        }
        public int Level()
        {
            return lvl;
        }
        public string Nombre() {
            return nombre;
        }
        public int LevelReq() {
            return lvlReq;
        }
        public int CdBase()
        {
            return cdBase;
        }
        public int SpReq()
        {
            return spReq;
        }
        public int Cast()
        {
            return cast;
        }

        public void subirNivelSkill()
        {
            lvl++;

        }
    }
}
