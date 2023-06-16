using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private float time;
    public float lifeTime;


    void Start()
    {
        
    }


    void Update()
    {
        time += Time.deltaTime;

        if(time >= lifeTime)
        {
            Destroy(this.gameObject);
        }

        transform.position += Vector3.forward.normalized * speed * Time.deltaTime;
    }
}
