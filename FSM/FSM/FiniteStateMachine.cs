using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FiniteStateMachine
{

    class Transition
    {

        public Enum from;
        public Enum to;
       
        public Transition(Enum f, Enum t)
        {
            from = f;
            to = t;
        }

    }

    public Enum _currentState;
    private List<Enum> _states;
    private List<Transition> tlist = new List<Transition>();
    private Dictionary<Enum, List<Transition>> Transitiontable = new Dictionary<Enum, List<Transition>>();
  
    public FiniteStateMachine(Enum sta)
    {
        _states = new List<Enum>();
        _currentState = sta;
    }

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

    public void Addtransition(Enum s1, Enum s2)
    {
        //If dictionary is empty..
        if(Transitiontable.Count == 0)
        {
            Transition t = new Transition(s1, s2);
            tlist.Add(t);
            Transitiontable.Add(s1, tlist);
        }
        //If dictionary is not empty
        else
        {//check if current key is already in the dictionary
            if (Transitiontable.ContainsKey(s1))
            {//If it is then just add to the current list in that key
                Transition t = new Transition(s1, s2);
                Transitiontable[s1].Add(t);
            }
            //If key does not exist then make it
            else
            {
                Transition t = new Transition(s1, s2);
                tlist.Add(t);
                Transitiontable.Add(s1, tlist);
            }

        }

    }

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
            Console.WriteLine(i.Key.ToString());
        }
    }

    public void ChangeStates(Enum a)
    {
        //need the list of transitions that are associated with the key
        //Check if the state passed in is same as currentState 
        if (_currentState == a)
        {
            Console.WriteLine("You are already in that state!");

        }
        //If the currentState is not in the passed in state
        else
        {//Loop through dictionary's keys
            foreach (Enum e in Transitiontable.Keys)
            {//for each key check if its equal to the passed in state
                if (e == a)
                { //Then transition to that state
                    _currentState = e;
                }
            }

        }

        Console.WriteLine("\nCurrent State: " + _currentState);
    }

}
