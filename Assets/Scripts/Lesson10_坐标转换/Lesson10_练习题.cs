using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson10_练习题 : MonoBehaviour
{
    Vector3 vec1 = new Vector3(-1, 0, 1);
    public void CreateEmpty()
    {
        GameObject empty = new GameObject();
        empty.transform.position = this.transform.TransformPoint(vec1);
    }

    Vector3 vec2 = new Vector3(0, 0, 1);
    Vector3 vec3 = new Vector3(0, 0, 2);
    Vector3 vec4 = new Vector3(0, 0, 3);

    public void CreateSphere()
    {
        GameObject Sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject Sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject Sphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Sphere1.transform.position = this.transform.TransformPoint(vec2);
        Sphere2.transform.position = this.transform.TransformPoint(vec3);
        Sphere3.transform.position = this.transform.TransformPoint(vec4);
    }

    // Start is called before the first frame update
    void Start()
    {
        //一个物体A，不管他在什么位置，写一个方法，只要执行这个方法就可以在他的左前方（-1，0，1）处创建一个空物体
        CreateEmpty();

        //一个物体A，不管他在什么位置，写一个方法，只要执行这个方法就可以在他的前方创建出三个球体，位置分别是（0，0，1），（0，0，2），（0，0，3）
        CreateSphere();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
