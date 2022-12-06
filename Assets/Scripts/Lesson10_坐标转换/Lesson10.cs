using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 世界坐标转为本地坐标系
        print(Vector3.forward);
        //世界坐标系的点转换为相对本地坐标系的点
        //受到缩放影响
        print(this.transform.InverseTransformPoint(Vector3.forward));

        //世界坐标系的方向转换为相对本地坐标系的方向
        //不受缩放影响
        print(this.transform.InverseTransformDirection(Vector3.forward));

        //受缩放影响
        print(this.transform.InverseTransformVector(Vector3.forward));

        #endregion

        #region 本地坐标转世界坐标系
        //本地坐标系的点转换为相对世界坐标系的点
        //受到缩放影响
        print(this.transform.TransformPoint(Vector3.forward));

        //本地坐标系的方向转换为相对世界坐标系的方向
        //不受缩放影响
        print(this.transform.TransformDirection(Vector3.forward));

        //受缩放影响
        print(this.transform.TransformVector(Vector3.forward));
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //总结
    //其中最重要的就是本地坐标系的点转世界坐标系的点
}
