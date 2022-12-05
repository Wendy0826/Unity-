using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    #region 知识点一 了解帧的概念
    //Unity底层已经帮助我们做好了死循环
    //我们需要学习Unity的生命周期函数
    //利用它做好的规则来执行我们的游戏逻辑就行了
    #endregion

    #region 知识点二 生命周期函数的概念
    //所有继承MonoBehaviour的脚本 最终都会挂载到GameObject游戏对象上
    //生命周期函数 就是该脚本对象依附的GameObject对象从出生到死亡整个生命周期中
    //会通过反射自动调用的一些特殊函数

    //Unity帮助我们记录了一个GameObject对象依附了哪些脚本
    //会自动的得到这些对象，通过反射去执行一些固定名字的函数
    #endregion

    #region 知识点三 生命周期函数
    //注意：
    //生命周期函数的访问修饰符一般为private和protect
    //因为不需要再外部自己调用生命周期函数 都是Unity自己帮助我们调用的

    //当对象（自己这个类对象）被创建时 才会调用该生命周期函数
    //类似构造函数的存在 我们可以再一个类对象创建时进行一些初始化操作
    void Awake()
    {
        //再unity中打印信息的两种方式
        //1.没有继承MonoBehaviour类的时候
        //Debug.Log("123");
        //debug.logerror("出错了！！！");
        //debug.logwarning("警告！！！");
        //2.继承MonoBehaviour类的时候
        print("Awake");
    }


    //想要当一个对象被激活时进行一些逻辑处理
    void OnEnable()
    {
        print("OnEnable");
    }
     
    //主要作用也是用于初始化信息，但是相对于Awake要晚一点
    //因为它是在对象进行第一次帧更新之前才会执行的
    void Start()
    {
        print("Start");
    }

    //主要是用于进行物理更新
    //每一帧都执行，但是这里的帧和游戏帧不同
    //它的时间间隔可以在Edit->Project Settings->Time->Fixed Timestep进行修改
    void FixedUpdate()
    {
        print("FixedUpdate");
    }

    //主要用于处理游戏逻辑更新的函数
    void Update()
    {
        print("Update");
    }

    //一般这个更新是用来处理摄像机位置更新相关内容的
    //Update和LateUpdate之间进行了一些处理，处理动画相关的更新
    void LateUpdate()
    {
        print("LateUpdate");
    }

    //对象失活时需要进行处理，就可以在该函数中写逻辑
    //对象失活时，需要循环执行的生命周期函数也会停止执行（比如FixedUpdate、Update、LateUpdate等）
    void OnDisable()
    {
        print("OnDisable");
    }

    //GameObjcet对象销毁时调用
    void OnDestroy()
    {
        print("OnDestroy");
    }
    #endregion

    #region 知识点四 生命周期函数 支持继承多态

    #endregion
}
