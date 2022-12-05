using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Lesson3 : MonoBehaviour
{
    public Lesson3 otherLesson3;
    void Start()
    {
        #region 重要成员
        //1.获取依附的GameObject
        print(this.gameObject.name);     
        //2.获取依附的GameObject的位置信息
        //得到对象位置信息
        print(this.transform.position);//位置
        print(this.transform.eulerAngles);//角度
        print(this.transform.lossyScale);//缩放大小
        //这种写法和上面是一样的效果，都是得到依附的对象的位置信息
        //this.gameObject.transform.position

        //3.获取脚本是否激活
        print(this.enabled);
        this.enabled = true;

        //获取别的脚本对象依附的gameobject和transform位置信息
        print(otherLesson3.gameObject.name);
        print(otherLesson3.transform.position);
        #endregion

        #region 重要方法
        //得到依附对象上挂载的其他脚本

        //1.得到自己挂载的单个脚本
        //根据脚本名获取
        //获取失败会默认返回null
        Lesson3_test t = this.GetComponent("Lesson3_test") as Lesson3_test;
        print(t);
        //根据Type获取
        t = this.GetComponent(typeof(Lesson3_test)) as Lesson3_test;
        print(t);
        //根据泛型获取，建议使用泛型获取，因为不用二次转换
        t = this.GetComponent<Lesson3_test>();
        print(t);
        //只要你能得到场景中别的对象或者对象依附的脚本
        //那你就可以获取到它的所有信息

        //2.得到自己挂载的多个脚本
        Lesson3[] l3 = this.GetComponents<Lesson3>();
        print(l3.Length);

        List<Lesson3> lesson3s = new List<Lesson3>();
        this.GetComponents<Lesson3>(lesson3s);
        print(lesson3s.Count);
        
        //3.得到子对象挂载的脚本(它默认也会找自己身上是否挂载该脚本)
        //函数是有一个参数的，默认不传是false，意思就是如果子对象失活，是不会去找这个对象是否有某个脚本的
        //如果传true即使失活也会找
        //单个
        t = this.GetComponentInChildren<Lesson3_test>();
        print(t);

        //多个
        Lesson3_test[] lesson3_Tests = this.GetComponentsInChildren<Lesson3_test>();
        print(lesson3_Tests.Length);
        List<Lesson3_test> lesson3_tests = new List<Lesson3_test>();
        this.GetComponentsInChildren<Lesson3_test>(false,lesson3_tests);
        print(lesson3_tests.Count);

        //4.得到父对象挂载的脚本(它默认也会找自己身上是否挂载该脚本)
        //单个
        t = this.GetComponentInParent<Lesson3_test>();
        print(t);

        //多个
        lesson3_Tests = this.GetComponentsInParent<Lesson3_test>();
        print(lesson3_Tests.Length);
        this.GetComponentsInParent<Lesson3_test>(false, lesson3_tests);
        print(lesson3_tests.Count);

        //5.尝试获取脚本
        //提供了一个更加安全的获取单个脚本的方法，如果得到了会返回true
        //然后再来进行逻辑处理即可
        this.TryGetComponent<Lesson3_test>(out Lesson3_test lesson3_test);
        #endregion
    }

}
