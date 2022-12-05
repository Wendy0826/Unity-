using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

static class Func
{
    public static void Sort(this Transform obj)
    {
        for (int i = 0; i < obj.childCount - 1; i++)
        {
            int index = 0;
            for (int j = 0; j < obj.childCount - i; j++)
            {
                if (obj.GetChild(j).name.Length > obj.GetChild(index).name.Length)
                {
                    index = j;
                }
            }
            if (index != obj.childCount - 1 - i)
            {
                obj.GetChild(index).SetSiblingIndex(obj.childCount - 1 - i);
            }
        }
    }
    public static List<Transform> FindSubChild(this Transform obj,string name)
    {
        List<Transform> objs = new List<Transform>();
        for (int i = 0; i < obj.childCount; i++)
        {
            if (obj.GetChild(i).name == name)
            {
                 objs.Add(obj.GetChild(i));
            }
            for (int j = 0; j < obj.GetChild(i).childCount; j++)
            {
                if (obj.GetChild(i).GetChild(j).name == name)
                {
                    objs.Add(obj.GetChild(i).GetChild(j));
                }
            }
        }
        return objs;
    }
}

public class Lesson9练习题 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //请为Transform写一个拓展方法，可以将它的子对象按名字的长短进行排序，并改变他们的顺序，名字短的写在前面，名字长的写在后面
        this.transform.Sort();


        //请为Transform写一个拓展方法，传入一个名字查找子对象，即使是子对象的子对象也能查到
        List<Transform> objs = this.transform.FindSubChild("1");
        for (int i = 0; i < objs.Count; i++)
        {
            print(objs[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
