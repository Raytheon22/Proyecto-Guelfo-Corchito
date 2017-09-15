using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManagerCorchito : MonoBehaviour {
	public int puntaje1 = 0;
	public int puntaje2 = 0;
	public static string nombre1 = "Esteban ";
	public static string nombre2 = "Sebas ";
	public Text texto1;
	public Text texto2;
	public Text texto3;
	public bool turno = false;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		texto1.text = nombre1 + puntaje1;
		texto2.text = nombre2 + puntaje2;
		if (turno == false) 
		{
			texto3.text = "Turno Jugador 1";
		}
		if (turno == true) 
		{
			texto3.text = "Turno Jugador 2";
		}
	}
}
