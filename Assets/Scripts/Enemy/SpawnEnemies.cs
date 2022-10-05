using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    [SerializeField] private float spawnInterval = 2f;

    private void Start()
    {
        StartCoroutine(SpawnEnemy(spawnInterval, Enemy));
    }
    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-300f, 300), Random.Range(-300f, 300), Random.Range(-300f, 300)), Quaternion.identity);
        newEnemy.SetActive(true);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }

}
