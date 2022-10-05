using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NoteGenerator : MonoBehaviour
{
    [SerializeField] Note notePrefab;

    
    public void SpawnNote()
    {
        Vector3 vector = CircleHorizon(1.0f, 2.5f);
        Instantiate(notePrefab,vector,Quaternion.Euler(-90f, 0,0));
    
    }

    private Vector3 CircleHorizon(float min, float max)
    {

        var angle = Random.Range(0, 360);
        var radius = Random.Range(min, max);
        var rad = angle * Mathf.Deg2Rad;
        var px = Mathf.Cos(rad) * radius;
        var py = Mathf.Sin(rad) * radius;
        //ˆê•”•ÏX‚µ‚Ä‚ ‚é
        return new Vector3(px, 10, py);
    }
}
