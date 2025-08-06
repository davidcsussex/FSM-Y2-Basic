

using UnityEngine;

public class RunState : State
{
    protected float speed;
    protected float rotationSpeed;

    private float horizontalInput;
    private float verticalInput;

    public RunState(Player player, StateMachine sm) : base(player, sm)
    {
    }

    public override void Enter()
    {
        base.Enter();
        horizontalInput = verticalInput = 0.0f;

        Debug.Log("entering running state");

        player.Color(0.8f, 0.8f, 0.2f);
    }

    public override void Exit()
    {
        base.Exit();
    }



    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (Input.GetKeyDown("i"))
        {
            sm.ChangeState(player.idleState);
        }

        if (Input.GetKeyDown("j"))
        {
            sm.ChangeState(player.jumpState);
        }

        UIscript.ui.DrawText("*This is the running script*");
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
