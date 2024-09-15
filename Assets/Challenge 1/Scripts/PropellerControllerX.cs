using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PropellerControllerX : MonoBehaviour
{
    
    private readonly float speed = 1500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, new Vector3(0, 0, 1), speed * Time.deltaTime);
    }
}
