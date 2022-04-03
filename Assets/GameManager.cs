using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject waterPrefab;
    public GameObject foodPrefab;

    public int platformCount = 25;
    public int waterCount = 10;
    public int foodCount = 10;
    // Start is called before the first frame update
    void Start()
    {
        //waterCount = platformCount/10;
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(2f, 4f);
            spawnPosition.x += Random.Range(-2f, 2f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            // spawnPosition.x += 2*Random.Range(1f, 2f);
            // Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        Vector3 spawnWater = new Vector3();

        for (int i = 0; i < waterCount; i++)
        {
            spawnWater.y += Random.Range(10f, 15f);
            spawnWater.x += Random.Range(-2f, 2f);
            Instantiate(waterPrefab, spawnWater, Quaternion.identity);
        }

        Vector3 spawnFood = new Vector3();

        for (int i = 0; i < waterCount; i++)
        {
            spawnFood.y += Random.Range(10f, 15f);
            spawnFood.x = 6*Random.Range(-1, 1);
            Instantiate(foodPrefab, spawnFood, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
