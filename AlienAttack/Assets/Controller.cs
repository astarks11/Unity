using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public float movementSpeed = 10;
    public GameObject bullet;
    public int arraySize = 10;
    int counter = 0;
    int maxHeight = 100;
    GameObject clone;
    GameObject[] array;

    // Use this for initialization
    void Start () {
        array = new GameObject[arraySize];
        if (bullet != null)
        {
            bullet.transform.SetPositionAndRotation(new Vector3(0, -10, 0), new Quaternion());
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // shoot

            if (array[counter] == null)
            {
                clone = Instantiate(bullet);
                clone.tag = "Bullet";
                clone.transform.SetPositionAndRotation(transform.position, new Quaternion());
                array[counter] = clone;
            } else
            {
                array[counter].transform.SetPositionAndRotation(transform.position, new Quaternion());
            }

            counter = (++counter % arraySize);
            
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != null)
            {
                array[i].transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
                if (array[i].transform.position.y > maxHeight)
                {
                    Destroy(array[i]);
                }

            }
        }



    }
}
