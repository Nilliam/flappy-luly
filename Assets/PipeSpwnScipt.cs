using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpwnScipt : MonoBehaviour
{

    public GameObject pipe;

    public float spawnRate = 2;

    private float timer = 0;

    public float heightOffset = 8;

    void Start()
    {
        spawnPipe();
    }

    
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    private void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);   
    }
}
