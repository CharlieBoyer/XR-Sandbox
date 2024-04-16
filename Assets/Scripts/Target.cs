using System;
using UnityEngine;

public class Target: MonoBehaviour
{
    public int PointsValue;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Point Scored !");
        }
    }
}
