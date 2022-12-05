using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_练习题3_A : MonoBehaviour
{
    public string B_name;
    public bool B_enabled;
    public bool B_destory;
    public bool B_destroyImmediate;
    void Start()
    { //一个对象A和一个对象B，在A上挂一个脚本，通过这个脚本可以让B对象改名，失活，延迟删除，立即删除。你可以在inspector窗口进行设置，让B实现不同的效果
        GameObject obj = GameObject.Find("Lesson4_练习题3_B");
        obj.name = B_name;
        obj.SetActive(B_enabled);
        if(B_destory == true)
        {
            Destroy(obj);
        }
        if (B_destroyImmediate == true)
        {
            DestroyImmediate(obj);
        }
    }
}
