using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    #region ֪ʶ��һ �˽�֡�ĸ���
    //Unity�ײ��Ѿ�����������������ѭ��
    //������ҪѧϰUnity���������ں���
    //���������õĹ�����ִ�����ǵ���Ϸ�߼�������
    #endregion

    #region ֪ʶ��� �������ں����ĸ���
    //���м̳�MonoBehaviour�Ľű� ���ն�����ص�GameObject��Ϸ������
    //�������ں��� ���Ǹýű�����������GameObject����ӳ�����������������������
    //��ͨ�������Զ����õ�һЩ���⺯��

    //Unity�������Ǽ�¼��һ��GameObject������������Щ�ű�
    //���Զ��ĵõ���Щ����ͨ������ȥִ��һЩ�̶����ֵĺ���
    #endregion

    #region ֪ʶ���� �������ں���
    //ע�⣺
    //�������ں����ķ������η�һ��Ϊprivate��protect
    //��Ϊ����Ҫ���ⲿ�Լ������������ں��� ����Unity�Լ��������ǵ��õ�

    //�������Լ��������󣩱�����ʱ �Ż���ø��������ں���
    //���ƹ��캯���Ĵ��� ���ǿ�����һ������󴴽�ʱ����һЩ��ʼ������
    void Awake()
    {
        //��unity�д�ӡ��Ϣ�����ַ�ʽ
        //1.û�м̳�MonoBehaviour���ʱ��
        //Debug.Log("123");
        //debug.logerror("�����ˣ�����");
        //debug.logwarning("���棡����");
        //2.�̳�MonoBehaviour���ʱ��
        print("Awake");
    }


    //��Ҫ��һ�����󱻼���ʱ����һЩ�߼�����
    void OnEnable()
    {
        print("OnEnable");
    }
     
    //��Ҫ����Ҳ�����ڳ�ʼ����Ϣ�����������AwakeҪ��һ��
    //��Ϊ�����ڶ�����е�һ��֡����֮ǰ�Ż�ִ�е�
    void Start()
    {
        print("Start");
    }

    //��Ҫ�����ڽ����������
    //ÿһ֡��ִ�У����������֡����Ϸ֡��ͬ
    //����ʱ����������Edit->Project Settings->Time->Fixed Timestep�����޸�
    void FixedUpdate()
    {
        print("FixedUpdate");
    }

    //��Ҫ���ڴ�����Ϸ�߼����µĺ���
    void Update()
    {
        print("Update");
    }

    //һ������������������������λ�ø���������ݵ�
    //Update��LateUpdate֮�������һЩ������������صĸ���
    void LateUpdate()
    {
        print("LateUpdate");
    }

    //����ʧ��ʱ��Ҫ���д����Ϳ����ڸú�����д�߼�
    //����ʧ��ʱ����Ҫѭ��ִ�е��������ں���Ҳ��ִֹͣ�У�����FixedUpdate��Update��LateUpdate�ȣ�
    void OnDisable()
    {
        print("OnDisable");
    }

    //GameObjcet��������ʱ����
    void OnDestroy()
    {
        print("OnDestroy");
    }
    #endregion

    #region ֪ʶ���� �������ں��� ֧�ּ̳ж�̬

    #endregion
}
