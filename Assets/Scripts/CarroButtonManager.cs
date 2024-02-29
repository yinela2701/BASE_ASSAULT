using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class CarroButtonManager : MonoBehaviour
{
    [SerializeField] private VirtualButtonBehaviour virtualButton;
    private float velocidad = 20f;

    public AudioSource sonidoDisparo; // Asegúrate de asignar esto en el Inspector.
    public GameObject balaPrefab; // Asegúrate de asignar esto en el Inspector.
    public Transform Target; // Asegúrate de asignar esto en el Inspector.

    private void OnEnable()
    {
        virtualButton.RegisterOnButtonPressed(ButtonPressed);
    }

    private void OnDestroy()
    {
        virtualButton.UnregisterOnButtonPressed(ButtonPressed);
    }

    private void ButtonPressed(VirtualButtonBehaviour button)
{
    // Reproducir sonido de disparo
    sonidoDisparo.Play();

    // Instanciar la bala en la posición del Target con su rotación
    GameObject bala = Instantiate(balaPrefab, Target.position, Target.transform.rotation);

    // Obtener el componente Rigidbody de la bala
    Rigidbody rb = bala.GetComponent<Rigidbody>();

    rb.velocity = bala.transform.up * velocidad;
}

}
