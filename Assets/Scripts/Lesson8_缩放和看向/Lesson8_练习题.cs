using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8_练习题 : MonoBehaviour
{
    public Transform transformObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(transformObj);
    }
}
