using System;
using System.Collections.Generic;


    public delegate void Handler();

    public class State : IStates
    {
        private Enum name;

        private Delegate del;

        public Enum sName
        {
            get
            {
                return name;
            }

            set
            {
                name = sName;
            }
        }

        public Delegate dDel
        {
            get
            {
                return del;
            }

            set
            {
                del = value;
            }
        }

        public State()
        {

        }

        public State(Enum a_eStateName, Delegate a_dStateHandler)
        {
            name = a_eStateName;
            del = a_dStateHandler;
        }

    ///<summary>
    ///Funciton that will handle execution of the delegate in a state
    ///<para></para>
    ///</summary>
    public bool Handler()
        {
            if (dDel != null)
            {
                Handler h;
                h = dDel as Handler;
                h();
                return true;
            }
            return false;
        }
    }

    public class Transition
    {
    public string sInput
    {
        get;
        private set;
    }

    public State sDestination
    {
        get;
        private set;
    }

    public Transition(string a_sToken, State a_sT)
    {
        sInput = a_sToken;
        sDestination = a_sT;
    }
}

    public class FiniteStateMachine<T>
    {

    ///<summary>
    ///The handler object used to store functions that can be used with a state
    ///<para></para>
    ///</summary>
    public delegate void Handler();

    ///<summary>
    ///Property used to get and set the current state of the machine
    ///<para></para>
    ///</summary>
    public State sCurrentState
        {
            get;
            private set;
        }

    private List<State> m_lsStates;

    private Dictionary<Enum, List<Transition>> m_dTransitionTable;

    public FiniteStateMachine()
        {
            m_dTransitionTable = new Dictionary<Enum, List<Transition>>();
            m_lsStates = new List<State>();

            AddStates();

        }

    ///<summary>
    ///Function used to feed a value into the machine so it can transition between states
    ///<para></para>
    ///<remarks><paramref name=" a_vToken"></paramref> -The value to feed to the machine to transition</remarks>
    ///<para></para>
    ///</summary>
    public bool Feed<V>(V a_vToken)
        {
            foreach (Transition t in m_dTransitionTable[sCurrentState.sName])
            {
                if (t.sInput == a_vToken.ToString())
                {
                    sCurrentState = t.sDestination;
                    sCurrentState.Handler();
                    return true;
                }
            }
            return false;
        }

    ///<summary>
    ///Function that creates a state and sets a delegate to it
    ///<para></para>
    ///<remarks><paramref name="a_tS1 "></paramref> -The State to Create</remarks>
    ///<para></para>
    ///<remarks><paramref name="deleg"></paramref> -The Delegate to give the State</remarks>
    ///<para></para>
    ///</summary>
    public bool State(T a_tS1, Delegate deleg)
        {
            Enum nState = a_tS1 as Enum;
            State sNewState = new State();

            foreach (State s in m_lsStates)
            {
                if (s.sName.ToString() == nState.ToString())
                {
                    sNewState = s;
                    break;
                }
            }
            sNewState.dDel = deleg;
            return true;
        }

    ///<summary>
    ///Function that add states to the list and dictionary
    ///<para></para>
    ///</summary>
    private void AddStates()
        {
            if (typeof(T).IsEnum)
            {
                foreach (T states in Enum.GetValues(typeof(T)))
                {
                    State sState = new State(states as Enum, null);
                    m_lsStates.Add(sState);
                    m_dTransitionTable.Add(sState.sName, new List<Transition>());
                }
                sCurrentState = m_lsStates[0];
            }
            else
            {
                Console.WriteLine("Error! " + typeof(T) + " is not of type Enum");
            }


        }

    ///<summary>
    ///Function that adds a transition from one state to another
    ///<para></para>
    ///<remarks><paramref name="a_tFrom "></paramref> -The State to transition from</remarks>
    ///<para></para>
    ///<remarks><paramref name="a_tTo"></paramref> -The State to transition to</remarks>
    ///<para></para>
    ///<remarks><paramref name="a_vInput"></paramref> -The input used to make the transition</remarks>
    ///<para></para>
    ///</summary>
    public bool AddTransition<V>(T a_tFrom, T a_tTo, V a_vInput)
        {
            Enum eF = a_tFrom as Enum;
            Enum eT = a_tTo as Enum;

            State sDestination = new State();

            foreach (State s in m_lsStates)
            {
                if (s.sName.ToString() == eT.ToString())
                {
                    sDestination = s;
                    break;
                }
            }

            if (m_dTransitionTable.ContainsKey(eF))
            {
                Transition transition = new Transition(a_vInput.ToString(), sDestination);
                m_dTransitionTable[eF].Add(transition);
            }
            else
            {
                Console.WriteLine("State does not exist!");

            }
            return true;
        }
    }
