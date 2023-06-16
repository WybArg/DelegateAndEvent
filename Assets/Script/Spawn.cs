using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject SpecialEnemy;
    public int cantEnemy;

    void Start()
    {
        ManagerEvent.OnEventSpawn += OnEvent;
    }




    void Update()
    { 
    }


    public void OnEvent(int randomEvent)
    {
        if(randomEvent == 1)
        {
            ClonPrefab(Enemy);
            ManagerEvent.OnEventSpawn -= OnEvent;
        }
        else if (randomEvent == 2 && this.gameObject.layer == 10)
        {
            ClonPrefab(Enemy);
            ManagerEvent.OnEventSpawn -= OnEvent;
        }
        else if (randomEvent == 3)
        {
            ClonPrefab(SpecialEnemy);
            ManagerEvent.OnEventSpawn -= OnEvent;
        }
    }



    public void ClonPrefab(GameObject Prefab)
    {
        for(int i=0; i < cantEnemy; i++)
        {
            Vector3 posRandom = Random.onUnitSphere * 10;
            posRandom.y = 0;

            Instantiate(Prefab, posRandom, Quaternion.identity);
        } 
    }


}


