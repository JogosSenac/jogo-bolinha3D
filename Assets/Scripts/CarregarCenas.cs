using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenas : MonoBehaviour
{
    
    public void Start()
    {
    
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
    public void Fase1()
    {
       SceneManager.LoadScene("fase1"); 
       Time.timeScale = 1;
    }
    public void Fase2()
    {
        SceneManager.LoadScene("fase2");
        Time.timeScale = 1;
    }
    public void Agradecimentos()
    {
        SceneManager.LoadScene("Agradecimentos");
        Time.timeScale = 1;
    }

}
