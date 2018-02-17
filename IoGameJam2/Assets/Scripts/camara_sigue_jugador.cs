using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara_sigue_jugador : MonoBehaviour {

    public GameObject player; 
    public Vector3 pos_inicial_player;
    public Vector3 offset;
	// Use this for initialization
	void Start () {


        offset.x= 0.5f;
        offset.y= 0.5f;
		
	}
	
	// Update is called once per frame
    void LateUpdate () {


        /// transformo todo a 2d para medir distancias planas sin tomar en cuenta la diferencia en el eje Z
        Vector2 flat_posicion_player;
        Vector2 flat_posicion_camera;
        flat_posicion_player.x = player.transform.position.x;
        flat_posicion_player.y = player.transform.position.y;
        flat_posicion_camera.x =transform.position.x;
        flat_posicion_camera.y =transform.position.y;

        float distancia = Vector2.Distance(flat_posicion_camera, flat_posicion_player);//distancia entre cam y jugador
        ///termino de transformar todo a 2d para medir distancias planas sin tomar en cuenta la diferencia en el eje Z

        if(Mathf.Abs(distancia)>=0.7) //si la camara se aleja del jugador una dsitancia de 0.7
        {

            if (Mathf.Abs(flat_posicion_player.x - flat_posicion_camera.x)< 0.05) // si el eje y la cámara no estan separados no se  mueva en "x" , es para evitar saltos a pocas distancias 
            {
                
            }
            else
            {
                if (flat_posicion_player.x - flat_posicion_camera.x > 0) //si el jugador está a la derecha, ir a la derecha , else, a la izquierda
                {

                    Vector3 aux;
                    aux = new Vector3(transform.position.x + 0.05f, transform.position.y, -10f);
                    transform.position = aux;
                }
                else
                {
                    Vector3 aux;
                    aux = new Vector3(transform.position.x - 0.05f, transform.position.y, -10f);
                    transform.position = aux;
                }
            }

            if (Mathf.Abs(flat_posicion_player.y - flat_posicion_camera.y)< 0.05)// si el eje y la cámara no estan separados no se  mueva en "y" , es para evitar saltos a pocas distancias 
            {

            }
            else
            {
                if (flat_posicion_player.y - flat_posicion_camera.y > 0) //si el jugador está arriba, ir a arriba, else, a abajo
                {
                    Vector3 aux;
                    aux = new Vector3(transform.position.x , transform.position.y+0.05f, -10f);
                    transform.position = aux;
                }
                else
                {
                    Vector3 aux;
                    aux = new Vector3(transform.position.x, transform.position.y-0.05f, -10f);
                    transform.position = aux;
                }
            }


        }



		
	}
}
