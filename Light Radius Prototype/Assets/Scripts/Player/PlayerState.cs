using UnityEngine;
using System.Collections;

public abstract class PlayerState
{

    // Lol realized that this is like a C++ header file.

    public PlayerState() { }
    public virtual PlayerState handleInput(Player player, Input input)
    {
        return this;
    }
    public virtual void update(Player player) { }
    public virtual void Enter(Player player) { }

    // public static MoveState moving; // standing, sitting, dashing, walking, running
    // public static AttackState attacking; // slashing, firing

    public static StandingState standing;
    public static SittingState sitting;
    public static DashingState dashing;
    public static WalkingState walking;
    public static RunningState running;
    public static SlashingState slashing;
    public static FiringState firing;

    public static HealState healState;
    public static ChargeState chargeState;
}

public class MoveState : PlayerState
{
    public override void Enter(Player player)
    {
        //player.setGraphics(Image_Standing);
    }
}

public class AttackState : PlayerState
{
    public override void Enter(Player player)
    {
        //player.setGraphics(Image_Standing);
    }

    public override PlayerState handleInput(Player player, Input input)
    {
        if (Input.GetKeyUp(KeyCode.Space)) // Player has to hold Down on d-pad to sit/heal.
        {
            // player.setGraphics(Image_Standing); // Change to standing state
            return new StandingState(); // REALLY Change to standing state
        }
        else
        {
            return this; // Maintain state
        }
    }
}

public class StandingState : MoveState
{
	public override void Enter(Player player)
    {
        //player.setGraphics(Image_Standing);
    }

    public override PlayerState handleInput(Player player, Input input)
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        //if (Input.GetAxis("7") == -1 ) // Down on d-pad
        {
            //player.state_ = sitting;
            return new SittingState(); // Enter Sitting state
        }
        else if (Input.GetMouseButtonDown(0)) // Left Click to Slash
        // else if (Input.GetButtonDown("X")) 
        {
            return new SlashingState();
        }
        else if (Input.GetMouseButtonDown(1)) // Right click to Fireball
        // else if (Input.GetButtonDown("B"))
        {
            return new FiringState();
        }
        else if (Input.GetKeyDown(KeyCode.Space)) // Space to Dash
        // else if (Input.GetButtonDown("A"))
        {
            return new DashingState();
        }
        else if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            return new WalkingState(); // Move to move
        }
        else
        {
            return this; // Maintain state
        }
    }
}

public class SittingState : MoveState
{ 

    public override void Enter(Player player)
    {
        // player.setGraphics(Image_Sitting);
    }

    public override PlayerState handleInput(Player player, Input input)
    {
        if (Input.GetKeyUp(KeyCode.LeftControl)) // Player has to hold Down on d-pad to sit/heal.
        {
            // player.setGraphics(Image_Standing); // Change to standing state
            return new StandingState(); // REALLY Change to standing state
        }
        else if (Input.GetMouseButtonDown(1))
        {
            return new FiringState();
        }
        else
        {
            return this; // Maintain state
        }
    }

    public virtual void Update(Player player)
    {
        
    }
}

public class WalkingState : MoveState
{
	public override void Enter(Player player)
    {
        // player.setGraphics(Image_Walking);
    }
}

public class DashingState : MoveState
{
	public override void Enter(Player player)
    {
        // player.setGraphics(Image_Dashing);
    }
}

public class RunningState : MoveState
{
	public override void Enter(Player player)
    {
        // player.setGraphics(Image_Running);
    }
}

public class SlashingState : AttackState
{
	public override void Enter(Player player)
    {
        // player.setGraphics(Image_Slashing);
    }
}

public class FiringState : AttackState
{
	public override void Enter(Player player)
    {
       // player.setGraphics(Image_Firing);
    }
}

public class ChargeState
{
    public virtual ChargeState handleInput(Player player, Input input)
    {
        return this;
    }

    public virtual void Enter(Player player)
    {
        //player.setGraphics(Image_Standing);
    }
}

class Charging : ChargeState
{
    public override void Enter(Player player)
    {
        // player.setGraphics(Image_Charging);
    }
}

class NotCharging : ChargeState
{
    public override void Enter(Player player)
    {
        //player.setGraphics(Image_Standing);
    }
}

public class HealState
{
    double HealRate = 37.5;

    public virtual HealState handleInput(Player player, Input input)
    {
        return this;
    }

    public virtual void Enter(Player player)
    {
        //player.setGraphics(Image_Standing);
    }
}

class Healing : HealState
{
    public override void Enter(Player player)
    {
        //player.setGraphics(Image_Standing);
    }
}

class NotHealing : HealState
{
    public override void Enter(Player player)
    {
        //player.setGraphics(Image_Standing);
    }
}
