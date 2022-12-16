using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 刚体
        //碰撞产生的必要条件
        //两个物体都有碰撞器，至少一个物体有刚体

        #region RigidBody组件信息
        //Mass 质量（默认为KG）
        //质量越大惯性越大

        //Drag 空气阻力
        //根据力移动对象时影响对象的空气阻力大小
        //0表示没有空气阻力

        //Angluar Drag
        //根据扭矩旋转对象时影响对象的空气阻力大小
        //0表示没有空气阻力

        //Use Gravity 是否受重力影响

        //Is Kinematic
        //如果启用此选项，则对象将不会被物理引擎驱动，只能通过（Transform）对其进行操作
        //对于移动平台，或者如果要动画化附加了HingeJoint的刚体，此属性将非常有用

        //Interpolate 插值运算
        //让刚体物体移动更平滑
        //  None 不应用插值运算
        //  Interpolate 根据前一帧的变换来平滑变换
        //  Extrapolate 差值计算，根据下一帧的估计变化来平滑变换

        //Collision Detection（碰撞检测模式）
        //用于放置快速移动的对象穿过其他对象而不检测碰撞
        //  Discrete 离散检测
        //      对场景中所有其他碰撞体使用离散碰撞检测。其他碰撞体在测试碰撞时会使用离散碰撞检测。用于正常碰撞（默认值）
        //  Continuous 连续检测
        //      对动态碰撞体（具有刚体）使用离散碰撞检测
        //      并对静态碰撞体（没有刚体）使用连续碰撞检测
        //      设置为连续动态（Continuous Dynamic）的刚体将在测试与该刚体的碰撞时使用连续碰撞检测。（此属性对物理性有很大影响，如果没有快速对象的碰撞问题请将其保留为Discrete设置）
        //      其他刚体将使用离散碰撞检测
        //  Continuous Dynamic (连续动态检测)性能消耗高
        //      对设置为连续（Continuous）和连续动态（Continuous Dynamic）碰撞的游戏对象使用连续碰撞检测。还将对静态碰撞体（没有刚体）使用连续碰撞检测
        //      对于所有其他碰撞体，使用离散碰撞检测。用于快速移动的对象
        //  Continuous Speculative（连续推测检测）
        //      对刚体和碰撞体使用推测下连续碰撞检测。该方法通常比连续碰撞检测的成本更低

        //Constrants 约束
        //对刚体运动的限制
        //  Freeze Position
        //      有选择地停止刚体沿世界X、Y和Z轴的移动
        //  Freeze Position
        //      有选择地停止刚体围绕局部X、Y和Z轴旋转
        #endregion
        #endregion

        #region 碰撞器
        //碰撞器表示物体的体积（形状）
        //刚体会利用体积进行碰撞计算，模拟真实的碰撞效果，产生里的作用

        #region 1.3D碰撞器种类
        //1.盒状
        //2.球状
        //3.胶囊
        //4.网格
        //5.轮胎
        //6.地形

        #endregion

        #region 2.共同参数
        //Is Trigger
        //是否是触发器，如果启用此属性
        //则该碰撞体将用于触发事件，并被物理引擎忽略
        //主要用于进行没有物理效果的碰撞检测

        //Material
        //物理材质，可以确定碰撞体和其他对象碰撞时的交互（表现）方式

        //Center
        //碰撞体在对象局部空间中的中心点位置

        #endregion

        #region 3.常用碰撞器
        //Box Collider 盒状碰撞器
        //  Size 碰撞体在X、Y、Z上方向的大小

        //Sphere Collider 球状碰撞器
        //  Radius 球形碰撞体的半径大小

        //Capsule Collider 胶囊碰撞器
        //  Radius 胶囊体的半径
        //  Height 胶囊体的高度
        //  Direction 胶囊体在对象局部空间中的轴向

        #endregion

        #region 4.异形物体使用多种碰撞器组合
        //刚体对象的子对象碰撞器信息参与碰撞检测
        #endregion

        #region 不常用碰撞器
        //Mesh Collider 网格碰撞器
        //  Convex
        //      勾选此复选框可启用Convex。如果启用此属性，该Mesh Collider将与其他Mesh Collider发生碰撞
        //      Convex Mesh Collider最多255个三角形
        //  Cooking Options
        //      启用或金庸影响物理引擎对网格处理方式的网格烹制选项
        //  Mesh
        //      引用需要用于碰撞的网格

        //Wheel Collider 轮胎碰撞器

        //Terrain Collider 地形碰撞器
        #endregion
        #endregion

        #region 物理材质
        //创建物理材质

        //物理材质参数
        //  Dynamic Friction
        //      已在移动时使用的摩擦力。通常为0-1之间的值。值为零就像冰一样，值为1将使对象迅速静止（除非用很大的力或重力推动对象）
        //  Static Friction
        //      当对象静止在表面上时使用的摩擦力。通常为0-1之间的值。值为零就像冰一样，值为1将导致很难让对象移动
        //  Bounciness
        //      表面弹性如何？值为0将不会反弹。值为1时在反弹时不产生任何能量损失，预计会有一些近似值，但只可能会给模拟增加少量能量
        //  Friction Combine
        //      两个碰撞对象的摩擦力的组合方式
        //      -Average 对两个摩擦值求平均值
        //      -Minimun 使用两个值中的最小值
        //      -Maximun 使用两个值中的最大值
        //      -Multiply 两个摩擦值相乘
        //  Unce Combine
        //      两个碰撞对象的弹性的组合方式。其模式与Friction Combine模式相同
        #endregion

        

    }

    #region 碰撞检测函数
    #region 注意：碰撞和触发响应函数，属于特殊的生命周期函数，也是通过反射调用

    #endregion

    #region 物理碰撞检测响应函数
    //碰撞触发接触时，会自动触发这个函数
    private void OnCollisionEnter(Collision collision)
    {
        //Collision类型的参数，包含了碰到自己的对象的相关信息

        // 关键参数
        //1.碰撞到的对象碰撞器的信息
        //collision.collider
        //2.碰撞对象的依附对象（GameObject）
        //collision.gameObject
        //3.碰撞对象的依附对象的位置信息
        //collision.transform
        //4.触碰点数相关
        //collision.contactCount
        //接触点具体的坐标
        //collision.contacts
        //只要得到了碰撞到的对象的任意信息，就可以得到他的所有信息
        print(this.name + "被" + collision.gameObject.name + "撞到了");
    }

    //碰撞结束分离时，会自动执行的函数
    private void OnCollisionExit(Collision collision)
    {
        print(this.name + "被" + collision.gameObject.name + "结束碰撞了");
    }

    //当两个物体接触摩擦时，就会一直调用该函数
    private void OnCollisionStay(Collision collision)
    {
        print(this.name + "被" + collision.gameObject.name + "碰撞中");
    }

    #endregion

    #region 触发器检测响应函数
    //触发开始的函数，第一次接触时会自动调用
    private void OnTriggerEnter(Collider other)
    {
        print(this.name + "被" + other.gameObject.name + "接触到了");
    }
    //触发结束的函数，结束接触时会自动调用
    private void OnTriggerExit(Collider other)
    {
        print(this.name + "被" + other.gameObject.name + "结束接触了");
    }
    //两个物理接触中会不停的调用
    protected virtual void OnTriggerStay(Collider other)
    {
        print(this.name + "被" + other.gameObject.name + "接触中");
    }
    #endregion

    #region 要明确什么时候会响应函数
    //1.只要挂载的对象能跟别的物体产生碰撞或者触发，那么对应的这六个函数，就能被响应
    //2.六个函数不是都要使用，具体的使用根据需求
    //3.如果时一个异形物体，刚体在父对象上，如果你想通过子对象挂脚本检测碰撞是不行的，必须挂载到刚体父对象上
    //4.要明确物理碰撞和触发器响应的区别
    #endregion

    #region 碰撞和触发器函数都可以写成虚函数 在子类去重写逻辑
    //一般会把想要重写的碰撞和出发函数携程保护类型的，没必要写成public，因为不会自己手动调用，都是unity自己调用
    #endregion
    #endregion
    // Update is called once per frame
    void Update()
    {
        
    }
}
