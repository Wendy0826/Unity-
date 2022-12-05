using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
        #region Transform主要用来干嘛？
        //游戏对象（GameObject）位移、旋转、缩放、父子关系、坐标转换等相关操作都由它处理
        //它是Unity提供的极其重要的类
        #endregion

        #region 必备知识点 Vector3基础
        //Vector3主要是用来表示三维坐标系中的一个点或者是一个向量
        //申明
        Vector3 v = new Vector3();
        v.x = 10;
        v.y = 10;
        v.z = 10;

        //只传xy，默认z是0
        Vector3 v2 = new Vector3(10, 10);

        //传xyz
        Vector3 v3 = new Vector3(10, 10, 10);

        //默认0，0，0
        Vector3 v4;

        //Vector的基本计算
        //+ - * /
        Vector3 v5 = new Vector3(1, 1, 1);
        Vector3 v6 = new Vector3(2, 2, 2);
        print(v5 + v6);
        print(v5 - v6);
        print(v5 * 2);
        print(v5 / 2);

        //常用
        print(Vector3.zero);//0,0,0
        print(Vector3.right);//1,0,0
        print(Vector3.left);//-1,0,0
        print(Vector3.forward);//0,0,1
        print(Vector3.back);//0,0,-1
        print(Vector3.up);//0,1,0
        print(Vector3.down);//0,-1,0

        //常用的方法
        //计算两个点之间的距离的方法
        Vector3.Distance(v5, v6);

        #endregion

        #region 位置
        //相对世界坐标系
        //通过position得到的位置是相对于世界坐标系的原点的位置，可能和面板上显示的不一样
        //因为如果对象有父子关系，并且父对象位置不在原点，那么和面板上肯定
        print(this.transform.position);

        //相对父对象
        //这两个坐标对我们很重要，如果你想以面板坐标为准来进行位置设置，那一定是通过localPosition来进行设置
        print(this.transform.localPosition);

        //两个坐标一样的情况
        //1.父对象的坐标 就是世界坐标系原点0,0,0
        //2.对象没有父对象

        //注意：位置的赋值不能直接改变x,y,z，只能整体改变
        this.transform.position = new Vector3(10, 10, 10);
        this.transform.localPosition = Vector3.up * 10;

        //如果只想改一个值
        //1.直接赋值
        this.transform.position = new Vector3(20, this.transform.position.y, this.transform.position.z);
        //2.先取出来再赋值
        //虽然不能直接改 transform的xyz，但是Vector3是可以直接改xyz的
        //所以可以先取出来改Vector3再重新赋值
        Vector3 vPos = this.transform.position;
        vPos.x = 10;
        this.transform.position = vPos;

        //对象当前的各朝向
        //对象当前的面朝向（z）
        print(this.transform.forward);
        //对象当前的头顶朝向（y）
        print(this.transform.up);
        //对象当前的右朝向（z）
        print(this.transform.right);

        #endregion


    }

    // Update is called once per frame
    void Update()
    {
        #region 位移
        //理解坐标系下的位移计算公式
        //路程 = 方向 * 速度 * 时间

        //方式一 自己计算
        //变化的就是position
        //用当前的位置+我要动多长距离，得到最终所在的位置
        //this.transform.position = this.transform.position + this.transform.forward * 1 * Time.deltaTime;
        //this.transform.position += this.transform.forward * 1 * Time.deltaTime;

        //方式二 API
        //参数一：表示位移多少
        //参数二：表示相对坐标系,默认是相对于自己坐标系的

        //相对世界坐标系的Z轴动
        this.transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.World);

        //相对于世界坐标系的自己的面朝向动
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.World);

        //相对于自己坐标系的面朝向动（一定不会让自己这样移动）
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.Self);

        //注意：一般用API来进行位移
        #endregion
    }
    //总结
    //Vector3
    //如何申明提供的常用静态属性，和一个距离结算的方法
    //位置
    //相对于世界坐标系和相对于父对象，这两个坐标的区别
    //不能够单独修改xyz，只能统一改
    //位移
    //自己如何计算来进行位移
    //API是哪个方法来进行位移，使用时要注意

}
