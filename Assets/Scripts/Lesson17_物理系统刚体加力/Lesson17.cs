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
        //模拟爆炸的力一定是所有希望产生爆炸效果影响的对象
        //都需要他们的刚体来执行这个方法，才都有效果
        rig.AddExplosionForce(10,Vector3.zero,10);
        #endregion

        #region 力的几种模式
        //第二个参数就是力的模式，主要的作用就是计算方式不同
        //由于四种计算方式的不同，最终的移动速度就会不同
        rig.AddForce(10 * Vector3.forward, ForceMode.Force);

        //动量定理
        //Ft = mv
        // v = Ft/m;
        //F:力
        //t:时间
        //m:质量
        //v:速度

        //1.Acceleration
        //给物体一个持续的加速度，忽略其质量
        //v = Ft/m
        //F:（0,0,10）
        //t:0.02s
        //m:默认为1
        //v = 10 * 0.02 / 1 = 0.2m/s
        //每物理帧移动0.2m/s * 0.02 = 0.004m

        //2.Force
        //给物体添加一个持续的力，与物体的质量有关
        //F:（0,0,10）
        //t:0.02s
        //m:2kg
        //v = 10 * 0.02 / 2 = 0.1m/s
        //每物理帧移动0.1m/s * 0.02 = 0.002m

        //3.Impulse
        //给物体添加一个瞬间的力，与物体的质量有关，忽略时间，默认为1
        // v = Ft / m
        //F:（0,0,10）
        //t:默认为1
        //m:2kg
        //v = 10 * 1 / 2 = 5m/s
        //每物理帧移动5m/s * 0.02 = 0.1m

        //4.VelocityChange
        //给物体添加一个瞬时速度，忽略质量
        // v = Ft / m
        //F:（0,0,10）
        //t:默认为1
        //m:默认为1
        //v = 10 * 1 / 1 = 10m/s
        //每物理帧移动10m/s * 0.02 = 0.2m
        #endregion

        #region 力场脚本
        //Unity自带Constant Force脚本
        //添加脚本时会自动添加刚体组件
        #endregion

        #region 补充 刚体的休眠
        //获取刚体是否在休眠状态
        if (rig.IsSleeping())
        {
            //如果在，就唤醒他
            rig.WakeUp();
        }
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //如果你希望即使有阻力也希望对象一直动，那就一直推就可以了
        //rig.AddForce(Vector3.forward * 10);

    }
}
