using UnityEngine;


public class StateMachine : MonoBehaviour
{
    public State CurrentState { get; private set; }
    public State LastState { get; private set; }

    public void Init(State startingState)
    {
        CurrentState = startingState;
        LastState = null;
        startingState.Enter();
    }

    public void ChangeState(State newState)
    {
        
        CurrentState.Exit();

        LastState = CurrentState;
        CurrentState = newState;
        newState.Enter();
    }

}
