using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawn : MonoBehaviour
{
    public GameObject obstacle;
    public float frequency = 1;
    private void Start()
    {
        InvokeRepeating("SpawnRocks", 1, frequency);
    }
    void SpawnRocks()
    {
        Vector3 randomPos = new Vector3(transform.position.x, Random.Range(-2, 2), transform.position.z);
        Instantiate(obstacle, randomPos, transform.rotation);
    }
}
