using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMeSenpai
{
    class Protaginist : IHighSchooler, IMechPilot
    {
        int m_Attack;
        int m_Defence;
        int m_Grade;
        string m_MechName;
        string m_School;

        public int Attack
        {
            get
            {
                return m_Attack;
            }

            set
            {
                m_Attack = value;
            }
        }

        public int Defence
        {
            get
            {
                return m_Defence;
            }

            set
            {
                m_Defence = value;
            }
        }

        public int Grade
        {
            get
            {
                return m_Grade;
            }

            set
            {
                m_Grade = value;
            }
        }

        public string MechName
        {
            get
            {
                return m_MechName;
            }

            set
            {
                m_MechName = value;
            }
        }

        public string School
        {
            get
            {
                return m_School;
            }

            set
            {
                m_School = value;
            }
        }

        public void ItsaAngle(IMonster angle)
        {
            if (angle.Level > (this.Defence/3))
            {
                Console.WriteLine(MechName + " lost in the Battle.");
            }
            if (angle.Level > (this.Attack/4))
            {
                Console.WriteLine(MechName + "'s attacks did nothing!");
            }
        }

        public void SenpaiNotice(IHighSchooler senpai)
        {
            if ((this.School == senpai.School) && (this.Grade < senpai.Grade))
            {
                Console.WriteLine(senpai + " senpai noticed me! =<^.^>=");
            }
        }

         public Protaginist(int a, int b, int c, string d, string e)
        {
            m_Attack = a;
            m_Defence = b;
            m_Grade = c;
            m_MechName = d;
            m_School = e;
        }
    }
}
