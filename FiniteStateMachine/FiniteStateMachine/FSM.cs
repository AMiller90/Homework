using System;
using System.Collections.Generic;
using System.Text;

namespace FiniteStateMachine
{
    //Handles the function calls 
    public delegate void Handler();

    //State class used for creating a state object
    //[Serializable]
    public class State
    {
        //Name of the Enum
        public Enum eName;

        //Create a delegate for storing functions 
        public Delegate dDel;

        //Default constructor
        public State()
        {

        }

        //State constructor - (Enum - used for naming the state, Delegate - Parameter user can use to pass in a delegate to the state object)
        public State(Enum a_eStateName, Delegate a_dStateHandler)
        {//Set name equal to passed in enum
            eName = a_eStateName;
            //Set delegate equal to the passed in delegate
            dDel = a_dStateHandler;
        }

        //Public function used to handle functionality of a delegate
        public bool Handler()
        {//If the delegate is not equal to null..
            if (dDel != null)
            {//Create a handler object
                Handler h;
                //Set the h variable to the class delegate type casted as a Handler object
                h = dDel as Handler;
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
        //Public string variable used for the sInput to activate a transition
        public string sInput
        {
            get;
            private set;
        }

        //Public state variable that will be used for the sDestination state to transition to
        public State sDestination
        {
            get;
            private set;
        }

        //Transition constructor - (string - variable used for the sInput to transition, State - state to transition to 
        public Transition(string a_sToken, State a_sT)
        {
            //Set sInput variable to passed in string variable
            sInput = a_sToken;
            //Set sDestination to passed in state
            sDestination = a_sT;
        }

    }

    //FSM Class<T> - Generic
    [Serializable]
    public class FiniteStateMachine<T>
    {
        //Current state
        public State sCurrentState
        {
            get;
            private set;
        }

        //List of states
        private List<State> m_lsStates;

        //Dictionary containing Generic keys and List of transitions for values
        private Dictionary<Enum, List<Transition>> m_dTransitionTable;

        //Constructor
        public FiniteStateMachine()
        {
            //Initialize dictionary
            m_dTransitionTable = new Dictionary<Enum, List<Transition>>();
            //Initialize List
            m_lsStates = new List<State>();

            //Store States in list and dictionary
            AddStates();

        }

        //Function used to activate fsm functionality - Parameter takes in a generic type used to activate transitions
        public bool Feed<V>(V a_vToken)
        {//Loop through the transitons in the current key of the dictionary
            foreach (Transition t in m_dTransitionTable[sCurrentState.eName])
            {//If the transition sInput variable is equal to the passed in variable 
                if (t.sInput == a_vToken.ToString())
                {//Set the current state to the sDestination state 
                    sCurrentState = t.sDestination;
                    //Activate the functions in current state 
                    sCurrentState.Handler();
                    //return true
                    return true;
                }
            }
            //Return false
            return false;
        }

        //Function for creating a state (T - Generic passed in variable will be the state, Delegate - passed in delegate variable)
        public bool State(T a_tS1, Delegate deleg)
        {//Type cast passed in a_tS1 variable as an enum 
            Enum nState = a_tS1 as Enum;
            //Create an instance of an empty state object
            State sNewState = new State();

            //Loop through the list of states
            foreach (State s in m_lsStates)
            {//If the states name is the same as the passed in variable 
                if (s.eName.ToString() == nState.ToString())
                {//Then set the state to the sNewState object that was created
                    sNewState = s;
                    //Then break out of loop because we only need the first match
                    break;
                }
            }
            //Set the states delegate to the passed in delegate variable
            sNewState.dDel = deleg;
            //Return true
            return true;
        }

        //Function that adds states to the list and dictionary
        private void AddStates()
        {//If the type of the passed in parameter to the FSM is an Enum
            if (typeof(T).IsEnum)
            {//Loop through the Enums that are listed by the user
                foreach (T states in Enum.GetValues(typeof(T)))
                {//Create a state object and set the first paramater as a type casted enum and the second parameter to null
                    State sState = new State(states as Enum, null);
                    //Add the state to the list of states
                    m_lsStates.Add(sState);
                    //Add the state name tothe dictionary as a key and add a new List o transitions to the key
                    m_dTransitionTable.Add(sState.eName, new List<Transition>());
                }
                //Initialize current state to first state in list at creation of fsm
                sCurrentState = m_lsStates[0];
            }
            //If type is not an enum
            else
            {//Print out that the type is not an enum
                Console.WriteLine("Error! " + typeof(T) + " is not of type Enum");
            }


        }

        //Function that adds the transition from and to a state by an sInput - (Generic parameter for form state, Generic parameter for to state, and Generic type for sInput of how to transition)
        public bool AddTransition<V>(T a_tFrom, T a_tTo, V a_vInput)
        {
            //Type cast the from variable and store it into a new Enum variable
            Enum eF = a_tFrom as Enum;
            //Type cast the to variable and store it into a new Enum variable
            Enum eT = a_tTo as Enum;

            //Create an instance of an empty state object
            State sDestination = new State();

            //Loop through the list of states
            foreach (State s in m_lsStates)
            {//If the states name is the same as the passed in variable 
                if (s.eName.ToString() == eT.ToString())
                {//Then set the state to the sNewState object that was created
                    sDestination = s;
                    //Then break out of loop because we only need the first match
                    break;
                }
            }
            //If the dictionary contains the key
            if (m_dTransitionTable.ContainsKey(eF))
            {//Create a new transition with the sInput parameter passed in and the sDestination parameter set to the passed in to variable
                Transition transition = new Transition(a_vInput.ToString(), sDestination);
                //Add the transition to the key in the dictionary
                m_dTransitionTable[eF].Add(transition);
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
}
