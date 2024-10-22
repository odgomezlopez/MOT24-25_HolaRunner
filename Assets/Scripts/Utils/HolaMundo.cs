using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    [SerializeField] private string mensanje = "Hola mundo!!";
    Rigidbody fisicas;
    public float fuerza = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //Obtengo el componete RigidBody
        Debug.Log(mensanje);
        fisicas = GetComponent<Rigidbody>();

        //Aplicar una fuerza hacía arriba
        fisicas.AddForce(Vector3.up * fuerza, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
