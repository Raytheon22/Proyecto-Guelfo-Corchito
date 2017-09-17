using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCopa : MonoBehaviour {

	public GameObject manager;
    public float Cronometro;
    bool Sumar = false;
	void Start () {
		
	}

	void Update ()
	{
		if (Cronometro > -0.5)
        {
            Cronometro -= Time.deltaTime;
        }
	}

	void OnTriggerEnter(Collider col)
	{
        Cronometro = 2.0f;
        Sumar = true;
 
		if (!LevelManagerCorchito.Instance.turno && Sumar) 
		{
			LevelManagerCorchito.Instance.puntaje1 += 1;
            Sumar = false;
		}
		if (LevelManagerCorchito.Instance.turno && Sumar) 
		{
            LevelManagerCorchito.Instance.puntaje2 += 1;
            Sumar = false;
        }
    }
}
