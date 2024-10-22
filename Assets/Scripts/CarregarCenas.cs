using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenas : MonoBehaviour
{
    private MudaMaterial mudaMaterial; 
    

    void Start()
    {
         mudaMaterial = GameObject.FindWithTag("Player").GetComponent<MudaMaterial>();
    }
    public void Play()
    {
       SceneManager.LoadScene("fase1"); 
    }

    
    public void Agradecimentos()
    {
        SceneManager.LoadScene("Agradecimentos");
    }

    public void Fase2()
    {
        if (mudaMaterial.mudaFase == true )
        {
            SceneManager.LoadScene("fase2"); 
        }
    }
}
