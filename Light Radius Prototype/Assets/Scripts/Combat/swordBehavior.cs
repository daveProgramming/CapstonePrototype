﻿using UnityEngine;
using System.Collections;

public class swordBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown("space"))
    {
        transform.Rotate(new Vector3(1,0,0), 90);
    }
	}
}
