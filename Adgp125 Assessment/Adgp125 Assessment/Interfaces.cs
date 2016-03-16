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
    string Type { get; set; }
    string Name { get; set; }
}

public interface IManage<T, U, V, W>
{
    List<Unit> sortBySpeed(T u);
    void Timetofight(T u, W f);
    void Statsofobjects(T u);
    bool Checkforvictory(U p, V e);
}


