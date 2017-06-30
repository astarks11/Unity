using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffSpawner : MonoBehaviour {

    public FloatRange timeBetweenSpawns, scale, rV, aV;
    public Stuff[] stuffPrefabs;
    public float velocity;
    public Material stuffMaterial;

    private float timeSinceLastSpawn;
    float currentSpawnDelay;


    private void FixedUpdate()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= currentSpawnDelay)
        {
            timeSinceLastSpawn -= currentSpawnDelay;
            currentSpawnDelay = timeBetweenSpawns.RandomInRange;
            SpawnStuff();
        }

    }

    void SpawnStuff()
    {
        Stuff prefab = stuffPrefabs[Random.Range(0, stuffPrefabs.Length)];
        Stuff spawn = Instantiate<Stuff>(prefab);
        spawn.transform.localPosition = transform.position;
        //spawn.transform.localScale = Vector3.one * scale.RandomInRange;
        spawn.transform.localRotation = Random.rotation;
        spawn.Body.velocity = transform.up * velocity + Random.onUnitSphere * rV.RandomInRange;
        spawn.Body.angularVelocity = Random.onUnitSphere * aV.RandomInRange;
       // spawn.GetComponent<MeshRenderer>().material = stuffMaterial;
        spawn.SetMaterial(stuffMaterial);
    }
}

