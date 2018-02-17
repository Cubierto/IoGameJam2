using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public List<GameObject> personaje;
    GameObject gancho;
    
    public float playerSpeed = 4f;

    void Start()
    {

    }
    void Update()
    {
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;

        Vector2 moveDirection = GetComponent<Rigidbody2D>().velocity;
        if (moveDirection != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

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

