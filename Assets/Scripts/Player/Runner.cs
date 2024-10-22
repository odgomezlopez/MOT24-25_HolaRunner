using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    //Variables
    Rigidbody fisicas;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float incrementPerSecond=1f;

    // Start is called before the first frame update
    void Start()
    {
        fisicas = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Aumeto la velocidad
        speed = speed + incrementPerSecond * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        //Calculo la nueva veocidad
        Vector3 newVelocity = transform.localToWorldMatrix * (Vector3.forward * speed);
        //Hago que la nueva velocidad tenga en cuentas las físicas
        newVelocity.y = fisicas.velocity.y;
        //Aplico la nueva velocidad al RigidBody
        fisicas.velocity = newVelocity;
    }
}
