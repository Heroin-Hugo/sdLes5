using System.Collections;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float timeBetweenSpawns;
    [Space]
    [SerializeField] private float randomX;
    [SerializeField] private float randomZ;

    private void Start() => StartCoroutine(SpawnObject());
    IEnumerator SpawnObject()
    {
        while(true)
        {
            yield return new WaitForSeconds(timeBetweenSpawns);

            float x = Random.Range(-randomX, randomX);
            float z = Random.Range(-randomZ, randomZ);

            Vector3 randomVector = new Vector3(x, -6.24f, z);
            Instantiate(objectToSpawn, randomVector, Quaternion.identity);
        }
    }
}
