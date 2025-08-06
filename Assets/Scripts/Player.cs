
using UnityEngine;

public class Player : MonoBehaviour
{

    public StateMachine sm;

    //declare all states here
    public IdleState idleState;
    public JumpState jumpState;
    public RunState runState;

    private SpriteRenderer sr;

    
    //LevelManager lm;
    public LevelManager lm;


    private void Start()
    {
        lm = LevelManager.lm;
        sm = new StateMachine();
        sr = GetComponent<SpriteRenderer>();

        //initialise all states here
        idleState = new IdleState(this, sm);
        jumpState = new JumpState(this, sm);
        runState = new RunState(this, sm);

        sm.Init(idleState); //this will be the first state to run 

    }

    private void Update()
    {
        sm.CurrentState.LogicUpdate();

        UIscript.ui.DrawText("Current state=" + sm.CurrentState );
        UIscript.ui.DrawText("Last state=" + sm.LastState );
        UIscript.ui.DrawText("Press I, J or R to change to idle, jump or run states");

    }

    private void FixedUpdate()
    {
        sm.CurrentState.PhysicsUpdate();
    }


    public void Color( float r, float g, float b)
    {
        sr.color = new Color(r, g, b);
        Debug.Log("Setting color to " + r + " " + g + " " + b);
    }

}
