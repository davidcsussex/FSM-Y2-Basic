

using UnityEngine;

public class JumpState : State
{
    protected float speed;
    protected float rotationSpeed;

    private float horizontalInput;
    private float verticalInput;

    public JumpState(Player player, StateMachine sm) : base(player, sm)
    {
    }

    public override void Enter()
    {
        base.Enter();
        //    horizontalInput = verticalInput = 0.0f;
        Debug.Log("entering jumping state");

        player.Color(0.8f, 0.3f, 0.4f);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown("i"))
        {
            sm.ChangeState(player.idleState);

        }

        if (Input.GetKeyDown("r"))
        {
            sm.ChangeState(player.runState);
        }

        UIscript.ui.DrawText("*This is the jumping script*");

    }

    public override void PhysicsUpdate()
    {
            base.PhysicsUpdate();
    }
}
