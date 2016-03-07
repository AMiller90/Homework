//using UnityEngine;
//using System.Collections.Generic;

//public class FiniteStateMachine
//{

//   public class Transition
//    {

//        State source;
//        public State destination;

//        public Transition(State f, State t)
//        {
//            input = "auto";
//            source = f;
//            destination = t;
//        }

//        public Transition(State f, State t, string token)
//        {
//            input = token;
//            source = f;
//            destination = t;
//        }

//        public string input;
//    }


//   public State current;
//    List<State> states;

//   public FiniteStateMachine()
//    {
//        current = State.INIT;
//    }

//    //Add state to list
//    void addState(State state)
//    {
//        states.Add(state);
//    }

//    /// dictionary of transitions
//    Dictionary<State, Transition> transitions_table = new Dictionary<State, Transition>();

  
//    /// add a transition to the state machine
//    public void transition(State s1, State s2, string input)
//    {
//         Transition t = new Transition(s1, s2, input);
//    }

//    public void transition(State s1, State s2)
//    {
//        Transition t = new Transition(s1, s2);
//        transitions_table.Add(s1, t);
//    }

//    public bool Start()
//    {
//        Feed("auto");
//        return true;

//    }
//    public bool Feed(string token)
//    {
//       if(transitions_table[current].input == token)
//        {
           
//        }

//    }
//}
