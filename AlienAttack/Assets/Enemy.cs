using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("hit2d");
    }
    private void OnTriggerEnter(Collider other)
    {
        print("ote");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("ote2d");
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("hit");

    }
}
