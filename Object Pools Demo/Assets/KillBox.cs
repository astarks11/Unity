using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour {

    BoxCollider boxCollider;
    Transform transform;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
        transform = GetComponent<Transform>();
    }
    private void Start()
    {
        boxCollider.isTrigger = true;
        boxCollider.size.Set(1000, 100, 1000);
        transform.position.Set(0, -60, 0);
    }

    
}
