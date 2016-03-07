//using UnityEngine;
//using System.Collections;


//public enum State
//{
//    INIT,
//    RUNNING,
//    PAUSED
//}

//public class TeacherTest : MonoBehaviour {


//    FiniteStateMachine _fsm;
//    // Use this for initialization
//    void Start ()
//    {
//        _fsm = new FiniteStateMachine();
//        _fsm.transition(State.INIT, State.PAUSED);
//        _fsm.transition(State.PAUSED, State.RUNNING, "unpause");
//        _fsm.transition(State.PAUSED, State.RUNNING, "pause");
//        _fsm.Start();

//    }
	
//	// Update is called once per frame
//	void Update ()
//    { 
//	  if(Input.GetKeyDown(KeyCode.Escape))
//        {
//            if(_fsm.Feed("pause"))
//            {
//                Debug.Log(_fsm.current);
//            }
//        }
//	}
//}
