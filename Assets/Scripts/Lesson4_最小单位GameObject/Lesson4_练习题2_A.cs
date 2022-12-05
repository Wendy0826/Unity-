using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_练习题2_A : MonoBehaviour
{
    //一个脚本A一个脚本B，脚本A挂在A对象上，脚本B挂在B对象上，实现脚本A的Start函数中将B对象上的B脚本失活（用GameObject相关知识做）
    void Start()
    {
        GameObject obj = GameObject.Find("Lesson4_练习题2_B");
        Lesson4_练习题2_B gc =obj.GetComponent<Lesson4_练习题2_B>();
        print(gc);
        gc.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
