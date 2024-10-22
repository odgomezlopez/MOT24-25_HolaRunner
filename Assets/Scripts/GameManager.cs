using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] UnityEvent winEvent;
    [SerializeField] UnityEvent gameOverEvent;

    public void Win()
    {
        Debug.Log("Win!!");
        winEvent.Invoke();
    }

    public void GameOver()
    {
        gameOverEvent.Invoke();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
