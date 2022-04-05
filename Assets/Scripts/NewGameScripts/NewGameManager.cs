using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject finalPlatform;
    public GameObject waterPrefab;
    public GameObject foodPrefab;

    public int platformCount = 25;
    public int waterCount = 10;
    public int foodCount = 10;
    private int flipSign = 1;
    // Start is called before the first frame update
    void Start()
    {
        //waterCount = platformCount/10;
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount/2; i++)
        {
            spawnPosition.y += Random.Range(3.5f, 4.5f);
            spawnPosition.x += flipSign*Random.Range(4f, 6f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            flipSign = -(flipSign);
        }
        //secret side
        Vector3 sideQuestPos = spawnPosition;
        for (int i = 0; i < 10; i++)
        {
            sideQuestPos.y += flipSign*Random.Range(1f, 2f);
            sideQuestPos.x += Random.Range(4f, 6f);
            Instantiate(platformPrefab, sideQuestPos, Quaternion.identity);
            flipSign = -(flipSign);
        }
        for (int i = platformCount/2; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(3.5f, 4.5f);
            spawnPosition.x += flipSign*Random.Range(4f, 6f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            flipSign = -(flipSign);
        }
        //finish line
        spawnPosition.y += 6f;
        Instantiate(finalPlatform, spawnPosition, Quaternion.identity);

        Vector3 spawnWater = new Vector3();

        for (int i = 0; i < waterCount; i++)
        {
            spawnWater.y += Random.Range(7f, 10f);
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
