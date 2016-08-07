using UnityEngine;
using System.Collections.Generic;


public class Player : MonoBehaviour
{

    public List<FireSource> FireList;
    public bool nextToFire;
    public bool isSitting;

    public PlayerState state_;
    public HealState heal_;
    public ChargeState charge_;
    //public static MoveState moving; // standing, sitting, dashing, walking, running
    //public static AttackState attacking; // slashing, firing

        //Top-down isometric smash

    enum State
    {
        State_Standing,
        State_Walking,
        State_Dashing,
        State_Running,
        State_Slashing,
        State_Firing,
        State_Sitting,

        State_DashSlash,
        State_DashFireball,
    };

    void HandleInput(Input input)
    {
        heal_.handleInput(this, input);
        charge_.handleInput(this, input);

        PlayerState state = state_.handleInput(this, input);
        if (state != null)
        {
            state_ = state;
            state_.Enter(this);
        }


        /*
        switch (State)
        {
            case State_Standing:
                if (input == Press_A) // Dash Maneuver
                {
                    State = State_Dashing;
                    velocity = DashVelocity();
                    setGraphics(Image_Dash);
                }

                else if (input == Press_X) // Slash Attack
                {
                    State = State_Slashing;
                    setGraphics(Image_Slash);
                }
                else if (input == Press_B) // Fireball
                {
                    State = State_Firing;
                    setGraphics(Image_Firing);
                }
                else if (input == D - Pad_Down) // Sit
                {
                    State = State_Sitting;
                    setGraphics(Image_Sitting);
                }
                break;

            case State_Dashing:
                if (input == Press_X) // Dash Attack
                {
                    State = State_DashSlash;
                    setGraphics(Image_DashSlash);
                }
                else if (input == Press_B) // Dash Fireball
                {
                    State = State_DashFireball;
                    setGraphics(Image_DashFireball);
                }
                else if (input == Hold_A) // Dash into Run
                {
                    State = State_Running;
                    setGraphics(Image_Running)
    
             }
                break;

            case State_Walking:
                if (input == Release_Stick)
                {
                    State = State_Standing;
                    setGraphics(Image_Stand);
                }
                else if (input == Press_A) // Dash Maneuver
                {
                    State = State_Dashing;
                    velocity = DashVelocity();
                    setGraphics(Image_Dash);
                }

                else if (input == Press_X) // Slash Attack
                {
                    State = State_Slashing;
                    setGraphics(Image_Slash);
                }
                else if (input == Press_B) // Fireball
                {
                    State = State_Firing;
                    setGraphics(Image_Firing);
                }
                else if (input == D - Pad_Down) // Sit
                {
                    State = State_Sitting;
                    setGraphics(Image_Sitting);
                }

                break;

            case State_Running:
                if (input == Release_A)
                {
                    State = State_Walking;
                    setGraphics(Image_Walking);
                }
                else if (input == Release_Stick)
                {
                    State = State_Standing;
                    setGraphics(Image_Standing);
                }
                else if (input == Press_X) // Slash Attack
                {
                    State = State_Slashing;
                    setGraphics(Image_Slash);
                }
                else if (input == Press_B) // Fireball
                {
                    State = State_Firing;
                    setGraphics(Image_Firing);
                }
                break;
                */
        }
        

    public void YaDead()
    {
        //Player dies
    }

    public void GetHearthState()
    {

       // FireList = [sphereCast for nearby Fires]


        if (FireList.Count == 0)
            {
         //       HearthType = null;
                nextToFire = false;
            }
            else
            {
       //         HearthType = [foreach (FireSource f in FireList)...HearthType = biggest one;]
			nextToFire = true;
            }
    }

    public void Update()
    {

    }

}
