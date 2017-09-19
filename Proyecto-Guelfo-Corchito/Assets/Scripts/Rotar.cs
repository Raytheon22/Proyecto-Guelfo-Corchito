using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{

    public Animator anim;
    public Animator animcam;
    public NombreText Identidad;
    public float Cronometro;
    bool restar;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        animcam = Camera.main.GetComponent<Animator>();
        Identidad = gameObject.GetComponent<NombreText>();
    }

    void OnMouseUp()
    {
        if (MemotestManager.Instance.BotellasLista.Count == 0 && MemotestManager.Instance.cronometro2 < 0)//Si no hay botellas levantadas, agrega esta a la lista de levantadas
        {
            MemotestManager.Instance.cronometro2 = 3.0f;
            animcam.SetBool("Vuelve", false);
            animcam.SetInteger("Botella", Identidad.Num);
            anim.SetBool("Rotar", true);//La rota
            restar = true;
            Cronometro = 2.0f;
            MemotestManager.Instance.BotellasLista.Add(gameObject); //La añade a la lista de botellas levantadas


        }
        if (MemotestManager.Instance.BotellasLista.Count == 1 && MemotestManager.Instance.BotellasLista[0].name != gameObject.name && MemotestManager.Instance.cronometro2 < 0) //Si hay una levantada, y es diferente a esta, agrega a esta tambien
        {
            MemotestManager.Instance.cronometro2 = 3.0f;
            animcam.SetBool("Vuelve", false);
            animcam.SetInteger("Botella", Identidad.Num);
            MemotestManager.Instance.cronometro = 1.5f;
            anim.SetBool("Rotar", true); //La rota
            restar = true;
            Cronometro = 2.0f;
            MemotestManager.Instance.BotellasLista.Add(gameObject); //La añade a la lista de botellas levantadas
        }
    }

    void Update()
    {
        if (Cronometro > -0.5f)
        {
            Cronometro -= Time.deltaTime;
        }

        if (Cronometro < 0 && restar)
        {
            animcam.SetInteger("Botella", 0);
            animcam.SetBool("Vuelve", true);
            restar = false;
        }

        if (Input.GetKey(KeyCode.R)) //Limpia la lista y vuelve al lugar a las botellas
        {
            anim.SetBool("Rotar", false);
            MemotestManager.Instance.BotellasLista.Clear();
        }
    }
}