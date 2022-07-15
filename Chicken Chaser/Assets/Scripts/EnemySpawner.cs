using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemyReference;
    private GameObject spawnedEnemy;
    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomeIndex, randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1,5));

            randomeIndex = Random.Range(0, enemyReference.Length);
            randomSide = Random.Range(0,2);

            spawnedEnemy = Instantiate(enemyReference[randomeIndex]);

            if(randomSide == 0)
            {
                spawnedEnemy.transform.position = leftPos.position;
                spawnedEnemy.GetComponent<Enemy>().speed = Random.Range(4,10);
            }
            else
            {
                spawnedEnemy.transform.position = rightPos.position;
                spawnedEnemy.GetComponent<Enemy>().speed = -Random.Range(4,10);
                Vector3 localScale = spawnedEnemy.transform.localScale;
                localScale.x *= -1;
                spawnedEnemy.transform.localScale = localScale;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
