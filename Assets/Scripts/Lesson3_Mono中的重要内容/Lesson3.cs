using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Lesson3 : MonoBehaviour
{
    public Lesson3 otherLesson3;
    void Start()
    {
        #region ��Ҫ��Ա
        //1.��ȡ������GameObject
        print(this.gameObject.name);     
        //2.��ȡ������GameObject��λ����Ϣ
        //�õ�����λ����Ϣ
        print(this.transform.position);//λ��
        print(this.transform.eulerAngles);//�Ƕ�
        print(this.transform.lossyScale);//���Ŵ�С
        //����д����������һ����Ч�������ǵõ������Ķ����λ����Ϣ
        //this.gameObject.transform.position

        //3.��ȡ�ű��Ƿ񼤻�
        print(this.enabled);
        this.enabled = true;

        //��ȡ��Ľű�����������gameobject��transformλ����Ϣ
        print(otherLesson3.gameObject.name);
        print(otherLesson3.transform.position);
        #endregion

        #region ��Ҫ����
        //�õ����������Ϲ��ص������ű�

        //1.�õ��Լ����صĵ����ű�
        //���ݽű�����ȡ
        //��ȡʧ�ܻ�Ĭ�Ϸ���null
        Lesson3_test t = this.GetComponent("Lesson3_test") as Lesson3_test;
        print(t);
        //����Type��ȡ
        t = this.GetComponent(typeof(Lesson3_test)) as Lesson3_test;
        print(t);
        //���ݷ��ͻ�ȡ������ʹ�÷��ͻ�ȡ����Ϊ���ö���ת��
        t = this.GetComponent<Lesson3_test>();
        print(t);
        //ֻҪ���ܵõ������б�Ķ�����߶��������Ľű�
        //����Ϳ��Ի�ȡ������������Ϣ

        //2.�õ��Լ����صĶ���ű�
        Lesson3[] l3 = this.GetComponents<Lesson3>();
        print(l3.Length);

        List<Lesson3> lesson3s = new List<Lesson3>();
        this.GetComponents<Lesson3>(lesson3s);
        print(lesson3s.Count);
        
        //3.�õ��Ӷ�����صĽű�(��Ĭ��Ҳ�����Լ������Ƿ���ظýű�)
        //��������һ�������ģ�Ĭ�ϲ�����false����˼��������Ӷ���ʧ��ǲ���ȥ����������Ƿ���ĳ���ű���
        //�����true��ʹʧ��Ҳ����
        //����
        t = this.GetComponentInChildren<Lesson3_test>();
        print(t);

        //���
        Lesson3_test[] lesson3_Tests = this.GetComponentsInChildren<Lesson3_test>();
        print(lesson3_Tests.Length);
        List<Lesson3_test> lesson3_tests = new List<Lesson3_test>();
        this.GetComponentsInChildren<Lesson3_test>(false,lesson3_tests);
        print(lesson3_tests.Count);

        //4.�õ���������صĽű�(��Ĭ��Ҳ�����Լ������Ƿ���ظýű�)
        //����
        t = this.GetComponentInParent<Lesson3_test>();
        print(t);

        //���
        lesson3_Tests = this.GetComponentsInParent<Lesson3_test>();
        print(lesson3_Tests.Length);
        this.GetComponentsInParent<Lesson3_test>(false, lesson3_tests);
        print(lesson3_tests.Count);

        //5.���Ի�ȡ�ű�
        //�ṩ��һ�����Ӱ�ȫ�Ļ�ȡ�����ű��ķ���������õ��˻᷵��true
        //Ȼ�����������߼�������
        this.TryGetComponent<Lesson3_test>(out Lesson3_test lesson3_test);
        #endregion
    }

}
