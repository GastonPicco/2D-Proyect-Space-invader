using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public float Distancia;
    public float Cronometro;
    public float CD;
    public GameObject ProyectilPrefab;
    public int direccion = 1;
    public float posicionx, posiciony;
    public float posicionmax, posicionmin;
    public float limites;
    public float Tick;
    public int Order;
    public float salida;
    public float Acelerador, aceleradorC = 0.85f;
    public bool boss = false;

    
    void Start()
    {
        posicionx = gameObject.transform.position.x;
        posiciony = gameObject.transform.position.y;
        posicionmax = posicionx + limites;
        posicionmin = posicionx - limites;
        if (boss == true)
        {
            aceleradorC = 0.78f;
        }
        

    }

    
    void Update()
    {
        Cronometro += Time.deltaTime;
        CD += Time.deltaTime;
        Acelerador += Time.deltaTime;
        if(Acelerador > 4)
        {
            Acelerador = 0;
            Tick = Tick * aceleradorC;
        }
        if(Order == 1 && CD > salida)
        {
            if ((direccion == 1) && (Cronometro > Tick))
            {
                Izquierda();
            }
            if ((direccion == 0) && (Cronometro > Tick))
            {
                Derecha();
            }
            if ((transform.position.x >= posicionmax) && (direccion == 0))
            {
                direccion = 1;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
            if ((transform.position.x <= posicionmin) && (direccion == 1))
            {
                direccion = 0;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
        }
        if (Order == 2 && CD > salida * 2)
        {
            if ((direccion == 1) && (Cronometro > Tick))
            {
                Izquierda();
            }
            if ((direccion == 0) && (Cronometro > Tick))
            {
                Derecha();
            }
            if ((transform.position.x >= posicionmax) && (direccion == 0))
            {
                direccion = 1;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
            if ((transform.position.x <= posicionmin) && (direccion == 1))
            {
                direccion = 0;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
        }
        if (Order == 3 && CD > salida * 3)
        {
            if ((direccion == 1) && (Cronometro > Tick))
            {
                Izquierda();
            }
            if ((direccion == 0) && (Cronometro > Tick))
            {
                Derecha();
            }
            if ((transform.position.x >= posicionmax) && (direccion == 0))
            {
                direccion = 1;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
            if ((transform.position.x <= posicionmin) && (direccion == 1))
            {
                direccion = 0;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
        }
        if (Order == 4 && CD > salida * 4)
        {
            if ((direccion == 1) && (Cronometro > Tick))
            {
                Izquierda();
            }
            if ((direccion == 0) && (Cronometro > Tick))
            {
                Derecha();
            }
            if ((transform.position.x >= posicionmax) && (direccion == 0))
            {
                direccion = 1;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
            if ((transform.position.x <= posicionmin) && (direccion == 1))
            {
                direccion = 0;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
        }
        if (Order == 5 && CD > salida * 5)
        {
            if ((direccion == 1) && (Cronometro > Tick))
            {
                Izquierda();
            }
            if ((direccion == 0) && (Cronometro > Tick))
            {
                Derecha();
            }
            if ((transform.position.x >= posicionmax) && (direccion == 0))
            {
                direccion = 1;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
            if ((transform.position.x <= posicionmin) && (direccion == 1))
            {
                direccion = 0;
                gameObject.transform.Translate(0f, -0.05f, 0f);

            }
        }



    }
    private void Izquierda()
    {
        gameObject.transform.Translate(Distancia * -1 , 0f, 0f);
        Cronometro = 0;
    }
    private void Derecha()
    {
        gameObject.transform.Translate(Distancia * 1 , 0f, 0f);
        Cronometro = 0;
    }
}
