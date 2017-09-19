using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemotestManager : MonoBehaviour {

    public static MemotestManager Instance;
    NombreText n1;
    NombreText n2;
    public List<GameObject> BotellasLista; //Lista de botellas levantadas
    public List<GameObject> BotellasAcertadas;
    public Animator anim1;
    public Animator anim2;
    public Rotar vuelverot;
	public float cronometro;
    public float cronometro2; //Para que no se puedan clickear botellas mientras esta el zoom

    void Awake() {

        Instance = this;
        BotellasLista = new List<GameObject>(); //Lista de botellas levantadas
        BotellasAcertadas = new List<GameObject>();
    }

    void Tiempo()
    {
        anim1.SetBool("Rotar", false);
        anim2.SetBool("Rotar", false);
        BotellasLista.Clear();
    }

	void nosoniguales()
	{		
		if (cronometro <= -0.5f) 
		{
			anim1.SetBool("Rotar", false);
			anim2.SetBool("Rotar", false);
			BotellasLista.Clear();
		}

	}
    void Update() {



		if(cronometro > -0.5f)
		{
			cronometro -= Time.deltaTime;
		}

        if (cronometro2 > -0.5f)
        {
            cronometro2 -= Time.deltaTime;
        }
	
        if (BotellasLista.Count == 2) //Cuando estan 2 levantadas accede al codigo que tiene como propiedad un numero y a ese numero le da un valor
        {
			
            n1 = BotellasLista[0].GetComponent<NombreText>();
            n2 = BotellasLista[1].GetComponent<NombreText>();
            anim1 = BotellasLista[0].GetComponent<Animator>();
            anim2 = BotellasLista[1].GetComponent<Animator>();

			if (n1.Nom == n2.Nom) { //Compara los nombres de la textura
				anim1 = null;
				anim2 = null;
				BotellasAcertadas.Add (BotellasLista [0]);
				BotellasAcertadas.Add (BotellasLista [1]);
				BotellasLista.Clear ();
			}
			else 
			{
				nosoniguales ();
			}
				
		}

    }
}
	

