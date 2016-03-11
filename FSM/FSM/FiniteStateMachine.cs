using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FiniteStateMachine
{
    //Transition Class
    class Transition
    {
        //Transition from
        public Enum from;
        //Transition to
        public Enum to;

        //Transition constructor
        public Transition(Enum f, Enum t)
        {
            from = f;
            to = t;
        }

    }

    //Current state
    public Enum _currentState;
    //List of states
    private List<Enum> _states;
    //List of Transitions
    private List<Transition> tlist = new List<Transition>();
    //Dictionary containing Enum keys and List of transitions for values
    private Dictionary<Enum, List<Transition>> Transitiontable = new Dictionary<Enum, List<Transition>>();

    //Constructor
    public FiniteStateMachine(Enum sta)
    {
        //Initialize List
        _states = new List<Enum>();
        //Initialize current state
        _currentState = sta;
    }

    //Add states to the machine
    public bool AddStates(Enum e)
    {

        if (_states.Contains(e))
        {
            Console.WriteLine("Cannot add the " + e + " state because it already exists\n");
            return false;
        }
        else
        {
            _states.Add(e);
            return true;
        }

    }

    //Add transitions to list 
    //Add keys and values to dictionary
    public void Addtransition(Enum f, Enum t)
    {
        //If key does not exist
        if (!Transitiontable.ContainsKey(f))
        {//Add the new key with a new list as a value
            Transitiontable.Add(f, new List<Transition>());
            //Set that new list with the states passed into function
            Transitiontable[f].Add(new Transition(f, t));
        }
        //If the key does exist
        else
        {//Add a new transition to the current list at that key
            Transitiontable[f].Add(new Transition(f, t));
        }

    }

    //Print out info about FSM
    public void info()
    {
        Console.WriteLine("FSM is comprised of ...\n");
        int count = 0;
        foreach (Enum s in _states)
        {
            Console.WriteLine("State " + count.ToString() + " : " + s.ToString());

            count++;
        }

        Console.WriteLine("\nCurrent State: " + _currentState);

        Console.WriteLine("\nKeys in dictionary ...\n");
        foreach (KeyValuePair<Enum, List<Transition>> i in Transitiontable)
        {
            Console.WriteLine(i.Key);
        }
    }

    //Changes states
    public void ChangeStates(Enum a)
    {
        Console.WriteLine("\n" + _currentState +"->" + a.ToString());

        Enum cstate = _currentState;

        foreach (Transition t in Transitiontable[_currentState])
        {
            if (t.to.Equals(a))
            {
                
                Console.Write("\nTransitioned from " + _currentState);
                _currentState = a;
                
                Console.WriteLine(" to " + a + ".");
                Console.WriteLine("\nCurrent State: " + _currentState);
                break;

            }
            
            
            
        }

        if (cstate == _currentState)
        {
            Console.WriteLine("invalid transition");
        }
            
         
    }
}

