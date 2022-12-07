using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11练习题 : MonoBehaviour
{

    public GameObject Tank ;
    
    // Start is called before the first frame update
    void Start()
    {
       GameObject obj = GameObject.Instantiate(Tank);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj = GameObject.Find("Cube(Clone)");
        //1.使用之前的坦克预设体，用WASD控制坦克的前进后退，左右转向
        if (Input.GetKey(KeyCode.W))
        {
            obj.transform.Translate(-10 * Time.deltaTime, 0,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            obj.transform.Translate(10 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            obj.transform.Rotate(0, -100 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            obj.transform.Rotate(0, 100 * Time.deltaTime, 0);
        }
        //2.在上一题的基础上，鼠标左右移动控制炮台的转向
        float move = Input.GetAxis("Mouse X");
        obj.transform.GetChild(0).RotateAround(obj.transform.position, Vector3.up, 1000 * move * Time.deltaTime);
    }
}
