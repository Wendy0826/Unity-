using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region �Ƕ����
        //�����������Ƕ�
        print(this.transform.eulerAngles);

        //��Ը�����Ƕ�
        print(this.transform.localEulerAngles);

        //ע�⣺���ýǶȺ�����λ��һ�����ܲ��ܵ�������xyz
        this.transform.localEulerAngles = new Vector3(10, 10, 10);

        #endregion

        
    }

    // Update is called once per frame
    void Update()
    {
        #region ��ת���
        //�Լ����㣨ʡ�Բ����ˣ���λ��һ������ͣ�ı�Ƕȼ��ɣ�

        //API����
        //��ת
        //����һ����ת�ĽǶ�
        //���������������ϵ��Ĭ��������Լ�����ϵ
        this.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0));
        this.transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0), Space.World);

        //�����ĳ����ת���ٶ�
        //����һ������ĸ������ת��
        //��������ת���ĽǶ�
        //���������������ϵ��Ĭ��������Լ�����ϵ
        this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);

        //�����һ����ת
        //����һ������ĸ������ת��
        //����������Ե���ĸ������ת��
        //��������ת���ĽǶ�
        this.transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
        #endregion

    }

    //�ܽ�
    //�Ƕ���غ�λ�����
    //ͨ��transform���Եõ������������ϵ����Ը�����ĽǶ�
    //�����ת�����ű���ת
    //Rotate
    //RotateAround

}
