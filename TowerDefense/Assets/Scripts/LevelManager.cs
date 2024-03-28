using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public Transform[] waypoints;
    public Transform startPoint;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
