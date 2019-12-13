using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour
{
    Rigidbody rb;
    public float velocidad;

    public Text marcador;

    public Text FinDeJuego;

    public float contador;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        ActualizarMarcador();
        FinDeJuego.gameObject.SetActive(false);
    marcador.text = "Puntos: " + contador;
    }

    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f,
        movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        marcador.text = "Puntos: " + contador;
        ActualizarMarcador();
        if (contador >= 9)
        {
            FinDeJuego.gameObject.SetActive(true);
        }
}
    void ActualizarMarcador()
    {
        marcador.text = "Puntos: " + contador;
    }
}