using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 如何清除背景 Clear Flags
        //Skybox 天空盒
        //Solid Color 颜色填充
        //Depth only 只画该层，背景透明
        //Don't Clear 不移除 覆盖渲染
        #endregion

        #region 选择性渲染部分层级 Culling Mask
        //可以指定渲染对应层级的对象
        #endregion

        #region projection
        #region Perspective 透视模式
        //FOV Axis 视角场 轴
        //决定了光学仪器的视野范围

        //Field of view 视角大小

        //physical Cerema
        //物理摄像机，勾选后可以模拟真实世界摄像机中的焦距、传感器尺寸、透镜移位等
        //Focal Length 焦距
        //Sensor Type 传感器类型
        //Sensor Size 传感器尺寸
        //Lens Shift 透镜移位
        //Gate Fit 闸门配合
        #endregion

        #region orthographic 正交摄像机
        //一般用于2D游戏制作
        //Size 摄制范围

        #endregion
        #endregion

        #region 裁剪平面距离 Clipping

        #endregion

        #region 渲染顺序上的深度 Depth
        //多个摄像机时，数字越小越先渲染
        #endregion

        #region 其他
        #region 渲染纹理 Target Texture
        //可以把摄像机画面渲染到一张图上
        //主要用于制作小地图
        //在Rroject右键创建RenderTexture
        #endregion

        #region 是否启用剔除遮挡 Occlusion Culling

        #endregion

        #region 视口范围 Viewport Rect 
        //屏幕上将绘制该摄像机视图的位置
        //主要用于双摄像机游戏
        //0~1相当于宽高百分比
        #endregion

        #region 渲染路径 redering path

        #endregion

        #region 是否允许高动态范围渲染 Allow HDR

        #endregion

        #region 是否允许抗锯齿 Allow MSAA

        #endregion

        #region 是否允许动态分辨率呈现 AllowDynamic Resolution

        #endregion

        #region 用于哪个显示器Target Display
        //主要用来开发有多个屏幕的平台游戏
        #endregion
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
