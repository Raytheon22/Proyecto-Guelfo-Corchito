using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour 
{

	public Image Fade2;
	public float transparencia;
	public bool apagado = false;
	// Use this for initialization
	void Start () 
	{
		Fade2 = GetComponent<Image> ();
		transparencia = Fade2.color.a;

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Fade2.color.a > 0)
		{
			transparencia = transparencia - 0.8f * Time.deltaTime;
		}
		Fade2.color = new Color (0, 0, 0, transparencia);

		if (Fade2.color.a < 0 && apagado != true)
		{
			apagado = true;
			gameObject.SetActive (false);

		}
	}
}
