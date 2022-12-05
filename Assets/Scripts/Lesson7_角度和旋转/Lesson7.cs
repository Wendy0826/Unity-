using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 角度相关
        //相对世界坐标角度
        print(this.transform.eulerAngles);

        //相对父对象角度
        print(this.transform.localEulerAngles);

        //注意：设置角度和设置位置一样，能不能单独设置xyz
        this.transform.localEulerAngles = new Vector3(10, 10, 10);

        #endregion

        
    }

    // Update is called once per frame
    void Update()
    {
        #region 旋转相关
        //自己计算（省略不讲了，和位置一样，不停改变角度即可）

        //API计算
        //自转
        //参数一：旋转的角度
        //参数二：相对坐标系，默认相对于自己坐标系
        this.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0));
        this.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0), Space.World);

        //相对于某个轴转多少度
        //参数一：相对哪个轴进行转动
        //参数二：转动的角度
        //参数三：相对坐标系，默认相对于自己坐标系
        this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);

        //相对于一个点转
        //参数一：相对哪个点进行转动
        //参数二：相对点的哪个轴进行转动
        //参数三：转动的角度
        this.transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
        #endregion

    }

    //总结
    //角度相关和位置相关
    //通过transform可以得到相对世界坐标系和相对父对象的角度
    //如何自转和绕着别人转
    //Rotate
    //RotateAround

}
