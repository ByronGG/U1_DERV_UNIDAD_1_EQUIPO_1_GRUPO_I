using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_1_MOVE_BASICO : MonoBehaviour
{
    [SerializeField]
    float velocidad = 20;
    int aux = 2;
    public int temp = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * velocidad * Time.deltaTime);
            Debug.Log("W");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -1 *velocidad * Time.deltaTime);
            Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -1 * velocidad * Time.deltaTime);
            Debug.Log("S");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * velocidad * Time.deltaTime);
            Debug.Log("D");
        }
    }
}
