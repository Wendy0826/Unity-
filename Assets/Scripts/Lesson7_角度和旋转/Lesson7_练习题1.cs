using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7_练习题1 : MonoBehaviour
{
    public GameObject cube;
    protected GameObject cubeclone;
    protected GameObject Plane;
    // Start is called before the first frame update
    void Start()
    {
        cubeclone = GameObject.Instantiate(cube);
        Plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Plane.transform.position = new Vector3(0, -1.5f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        cubeclone.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0));
        Plane.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0));
        if (cubeclone.transform.rotation.y < 0)
        {
            cubeclone.transform.GetChild(0).transform.Rotate(cubeclone.transform.up, 20 * Time.deltaTime);
            cubeclone.transform.GetChild(1).transform.RotateAround(Vector3.zero, cubeclone.transform.up, 20 * Time.deltaTime);
        }
        else
        {
            cubeclone.transform.GetChild(0).transform.Rotate(cubeclone.transform.up, -20 * Time.deltaTime);
        }

    }
}
