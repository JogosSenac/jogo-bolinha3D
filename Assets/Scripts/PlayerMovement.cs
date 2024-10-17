                using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    private float moveH;
    private float moveV;
    private Rigidbody rb;
    [SerializeField]private float velocidade;
    [SerializeField]private float forcaPulo;
    [SerializeField]private bool invertH;
     [SerializeField]private bool invertV;
     [Header("Sons da Bolinha")]
     [SerializeField] private AudioClip pulo;
      [SerializeField] private AudioClip pegaCubo;
     [SerializeField] private int pontos;
     [SerializeField] private bool estaVivo;
     private AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        estaVivo = true;
        rb = GetComponent<Rigidbody>();
        audioPlayer = GetComponent<AudioSource>();
        velocidade = 7f;
        forcaPulo = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        if(estaVivo == true)
        {
            

        
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveH * Time.deltaTime, 0, moveV * Time.deltaTime );

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

    private void OnCollisionEnter(Collision lava)
    {
        if(lava.gameObject.CompareTag("Lava"))
        {
             estaVivo = false;
             Destroy(this.gameObject);
        }
       
    }
}

