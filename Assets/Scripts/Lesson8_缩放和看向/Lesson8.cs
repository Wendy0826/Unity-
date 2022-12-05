using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    public Transform lookatobj;
    // Start is called before the first frame update
    void Start()
    {
        #region 缩放
        //相对世界坐标系
        print(this.transform.lossyScale);

        //相对本地坐标系（父对象）
        print(this.transform.localScale);

        //注意：
        //1.同样缩放不能只改xyz，只能一起改(相对世界坐标系的缩放大小，只能得不能改)
        //一般要改缩放大小，都是改的相对于父对象的缩放大小 localScale
        this.transform.localScale = new Vector3(3, 3, 3);

        //2.Unity每天提供关于缩放的API
        //之前的旋转位移都提供了对应的API，但是缩放没有
        //如果你想让缩放发生变化，只能自己写
        this.transform.localScale += Vector3.one * Time.timeScale;
        #endregion

        
    }

    // Update is called once per frame
    void Update()
    {
        #region 看向
        //让一个对象的面朝向，可以一直看向某一个点或者某一个对象

        //看向一个点（相对世界坐标系）
        this.transform.LookAt(Vector3.zero);

        //看向一个对象
        //看向一个对象，就传入一个对象的Transform信息
        this.transform.LookAt(lookatobj);

        #endregion 
    }

    //总结：
    //缩放相关：
    //相对世界坐标系的只能得不能改
    //只能去修改相对于本地坐标系的缩放（相对于父对象）
    //没有提供对象的API来缩放变化，只能自己算
    //看向相关：
    //LookAt，看向一个点或者一个对象
    //写在Update里面才会不停变化

}
