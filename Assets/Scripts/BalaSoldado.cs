using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaSoldado : MonoBehaviour
{
    public float velocidad = 20;
    Rigidbody rb;
    public float dano = 10; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += transform.up * velocidad * Time.deltaTime;
    }
}

