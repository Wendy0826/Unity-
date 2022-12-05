using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6_练习题3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj = GameObject.Find("Cube(Clone)");
        obj.transform.Translate(Vector3.forward * 1 * Time.deltaTime);
    }
}
