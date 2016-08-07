using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {


    public GameObject player;
    public CharacterController cc;
    public float speedness;
	public float friction;

    private Vector3 move;

	void Update()
    {
        if(Input.GetKey("w"))
        {
            move.x = speedness;
            move.z = speedness;
        }
		else if(Input.GetKeyUp ("w")) 
		{
			//move.x = 0;
			//move.z = 0;
			move = Vector3.zero;
		}
        if (Input.GetKey("s"))
        {
            move.x = -speedness;
            move.z = -speedness;
        }

		else if (Input.GetKeyUp ("s")) 
		{
			//move.x = 0;
			//move.z = 0;
			move = Vector3.zero;
		}

        if (Input.GetKey("a"))
        {
            move.x = -speedness;
            move.z = speedness;
        }

		else if (Input.GetKeyUp ("a")) 
		{
			//move.x = 0;
			//move.z = 0;
			move = Vector3.zero;
		}
        if (Input.GetKey("d"))
        {
            move.x = speedness;
            move.z = -speedness;
        }

		else if (Input.GetKeyUp ("d")) 
		{
			//move.x = 0;
			//move.z = 0;
			move = Vector3.zero;
		}


        cc.Move(move * Time.deltaTime);

        //transform.LookAt(transform.position + move);

    }
}
