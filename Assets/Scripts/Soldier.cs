using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Soldier : MonoBehaviour
{
    public List<AudioClip> frasesSoldado;
    public float tiempoMinimo = 5.0f;
    public float tiempoMaximo = 10.0f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(DecirFraseAleatoria());
    }

    IEnumerator DecirFraseAleatoria()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(tiempoMinimo, tiempoMaximo));

            if (frasesSoldado.Count > 0)
            {
                int indiceFrase = Random.Range(0, frasesSoldado.Count);
                audioSource.clip = frasesSoldado[indiceFrase];
                audioSource.Play();
            }
        }
    }
}
