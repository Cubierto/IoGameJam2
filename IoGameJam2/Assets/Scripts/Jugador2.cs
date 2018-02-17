using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador2 : MonoBehaviour
{

    public List<GameObject> personaje;
    GameObject gancho;

    public float playerSpeed = 4f;

    void Start()
    {

    }
    void FixedUpdate()
    {
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;

        Debug.Log(personaje.Count);

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            soltarLetra(); ;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            lanzarGancho();
        }
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.CompareTag("Letra"))
        {
            agarrarLetra(obj.gameObject);
        }
    }
    void agarrarLetra(GameObject letra)
    {
        personaje.Add(letra);

    }
    void soltarLetra()
    {
        personaje.RemoveAt(personaje.Count - 1);
    }
    void perderLetra(GameObject letrarobada)
    {
        personaje.Remove(letrarobada);
    }
    void lanzarGancho()
    {

    }
}
