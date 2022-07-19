using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSphereGenerator : MonoBehaviour
{
    public float timeToGenerate = 1;
    public GameObject SpherePrefab;

    public bool collided;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeToGenerate -= Time.deltaTime;

        if(timeToGenerate <= 0)
        {
            GenerateSpheres();
            timeToGenerate = 1;
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {

        }
    }

    


    public void GenerateSpheres()
    {
        float xRange = transform.localScale.x / 2;

        float xPosicion = Random.Range(-xRange, xRange);

        float yRange = transform.localScale.y / 2;

        float yPosicion = Random.Range(-yRange, yRange);

        float zRange = transform.localScale.z / 2;

        float zPosicion = Random.Range(-zRange, zRange);

        
        Vector3 SpherePosition = new Vector3(xPosicion, yPosicion, zPosicion);
        SpherePosition += transform.position;
        Instantiate(SpherePrefab, SpherePosition, transform.rotation);

    }
}
