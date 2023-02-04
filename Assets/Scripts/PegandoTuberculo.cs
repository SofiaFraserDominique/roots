using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegandoTuberculo : MonoBehaviour
{

    private GameObject Tuberculo;
    [SerializeField] private BoolReference PegouTuberculo;
    //[SerializeField] private Animation AnimaPegar;
    [SerializeField] private Animator AnimaPegar;
    


    private void Start()
    {
        PegouTuberculo.Value = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Tuberculo != null)
            {
                Anima(1);
                PegouTuberculo.Value = true;
                
                Destroy(gameObject,0.8f);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
       

        print("coliciu");
        if (other.collider.CompareTag("Player") && PegouTuberculo.Value == false)
        {

            print("Tocou");
            Tuberculo = gameObject;
        }

       
    }

    void OnTriggerExit(Collider other)
    {
        Tuberculo = null;
    }

    void Anima (int numeroDaAnimacao)
    {
        if (numeroDaAnimacao == 1)
        {
            
            AnimaPegar.SetTrigger("Coletouu");
        }
    }

}
