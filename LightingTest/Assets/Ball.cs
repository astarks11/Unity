using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float moveSpeed = 10f;
    private Rigidbody rb;
    private Renderer rend;
    private Light light;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        light = GetComponent<Light>();

	}
	
	// Update is called once per frame
	void Update () {

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        float moveX = inputX * moveSpeed * Time.deltaTime;
        float moveZ = inputZ * moveSpeed * Time.deltaTime;

  


        // transform.Translate(moveX, 0f, moveZ);
        rb.AddForce(moveX, 0f, moveZ);

	}

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.name == "Wall1")
        {
            rend.material.color = Color.red;
            light.color = Color.red;
        }
        if (coll.collider.name == "Wall2")
        {
            rend.material.color = Color.blue;
            light.color = Color.blue;
        }
        if (coll.collider.name == "Wall3")
        {
            rend.material.color = Color.cyan;
            light.color = Color.cyan;
        }
        if (coll.collider.name == "Wall4")
        {
            rend.material.color = Color.green;
            light.color = Color.green;
        }
    }
}
