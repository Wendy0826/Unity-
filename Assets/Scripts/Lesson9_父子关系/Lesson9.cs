using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public Transform son;
    // Start is called before the first frame update
    void Start()
    {
        #region 获取和设置父对象
        //获取父对象
        print(this.transform.parent.name);

        //设置父对象
        this.transform.parent = null;
        this.transform.parent = GameObject.Find("Father").transform;

        //通过API设置
        this.transform.SetParent(null);
        this.transform.SetParent(GameObject.Find("Father2").transform);
        //参数一：父对象
        //参数二：是否保留世界坐标的位置、角度、缩放等信息
        //       true保留世界坐标系下的状态，和父对象进行计算得到本地坐标系的信息
        //       false不保留世界坐标系下的状态，位置角度缩放直接赋值到本地坐标系下
        this.transform.SetParent(GameObject.Find("Father3").transform, false);
        #endregion

        #region 抛妻弃子
        //和自己的所有子对象断绝关系
        this.transform.DetachChildren();
        #endregion

        #region 获取子对象
        //按名字查找子对象

        //Find方法能够找到失活的对象，GameObject相关的查找不能找到失活的对象
        //只能找到子对象，不能找到子对象的子对象
        //虽然它的效率比GameObject的方法高一些，但是前提是必须知道父对象
        print(this.transform.Find("Cube").name);

        //遍历子对象
        //如何的得到有多少子对象
        //1.失活的子对象也算数量
        //2.子对象的子对象不会算数量
        print(this.transform.childCount);

        //通过索引号，得到对应的子对象
        //如果索引超出子对象数量会直接报错
        for (int i = 0; i < this.transform.childCount; i++)
        {
            print(this.transform.GetChild(i).name);
        }
        #endregion

        #region 儿子的操作
        //判断父对象
        son.transform.IsChildOf(this.transform);

        //得到自己作为子对象的索引
        print(son.transform.GetSiblingIndex());

        //把自己设置为第一个子对象
        son.SetAsFirstSibling();

        //把自己设定为最后一个子对象
        son.SetAsLastSibling();

        //把自己设置为指定索引的子对象
        son.SetSiblingIndex(2);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //总结
    //设置父对象相关的内容
    //获取子对象相关的内容

    //抛妻弃子

    //儿子的操作
}
