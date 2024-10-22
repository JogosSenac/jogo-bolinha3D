using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using TMPro;

public class Textos : MonoBehaviour
{
    public TextMeshProUGUI textoPontos;  
    public TextMeshProUGUI textoDeveres;
      private Player player;
    
    void Start()
    {
        AtualizarTexto();  // Atualiza o texto quando o jogo começa
         player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    void Update()
    {
        AtualizarTexto(); 
    }

    
    void AtualizarTexto()
    {
        // Concatenando a variável com a string
        textoPontos.text = player.PegaPontos().ToString() + "/12";
        if (player.PegaPontos() == 0)
        {
            textoDeveres.text = ("Colete todos os cubos, mas não encoste na LAVA");
        }
        if (player.PegaPontos() == 6)
        {
            textoDeveres.text = ("Quase lá");
        }
        if (player.PegaPontos() == 12)
        {
            textoDeveres.text = ("Vá para o portal");
        }
        if (player.estaVivo == false)
        {
            textoDeveres.text = ("Você Morreu!");
        }


        
    }
}
