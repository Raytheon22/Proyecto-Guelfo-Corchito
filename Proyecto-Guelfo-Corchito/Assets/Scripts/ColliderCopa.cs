using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCopa : MonoBehaviour {

	public GameObject manager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	void OnTriggerEnter(Collider col)
	{
		Destroy (col.gameObject);
		if (manager.GetComponent<LevelManagerCorchito> ().turno == false) 
		{
			manager.GetComponent<LevelManagerCorchito> ().puntaje1 = manager.GetComponent<LevelManagerCorchito> ().puntaje1 + 1;
		}
		if (manager.GetComponent<LevelManagerCorchito> ().turno == true) 
		{
			manager.GetComponent<LevelManagerCorchito> ().puntaje2 = manager.GetComponent<LevelManagerCorchito> ().puntaje2 + 1;
		}
	}
}
