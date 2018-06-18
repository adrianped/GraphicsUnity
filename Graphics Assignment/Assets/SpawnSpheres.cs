using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpheres : MonoBehaviour {

    public GameObject SpherePrefab;
    public Transform SpawnPoint;

    private void Start()
    {
    
    }

    public void spawnObject()
    {
        Instantiate(SpherePrefab, SpawnPoint.position + Random.insideUnitSphere * 10, Quaternion.identity);
    }

}
