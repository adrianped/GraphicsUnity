using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnSpheres : MonoBehaviour {

    //Grabs Sphere Prefab gameobject
    public GameObject SpherePrefab;
    //Grabs SpawnPoint transform
    public Transform SpawnPoint;
    //Grabs Material
    public Material Mat;
    //Grabs Slider
    public Slider Transparency;


    public void Update()
    {
        //Set Transparency Float value
        Mat.SetFloat("_Transparency", Transparency.value);
    }

    public void spawnObject()
    {
        //Adds Spheres in random spots around unit sphere
        Instantiate(SpherePrefab, SpawnPoint.position + Random.insideUnitSphere * 10, Quaternion.identity);
    }

}
