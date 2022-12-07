using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region 注意：输入相关内容肯定是写在Update中的

        #endregion

        #region 鼠标在屏幕位置
        //屏幕坐标的原点屏幕的左下角，往右是x轴正方向，往上是y轴正方向
        //返回值是Vector3，但是只有x和y有值，z一直是0，屏幕本来就是2D的，不存在Z轴
        //print(Input.mousePosition);
        #endregion

        #region 检测鼠标输入
        //鼠标按下一瞬间进入
        //0左键 1右键 2中键
        //只有按下的一瞬间进入一次
        if (Input.GetMouseButtonDown(0))
        {
            print("鼠标按下");
        }

        //鼠标抬起一瞬间进入
        if (Input.GetMouseButtonUp(0))
        {
            print("鼠标抬起");
        }

        //鼠标长按按下抬起都会进入
        //当按住按键不放时会一直进入这个判断
        if (Input.GetMouseButton(1))
        {
            print("鼠标右键按下");
        }
        //中键滚动
        //返回值的y -1下滑 0无滑动 1上滑
        //返回值是Vector2的值，鼠标中键滚动，会改变其中的y值
        print(Input.mouseScrollDelta);

        #endregion

        #region 检测键盘输入
        //键盘按下
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("按下W");
        }

        //传入字符串的重载
        //传入的字符串必须是小写，不然会报错
        if (Input.GetKeyDown("q"))
        {
            print("按下Q");
        }

        //键盘抬起
        if (Input.GetKeyUp(KeyCode.W))
        {
            print("抬起W");
        }

        //键盘长按
        if (Input.GetKey(KeyCode.E))
        {
            print("E健长按");
        }
        #endregion

        #region 检测默认轴输入
        //鼠标和键盘输入主要是用来，控制玩家的旋转、位移等
        //所以Unity提供了更方便的方法，来帮助我们控制对象的旋转和位移

        //键盘AD按下时，返回-1到1之间的变换
        //可以在Edit->ProjectSetting->Input Manager设置
        //得到的这个值就是我们的方向，我们也可以通过控制它来控制对象左右移动或旋转
        print(Input.GetAxis("Horizontal"));

        //键盘SW按下时，返回-1到1之间的变换
        //得到的这个值就是我们的方向，我们也可以通过控制它来控制对象上下移动或旋转
        print(Input.GetAxis("Vertical"));

        //鼠标横向移动时，-1到1表示左右
        print(Input.GetAxis("Mouse X"));

        //鼠标竖向移动时，-1到1表示上下
        print(Input.GetAxis("Mouse Y"));

        //GetAxis方法是有渐变的，会从-1~0~1之间出现小数
        //GetAxisRaw方法和GetAxis使用方式相同
        //只不过它的返回值只会是 -1 0 1 不会有中间值
        #endregion

        #region 其它
        //是否有任意键或鼠标长按
        if (Input.anyKey)
        {
            print("任意键长按");
        }

        //是否有任意键或鼠标按下
        if (Input.anyKeyDown)
        {
            print("任意键按下");
            //这一帧的键盘输入
            print(Input.inputString);
        }

        //手柄输入开关
        //得到连接的手柄的所有按钮名字
        string[] strs= Input.GetJoystickNames();

        //某一个手柄按下
        if (Input.GetButtonDown("Jump"))
        {

        }

        //某一个手柄抬起
        if (Input.GetButtonUp("Jump"))
        {

        }
        //某一个手柄长按
        if (Input.GetButton("Jump"))
        {

        }

        //移动设备触摸相关
        if (Input.touchCount > 0) 
        {
            Touch t1 = Input.touches[0];

            //位置
            print(t1.position);
            //相对上次位置的变化
            print(t1.deltaPosition);
        }
        //是否启用多点触控
        Input.multiTouchEnabled= false;

        //陀螺仪（重力感应）
        //是否开启陀螺仪，必须开启，才能正常使用
        Input.gyro.enabled= true;

        //重力加速度向量
        print(Input.gyro.gravity);

        //旋转速度
        print(Input.gyro.rotationRate);

        //陀螺仪当前的旋转四元数
        //比如用这个角度信息，来控制场景上一个3D物体受到重力影响
        //手机怎么动，它怎么动
        print(Input.gyro.attitude);
        #endregion
    }

    //总结
    //Input类提供了大部分和输入相关的内容
    //鼠标、键盘、触屏、手柄、重力感应
}
