using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]private float speedX;
    [SerializeField]private float speedY;
    private MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        speedY = -0.07f;
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.mainTextureOffset = new Vector2 (speedX * Time.timeSinceLevelLoad, speedY * Time.timeSinceLevelLoad);
    }
}
