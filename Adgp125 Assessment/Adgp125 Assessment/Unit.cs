using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class Unit : IStats
{
    
    private int m_uDefense;
    private int m_uExperience;
    private int m_uHealth;
    private int m_uLevel;
    private int m_uSpeed;
    private int m_uStrength;
    private bool m_uTurn;
    private string m_uType;
    

    public Unit()
    {
    

    }

    public int Defense
    {
        get
        {
            return m_uDefense;
        }

        set
        {
            m_uDefense = value;
        }
    }

    public int Experience
    {
        get
        {
            return m_uExperience;
        }

        set
        {
           m_uExperience = value;
        }
    }

    public int Health
    {
        get
        {
            return m_uHealth;
        }

        set
        {
            m_uHealth = value;
        }
    }

    public int Level
    {
        get
        {
            return m_uLevel;
        }

        set
        {
            m_uLevel = value;
        }
    }

    public int Speed
    {
        get
        {
            return m_uSpeed;
        }

        set
        {
            m_uSpeed = value;
        }
    }

    public int Strength
    {
        get
        {
            return m_uStrength;
        }

        set
        {
            m_uStrength = value;
        }
    }

    public bool Turn
    {
        get
        {
            return m_uTurn;
        }

        set
        {
            m_uTurn = value;
        }
    }

    public string Type
    {
        get
        {
            return m_uType;
        }
        set
        {
            m_uType = value;
        }
    }
}

