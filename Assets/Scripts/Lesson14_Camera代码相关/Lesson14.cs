using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        #region 重要静态成员
        //1.获取摄像机
        //主摄像机的获取
        //主摄像机的tag一定要是MainCarema才能获取
        print(Camera.main.name);

        //获取摄像机的数量
        print(Camera.allCamerasCount);

        //得到所有摄像机
        Camera[] allCamera = Camera.allCameras;
        print(allCamera.Length);

        //2.渲染相关委托
        //摄像机剔除前处理的委托
        Camera.onPreCull += (c) => { };

        //摄像机渲染前处理的委托
        Camera.onPreRender += (c) => { };

        //摄像机渲染后处理的委托
        Camera.onPostRender += (c) => { };
        #endregion

        #region 重要成员
        //1.界面上的参数都可以在camera中获取到
        Camera.main.depth = 0;

        //2.世界坐标转屏幕坐标
        //转换后X和Y就是屏幕位置，Z就是物体与摄像机之间的距离
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position);
        print(v);

        

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //3.屏幕坐标转世界坐标
        //如果不改变，z默认为0，转换为世界坐标系的点，永远都是视口相交的交点
        //如果改变了z，那么转换过去的世界坐标系的点，就是相对于摄像机前方多少距离的横截面上的点
        Vector3 v = Input.mousePosition;
        v.z = 10;
        obj.position = Camera.main.ScreenToWorldPoint(v);
    }
}
