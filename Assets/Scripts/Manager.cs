using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : Singleton<Manager>
{
    private HUDController HUD;
    private int points;

    public int Points
    {
        get {return points; }
        set
        {
            points = value;
            HUD.UpdatePoints(points);
        }
    }

    private void Start()
    {
        HUD = FindObjectOfType<HUDController>();


        Points = 0;
    }

}
