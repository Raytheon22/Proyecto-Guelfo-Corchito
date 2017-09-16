using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour {
	
	public AnimationClip animacion;

	// Use this for initialization
	void Start () 
	{

		animacion.legacy = true;
		AnimationCurve curva = AnimationCurve.EaseInOut (0.0f, 0.0f, 5.0f, 5.0f);
		animacion.SetCurve ("", typeof(Transform), "LocalPosition.z", curva);
		animacion.name = "Hola";


	}
	
	// Update is called once per frame

}
