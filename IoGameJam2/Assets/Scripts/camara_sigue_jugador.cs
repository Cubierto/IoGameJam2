using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara_sigue_jugador : MonoBehaviour
{

    public GameObject player;
    public float velocidad = 1.0f;
    public Vector3 offset;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {


        Vector3 desiredPosition = player.transform.position + offset;
        Vector3 posicionsuave = Vector3.Lerp(transform.position, desiredPosition, velocidad * Time.deltaTime);
        posicionsuave.z = -10;
        transform.position = posicionsuave;



    }
}
