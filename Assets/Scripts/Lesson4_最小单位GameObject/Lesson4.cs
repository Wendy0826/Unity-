using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    //׼��������¡�Ķ���
    //1.ֱ���ǳ����ϵ�ĳ������
    //2.������һ��Ԥ�������
    public GameObject gb;

    void Start()
    {
        #region GameObject�еĳ�Ա����
        //����
        print(this.gameObject.name);
        this.gameObject.name = "Lesson4";

        //�Ƿ񼤻�
        print(this.gameObject.activeSelf);

        //�Ƿ��Ǿ�̬
        print(this.gameObject.isStatic);

        //�㼶
        print(this.gameObject.layer);

        //��ǩ
        print(this.gameObject.tag);

        //transform
        print(this.gameObject.transform.position);
        #endregion

        #region GameObject�еľ�̬����

        #region �����Դ�������
        //ֻҪ�õ���һ��GameObject������ô�Ϳ��Եõ������Ϲ��ص��κνű���Ϣ
        //ͨ��GetComponent���õ�
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "������������";
        #endregion

        #region ���Ҷ���ķ���
        //1.���ҵ�������
        //�޷��ҵ�ʧ��Ķ���ֻ���ҵ�����Ķ���

        //��������д��ڶ�����������Ķ���
        //�����޷�ָ���ҵ�ĳ������

        //ͨ������������
        //�������Ч�ʵ��£���Ϊ�����ڳ��������ж���ȥ����
        GameObject obj2 = GameObject.Find("������������");
        if (obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("û�ж�Ӧ�Ķ���");
        }

        //ͨ��tag�����Ҷ���
        GameObject obj3 = GameObject.FindWithTag("Player");
        obj3 = GameObject.FindGameObjectWithTag("Player");
        if (obj3 != null)
        {
            print(obj3.name);
        }
        else
        {
            print("û�ж�Ӧ�Ķ���");
        }

        //2.���Ҷ������
        //�Ҷ�������API��ֻ��ͨ��tagȥ�Ҷ��
        //ֻ���ҵ���������޷��ҵ�ʧ�����
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print(objs.Length);

        //���м������Ҷ�����ص����õıȽ��ٵķ�������GameObject����Object�ṩ�ķ���
        //Unity�����Object����ָ������֮��object
        //Unity�����Object�����ռ���UnityEngine�е�Object�࣬Ҳ�Ǽ̳�����֮����һ���Զ�����
        //C#�е�Object�������ռ���System�е�

        //�����ҵ������й��ص�ĳһ���ű�����
        Lesson4 lesson4 = GameObject.FindObjectOfType<Lesson4>();
        print(lesson4.gameObject.name);
        #endregion

        #region ʵ�������󣨿�¡���󣩵ķ���
        //����һ��GameObject���󴴽���һ������һģһ���Ķ���
        GameObject obj4 = GameObject.Instantiate(gb);
        //����̳���MonoBehaviour�����Բ���дGameObjectһ������ʹ��
        //��Ϊ���������Unity�����Object�����ṩ��
        GameObject obj5 = Instantiate(gb);
        #endregion

        #region ɾ������ķ���
        GameObject.Destroy(obj4);
        //�ڶ������������ӳټ����Ӳ���
        GameObject.Destroy(obj5, 10);
        //Destroy��������ɾ�����󣬻�����ɾ���ű�
        GameObject.Destroy(this);

        //ɾ����������������
        //1.ɾ��ָ����һ����Ϸ����
        //2.ɾ��һ��ָ���Ľű�����
        //ע�⣺���Destroy���������������Ƴ�����һ���������������һ֡ʱ����������Ƴ������ڴ����Ƴ�

        //���û�������Ƴ������󣬽���ʹ��Destory���������Խ��Ϳ��ٵĸ���
        GameObject.DestroyImmediate(this);
        //����̳���MonoBehaviour�����Բ���дGameObjectһ������ʹ��
        //��Ϊ���������Unity�����Object�����ṩ��
        DestroyImmediate(this);
        #endregion

        #region ���������Ƴ�
        //Ĭ�����л�����ʱ�������еĶ��󶼻ᱻ�Զ�ɾ����
        //�����ϣ��ĳ����������������Ƴ�
        //���������룬���ǲ���˭���������Ƴ��ʹ�˭
        //һ�㶼�Ǵ�������GameObject����
        GameObject.DontDestroyOnLoad(this.gameObject);
        //����̳���MonoBehaviour�����Բ���дGameObjectһ������ʹ��
        //��Ϊ���������Unity�����Object�����ṩ��
        DontDestroyOnLoad(this.gameObject);
        #endregion

        #endregion

        #region GameObject�еĳ�Ա����
        #region ����������
        GameObject obj6 = new GameObject();
        GameObject obj7 = new GameObject("������");
        GameObject obj8 = new GameObject("������", typeof(Lesson4), typeof(Lesson2));
        #endregion

        #region Ϊ������ӽű�
        //�̳�MonoBehaviour�Ľű��ǲ���ȥnew��
        //�����Ҫ��̬�����MonoBehaviour�Ľű���ĳһ��������
        //ֱ��ʹ��GameObject�ṩ�ķ�������
        Lesson2 les1 = obj6.AddComponent(typeof(Lesson2)) as Lesson2;
        les1 = obj6.AddComponent<Lesson2>();
        //ͨ������ֵ���Եõ�����Ľű���Ϣ��������һЩ����
        #endregion

        //�õ��ű��ĳ�Ա�����ͼ̳�Mono����õ��ű��ķ���һģһ��

        #region ��ǩ�Ƚ�
        //���ֱȽϵķ�����һ����
        if (this.gameObject.CompareTag("Player"))
        {
            print(this.gameObject.name);
        }

        if (this.gameObject.tag == "Player")
        {
            print(this.gameObject.name);
        }
        #endregion

        #region ���ü���ʧ��
        //true���� falseʧ��
        obj6.SetActive(true);
        #endregion

        #region ��Ҫ��Ա����
        //�˽⼴�� ������ʹ��
        //ǿ����Ч�ʽϵͲ�����ʹ��
        //ͨ���㲥���߷�����Ϣ����ʽ�����Լ����߱���ִ��ĳЩ��Ϊ����

        //֪ͨ�Լ�,ִ��ʲô��Ϊ
        //���Լ����Ϲ��ص����нű�ȥ��������ֵĺ���
        this.gameObject.SendMessage("TestFun");
        this.gameObject.SendMessage("TestFun2", 199);

        //�㲥��Ϊ�����Լ����Լ����Ӷ���ִ��
        this.gameObject.BroadcastMessage("TestFun");

        //�򸸶�����Լ�������Ϣ��ִ��
        this.gameObject.SendMessageUpwards("TestFun");
        #endregion
        #endregion
    }

    void TestFun()
    {
        print("��ӡTestFun");
    }
    void TestFun2(int a)
    {
        print("��ӡTestFun2" + a);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    //�ܽ�
    //GameObject�г��õ�����

    //������Ա����
    //����
    //ʧ���״̬
    //��ǩ
    //�㼶
    //...

    //��̬����
    //�����Դ�������
    //���ҳ����ж���
    //ʵ��������
    //ɾ������
    //���������Ƴ�

    //��Ա����
    //Ϊ����̬���ָ���ű�
    //����ʧ����״̬
    //��MonoBehavior����ͬ�ĵõ��ű��ķ���
}
