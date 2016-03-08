using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMeSenpai
{
    class SadTwist : IHighSchooler, IMonster
    {
        int m_Grade;
        int m_Level;
        string m_School;

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

        public int Level
        {
            get
            {
                return m_Level;
            }

            set
            {
                m_Level = value;
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

        public void SenpaiNotice(IHighSchooler senpai)
        {
            if ((this.School == senpai.School) && (this.Grade < senpai.Grade))
            {
                Console.WriteLine(senpai + " senpai noticed me! =<^.^>=");
            }
        }

        public SadTwist(int a, int b, string c)
        {
            m_Grade = a;
            m_Level = b;
            m_School = c;
        }
    }
}
