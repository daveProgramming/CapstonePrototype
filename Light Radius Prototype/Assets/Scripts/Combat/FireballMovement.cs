using UnityEngine;
using System.Collections;

public class FireballMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AddForceToFireball ();
		DestroyFireball ();
	}
	
	void AddForceToFireball()
	{
		transform.Translate(Vector3.forward * 30 * Time.deltaTime);
	}
	
	void DestroyFireball()
	{
		Destroy (gameObject, 0.30f);
	}
}