using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour {

    public GameObject Jugador;

    void Awake () {

	}

    void OnMouseDown()
    {
        Jugador.GetComponent<Disparar>().CargarVel = true;
    }

    void OnMouseUp()
    {
        Jugador.GetComponent<Disparar>().CargarVel = false;
        Jugador.GetComponent<Disparar>().Lanzar = true;
        Jugador.GetComponent<Disparar>().Recargar = true;
    }

    void Update()
    {

    }

}



