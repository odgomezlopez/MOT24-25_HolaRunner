using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    GameManager gameManager;
    public UnityEvent onDie;

    void Start()
    {
        gameManager = GameObject.FindFirstObjectByType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            onDie.Invoke();
            gameManager.GameOver();
        }

        if (collision.gameObject.CompareTag("Meta"))
        {
            gameManager.Win();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            onDie.Invoke();
            gameManager.GameOver();
        }

        if (other.gameObject.CompareTag("Meta"))
        {
            gameManager.Win();
        }
    }
}
