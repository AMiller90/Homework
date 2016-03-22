using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FSM Class<T> - Generic
[Serializable]
public class FiniteStateMachine<T>
{
    //Transition Class
    private class Transition
    {
        //Transition from
        public T from;
        //Transition to
        public T to;

        //Transition constructor
        public Transition(T f, T t)
        {

            from = f;
            to = t;
        }

    }

    //Current state
    private T _currentState;
    //List of states
    [NonSerialized]private List<T> _states;
    //Dictionary containing Generic keys and List of transitions for values
    [NonSerialized]private Dictionary<T, List<Transition>> Transitiontable;

    //Property used to get the current state outside of the FSM and prevent from being modified from the outside
    public T state
    {
        get
        {
            return _currentState;
        }
    }

    //Constructor
    public FiniteStateMachine()
    {
        //Initialize dictionary
        Transitiontable = new Dictionary<T, List<Transition>>();
        //Initialize List
        _states = new List<T>();

    }

    //Add states to the machine
    public bool AddStates(T e)
    {
        //Check if list contains state already
        if (_states.Contains(e))
        {//If it does then prompt user that the state is already added
            Console.WriteLine("Cannot add the " + e + " state because it already exists\n");
            return false;
        }
        else
        {//If the state is not in the list then add it and add it as a new key to the dictionary
            _states.Add(e);
            Transitiontable.Add(e, new List<Transition>());
            return true;
        }

    }

    //Add transitions to list 
    //Add keys and values to dictionary
    public void Addtransition(T f, T t)
    {
        //If key exists
        if (Transitiontable.ContainsKey(f))
        {
            //Add a new transition to the current list at that key
            Transitiontable[f].Add(new Transition(f, t));

        }

    }

    //Print out info about FSM
    public void info()
    {
        Console.WriteLine("FSM is comprised of ...\n");
        int count = 1;
        //Foreach type in the list
        foreach (T s in _states)
        {
            //Print it 
            Console.WriteLine("State " + count.ToString() + " : " + s.ToString());
            //Add to the count
            count++;
        }

        //Print current state
        Console.WriteLine("\nCurrent State: " + _currentState);

    }

    //Changes states
    public void ChangeStates(T a)
    {
        //Print the current state and the state user is wanting to change to
        //Console.WriteLine("\n" + _currentState + "->" + a.ToString());

        //Dynamic variable used to store current state at runtime
        dynamic cstate = _currentState;

        if(!Transitiontable.ContainsKey(_currentState))
        {
            Console.WriteLine("That state does not exist!\n");
        }
        else
        {
            //If the key exists
            //Loop through each transition in the current key of the dictionary
            foreach (Transition t in Transitiontable[_currentState])
            {//If the transitions to variable is equal to the passed in variable
                if (t.to.Equals(a))
                {
                    //It has the valid transition
                    //Print current state transitioned from
                    //Console.Write("\nTransitioned from " + _currentState);
                    //Set current state to passed into new state
                    _currentState = a;
                    //Print the current state transitioned to
                    //Console.WriteLine(" to " + a + ".");
                    //Print out the current state
                    //Console.WriteLine("\nCurrent State: " + _currentState);
                    break;

                }

            }
            //If the variable is equal to the current state
            if (cstate == _currentState)
            {//Print invalid transition
                Console.WriteLine("invalid transition");
            }
        }
       




    }

}