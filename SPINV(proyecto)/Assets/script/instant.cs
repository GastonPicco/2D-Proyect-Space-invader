using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instant : MonoBehaviour
{
    public GameObject prefabnave1;
    public GameObject prefabnave2;
    public GameObject prefabnave3;
    
    public int validator = 1;
    public int valid1 = 0, valid2 = 0, valid3 = 0, valid4 = 0, valid5 = 0, valid6 = 0, valid7 = 0, valid8 = 0, valid9 = 0;
    
    
    public float timer;
    public int counter = -10;
    public GameObject posicion;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        
       
        if (timer > 0.09)
        {
            counter = counter + 1;
            timer = 0;
        }
        if ((counter == 1)&& (valid1 == 0))
        {
            Instantiate(prefabnave1, new Vector3(posicion.transform.position.x, posicion.transform.position.y+0.15f, posicion.transform.position.z), Quaternion.identity);
            valid1 = validator;
        }
        if ((counter == 2) && (valid2 == 0))
        {
            Instantiate(prefabnave1, new Vector3(posicion.transform.position.x, posicion.transform.position.y + (counter * 0.15f), posicion.transform.position.z), Quaternion.identity);
            valid2 = validator;
        }
        if ((counter == 3) && (valid3 == 0))
        {
            Instantiate(prefabnave2, new Vector3(posicion.transform.position.x, posicion.transform.position.y + (counter * 0.15f), posicion.transform.position.z), Quaternion.identity);
            valid3 = validator;
        }
        if ((counter == 4) && (valid4 == 0))
        {
            Instantiate(prefabnave2, new Vector3(posicion.transform.position.x, posicion.transform.position.y + (counter * 0.15f), posicion.transform.position.z), Quaternion.identity);
            valid4 = validator;
        }
        if ((counter == 5) && (valid5 == 0))
        {
            Instantiate(prefabnave3, new Vector3(posicion.transform.position.x, posicion.transform.position.y + (counter * 0.15f), posicion.transform.position.z), Quaternion.identity);
            valid5 = validator;
        }
        

    }
}
