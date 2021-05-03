using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private GameObject[] powerupsPrefab;

    private GameManager _gameManager;

    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        StarCorotines();
    }

    public void StarCorotines()
    {
        StartCoroutine(SpawnEnemyRotine());
        StartCoroutine(SpawnPowerupsRotine());
    }

    IEnumerator SpawnEnemyRotine()
    {
        while (!_gameManager.gameOver)
        {
            float randoX = Random.Range(-7.6f, 7.6f);
            Instantiate(enemyPrefab, new Vector3(randoX, 7.0f, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }

    IEnumerator SpawnPowerupsRotine()
    {
        while (!_gameManager.gameOver)
        {
            int i = Random.Range(0, 3);
            float randoX = Random.Range(-7.6f, 7.6f);

            Instantiate(powerupsPrefab[i], new Vector3(randoX, 7.0f, 0), Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
