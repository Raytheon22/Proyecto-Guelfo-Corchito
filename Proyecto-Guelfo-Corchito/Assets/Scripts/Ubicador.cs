using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ubicador : MonoBehaviour {

    public List<Material> MaterialesSinPoner;
    public Material[] mats2;
    public GameObject[] Botellas;
    private Renderer render;
    private NombreText NombredeTextura;
    //Hacer dos listas de 10 elementos, llenarlas de numeros que no se repitan
    //usar .contain() para checkear si un valor ya esta en la lista
    //luego añadir una a otra y con esa lista combinada
    //asignar las etiquetas a las botellas
    
	void Awake () {

        foreach (GameObject g in Botellas)//Recorre todas las botellas antes de empezara jugar
        {    
            int rnd = Random.Range(0, MaterialesSinPoner.Count); //Por botella crea un random
            Mathf.Round(rnd);//Lo redondea
            mats2 = g.GetComponent<Renderer>().materials; //crea una copia de la lista de materiales de la botella
            mats2[1] = MaterialesSinPoner[rnd];             //Le cambia el material de etiqueta por uno random de la lista de etiquetas              
            g.GetComponent<Renderer>().materials = mats2; //Le asigna la etiqueta cambiada
            NombredeTextura = g.GetComponent<NombreText>(); //Guarda el nombre de la textura
            NombredeTextura.Nom = mats2[1].name; //Le asigna el nombre de la textura a la botella
            MaterialesSinPoner.Remove(MaterialesSinPoner[rnd]);
        }
    }
}
