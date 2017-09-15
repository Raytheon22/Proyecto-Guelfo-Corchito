using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour {

	// ESTE SCRIPT ES PARA ROMPER LA CAJA QUE ESTA TAPANDO LO "BLANCO" DE LA UNION DE LAS PUERTAS.
	void awake()
	{
		
	}
	void Start () 
	{
		Invoke ("destruir", 0.95f);
	}
	void destruir() 
	{
		Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
