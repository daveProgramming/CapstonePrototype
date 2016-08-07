using UnityEngine;
using System.Collections;

public class SmoothMoves : MonoBehaviour {

    // NEED TO MIGRATE THIS CODE INTO THE PLAYER/PLAYERSTATE CLASSES

	public Rigidbody Avatar;
	public float speed;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movement ();

		
	}

	void movement()
	{
		Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		moveDirection = Camera.main.transform.TransformDirection (moveDirection);
		moveDirection.y = 0;

        // Reaycasting to face character
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        if (hit.collider.gameObject.tag == "terrain")
        {
            Vector3 _target = hit.point;
            _target.y += 1.0f;
            transform.LookAt(_target);
        }

		Avatar.MovePosition (Avatar.position + moveDirection * speed * Time.deltaTime);
	}

}
