using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermove : MonoBehaviour
{
    public float Distancia;
    public float Cronometro;
    public float CD;
    public GameObject ProyectilPrefab;
    public GameObject ProyectilPrefab0;
    Vector3 posicion1 = new Vector3(0.035f, 0.045f, 0f);
    Vector3 posicion2 = new Vector3(-0.025f, 0.045f, 0f);
    public int inter = 0;
    public float cadencia = 0.9f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Cronometro += Time.deltaTime;
        CD += Time.deltaTime;

        if (Input.GetKey("left") && (Cronometro > 0.05) && (transform.position.x > -1.1f))
        {
            Izquierda();
        }
        if (Input.GetKey("right") && (Cronometro > 0.05) && (transform.position.x < 1.1f))
        {
            Derecha();
        }
        if (Input.GetKey("space") && (CD > cadencia) && (inter == 0))
        {
            Shoot();
        }
        if (Input.GetKey("space") && (CD > cadencia) && (inter == 1))
        {
            Shoot2();
        }


    }
    private void Izquierda()
    {
        gameObject.transform.Translate(Distancia * -1, 0f, 0f);
        Cronometro = 0;
    }
    private void Derecha()
    {
        gameObject.transform.Translate(Distancia * 1, 0f, 0f);
        Cronometro = 0;
    }
    private void Shoot()
    {
        Instantiate(ProyectilPrefab, transform.position + posicion1, Quaternion.identity);
        Instantiate(ProyectilPrefab0, transform.position + posicion1, Quaternion.identity);
        CD = 0;
        inter = 1;
    }
    private void Shoot2()
    {
        Instantiate(ProyectilPrefab, transform.position + posicion2, Quaternion.identity);
        Instantiate(ProyectilPrefab0, transform.position + posicion2, Quaternion.identity);
        CD = 0;
        inter = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "nave")
        {
            SceneManager.LoadScene("lose");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "balaEnemigo")
        {
            SceneManager.LoadScene("lose");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "killer")
        {
            SceneManager.LoadScene("lose");
            Destroy(gameObject);

        }
    }
}