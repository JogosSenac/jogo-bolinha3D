using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    public Text textoPontos;  
    public Text textoDeveres;

    void Start()
    {
        AtualizarTexto();  // Atualiza o texto quando o jogo começa
    }

    void Update()
    {
        AtualizarTexto(); 
    }

    // Método para atualizar o texto com o valor da variável pontos
    void AtualizarTexto()
    {
        // Concatenando a variável com a string
        textoPontos.text = PlayerMovement.pontos.ToString() + "/12";
        if (PlayerMovement.pontos == 0)
        {
            textoDeveres.text = ("Colete todos os cubos");
        }
        if (PlayerMovement.pontos == 6)
        {
            textoDeveres.text = ("Quase lá");
        }
        if (PlayerMovement.pontos == 12)
        {
            textoDeveres.text = ("Vá para o portal");
        }


        
    }
}
