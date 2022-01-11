using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] EnemyStage1;
    public GameObject[] EnemyStage2;
    public GameObject[] EnemyStage3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            int rng = Random.Range(2, 21);
            TestSpawn(rng);
        }
        
    }

    public void TestSpawn(int rng)
    {        
       
        for (int i = 1; i <= rng; i++)
        {
            int RandEnemy = Random.Range(0, EnemyStage3.Length);
            int RandSpawnPoint = Random.Range(0, SpawnPoints.Length);

            Instantiate(EnemyStage3[RandEnemy], SpawnPoints[RandSpawnPoint].position, transform.rotation);

            Debug.Log("Enemy nr: " + i);
        }
        
        Debug.Log("Spawned " + rng + " enemies!");

        if (rng >= 2 && rng < 5)
        {
            Debug.Log("Seems ez idk");
        }
        else if (rng >= 5 && rng < 13)
        {
            Debug.Log("You can handle it");
        }
        else
        {
            Debug.Log("God have mercy");
        }
    }

    public void SpawnEnemies(int days)
    {
        short stage;
        int rng;

        if(days <= 5)
        {
            stage = 1;
        }
        else
        {
            if(days > 5 && days <= 10)
            {
                stage = 2;
            }
            else
            {
                if (days > 10 && days <= 20)
                {
                    stage = 3;
                }
                else
                {
                    if (days > 20 && days <= 30)
                    {
                        stage = 4;
                    }
                    else
                    {
                        if (days > 30 && days <= 40)
                        {
                            stage = 5;
                        }
                        else
                        {
                            stage = 6;
                        }
                    }
                }
            }
        }

        switch(stage)
        {
            case 1:
                for(int i=0; i < days + 1; i++)
                {
                    int RandEnemy = Random.Range(0, EnemyStage1.Length);
                    int RandSpawnPoint = Random.Range(0, SpawnPoints.Length);

                    Instantiate(EnemyStage1[RandEnemy], SpawnPoints[RandSpawnPoint].position, transform.rotation);
                }
                break;

            case 2:
                for (int i = 0; i < days/2 + 2; i++)
                {
                    int RandEnemy = Random.Range(0, EnemyStage2.Length);
                    int RandSpawnPoint = Random.Range(0, SpawnPoints.Length);

                    Instantiate(EnemyStage2[RandEnemy], SpawnPoints[RandSpawnPoint].position, transform.rotation);
                }
                break;

            case 3:
                rng = Random.Range(1, 6);

                for (int i = 0; i < days/2 + rng; i++)
                {
                    int RandEnemy = Random.Range(0, EnemyStage3.Length);
                    int RandSpawnPoint = Random.Range(0, SpawnPoints.Length);

                    Instantiate(EnemyStage3[RandEnemy], SpawnPoints[RandSpawnPoint].position, transform.rotation);

                    //to-do: add boss spawning
                }
                break;

            case 4:
                rng = Random.Range(1, 8);

                for (int i = 0; i < days/2 + rng; i++)
                {
                    int RandEnemy = Random.Range(0, EnemyStage3.Length);
                    int RandSpawnPoint = Random.Range(0, SpawnPoints.Length);

                    Instantiate(EnemyStage3[RandEnemy], SpawnPoints[RandSpawnPoint].position, transform.rotation);

                    //to-do: add boss spawning
                }
                break;

            case 5:
                rng = Random.Range(1, 11);

                for (int i = 0; i < days/2 + rng; i++)
                {
                    int RandEnemy = Random.Range(0, EnemyStage3.Length);
                    int RandSpawnPoint = Random.Range(0, SpawnPoints.Length);

                    Instantiate(EnemyStage3[RandEnemy], SpawnPoints[RandSpawnPoint].position, transform.rotation);

                    //to-do: add boss spawning
                }
                break;

            case 6:
                rng = Random.Range(1, 11);

                for (int i = 0; i < days / 2 + rng; i++)
                {
                    int RandEnemy = Random.Range(0, EnemyStage3.Length);
                    int RandSpawnPoint = Random.Range(0, SpawnPoints.Length);

                    Instantiate(EnemyStage3[RandEnemy], SpawnPoints[RandSpawnPoint].position, transform.rotation);

                    //to-do: add boss spawning
                }
                break;
        }
    }
}
