using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    [SerializeField] private float maxPositionX;
    [SerializeField] private float maxPositionY;

    private SnakeController snake;

    private void Start()
    {
        snake = FindObjectOfType<SnakeController>();

        transform.position = new Vector3(Random.Range(-maxPositionX, maxPositionX), Random.Range(-maxPositionY, maxPositionY), 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = new Vector3(Random.Range(-maxPositionX, maxPositionX), Random.Range(-maxPositionY, maxPositionY), 0f);

        Manager.Instance.Points += 1;

        snake.NewPartsInstantiate();
    }
}
