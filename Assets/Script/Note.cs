using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    [SerializeField]
    [Tooltip("xŽ²‚Ì‰ñ“]Šp“x")]
    private float rotateX = 0;

    [SerializeField]
    [Tooltip("yŽ²‚Ì‰ñ“]Šp“x")]
    private float rotateY = 20;

    [SerializeField]
    [Tooltip("zŽ²‚Ì‰ñ“]Šp“x")]
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
