using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI pointsOnScreen; 
    [SerializeField] private GameObject gameover;

    private void Awake()
    {
        gameover.SetActive(false);
    }

    public void UpdatePoints(int Points)
    {
        pointsOnScreen.text = "" + Points;
    }
}
