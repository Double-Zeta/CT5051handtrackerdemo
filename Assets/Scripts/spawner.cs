using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform SpawnPosition;
    public GameObject Target;
    Vector3 randomPos;

    void SpawnObject()
    {
        Instantiate(Target, SpawnPosition.transform);
    }

    private void Update()
    {
        randomPos = new Vector3(Random.Range(0, 400), Random.Range(0, 100), Random.Range(0, 100));

    }
}
