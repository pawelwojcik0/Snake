using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnakeHead : MonoBehaviour
{
    [SerializeField] private GameObject gameover;

    private SnakeController snake;

    private void Start()
    {
        snake = FindObjectOfType<SnakeController>();    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Snake") || collision.collider.gameObject.layer == LayerMask.NameToLayer("GameArea"))
        {
            snake.direction = Vector3.zero;
            StartCoroutine(RestartCoroutine());
            gameover.SetActive(true);
        }
    }

    IEnumerator RestartCoroutine()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("SampleScene");
    }
    
}
