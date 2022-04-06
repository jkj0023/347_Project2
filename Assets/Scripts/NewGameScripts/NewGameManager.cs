using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject finalPlatform;
    public GameObject waterPrefab;
    public GameObject foodPrefab;
    public GameObject finalKey;
    public GameObject poison;
    public GameObject magic;

    public int platformCount = 70;
    public int waterCount = 35;
    public int foodCount = 22;
    private int flipSign = 1;
    // Start is called before the first frame update
    void Start()
    {
        //waterCount = platformCount/10;
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount/2; i++)
        {
            spawnPosition.y += Random.Range(3.5f, 4.5f);
            spawnPosition.x += flipSign*Random.Range(5f, 7f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            flipSign = -(flipSign);
        }
        spawnPosition.x += 3f;
        Instantiate(poison, spawnPosition, Quaternion.identity);
        spawnPosition.y += 5f;
        Instantiate(magic, spawnPosition, Quaternion.identity);
        //secret side
        Vector3 sideQuestPos = spawnPosition;
        for (int i = 0; i < 10; i++)
        {
            sideQuestPos.y += flipSign*Random.Range(1f, 2f);
            sideQuestPos.x += Random.Range(4f, 6f);
            Instantiate(platformPrefab, sideQuestPos, Quaternion.identity);
            flipSign = -(flipSign);
        }
        sideQuestPos.x += -2f;
        Instantiate(poison, sideQuestPos, Quaternion.identity);
        sideQuestPos.y += 5f;
        Instantiate(magic, sideQuestPos, Quaternion.identity);

        //make key appear
        sideQuestPos.y += 2f;
        Instantiate(finalKey, sideQuestPos, Quaternion.identity);
        //top half of platforms
        for (int i = platformCount/2; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(3.5f, 4.5f);
            spawnPosition.x += flipSign*Random.Range(5f, 7f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            flipSign = -(flipSign);
        }
        spawnPosition.x += -2f;
        Instantiate(poison, spawnPosition, Quaternion.identity);
        spawnPosition.y += -7f;
        Instantiate(magic, spawnPosition, Quaternion.identity);

        //finish line
        spawnPosition.y += 6f;
        Instantiate(finalPlatform, spawnPosition, Quaternion.identity);

        Vector3 spawnWater = new Vector3();

        for (int i = 0; i < waterCount; i++)
        {
            spawnWater.y += Random.Range(7f, 9f);
            spawnWater.x += Random.Range(-1.5f, 1.5f);
            Instantiate(waterPrefab, spawnWater, Quaternion.identity);
        }

        Vector3 spawnFood = new Vector3();

        for (int i = 0; i < waterCount; i++)
        {
            spawnFood.y += Random.Range(10.5f, 13.5f);
            spawnFood.x = 6*Random.Range(-1f, 1f);
            Instantiate(foodPrefab, spawnFood, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
