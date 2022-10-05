using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    [SerializeField]
    [Tooltip("x���̉�]�p�x")]
    private float rotateX = 0;

    [SerializeField]
    [Tooltip("y���̉�]�p�x")]
    private float rotateY = 20;

    [SerializeField]
    [Tooltip("z���̉�]�p�x")]
    private float rotateZ = 0;


    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 40;
    }

    // Update is called once per frame
    void Update()
    {
        
        gameObject.transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime);
        if (gameObject.transform.position.y <= -20)
        {
            Destroy(this.gameObject);
        }

    }
}
