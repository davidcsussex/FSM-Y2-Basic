

public abstract class State
{
    protected Player player;
    protected StateMachine sm;

    // base constructor
    protected State(Player player, StateMachine sm)
    {
        this.player = player;
        this.sm = sm;
    }

    public virtual void Enter()
    {
    }

    public virtual void LogicUpdate()
    {
    }

    public virtual void PhysicsUpdate()
    {
    }

    public virtual void Exit()
    {
    }

}
