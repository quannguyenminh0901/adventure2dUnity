using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//cWi : current Waypoint Index
// wP: waypoints
public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] wP;
    private int cWi = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if (Vector2.Distance(wP[cWi].transform.position, transform.position) < .1f)
        {
            cWi++;
            if (cWi >= wP.Length)
            {
                cWi = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wP[cWi].transform.position, Time.deltaTime * speed);
    }
}
