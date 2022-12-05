using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 练习题3_A : MonoBehaviour
{
    public 练习题3_B otherlxt;
    // Start is called before the first frame update
    void Start()
    {
        练习题3_B lxtb = otherlxt.GetComponent<练习题3_B>();
        lxtb.enabled= false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
