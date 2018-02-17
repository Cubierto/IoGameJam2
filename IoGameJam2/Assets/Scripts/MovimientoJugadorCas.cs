using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugadorCas : MonoBehaviour {

    public float velocidad = 1.0f;

    void Start()
    {
        Transform tras = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update () {
        Vector3 movimiento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += movimiento * velocidad * Time.deltaTime; 
	}
}
