using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    public Transform lookatobj;
    // Start is called before the first frame update
    void Start()
    {
        #region ����
        //�����������ϵ
        print(this.transform.lossyScale);

        //��Ա�������ϵ��������
        print(this.transform.localScale);

        //ע�⣺
        //1.ͬ�����Ų���ֻ��xyz��ֻ��һ���(�����������ϵ�����Ŵ�С��ֻ�ܵò��ܸ�)
        //һ��Ҫ�����Ŵ�С�����Ǹĵ�����ڸ���������Ŵ�С localScale
        this.transform.localScale = new Vector3(3, 3, 3);

        //2.Unityÿ���ṩ�������ŵ�API
        //֮ǰ����תλ�ƶ��ṩ�˶�Ӧ��API����������û��
        //������������ŷ����仯��ֻ���Լ�д
        this.transform.localScale += Vector3.one * Time.timeScale;
        #endregion

        
    }

    // Update is called once per frame
    void Update()
    {
        #region ����
        //��һ��������泯�򣬿���һֱ����ĳһ�������ĳһ������

        //����һ���㣨�����������ϵ��
        this.transform.LookAt(Vector3.zero);

        //����һ������
        //����һ�����󣬾ʹ���һ�������Transform��Ϣ
        this.transform.LookAt(lookatobj);

        #endregion 
    }

    //�ܽ᣺
    //������أ�
    //�����������ϵ��ֻ�ܵò��ܸ�
    //ֻ��ȥ�޸�����ڱ�������ϵ�����ţ�����ڸ�����
    //û���ṩ�����API�����ű仯��ֻ���Լ���
    //������أ�
    //LookAt������һ�������һ������
    //д��Update����Ż᲻ͣ�仯

}
