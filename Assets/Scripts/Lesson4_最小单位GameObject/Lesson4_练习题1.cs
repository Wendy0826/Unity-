using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_练习题1 : MonoBehaviour
{
    public GameObject obj;
    void Start()
    {
        //一个空物品上挂了一个脚本，游戏运行时该脚本可以实例化出之前的坦克预设体
        GameObject.Instantiate(obj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
