using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Unit : IActions, IStats, ICombat
{
    private int m_Health;
    private int m_Strength;
    private int m_Speed;
    private int m_Defense;
    private bool m_Turn;
    private Unit m_CurrentUnit;
    private List<Unit> m_participants = new List<Unit>();

    //Overloaded Constructor
    public Unit(int hp, int str, int spd, int def)
    {
        m_Health = hp;
        m_Strength = str;
        m_Speed = spd;
        m_Defense = def;
    }

    //Constructor
    public Unit()
    {

    }

    //Defense
    public int Defense
    {
        get
        {
            return m_Defense;
        }

        set
        {
            m_Defense = value;
        }
    }

    //Health
    public int Health
    {
        get
        {
            return m_Health;
        }

        set
        {
            m_Health = value;
        }
    }

    //Speed
    public int Speed
    {
        get
        {
            return m_Speed;
        }

        set
        {
            m_Speed = value;
        }
    }

    //Strength
    public int Strength
    {
        get
        {
            return m_Strength;
        }

        set
        {
            m_Strength = value;
        }
    }

    //True or False - Units turn 
    public bool Turn
    {
        get
        {
            return m_Turn;
        }

        set
        {
            m_Turn = value;
        }
    }

    //Current Unit Taking The Turn
    public Unit currentUnitTakingTurn
    {
        get
        {
            return m_CurrentUnit;
        }

        set
        {
            m_CurrentUnit = value;
        }
    }

    //List of all units
    public List<Unit> participants
    {
        get
        {
            return m_participants;
        }

        set
        {
            m_participants = value;
        }
    }

    //Attack
    public void Attack(Unit u)
    {
        float perc = u.m_Defense * 0.25f;
        u.m_Health -= this.m_Strength / (int)perc;

    }

    //Escape Battle
    public void Escape()
    {
        
    }

    //Guard Action
    public void Guard()
    {

        Unit check = currentUnitTakingTurn;

        if(currentUnitTakingTurn == this)
        {
            this.m_Defense += 10;
        }
        else
        {
            this.m_Defense = Defense;
        }
        


    }
    //Next Unit Turn 
    public void NextUnit()
    {
        
    }

    //Check for the highest speed stat
    public void checkForSpeed()
    {
        foreach (Unit m in m_participants)
        {
            currentUnitTakingTurn = Compare(m);

        }

    }

    //Check list of units for unit with highest speed stat to attack first
    public Unit Compare(Unit m)
    {
        foreach (Unit p in m_participants)
        {
            if(p.m_Speed > m.m_Speed)
            {
                currentUnitTakingTurn = p;
                p.m_Turn = true;
            }
            else
            {
                currentUnitTakingTurn = m;
                m.m_Turn = true;
            }
        }

        return currentUnitTakingTurn;
    }
}

