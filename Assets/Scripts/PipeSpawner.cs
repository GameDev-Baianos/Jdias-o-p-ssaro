using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float timer = 0;
    public float pipeDelay = 4;
    public float heightOff = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < pipeDelay)
        {
            timer += Time.deltaTime;
        }
        else 
        {
            spawnPipe();
            timer = 0;
        }
    }

    public void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOff;
        float highestPoint = transform.position.y + heightOff;

        Instantiate(pipe, 
            new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), 
            transform.rotation);
    }
}
