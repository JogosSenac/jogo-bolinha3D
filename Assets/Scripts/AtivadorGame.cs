using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivadorGame : MonoBehaviour
{
private Player player;
        public GameObject canvaRestart;
 
    public void Start()
        {
            player = GameObject.FindObjectOfType<Player>();
 
            canvaRestart.SetActive(false);
        }
 
 
    public void Update()
        {
            Ativando();
        }
 
    public void Ativando()
        {
            if(!player.VerificaVidaPlayer())
                {
                    canvaRestart.SetActive(true);
                }
        }
 
 
    public void Desativando()
        {
            canvaRestart.SetActive(false);
        }
 
}
