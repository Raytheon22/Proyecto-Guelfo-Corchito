using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{

    public Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void OnMouseUp()
    {
        if (MemotestManager.Instance.BotellasLista.Count == 0)//Si no hay botellas levantadas, agrega esta a la lista de levantadas
        {
            anim.SetBool("Rotar", true);//La rota
            MemotestManager.Instance.BotellasLista.Add(gameObject); //La añade a la lista de botellas levantadas
        }
        if (MemotestManager.Instance.BotellasLista.Count == 1 && MemotestManager.Instance.BotellasLista[0].name != gameObject.name) //Si hay una levantada, y es diferente a esta, agrega a esta tambien
        {
            anim.SetBool("Rotar", true); //La rota
            MemotestManager.Instance.BotellasLista.Add(gameObject); //La añade a la lista de botellas levantadas
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R)) //Limpia la lista y vuelve al lugar a las botellas
        {
            anim.SetBool("Rotar", false);
            MemotestManager.Instance.BotellasLista.Clear();
        }
    }
}