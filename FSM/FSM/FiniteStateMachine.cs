using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FiniteStateMachine
{
    //Transiton Class
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
    public void Addtransition(Enum s1, Enum s2)
    {
        //If dictionary is empty..
        if(Transitiontable.Count == 0)
        {//Creat a new transition
            Transition t = new Transition(s1, s2);
            //Add the transition to the list
            tlist.Add(t);
            //Add the key and value to the dictionary
            Transitiontable.Add(s1, tlist);
        }
        //If dictionary is not empty
        else
        {//check if current key is already in the dictionary
            if (Transitiontable.ContainsKey(s1))
            {//If it is then create another transition
                Transition t = new Transition(s1, s2);
                //then just add the transition to the current list in that key
                Transitiontable[s1].Add(t);
            }
            //If key does not exist then make it
            else
            {//Create a new transition
                Transition t = new Transition(s1, s2);
                //Add the transition to the list
                tlist.Add(t);
                //Add the key and value to the dictionary
                Transitiontable.Add(s1, tlist);
            }

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
        //need the list of transitions that are associated with the key
        //Check if the state passed in is same as currentState 
        if (_currentState != a)
        {
            //Loop through dictionary's keys
            foreach (Enum e in Transitiontable.Keys)
            {//for each key check if its equal to the passed in state
                if (e == a)
                { //Then transition to that state
                    _currentState = e;
                }
                else
                {
                    Console.WriteLine("Key does not exist");
                }
            }
        }
        //If the currentState is not in the passed in state
        else
        {
            Console.WriteLine("You are already in that state!");
        }

        //_currentState = a;
        Console.WriteLine("\nCurrent State: " + _currentState);
    }

}
