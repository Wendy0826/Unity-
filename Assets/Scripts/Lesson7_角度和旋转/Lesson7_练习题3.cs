using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson7_练习题3 : MonoBehaviour
{
    GameObject sun;
    GameObject earth;
    GameObject moon;

    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        earth = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        moon = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        sun.transform.position = Vector3.zero;
        earth.transform.position = new Vector3(10, 0, 0);
        moon.transform.position = new Vector3(10, 2, 0);

        moon.transform.parent = earth.transform;
        earth.transform.parent = sun.transform;

    }

    // Update is called once per frame
    void Update()
    {
        sun.transform.Rotate(sun.transform.up, 10 * Time.deltaTime);
        earth.transform.RotateAround(earth.transform.position,earth.transform.right, 20 * Time.deltaTime);
    }
}
