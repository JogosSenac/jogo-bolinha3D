using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private float moveH;
    private float moveV;
    private Rigidbody rb;
    [SerializeField]private float velocidade;
    [SerializeField]private float forcaPulo;
    [SerializeField]private bool invertH;
    [SerializeField]private bool invertV;
    [SerializeField]public int pontos;
    [SerializeField]public bool estaVivo;
    [SerializeField]private bool TocandoChao;
    [SerializeField]public Vector3 posicaoInicial;
    [Header("Sons da Bolinha")]
    [SerializeField]private AudioClip pulo;
    [SerializeField]private AudioClip pegaCubo;
    [SerializeField]private AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        estaVivo = true;
        rb = GetComponent<Rigidbody>();
        audioPlayer = GetComponent<AudioSource>();
        velocidade = 3.5f;
        forcaPulo = 7f;
        posicaoInicial = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(estaVivo == true)
        {
            

        
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveH * Time.deltaTime * velocidade, 0, moveV * Time.deltaTime * velocidade );

        //Pulo
       
       
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * forcaPulo, ForceMode.Impulse);
            audioPlayer.PlayOneShot(pulo);
            
        
        }

        

    }
    }
     private void OnTriggerEnter(Collider moeda)
    {
        Destroy(moeda.gameObject);
         audioPlayer.PlayOneShot(pegaCubo);
        pontos++;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Lava"))
        {
             estaVivo = false;
             
            Time.timeScale = 0;
        }
        if(other.gameObject.CompareTag("Portal") && pontos < 12)
        {
            VoltarParaPosicaoInicial();
        }
    }  
    public void VoltarParaPosicaoInicial()
    {
        transform.position = posicaoInicial;  // Reseta a posição do player para a posição inicial
    }     
    public int PegaPontos()
    {
        return pontos;
    }
}   

