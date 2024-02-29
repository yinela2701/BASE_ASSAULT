using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaTanque : MonoBehaviour
{
    public float velocidad = 20;
    Rigidbody rb;
    public float dano = 30; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += transform.up * velocidad * Time.deltaTime;
    }
}
