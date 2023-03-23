using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ExploPrefab1;
    public GameObject punteador;
    public GameObject balaEnemigoPrefab;
    Vector3 posicion1 = new Vector3(0.0f, 0.0f, 0f);
    public int cpuntos = 20;
    public int cnaves = 1;
    public Puntaje puntaje;
    public float timer;
    int repetidor = 0;
    public bool canshoot,cansummon = true;
    public float detector;
    public float shoottime;
    public int Animacion = 1;
    public float shooter;
    public GameObject killerprefab;
    public bool boss=false;
    public int vidaboss = 10;

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (boss == false)
        {
            timer += Time.deltaTime;
            shoottime += Time.deltaTime;
            Debug.DrawRay(transform.position, Vector3.down * detector, Color.red);
            if (transform.position.y < -0.72 && cansummon == true)
            {
                Instantiate(killerprefab, new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z), Quaternion.identity);
                cansummon = false;
            }
            if (Physics2D.Raycast(transform.position, Vector3.down, detector))
            {
                canshoot = false;
            }
            else
            {
                canshoot = true;
            }
        }
        if (boss == true)
        {
            timer += Time.deltaTime;
            shoottime += Time.deltaTime;
            Debug.DrawRay(transform.position, Vector3.down * detector, Color.red);
            if (transform.position.y < -0.72 && cansummon == true)
            {
                Instantiate(killerprefab, new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z), Quaternion.identity);
                cansummon = false;
            }
            if (Physics2D.Raycast(transform.position, Vector3.down, detector))
            {
                canshoot = false;
            }
            else
            {
                canshoot = true;
            }
        }
        if (boss == false)
        {
            if (shoottime > 0.8 && canshoot == true)
            {

                shooter = Random.Range(0f, 10f);
                //Debug.Log(shooter);

                if (shooter <= 10.0f && shooter >= 9.0f)
                {
                    Instantiate(balaEnemigoPrefab, new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z), Quaternion.identity);
                    shoottime = 0;
                    canshoot = false;

                }
                else
                {
                    shoottime = 0;
                    canshoot = false;
                }
            }
        }
        if(boss == true)
        {
            if (shoottime > 0.2 && canshoot == true)
            {

                shooter = Random.Range(0f, 10f);
                //Debug.Log(shooter);

                if (shooter <= 10.0f && shooter >= 9.0f)
                {
                    Instantiate(balaEnemigoPrefab, new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z), Quaternion.identity);
                    Instantiate(balaEnemigoPrefab, new Vector3(transform.position.x + 0.04f, transform.position.y - 0.1f, transform.position.z), Quaternion.identity);
                    Instantiate(balaEnemigoPrefab, new Vector3(transform.position.x - 0.04f, transform.position.y - 0.1f, transform.position.z), Quaternion.identity);
                    shoottime = 0;
                    canshoot = false;

                }
                else
                {
                    shoottime = 0;
                    canshoot = false;
                }
            }
        }


        if (boss == false)
        {
            if (timer > 30 && repetidor < 10)
            {
                cpuntos = cpuntos - 1;
                timer = 0;
                repetidor = repetidor + 1;
            }
        }
        
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (boss == false)
        {
            if (collision.gameObject.tag == "bala")
            {

                Instantiate(ExploPrefab1, transform.position + posicion1, Quaternion.identity);
                puntaje.SumarPuntos(cpuntos);
                puntaje.RestarNave(cnaves);
                Destroy(gameObject);
            }
        }
        if (boss == true)
        {
            if (collision.gameObject.tag == "bala")
            {

                Instantiate(ExploPrefab1, transform.position + posicion1, Quaternion.identity);
                vidaboss = vidaboss - 1;
                if(vidaboss < 1)
                {
                    SceneManager.LoadScene("win");
                    Destroy(gameObject);
                }
         
                
            }
        }
  
    }
}
