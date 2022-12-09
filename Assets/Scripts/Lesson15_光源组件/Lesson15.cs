using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        #region 面板参数
        #region type 光源类型
        //Spot 聚光灯
        //  Range 发光范围距离
        //  Spot Angle 光维角度
        //Diretional 方向光（环境光）
        //Point 点光源
        //Area 面光源
        #endregion

        #region Color 颜色

        #endregion

        #region Mode 光源模式
        //Realtime 实时光源
        //每帧实时计算，效果好，性能消耗大

        //Baked 烘焙光源
        //事先计算好，无法动态变化

        //Mixed 混合光源
        //预先计算+实时运算
        #endregion

        #region intensity 光源亮度

        #endregion

        #region Shadow Type 阴影类型
        //NoShadows 关闭阴影
        //HardShadows 生硬阴影
        //SoftShadows 柔和阴影
        #endregion

        #region Cookie 投影遮罩

        #endregion

        #region Draw Halo 球形光环开关

        #endregion

        #region Flare 耀斑

        #endregion

        #region Culling Mask 剔除遮罩层
        //决定哪些层的对象受到该光源影响

        #endregion

        #region 其他
        #region Indirect Multiplier 改变间接光的强度
        //低于1，每次反弹会使光更暗
        //高于1，每次反弹会使光更亮
        #endregion

        #region RealTimeShadows 阴影相关参数
        //Strength 阴影暗度
        //0-1之间，越大越黑

        //Resolution 阴影贴图渲染分辨率
        //越高越逼真，消耗越高

        //Bias 阴影推离光源的距离

        //Noraml Bias 阴影投射面沿法线收缩距离

        //Near Panel 渲染阴影的近剪裁面
        #endregion

        #region Cookies Size

        #endregion

        #region Render Mode 渲染优先级
        //Auto 运行时确定

        //Important 以像素质量为单位进行渲染，效果逼真，消耗大

        //Not Important 以快速模式进行渲染
        #endregion

        #endregion

        #endregion

        #region 代码控制
        //面板属性都可以通过点出来使用
        light.intensity = 1.0f;

        #endregion

        #region 光面板相关
        //Window->Rendering->Lighting

        //Environment 环境相关设置
        //1.Skybox Material 天空盒材质
        //  可以改变天空盒
        //2.Sun Source 太阳来源
        //  不设置会默认使用场景中最亮的方向光代表太阳
        //3.Environment Lighting 环境光设置
        //  a.Source 环境光源颜色
        //      Skybox 天空和材质作为环境光颜色
        //      Gradient 可以为天空、地平线、地面单独选择颜色和他们之间混合
        //  b.Intersity Muiltiplier 环境光亮度
        //  c.Ambient Mode 全局光照设置
        //      只有启用了实时全局和全局烘焙时才有用
        //      Realtime（已弃用）
        //      Baked


        //Other Settings 其他设置
        //1.Fog 雾开关
        //  a.Color 雾颜色
        //  b.Mode 雾计算模式
        //      I.Linear 随距离线性增加
        //          Start 离摄像机多远开始有雾
        //          End 离摄像机多远完全遮挡
        //      II.Exponential 随距离指数增加
        //          Density 强度
        //      III.Exponential Quare 随距离比指数更快的增加
        //          Density 强度
        //2.Halo Texture 光源周围光环的纹理
        //3.Halo Strength 光环可见性
        //4.Flare Fade Speed 耀斑淡出时间，最初出现之后淡出的时间
        //5.Flare Strength 耀斑可见性
        //6.Spot Cookie 聚光灯剪影纹理
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
