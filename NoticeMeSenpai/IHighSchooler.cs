using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMeSenpai
{
    interface IHighSchooler
    {
        string School
        {
            get; set;
        }

        int Grade
        {
            get; set;
        }

        void SenpaiNotice(IHighSchooler senpai);
    }
}
