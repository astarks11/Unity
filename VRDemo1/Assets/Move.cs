using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void activateGate()
    {

        transform.SetPositionAndRotation(new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z),this.transform.rotation);
    }
}
