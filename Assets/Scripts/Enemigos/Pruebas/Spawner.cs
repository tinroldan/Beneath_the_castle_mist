using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    //private bool detener_spawner;
    private System.Random random = new System.Random();

    [Header("Variables")]
    [SerializeField]
    float rateSpawn;

    [SerializeField]
    int cantidad_enemigos;

    private float m_rateSpawn;
    

    [Header("Prefabs")]
    [SerializeField] GameObject enemigo;
    //private List<GameObject> spawners;

    private GameObject[] spawns;


    void Start()
    {
        m_rateSpawn = rateSpawn;
        spawns = GameObject.FindGameObjectsWithTag("Spawners");
        //spawners.add(GameObject.FindWithTag("Spawner"));
        //InvokeRepeating("SpawnObject",tiempo_spawn,spawn_delay);
    }

    private void Update()
    {
        //timer
        if(m_rateSpawn>0)
        {
            m_rateSpawn -= Time.deltaTime;
        }
        else if(m_rateSpawn<=0)
        {
            for (int i = 0; i < cantidad_enemigos; i++)
            {
                SpawnObject();

            }
            m_rateSpawn = rateSpawn;
        }

    }

    public int GetRandomSpawn()
    {
        int spawn=0;
        spawn = random.Next(0, spawns.Length);
        return spawn;
    }

    // Update is called once per frame
    public void SpawnObject(){
        //for(int i=0;i<cantidad_enemigos+1;i++){        
        //Instantiate(enemigo,transform.position, transform.rotation);

        //}
        //if(detener_spawner){
        //    CancelInvoke("SpawnObject"); 
        //}
        int index = GetRandomSpawn();
        Instantiate(enemigo, spawns[index].transform.position, spawns[index].transform.rotation);
    }

}
