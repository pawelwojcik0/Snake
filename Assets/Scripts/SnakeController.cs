using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private GameObject snakePart;
    [SerializeField] private float mindistance;
    [SerializeField] private List<Transform> SnakePartsList = new List<Transform>();

    public Vector2 direction = Vector2.right;
    private float distance;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                direction = Vector2.right;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                direction = Vector2.left;
            }
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direction = Vector2.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                direction = Vector2.down;
            }
        }

        SnakePartsList[0].Translate(direction * movementSpeed * Time.deltaTime);

        for (int i = 1; i < SnakePartsList.Count; i++)
        {
            distance = Vector3.Distance(SnakePartsList[i - 1].position, SnakePartsList[i].position);

            float T = Time.deltaTime * distance / mindistance;

            SnakePartsList[i].position = Vector3.Lerp(SnakePartsList[i].position, SnakePartsList[i - 1].position, T);
        }
    }

    public void NewPartsInstantiate()
    {
        Transform newpart = GameObject.Instantiate(snakePart, SnakePartsList[SnakePartsList.Count - 1].transform.position, Quaternion.identity).transform;
        newpart.SetParent(transform);
        SnakePartsList.Add(newpart);
    }
    
}

