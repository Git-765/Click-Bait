using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnDistance = 5;
    public float spawnInitialDelay = 2;
    public float spawnDelay = 1;
    public GameObject[] spawnedObjs;
    public GameObject spawnObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnInitialDelay, spawnDelay);
    }

    public void SpawnObject()
    {
        Vector3 newPos = Random.insideUnitCircle.normalized * spawnDistance;
        spawnObj = spawnedObjs[Random.Range(0,spawnedObjs.Length)];
        Instantiate(spawnObj, transform.position + newPos, transform.rotation);
    }
}
