using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{

    Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        #region 刚体自带添加力的方法
        //给刚体加力的目标就是
        //让其有一个速度，朝某一个方向移动

        //1.首先应该获取刚体组件
        rig= this.GetComponent<Rigidbody>();

        //2.添加力
        //相对世界坐标
        //加力之后对象是否停止移动，是由阻力决定的
        //如果阻力为0，那么给了一个力之后，始终不会停止运动的
        rig.AddForce(Vector3.forward * 10);
        //如果想在世界坐标系中，让对象相对于自己的面朝向动
        rig.AddForce(this.transform.forward * 10);

        //相对本地坐标
        rig.AddRelativeForce(Vector3.forward * 10);

        //3.添加扭矩力，让其旋转
        //相对世界坐标
        rig.AddTorque(Vector3.up * 10);
        //在世界坐标系，朝自己得Y轴转动
        rig.AddTorque(this.transform.up * 10);

        //相对本地坐标
        rig.AddRelativeTorque(Vector3.up * 10);

        //4.直接改变速度
        //这个速度方向是相对于世界坐标系的
        //如果要直接通过改变速度，来让其移动，一定要注意这一点
        rig.velocity = Vector3.forward * 5;

        //5.模拟爆炸效果
        rig.AddExplosionForce(10,Vector3.zero,10);
        #endregion

        #region 力的几种模式

        #endregion

        #region 力场脚本

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //如果你希望即使有阻力也希望对象一直动，那就一直推就可以了
        //rig.AddForce(Vector3.forward * 10);

    }
}
