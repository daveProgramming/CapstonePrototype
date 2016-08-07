using UnityEngine;
using System.Collections;

public class ShootFireball : MonoBehaviour {

	public GameObject _Fireball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ShootFireballs ();
	}

	void ShootFireballs()
	{
		if(Input.GetMouseButtonDown(2))
		{
			Instantiate(_Fireball, transform.position, transform.rotation);

			//Vector3 fwd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}
}
