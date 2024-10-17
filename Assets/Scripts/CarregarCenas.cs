using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenas : MonoBehaviour
{
    
    public void Play()
    {
       SceneManager.LoadScene("fase1"); 
    }

    
    public void Agradecimentos()
    {
        SceneManager.LoadScene("Agradecimentos");
    }
}
