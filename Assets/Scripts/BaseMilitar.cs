using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BaseMilitar : MonoBehaviour
{
    public float vida;
    public GameObject Explosion;
    public AudioSource SonidoExplosion;
    public AudioSource SonidoChoque;
    public FinJuego finJuego;
    public Text Score;

    void Start() {

        Explosion.SetActive(false);
        this.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("balaSoldado"))
        {

            // Resta vida al objeto
             BalaSoldado bala = collision.gameObject.GetComponent<BalaSoldado>();
             float dano = bala.dano;

             vida -= dano; 

            // Verifica si la vida ha llegado a cero o menos
            if (vida <= 0)
            {
                // El objeto ha sido destruido, puedes realizar aquí las acciones necesarias, como destruirlo
                Explosion.SetActive(true);
                SonidoExplosion.Play();
                this.gameObject.SetActive(false);
                finJuego.objetos -= 1;
                finJuego.puntos += 50;
                Score.text = "Score: " + finJuego.puntos.ToString();

                if(finJuego.objetos ==0)
                {
                     SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
                }
                
            }
            
            SonidoChoque.Play();
            Destroy(collision);
        }

        if (collision.gameObject.CompareTag("balaCarro"))
        {
            // Resta vida al objeto
             BalaCarro bala = collision.gameObject.GetComponent<BalaCarro>();
             float dano = bala.dano;

             vida -= dano; 
             

            // Verifica si la vida ha llegado a cero o menos
            if (vida <= 0)
            {
                // El objeto ha sido destruido, puedes realizar aquí las acciones necesarias, como destruirlo
                Explosion.SetActive(true);
                SonidoExplosion.Play();
                this.gameObject.SetActive(false);
                finJuego.objetos -= 1;
                finJuego.puntos += 30;
                Score.text = "Score: " + finJuego.puntos.ToString();

                 if(finJuego.objetos ==0)
                {
                     SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
                }
            }

            
            SonidoChoque.Play();
            Destroy(collision);

        }

        if (collision.gameObject.CompareTag("balaTanque"))
        {
            // Resta vida al objeto
             BalaTanque bala = collision.gameObject.GetComponent<BalaTanque>();
             float dano = bala.dano;

             vida -= dano; 
          

            // Verifica si la vida ha llegado a cero o menos
            if (vida <= 0)
            {
                // El objeto ha sido destruido, puedes realizar aquí las acciones necesarias, como destruirlo
                Explosion.SetActive(true);
                SonidoExplosion.Play();
                this.gameObject.SetActive(false);
                finJuego.objetos -= 1;
                finJuego.puntos += 10;
                Score.text = "Score: " + finJuego.puntos.ToString();

                 if(finJuego.objetos ==0)
                {
                     SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
                }
            }

            
            SonidoChoque.Play();
            Destroy(collision);
        }
    }
   
}
