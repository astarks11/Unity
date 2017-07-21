using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSomethingHappen : MonoBehaviour {

    public GameObject door;

    // Use this for initialization
    void Start () {
        GameObject.FindObjectOfType<CapsuleCollider>().isTrigger = true;
        }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        // works if istrigger is marked
        door.GetComponent<Move>().activateGate();

    }


}
