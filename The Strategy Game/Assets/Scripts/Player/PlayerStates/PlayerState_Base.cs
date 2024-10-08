using UnityEngine;
using UnityEngine.InputSystem;

public abstract class PlayerState_Base
{
    public abstract void EnterState(PlayerController controller);
    public abstract void ExitState(PlayerController controller);

    public virtual void FrameUpdate(PlayerController controller)
    {

    }

    public virtual void PhysicsUpdate(PlayerController controller)
    {

    }

    public virtual void OnMove(PlayerController controller, InputAction.CallbackContext ctx)
    {

    }

    public virtual void OnButtonSouth(PlayerController controller, InputAction.CallbackContext ctx)
    {

    }

    public virtual void OnButtonWest(PlayerController controller, InputAction.CallbackContext ctx)
    {

    }

    public virtual void OnButtonNorth(PlayerController controller, InputAction.CallbackContext ctx)
    {

    }

    public virtual void OnButtonEast(PlayerController controller, InputAction.CallbackContext ctx)
    {

    }

    public virtual void DrawGizmos(PlayerController controller)
    {

    }

}
