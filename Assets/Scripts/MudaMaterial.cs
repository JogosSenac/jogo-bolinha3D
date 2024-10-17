using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMaterial : MonoBehaviour
{
    public Material materialInicial;  // Material inicial
    public Material materialNovo;     // Material a ser aplicado quando atingir os pontos
    private Renderer objetoRenderer;  // Renderer do objeto para aplicar o material
    private PlayerMovement playerMovement;
                   // Pontos do jogador

    void Start()
    {
        objetoRenderer = GetComponent<Renderer>();
        playerMovement = GetComponent<PlayerMovement>();
        objetoRenderer.material = materialInicial;  // Define o material inicial 
        Debug.Log("Pontos do PlayerMovement: " + PlayerMovement.pontos);
    }

    void Update()
    {
       
        // Verifica se os pontos atingiram a quantidade necessária para mudar o material
        if (PlayerMovement.pontos >= 12)
        {
            objetoRenderer.material = materialNovo;  
        
        }
    }
            public void OnCollisionEnter(Collision player)
            {
                if(PlayerMovement.pontos >= 12)
                {
                    if(player.gameObject.CompareTag("Player"))
                    {
                        SceneManager.LoadScene("Fase 2");
                    }
                }
            
             if (playerMovement != null)
             {
            if(PlayerMovement.pontos < 12)
                {
                    if(player.gameObject.CompareTag("Player"))
                    {
                       playerMovement.VoltarParaPosicaoInicial();
                    }
                }
            }
            }
               
            
        
 
}
