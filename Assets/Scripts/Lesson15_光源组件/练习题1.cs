using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 练习题1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //通过代码结合点光源，模拟一个蜡烛的光源效果
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        obj.transform.parent = this.transform;

        GameObject candle = new GameObject();
        candle.transform.parent = this.transform;

        candle.AddComponent<Light>();
        Light light = candle.GetComponent<Light>();

        light.type = LightType.Point;
        light.range = 1;
        Vector3 candlePosition = light.transform.position;
        candlePosition.y = obj.transform.localScale.y/2 + light.range;
        candle.transform.position = candlePosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
