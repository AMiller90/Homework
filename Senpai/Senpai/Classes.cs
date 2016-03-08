using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Protaginist : IHighSchooler, IMechPilot
{
    private int grade;
    private string school;
    private string mechName;
    private int attack;
    private int defence;

    public Protaginist(string s, int g, string m, int a, int d)
    {
      school = s;
      grade = g;
      mechName = m;
      attack = a;
      defence = d;
    }

    public int Grade
    {
        get
        {
            return grade;
        }

        set
        {
            grade = value;
        }
    }

    public string School
    {
        get
        {
            return school;
        }

        set
        {
            school = value;
        }
    }

    public bool SenpaiNotice(IHighSchooler senpai)
    {
        if(senpai.School == School && senpai.Grade >= Grade)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int Attack
    {
        get
        {
            return attack;
        }

        set
        {
            attack = value;
        }
    }

    public int Defence
    {
        get
        {
            return defence;
        }

        set
        {
            defence = value;
        }
    }

    public string MechName
    {
        get
        {
            return mechName;
        }

        set
        {
            mechName = value;
        }
    }

    public string ItsaAngel(IMonster angel)
    {
        if(angel.Level > 0.33 * defence)
        {
            return (mechName + " Lost in Battle.\n");
        }
        else
        {
            return (mechName + " Continues the fight.\n");
        }

        if (angel.Level > 0.25 * attack)
        {
            return (mechName + "'s Attacks did nothing.\n");
        }
        else
        {
            return (mechName + " Defeated the monster.\n");
        }
    }
}

class SadTwist : IHighSchooler, IMonster
{
    private int grade;
    private string school;

    private int level;

    public SadTwist(string s, int g, int l)
    {
        school = s;
        grade = g;
        level = l;
    }


    public int Grade
    {
        get
        {
            return grade;
        }

        set
        {
            grade = value;
        }
    }

    public string School
    {
        get
        {
            return school;
        }

        set
        {
            school = value;
        }
    }

    public int Level
    {
        get
        {
            return level;
        }

        set
        {
            level = value;
        }
    }

    public bool SenpaiNotice(IHighSchooler senpai)
    {
        if (senpai.School == school && senpai.Grade >= grade)
        {

            return true;
        }
        else
        {
            return false;
        }
    }
}
