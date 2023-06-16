using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEvent : MonoBehaviour
{
    public float time;
    public int initialTime;
    private int randomEvent;


    public delegate void DelSpawn(int randomEvent);
    public static event DelSpawn OnEventSpawn;


    void Start()
    {
        initialTime = Random.Range(1, 5);
    }


    void Update()
    {
        if (OnEventSpawn != null)
        {
            time += Time.deltaTime;

            if (time >= initialTime)
            {
                randomEvent = Random.Range(1, 4);
                MessageEvent(randomEvent);

                OnEventSpawn.Invoke(randomEvent);
                time = 0;
                initialTime = Random.Range(1, 5);
            }
        }
    }


    public void MessageEvent(int randomEvent)
    {
        if (randomEvent == 1)
        {
            print("Event: All Spawn\nThere are no more object");
            print("-- Gamer Over --");
        }
        else if (randomEvent == 2)
        {
            print("Event: Only Odds Spawn");
        }
        else
        {
            print("Event: All Spawn this Obj\nThere are no more object");
            print("-- Gamer Over --");
        }
    }

}
