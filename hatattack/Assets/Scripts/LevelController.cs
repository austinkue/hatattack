using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject hatToSpawn;

    private void spawnHat()
    {
        GameObject a = Instantiate(hatToSpawn) as GameObject;
        a.transform.position = new Vector3(Random.Range(-3f, 3'f), 9, -1);
    }

    IEnumerator hatSpawner()
    {
        while (hatToSpawn != null)
        {
            yield return new WaitForSeconds(1.5f);
            spawnHat();
        }
    }

    void Start()
    {
        StartCoroutine(hatSpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
