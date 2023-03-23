using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectil : MonoBehaviour
{
    public float Distancia;
    public float Cronometro;
    public float Limitador;
    private float Dead;
    public float DeadTime;
    public bool friendly = true;
    
    Vector3 posicion1 = new Vector3(0.0f, 0.0f, 0f);
    public GameObject ProyectilPrefab2;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cronometro += Time.deltaTime;
        if (Cronometro > Limitador)
        {
            gameObject.transform.Translate(0f, Distancia * 1, 0f);
            Cronometro = 0;
            transform.localScale = new Vector3(transform.localScale.x * -1, 1f, 1f);
            Dead = Dead + 1;

        }
        if(Dead > DeadTime)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "nave" && friendly == true)
        {
            Instantiate(ProyectilPrefab2, transform.position + posicion1, Quaternion.identity);
            
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "player" && friendly == false)
        {
            Instantiate(ProyectilPrefab2, transform.position + posicion1, Quaternion.identity);

            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "cajitas")
        {
            Instantiate(ProyectilPrefab2, transform.position + posicion1, Quaternion.identity);

            Destroy(gameObject);
        }
        
        
    }
}
