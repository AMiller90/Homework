using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public interface IHighSchooler
    {
        string School{ get;set; }
        int Grade { get; set; }

        bool SenpaiNotice(IHighSchooler senpai);

    }

    public interface IMechPilot
    {
        string MechName{ get; set; }
        int Attack { get; set; }
        int Defence { get; set; }

        string ItsaAngel(IMonster angel);
    }


    public interface IMonster
    {
        int Level { get; set; }
    }


