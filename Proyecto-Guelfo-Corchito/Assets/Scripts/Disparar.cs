using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {

    public GameObject Corcho;
	public GameObject manager;
    public bool Cargado = true;
    public float Velocidad;

	void Awake () 
	{
        Velocidad = 0;
	}
	

	void Update () {



        if (Input.GetKey(KeyCode.Space))
        {
            Velocidad += 0.2f;
        }

        if (Input.GetKeyUp(KeyCode.Space) && Cargado)
        {
            GameObject proyectil = Instantiate(Corcho) as GameObject;
            proyectil.transform.position = transform.position + transform.forward * Time.deltaTime;
			proyectil.transform.rotation = Random.rotation;
            Rigidbody rig = proyectil.GetComponent<Rigidbody>();
            rig.velocity = transform.forward * Velocidad;
			Cargado = false;

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Velocidad = 0;
            Cargado = true;
        }
	}
}
