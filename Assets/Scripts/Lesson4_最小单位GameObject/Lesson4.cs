using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    //准备用来克隆的对象
    //1.直接是场景上的某个对象
    //2.可以是一个预设体对象
    public GameObject gb;

    void Start()
    {
        #region GameObject中的成员变量
        //名字
        print(this.gameObject.name);
        this.gameObject.name = "Lesson4";

        //是否激活
        print(this.gameObject.activeSelf);

        //是否是静态
        print(this.gameObject.isStatic);

        //层级
        print(this.gameObject.layer);

        //标签
        print(this.gameObject.tag);

        //transform
        print(this.gameObject.transform.position);
        #endregion

        #region GameObject中的静态方法

        #region 创建自带几何体
        //只要得到了一个GameObject对象，我么就可以得到他身上挂载的任何脚本信息
        //通过GetComponent来得到
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "创建的立方体";
        #endregion

        #region 查找对象的方法
        //1.查找单个对象
        //无法找到失活的对象，只能找到激活的对象

        //如果场景中存在多个满足条件的对象
        //我们无法指定找到某个对象

        //通过对象名查找
        //这个查找效率低下，因为他会在场景中所有对象去查找
        GameObject obj2 = GameObject.Find("创建的立方体");
        if (obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("没有对应的对象");
        }

        //通过tag来查找对象
        GameObject obj3 = GameObject.FindWithTag("Player");
        obj3 = GameObject.FindGameObjectWithTag("Player");
        if (obj3 != null)
        {
            print(obj3.name);
        }
        else
        {
            print("没有对应的对象");
        }

        //2.查找多个对象
        //找多个对象的API，只能通过tag去找多个
        //只能找到激活对象，无法找到失活对象
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print(objs.Length);

        //还有几个查找对象相关的是用的比较少的方法，是GameObject父类Object提供的方法
        //Unity里面的Object不是指的万物之父object
        //Unity里面的Object命名空间再UnityEngine中的Object类，也是继承万物之父的一个自定义类
        //C#中的Object的命名空间在System中的

        //可以找到场景中挂载的某一个脚本对象
        Lesson4 lesson4 = GameObject.FindObjectOfType<Lesson4>();
        print(lesson4.gameObject.name);
        #endregion

        #region 实例化对象（克隆对象）的方法
        //根据一个GameObject对象创建出一个和它一模一样的对象
        GameObject obj4 = GameObject.Instantiate(gb);
        //如果继承了MonoBehaviour，可以不用写GameObject一样可以使用
        //因为这个方法是Unity里面的Object基类提供的
        GameObject obj5 = Instantiate(gb);
        #endregion

        #region 删除对象的方法
        GameObject.Destroy(obj4);
        //第二个参数代表延迟几秒钟参数
        GameObject.Destroy(obj5, 10);
        //Destroy不仅可以删除对象，还可以删除脚本
        GameObject.Destroy(this);

        //删除对象有两种作用
        //1.删除指定的一个游戏对象
        //2.删除一个指定的脚本对象
        //注意：这个Destroy方法，不会马上移除对象，一般情况下他会在下一帧时把这个对象移除并从内存中移除

        //如果没有立即移除的需求，建议使用Destory方法，可以降低卡顿的概率
        GameObject.DestroyImmediate(this);
        //如果继承了MonoBehaviour，可以不用写GameObject一样可以使用
        //因为这个方法是Unity里面的Object基类提供的
        DestroyImmediate(this);
        #endregion

        #region 过场景不移除
        //默认在切换场景时，场景中的对象都会被自动删除掉
        //如果你希望某个对象过场景不被移除
        //下面这句代码，就是不想谁过场景被移除就传谁
        //一般都是传依附的GameObject对象
        GameObject.DontDestroyOnLoad(this.gameObject);
        //如果继承了MonoBehaviour，可以不用写GameObject一样可以使用
        //因为这个方法是Unity里面的Object基类提供的
        DontDestroyOnLoad(this.gameObject);
        #endregion

        #endregion

        #region GameObject中的成员方法
        #region 创建空物体
        GameObject obj6 = new GameObject();
        GameObject obj7 = new GameObject("空物体");
        GameObject obj8 = new GameObject("空物体", typeof(Lesson4), typeof(Lesson2));
        #endregion

        #region 为对象添加脚本
        //继承MonoBehaviour的脚本是不能去new的
        //如果想要动态的添加MonoBehaviour的脚本在某一个对象上
        //直接使用GameObject提供的方法即可
        Lesson2 les1 = obj6.AddComponent(typeof(Lesson2)) as Lesson2;
        les1 = obj6.AddComponent<Lesson2>();
        //通过返回值可以得到加入的脚本信息，来进行一些处理
        #endregion

        //得到脚本的成员方法和继承Mono的类得到脚本的方法一模一样

        #region 标签比较
        //两种比较的方法是一样的
        if (this.gameObject.CompareTag("Player"))
        {
            print(this.gameObject.name);
        }

        if (this.gameObject.tag == "Player")
        {
            print(this.gameObject.name);
        }
        #endregion

        #region 设置激活失活
        //true激活 false失活
        obj6.SetActive(true);
        #endregion

        #region 次要成员方法
        //了解即可 不建议使用
        //强调：效率较低不建议使用
        //通过广播或者发送消息的形式，让自己或者别人执行某些行为方法

        //通知自己,执行什么行为
        //在自己身上挂载的所有脚本去找这个名字的函数
        this.gameObject.SendMessage("TestFun");
        this.gameObject.SendMessage("TestFun2", 199);

        //广播行为，让自己和自己的子对象执行
        this.gameObject.BroadcastMessage("TestFun");

        //向父对象和自己发送消息并执行
        this.gameObject.SendMessageUpwards("TestFun");
        #endregion
        #endregion
    }

    void TestFun()
    {
        print("打印TestFun");
    }
    void TestFun2(int a)
    {
        print("打印TestFun2" + a);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    //总结
    //GameObject中常用的内容

    //基本成员变量
    //名字
    //失活激活状态
    //标签
    //层级
    //...

    //静态方法
    //创建自带集合体
    //查找场景中对象
    //实例化对象
    //删除对象
    //过场景不移除

    //成员方法
    //为对象动态添加指定脚本
    //设置失活激活的状态
    //和MonoBehavior中相同的得到脚本的方法
}
