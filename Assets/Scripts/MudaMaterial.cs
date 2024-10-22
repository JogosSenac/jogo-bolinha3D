using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudaMaterial : MonoBehaviour
{
    public Material materialInicial;  // Material inicial
    public Material materialNovo;     // Material a ser aplicado quando atingir os pontos
    private Renderer objetoRenderer;  // Renderer do objeto para aplicar o material
    private Player player;
    public  bool mudaFase;

    void Start()
    {
        objetoRenderer = GetComponent<Renderer>();
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        objetoRenderer.material = materialInicial;  // Define o material inicial 
        Debug.Log("Pontos do Player: " + player.PegaPontos());
        mudaFase = false;
    }

    void Update()
    {
       
        // Verifica se os pontos atingiram a quantidade necessária para mudar o material
        if (player.PegaPontos() >= 12)
        {
            objetoRenderer.material = materialNovo;  
        
        }
    }
            
}
               
            
        
 

