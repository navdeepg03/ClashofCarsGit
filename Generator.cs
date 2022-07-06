using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public Camera cam;
    public GameObject item;
    public float generationRate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate", 3, generationRate);  
    }
     
    // Update is called once per frame
    void FixedUpdate()
    {
        
    } 

    public void Generate() 
    {
        const float yVal = -2f; 
        const float x_min = -48f;
        const float x_max = 48;
        const float z_min = -33;   
        const float z_max = 60;

        Vector3 enemySpawnPosition = new Vector3(Random.Range(x_min, x_max), yVal, Random.Range(z_min, z_max));

        Vector3 positionToGenerate = cam.WorldToViewportPoint(enemySpawnPosition);
        bool inCameraScope = positionToGenerate.z > 0 && positionToGenerate.x > 0 && positionToGenerate.x < 1 && positionToGenerate.y > 0 && positionToGenerate.y < 1;

        if(!inCameraScope)
        {
            Instantiate(item, enemySpawnPosition, Quaternion.identity); 
        }
    }
}
