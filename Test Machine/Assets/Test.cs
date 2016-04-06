using UnityEngine;
using System.Collections;
using FiniteStateMachine;
using Adgp125_Assessment_Library;

public class Test : MonoBehaviour {

    public enum e_GameStates
    {
        Init,
        Idle,
        Walk,
        Run
    }

    FiniteStateMachine<e_GameStates> fsm = new FiniteStateMachine<e_GameStates>();

    // Use this for initialization
    void Start ()
    {
        Handler idleState = idle;
        Handler walkState = walk;
        Handler runState = run;

        fsm.State(e_GameStates.Init, null);
        fsm.State(e_GameStates.Idle, idleState);
        fsm.State(e_GameStates.Idle, idleState);
        fsm.State(e_GameStates.Walk, walkState);
        fsm.State(e_GameStates.Run, runState);

        fsm.AddTransition(e_GameStates.Init, e_GameStates.Idle, "auto");
        fsm.AddTransition(e_GameStates.Idle, e_GameStates.Walk, "walk");
        fsm.AddTransition(e_GameStates.Walk, e_GameStates.Run, "run");
        fsm.AddTransition(e_GameStates.Run, e_GameStates.Walk, "slowdown");
        fsm.AddTransition(e_GameStates.Walk, e_GameStates.Idle, "stop");

        fsm.Feed("auto");
    }
	

	// Update is called once per frame
	void Update ()
    {
	 if(Input.GetKeyDown(KeyCode.A))
        {
            fsm.Feed("walk");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            fsm.Feed("run");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            fsm.Feed("slowdown");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            fsm.Feed("stop");
        }
    }

    public void walk()
    {
        Debug.Log("I am walking");
    }

    public void run()
    {
        Debug.Log("I am running");
    }

    public void idle()
    {
        Debug.Log("I am idle");
    }
}
