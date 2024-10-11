using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modifyLogo : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-Time.deltaTime * speed, -Time.deltaTime * speed*1.5f, -Time.deltaTime * speed*0.9f, Space.Self);
    }
}
