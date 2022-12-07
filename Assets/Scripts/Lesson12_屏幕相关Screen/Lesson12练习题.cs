using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12练习题 : MonoBehaviour
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

        //1.在输入练习题的基础上，鼠标滚轮控制炮管的抬起和放下
        Transform temp = obj.transform.GetChild(0).GetChild(0);
        float move2 = Input.mouseScrollDelta.y;
        temp.transform.RotateAround(new Vector3(temp.position.x + temp.localScale.y / 2, temp.position.y, temp.position.z), temp.right, 1000 * move2 * Time.deltaTime);


        //2.在上一题的基础上，加入长按鼠标右键移动鼠标可以让摄像机围着坦克旋转 改变观察坦克的视角
        if (Input.GetMouseButton(1))
        {
            GameObject Camera = GameObject.Find("Main Camera");
            Camera.transform.RotateAround(obj.transform.position, obj.transform.up, 100 * Time.deltaTime);
        }
    }
}
