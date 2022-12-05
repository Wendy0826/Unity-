using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public Transform son;
    // Start is called before the first frame update
    void Start()
    {
        #region ��ȡ�����ø�����
        //��ȡ������
        print(this.transform.parent.name);

        //���ø�����
        this.transform.parent = null;
        this.transform.parent = GameObject.Find("Father").transform;

        //ͨ��API����
        this.transform.SetParent(null);
        this.transform.SetParent(GameObject.Find("Father2").transform);
        //����һ��������
        //���������Ƿ������������λ�á��Ƕȡ����ŵ���Ϣ
        //       true������������ϵ�µ�״̬���͸�������м���õ���������ϵ����Ϣ
        //       false��������������ϵ�µ�״̬��λ�ýǶ�����ֱ�Ӹ�ֵ����������ϵ��
        this.transform.SetParent(GameObject.Find("Father3").transform, false);
        #endregion

        #region ��������
        //���Լ��������Ӷ���Ͼ���ϵ
        this.transform.DetachChildren();
        #endregion

        #region ��ȡ�Ӷ���
        //�����ֲ����Ӷ���

        //Find�����ܹ��ҵ�ʧ��Ķ���GameObject��صĲ��Ҳ����ҵ�ʧ��Ķ���
        //ֻ���ҵ��Ӷ��󣬲����ҵ��Ӷ�����Ӷ���
        //��Ȼ����Ч�ʱ�GameObject�ķ�����һЩ������ǰ���Ǳ���֪��������
        print(this.transform.Find("Cube").name);

        //�����Ӷ���
        //��εĵõ��ж����Ӷ���
        //1.ʧ����Ӷ���Ҳ������
        //2.�Ӷ�����Ӷ��󲻻�������
        print(this.transform.childCount);

        //ͨ�������ţ��õ���Ӧ���Ӷ���
        //������������Ӷ���������ֱ�ӱ���
        for (int i = 0; i < this.transform.childCount; i++)
        {
            print(this.transform.GetChild(i).name);
        }
        #endregion

        #region ���ӵĲ���
        //�жϸ�����
        son.transform.IsChildOf(this.transform);

        //�õ��Լ���Ϊ�Ӷ��������
        print(son.transform.GetSiblingIndex());

        //���Լ�����Ϊ��һ���Ӷ���
        son.SetAsFirstSibling();

        //���Լ��趨Ϊ���һ���Ӷ���
        son.SetAsLastSibling();

        //���Լ�����Ϊָ���������Ӷ���
        son.SetSiblingIndex(2);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //�ܽ�
    //���ø�������ص�����
    //��ȡ�Ӷ�����ص�����

    //��������

    //���ӵĲ���
}
