using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour {
	public Animation animator;
	// Use this for initialization
	void Start () 
	{
		

	}
	
	// Update is called once per frame
	void Update () {
		animator.Play("Hola");
	}
}
