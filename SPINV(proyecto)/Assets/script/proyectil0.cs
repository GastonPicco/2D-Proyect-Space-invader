using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil0 : MonoBehaviour
{
    public float timer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.1)
        {
            Destroy(gameObject);
        }
    }
}
