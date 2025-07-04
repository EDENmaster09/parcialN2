using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject chestPrefab;
    public GameObject trapPrefab;

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        Instantiate(enemyPrefab, new Vector3(3, 0, 5), Quaternion.identity);
        Instantiate(chestPrefab, new Vector3(-2, 0, 3), Quaternion.identity);
        Instantiate(trapPrefab, new Vector3(1, 0, -4), Quaternion.identity);
    }
}
