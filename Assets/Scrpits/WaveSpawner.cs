using Spriter2UnityDX;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING };
    [System.Serializable]
    public class Wave
    {
        public string name;
        public GameObject enemy;
        public int count;
        public float rate;

        public Wave(string _name,GameObject _enemy, int _count, float _rate) 
        {

            name = _name;
            enemy = _enemy;
            count = _count;
            rate = _rate;
        }
    }

    private int completedtour=0,randomNumber, realDailyEnemyCount;
    public float dailyEnemyCount;
    public GameManagager gm;
    public EnemyType[] enemies;
    public List<Wave> waves= new List<Wave>();
    private GameObject _enemy,spawnedEnemy;
    private int nextWave = 0;
    public Transform[] spawnPoints;
    public float timeBetweenWaves = 5f;
    private float waveCountdown,totalWeight,WeightPerEnemy;
    private float searchCountdown = 1f;
    public SpawnState state = SpawnState.COUNTING;
    void Start()
    {
   

        gm.textC.enemyNameText.text = enemies[0].enemyName;
        gm.textC.enemyInfoText.text = enemies[0].enemyInfo;
        gm.textC.enemyInfoText1.text = enemies[0].enemyInfo1;
        gm.textC.enemyInfoText2.text = enemies[0].enemyInfo2;
        gm.textC.enemyInfoText3.text = enemies[0].enemyInfo3;
        gm.gameObjectC.enemyImage.GetComponent<Image>().sprite = enemies[0].enemyImage;
        




        CalculteTheWieght();


        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points referenced");
        }
        waveCountdown = timeBetweenWaves;
    }
    void Update()
    {
        







        if (completedtour >= 2)
        {
            completedtour = 0;
            gm.nextDay = true;
           
            //for (int i = 0; i < enemies.Length; i++)
            //{
            //    if (gm.day  == enemies[i].waveStart)
            //    {
            //        gm.textC.enemyNameText.text = enemies[i].enemyName;
            //        gm.textC.enemyInfoText.text = enemies[i].enemyInfo;
            //        gm.textC.enemyInfoText1.text = enemies[i].enemyInfo1;
            //        gm.textC.enemyInfoText2.text = enemies[i].enemyInfo2;
            //        gm.textC.enemyInfoText3.text = enemies[i].enemyInfo3;
            //        gm.gameObjectC.enemyImage.GetComponent<Image>().sprite = enemies[i].enemyImage;
                   
            //    }

            //}
            dailyEnemyCount = 30*gm.day * 1.5f;
            CalculteTheWieght();
            
        }



        if (state == SpawnState.WAITING)
        {
          
            if (!EnemyIsAlive())
            {
                // Begin new round
              //  Debug.Log("Wave Completed!");
                WaveCompleted();
                return;
            }
            else
            {
                return;
            }
        }
        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                // Start spawning wave
               
                for (int j = 0; j < waves.Count; j++)
                {
                    StartCoroutine(SpawnWave(waves[nextWave]));
                    nextWave++;
                }
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }
    void WaveCompleted()
    {
       // Debug.Log("Wave Completed!");
        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;
        completedtour++;
        if (nextWave + 1 > waves.Count - 1)
        {
            nextWave = 0;
           // Debug.Log("All Waves Complete Looping...");
        }
      

    }
    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                return false;
            }
        }
        return true;
    }
    IEnumerator SpawnWave(Wave _wave)
    {
      //  Debug.Log("Spawning Wave: " + _wave.name);
        state = SpawnState.SPAWNING;
        //Spawn
       
            for (int i = 0; i < _wave.count; i++)
            {
                _enemy = _wave.enemy;
                SpawnEnemy();
                yield return new WaitForSeconds(1f / _wave.rate);
            }
        
        
        state = SpawnState.WAITING;
        yield break;
    }
    void SpawnEnemy()
    {
        // Spawn Enemy
        
        //Debug.Log("Spawning Enemy: " + _enemy.name);
        if (_enemy.GetComponent<enemyScrpit>().enemyType.type != 4)
        randomNumber = Random.Range(0, spawnPoints.Length);
        if (_enemy.GetComponent<enemyScrpit>().enemyType.type == 4)
            randomNumber = Random.Range(0, 5);
        Transform _sp = spawnPoints[randomNumber];
        spawnedEnemy=  Instantiate(_enemy, _sp.position, _sp.rotation);
        spawnedEnemy.transform.SetParent(gameObject.transform);
        if (_enemy.GetComponent<enemyScrpit>().enemyType.type != 4)
            spawnedEnemy.GetComponentInChildren<EntityRenderer>().SortingOrder = (2 + randomNumber);

        if (_enemy.GetComponent<enemyScrpit>().enemyType.type == 4)
            spawnedEnemy.GetComponentInChildren<EntityRenderer>().SortingOrder = (3 + randomNumber);

        gm.enemies.Add(spawnedEnemy);
    }
    
    
    
    
    public void CalculteTheWieght()
    {
        waves.Clear();
        totalWeight = 0;
        realDailyEnemyCount = 0;
dailyEnemyCount = (Mathf.Pow(gm.day, 1.35f) + 10 + Mathf.Sin(gm.day));
       
        for (int i = 0; i < enemies.Length; i++)
        {
         
            if (gm.day >= enemies[i].waveStart)
            {
                totalWeight += enemies[i].weight;
            
            }

        }

        WeightPerEnemy = dailyEnemyCount/totalWeight;
       
        for (int i = 0; i < enemies.Length; i++)
        {
            
            if (gm.day >= enemies[i].waveStart)
            {

              
                enemies[i].dailyCount = Mathf.CeilToInt((float)(enemies[i].weight * WeightPerEnemy));
                waves.Add(new Wave(enemies[i].name,
                enemies[i].enemy,
                Mathf.CeilToInt(((float)(enemies[i].dailyCount / 2.0f))),
                enemies[i].rate + (float)(gm.day / 100.0f)
                ));

                realDailyEnemyCount += (Mathf.CeilToInt(((float)(enemies[i].dailyCount / 2.0f)))*2);
            }
        }
        gm.dailyEnemyCount = realDailyEnemyCount;
        gm.currentEnemyCount = realDailyEnemyCount;
    }


}