using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IActions<T>
{

    bool Attack(T u);
    void Guard();

}

public interface IStats
{
    string Name { get; }
    int Level { get; set; }
    int Health { get; set; }
    int Strength { get; set; }
    int Speed { get; set; }
    int Defense { get; set; }
    int Experience { get; set; }
    bool Turn { get; set; }

}

public interface IManage<T, V>
{
    bool checkForSpeed(T p, V e);
    void Timetofight(bool b, T p, V e);
    void Statsofobjects(T p, V e);
}


