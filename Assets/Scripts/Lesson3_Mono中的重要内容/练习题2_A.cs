using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 练习题2_A : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        练习题2_B lxtb = this.GetComponent<练习题2_B>();
        lxtb.enabled= false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
