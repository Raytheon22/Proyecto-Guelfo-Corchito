using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
	public bool rotando = true;
	public Vector3 rotacion;

	void Start () 
	{
		Invoke ("destruir", 5);
	}
	

	void Update () 
	{
		if (rotando == true) 
		{
			this.transform.Rotate (3, 0, 0);
		}

       
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "CopaGuelfo")
		{
			rotando = false;
		}
		if (col.gameObject.name == "BarrilPrincipal")
		{
			rotando = false;
		}


	}
	void destruir ()
	{
		Destroy (gameObject);
	}


}
