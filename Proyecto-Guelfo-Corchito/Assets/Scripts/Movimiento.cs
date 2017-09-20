using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
	public bool rotando = true;
	public Vector3 rotacion;
    bool CambiarTurno = true;
    bool TocoTrigger = false;

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

    void OnTriggerEnter(Collider col)
    {
        TocoTrigger = true;
    }


    void OnCollisionEnter(Collision col)
    {
        rotando = false;

        if (CambiarTurno && !TocoTrigger) 
        {
            LevelManagerCorchito.Instance.turno = !LevelManagerCorchito.Instance.turno;
            CambiarTurno = false;
        }
    }
	void destruir ()
	{
		Destroy (gameObject);
	}


}
