

using UnityEngine;

public class IdleState : State
{
    // constructor
    public IdleState( Player player, StateMachine sm) : base(player, sm)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("entering idle state");
        player.Color(0.5f, 0.8f, 0.7f);
    }

    public override void Exit()
    {
        base.Exit();
    }


    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (Input.GetKeyDown("r"))
        {
            sm.ChangeState(player.runState);
        }
        if (Input.GetKeyDown("j"))
        {
            sm.ChangeState(player.jumpState);

        }
        UIscript.ui.DrawText("*This is the idle script*");
       
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
