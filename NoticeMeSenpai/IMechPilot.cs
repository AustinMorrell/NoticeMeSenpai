using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMeSenpai
{
    interface IMechPilot
    {
        string MechName
        {
            get; set;
        }

        int Attack
        {
            get; set;
        }

        int Defence
        {
            get; set;
        }

        void ItsaAngle(IMonster angle);
    }
}
