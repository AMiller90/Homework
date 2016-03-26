using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//State class used for creating a state object
public class State
{
    //Name of the Enum
    public Enum name;

    //Create a delegate for storing functions 
    public Delegate del;

    //Default constructor
    public State()
    {

    }

    //State constructor - (Enum - used for naming the state, Delegate - Parameter user can use to pass in a delegate to the state object)
    public State(Enum stateName, Delegate stateHandler)
    {//Set name equal to passed in enum
        name = stateName;
        //Set delegate equal to the passed in delegate
        del = stateHandler;
    }
 
    //Public function used to handle functionality of a delegate
    public bool Handler()
    {//If the delegate is not equal to null..
        if (del != null)
        {//Create a handler object
            Handler h;
            //Set the h variable to the class delegate type casted as a Handler object
            h = del as Handler;
            //Call the delegate and activate functions
            h();
            //return true
            return true;
        }
        //return false
        return false;
    }

}

//Transition Class used for creating transition objects
public class Transition
{
    //Public string variable used for the input to activate a transition
    public string input
    {
        get;
        private set;
    }

    //Public state variable that will be used for the destination state to transition to
    public State destination
    {
        get;
        private set;
    }

    //Transition constructor - (string - variable used for the input to transition, State - state to transition to 
    public Transition(string token, State t)
    {
        //Set input variable to passed in string variable
        input = token;
        //Set destination to passed in state
        destination = t;
    }

}
//FSM Class<T> - Generic
public class FiniteStateMachine<T>
{
    //Current state
    private State currentState
    {
        get;
        set;
    }

    //List of states
    private List<State> _states;

    //Dictionary containing Generic keys and List of transitions for values
    private Dictionary<Enum, List<Transition>> Transitiontable;

    //Constructor
    public FiniteStateMachine()
    {
        //Initialize dictionary
        Transitiontable = new Dictionary<Enum, List<Transition>>();
        //Initialize List
        _states = new List<State>();

        //Store States in list and dictionary
        AddStates();
        
    }
    
    //Function used to activate fsm functionality - Parameter takes in a generic type used to activate transitions
    public bool Feed<V>(V token)
    {//Loop through the transitons in the current key of the dictionary
        foreach (Transition t in Transitiontable[currentState.name])
        {//If the transition input variable is equal to the passed in variable 
            if (t.input == token.ToString())
            {//Set the current state to the destination state 
                currentState = t.destination;
                //Activate the functions in current state 
                currentState.Handler();
                //return true
                return true;
            }
        }

        return false;
    }

    //Function for creating a state (T - Generic passed in variable will be the state, Delegate - passed in delegate variable)
    public bool State(T s1, Delegate deleg)
    {//Type cast passed in s1 variable as an enum 
        Enum nState = s1 as Enum;
        //Create an instance of an empty state object
        State newState = new State();
       
        //Loop through the list of states
        foreach (State s in _states)
        {//If the states name is the same as the passed in variable 
            if(s.name.ToString() == nState.ToString())
            {//Then set the state to the newState object that was created
                newState = s;
                //Then break out of loop because we only need the first match
                break;
            }
        }
        //Set the states delegate to the passed in delegate variable
        newState.del = deleg;

        return true;
    }

    //Function that adds states to the list and dictionary
    private void AddStates()
    {//If the type of the passed in parameter to the FSM is an Enum
        if(typeof(T).IsEnum)
        {//Loop through the Enums that are listed by the user
            foreach(T states in Enum.GetValues(typeof(T)))
            {//Create a state object and set the first paramater as a type casted enum and the second parameter to null
                State state = new State(states as Enum, null);
                //Add the state to the list of states
                _states.Add(state);
                //Add the state name tothe dictionary as a key and add a new List o transitions to the key
                Transitiontable.Add(state.name, new List<Transition>());
            }
            //Initialize current state to first state in list at creation of fsm
            currentState = _states[0];
        }
        else
        {//Print out that the type is not an enum
            Console.WriteLine("Error! " + typeof(T) + " is not of type Enum");
        }
        
        
    }

    //Function that adds the transition from and to a state by an input - (Generic parameter for form state, Generic parameter for to state, and Generic type for input of how to transition)
    public bool AddTransition<V>(T from, T to, V input)
    {
        //Type cast the from variable and store it into a new Enum variable
        Enum f = from as Enum;
        //Type cast the to variable and store it into a new Enum variable
        Enum t = to as Enum;

        //Create an instance of an empty state object
        State destination = new State();

        //Loop through the list of states
        foreach (State s in _states)
        {//If the states name is the same as the passed in variable 
            if (s.name.ToString() == t.ToString())
            {//Then set the state to the newState object that was created
                destination = s;
                //Then break out of loop because we only need the first match
                break;
            }
        }
        //If the dictionary contains the key
        if (Transitiontable.ContainsKey(f))
        {//Create a new transition with the input parameter passed in and the destination parameter set to the passed in to variable
            Transition transition = new Transition(input.ToString(), destination);
            //Add the transition to the key in the dictionary
            Transitiontable[f].Add(transition);
        }
        //If the dictionary does not contain the key
        else
        {//Print out the state does not exist
            Console.WriteLine("State does not exist!");

        }
        //return true
        return true;
    }
}