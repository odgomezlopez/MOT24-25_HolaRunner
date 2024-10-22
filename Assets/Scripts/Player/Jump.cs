using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Jump : MonoBehaviour
{
    //Variables
    [SerializeField] public float jumpForze = 5f;
    private bool jumping = false;

    //Eventos
    public UnityEvent OnJump;

    //Referencia a otros componentes
    Rigidbody fisicas;

    // Start is called before the first frame update
    void Start()
    {
        fisicas = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() { 
        if(Input.GetKeyDown(KeyCode.Space)){
            jumping = true;
            OnJump.Invoke();
        }
    }

    private void FixedUpdate()
    {
        if (jumping)
        {
            fisicas.AddForce(Vector3.up * jumpForze, ForceMode.Impulse);
            jumping = false;
        }
    }
}
