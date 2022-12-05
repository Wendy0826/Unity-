using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        #region Time相关内容主要用来干啥
        //时间相关内容主要用于游戏中参与位移、计时、时间暂停等
        #endregion

        #region 时间缩放比例
        //时间停止
        Time.timeScale = 0;
        //恢复正常
        Time.timeScale = 1;
        //2倍速
        Time.timeScale = 2;
        #endregion

        #region 帧间隔时间
        //帧间隔时间主要用来计算位移
        //路程=时间*速度
        //根据需求选择参与计算的间隔时间
        //如果希望游戏暂停时就不动的 那就使用deltatime
        //如果希望游戏不受赞同影响就可以使用unscaledDeltaTime

        //帧间隔时间：最近的一帧用了多少时间（秒）
        //受Scale影响
        print("帧间隔时间" + Time.deltaTime);

        //不受Scale影响
        print("不受Scale影响的帧间隔时间" + Time.unscaledDeltaTime);

        #endregion

        #region 游戏开始到现在的时间
        //主要用来计时，单机游戏中计时
        //受Scale影响
        print("游戏开始到现在的时间" + Time.time);

        //不受Scale影响
        print("不受Scale影响的游戏开始到现在的时间" + Time.unscaledTime);

        #endregion

        #region 帧数
        //从开始到现在游戏跑了多少帧（次循环）
        print(Time.frameCount);
        #endregion
    }
    void FixedUpdate()
    {
        #region 物理帧间间隔时间 FixedUpdate
        //受Scale影响
        print("物理帧间间隔时间" + Time.fixedDeltaTime);

        //不受Scale影响
        print("不受Scale影响的物理帧间间隔时间" + Time.fixedUnscaledDeltaTime);

        #endregion
    }

    //总结
    //Time相关的内容
    //最常用的就是我们的
    //1.帧间隔时间，计算位移相关内容
    //2.时间缩放比例，用来粘贴或者倍速等等
    //3.帧数（帧同步）
}
