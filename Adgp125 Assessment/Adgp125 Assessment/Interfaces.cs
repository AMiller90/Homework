using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IActions<T>
{

    bool Attack(T u);
    
}

public interface IStats
{
    int Level { get; set; }
    int Health { get; set; }
    int Strength { get; set; }
    int Speed { get; set; }
    int Defense { get; set; }
    int Experience { get; set; }
    bool Turn { get; set; }
    string Type { get; set; }

}

public interface IManage<T, V, W>
{
    bool checkForSpeed(T p, V e);
    void Timetofight(bool b, T p, V e, W f);
    void Statsofobjects(T p, V e);
}


