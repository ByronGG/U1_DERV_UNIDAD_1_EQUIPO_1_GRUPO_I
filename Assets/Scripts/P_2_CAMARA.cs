using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_2_CAMARA : MonoBehaviour
{
    public Vector3 distancia; //Offset
    private Transform jugardor;
    [Range (0, 1)] public float lerpValue; //Mueve la camara entre posicion
    public float sensibilidad;

    // Start is called before the first frame update
    void Start()
    {
        jugardor = GameObject.Find("Player").transform; //Find encuentra la etiqueta a la que la camara seguira
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, jugardor.position + distancia, lerpValue); //La camara sigue al cubo
        distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up) * distancia; //Mueve la camara con el mouse y puede ajustar la sensibilidad
        transform.LookAt(jugardor); //La camra mirara al jugador
    }
}
