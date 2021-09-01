using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScriptCor : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject asteroidPrefab;
    void Start()
    {
        StartCoroutine(CloneEnemyPrefab());
        StartCoroutine(CloneAsteroidPrefab());
    }
    IEnumerator CloneEnemyPrefab()
    {
        while (true)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-7.5f, 7.5f), 6.7f, 0), Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
        }
    }
    IEnumerator CloneAsteroidPrefab()
    {
        while (true)
        {
            Instantiate(asteroidPrefab, new Vector3(10.2f, Random.Range(-3f, 3.5f), 0), Quaternion.identity);
            yield return new WaitForSeconds(4f);
        }
    }

}
