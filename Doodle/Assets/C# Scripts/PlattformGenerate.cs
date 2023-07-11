using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlattformGenerate : MonoBehaviour
{
    public GameObject platformPrefab;

    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();
        for (int i =0; i<16; i++)
        {
            SpawnerPosition.x = Random.Range(-5.5f, 5.5f);
            SpawnerPosition.y += Random.Range(2.5f, 3f);

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }

   
    void Update()
    {
        
    }
}
