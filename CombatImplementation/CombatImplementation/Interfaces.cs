using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IActions
{

    void Attack(Unit u);
    void Escape();
    void Guard();

}

public interface IStats
{
    int Health { get; set; }
    int Strength { get; set; }
    int Speed { get; set; }
    int Defense { get; set; }


}

public interface ICombat
{
    List<Unit> participants{ get; set;}

    bool Turn { get; set; }
    Unit currentUnitTakingTurn { get; set; }
    void checkForSpeed();
    void NextUnit();
    Unit Compare(Unit m);
}

