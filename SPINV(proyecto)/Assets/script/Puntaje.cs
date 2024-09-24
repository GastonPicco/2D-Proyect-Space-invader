using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Puntaje : MonoBehaviour
{
    [SerializeField] public int puntajeContador = 0;
    [SerializeField] public int naveContador = 45;
    public TextMeshProUGUI puntos;
    public TextMeshProUGUI naves;
    public GameObject Boss;
    public bool spawn = true; 

    void Start()
    {
        puntos = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = ("Score:"+puntajeContador+" "+"ships:"+ naveContador);
        if (naveContador == 0 && spawn == true)
        {
            Instantiate(Boss, new Vector3(transform.position.x + 0, transform.position.y - 0,transform.position.z), Quaternion.identity);
            spawn = false;
        }


    }

    public void SumarPuntos(int PuntosEntrada)
    {
        puntajeContador += PuntosEntrada;
        Debug.Log(puntajeContador +"puntos");
    }
    public void RestarNave(int NaveEntrada)
    {
        naveContador -= NaveEntrada;
        Debug.Log(naveContador+"restantes");
    }
    

}
