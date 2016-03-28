using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Public interface for actions - T Generic type that can be passed as a parameter
public interface IActions<T>
{
    //Function used for the battling between units
    bool Attack(T u);
    
}
//Public interface for stats
public interface IStats
{//Property used for Level
    int Level { get; set; }
    //Property used for MaxHp
    int MaxHp { get; }
    //Property used for Health
    int Health { get; set; }
    //Property used for Strength
    int Strength { get; set; }
    //Property used for Speed
    int Speed { get; set; }
    //Property used for Defense
    int Defense { get; set; }
    //Property used for Experience
    int Experience { get; set; }
    //Property used for Type
    string Type { get; set; }
    //Property used for Name
    string Name { get; set; }
}
//Public interface for Managing - T Generic type that can be passed as a parameter
public interface IManage<T>
{//Function used to sort a list by speed and return a List<Unit>
    List<Unit> sortBySpeed(T u);
    //Function used to print the stats of objects in the game
    void Statsofobjects(T u);
    //Function used to check for victory
    bool Checkforvictory(T p, T e);
}


