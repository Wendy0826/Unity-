using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ��������תΪ��������ϵ
        print(Vector3.forward);
        //��������ϵ�ĵ�ת��Ϊ��Ա�������ϵ�ĵ�
        //�ܵ�����Ӱ��
        print(this.transform.InverseTransformPoint(Vector3.forward));

        //��������ϵ�ķ���ת��Ϊ��Ա�������ϵ�ķ���
        //��������Ӱ��
        print(this.transform.InverseTransformDirection(Vector3.forward));

        //������Ӱ��
        print(this.transform.InverseTransformVector(Vector3.forward));

        #endregion

        #region ��������ת��������ϵ
        //��������ϵ�ĵ�ת��Ϊ�����������ϵ�ĵ�
        //�ܵ�����Ӱ��
        print(this.transform.TransformPoint(Vector3.forward));

        //��������ϵ�ķ���ת��Ϊ�����������ϵ�ķ���
        //��������Ӱ��
        print(this.transform.TransformDirection(Vector3.forward));

        //������Ӱ��
        print(this.transform.TransformVector(Vector3.forward));
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //�ܽ�
    //��������Ҫ�ľ��Ǳ�������ϵ�ĵ�ת��������ϵ�ĵ�
}
