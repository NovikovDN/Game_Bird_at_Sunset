using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGenerator : MonoBehaviour
{

    public GameObject pointPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
        Vector3 SpawnerPosition2 = new Vector3();
        for (int i = 0; i < 49; i++)
        {
            SpawnerPosition2.x = Random.Range(-4.5f, 4.5f);
            SpawnerPosition2.y += Random.Range(10f, 20f);

            Instantiate(pointPrefab, SpawnerPosition2, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
