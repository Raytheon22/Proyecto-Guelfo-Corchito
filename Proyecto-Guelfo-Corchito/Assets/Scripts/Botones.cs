using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour {
	public GameObject Fade;
	public float transparencia;
	public bool click=false;
	public Image imagen;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (click == true) 
		{
			if (imagen.color.a < 1)
			{
				transparencia = transparencia + 0.8f * Time.deltaTime;
			}
			imagen.color = new Color (0, 0, 0, transparencia);
			if (imagen.color.a > 1)
			{
				SceneManager.LoadScene ("MenuPrototipo");;
			}
		}



	}

	public void Click1()
	{
		SceneManager.LoadScene ("Memotest");
	}
	public void Click2()
	{
		SceneManager.LoadScene ("Corchito");
	}
	public void Click3()
	{
		Fade.SetActive(true);
		click = true;
		imagen = Fade.GetComponent<Image>();
		Fade.GetComponent<Fade> ().enabled = false;
		transparencia = imagen.color.a;


	}
}
