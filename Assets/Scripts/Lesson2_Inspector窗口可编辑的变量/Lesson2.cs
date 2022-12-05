using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum E_TestEnum
{
    monster,
    player,
}
[System.Serializable]
public struct MyStruct
{
    public int age;
    public string name;
}
[System.Serializable]
public class MyClass
{
    public int age;
    public string name;
}

public class Lesson2 : MonoBehaviour
{
    #region Inspector��ʾ�Ŀɱ༭���ݾ��ǽű��ĳ�Ա����

    #endregion

    #region ˽�кͱ����޷���ʾ�༭
    private int i1;
    protected string str1;
    #endregion

    #region ��˽�еĺͱ�����Ҳ���Ա���ʾ
    //����ǿ�����л�����
    //[SerializeField]
    //��ν���л����ǰ�һ�����л����󱣴浽һ���ļ������ݿ��ֶ���ȥ
    [SerializeField]private int i2;
    [SerializeField]protected string str2;
    #endregion

    #region �����Ŀ�����ʾ�༭
    public int i3 = 10;
    #endregion

    #region ������Ҳ����ʾ����༭
    //�ڱ���ǰ��������
    //[HideInInspector]
    [HideInInspector] public int i4 = 20;
    #endregion

    #region �󲿷����Ͷ�����ʾ�༭
    public int[] array;
    public List<int> list;
    public E_TestEnum type;
    public GameObject lgameObject;

    //�ֵ䲻�ܱ�Inspector������ʾ
    public Dictionary<int, string> dic;
    //�Զ������ͱ������ܱ�Inspector������ʾ
    public MyStruct myStruct;
    public MyClass myClass;
    #endregion

    #region ���Զ������Ϳ��Ա�����
    //�ڶ�������ʱ�������л�����
    //[System.Serializable]
    //�ֵ���ô��������
    #endregion

    #region һЩ��������
    //1.����˵������Header
    //Ϊ��Ա����
    //Header����
    //[Header("����˵��")]
    [Header("��������")]
    public int age;
    public bool sex;
    [Header("ս������")]
    public int atk;
    public int def;

    //2.��ͣע��Tooltip
    //Ϊ�������˵��
    //[Tooltip("˵������")]
    [Tooltip("����")]
    public int miss;

    //3.������� Space()
    //�������ֶμ���ּ��
    //[Space()]
    [Space()]
    public int crit;

    //4.������ֵ�Ļ�����ΧRange
    //[Range(��Сֵ,���ֵ)]
    [Range(0, 10)]
    public float luck;

    //5.������ʾ�ַ�����Ĭ�ϲ�д������ʾ3��
    //д�������Ƕ�Ӧ��
    //[Multiline(4)]
    [Multiline(4)]
    public string tips;

    //6.��������ʾ�ַ���
    //Ĭ�ϲ�д�������ǳ���������ʾ������
    //[TextArea(3,4)]
    //������ʾ3�У����4�У�����4�о���ʾ������
    [TextArea(3, 4)]
    public string life;

    //7.Ϊ������ӿ�ݷ���
    //[ContextMenuItem("��ʾ��ť��","������")]
    //�����������в���
    [ContextMenuItem("����Ǯ", "Reset")]
    public int money;
    private void Reset()
    {
        money = 99;
    }

    //8.Ϊ������������ܹ���Inspector��ִ��
    //[ContextMenu("���Ժ���")]
    [ContextMenu("��������")]
    private void TestFun()
    {
        print("���Է���");
    }

    #endregion

    #region ע��
    //1.Inspector�����еı��������ľ��Ƕ���ĳ�Ա����������ʱ�ı����Ǿ����ڸı��Ա����
    //2.��ק��GameObject������ٸı�ű�����Ĭ��ֵ�����治��ı�
    //3.�������޸ĵ���Ϣ���ᱣ��
    public int i = 10;
    #endregion

    private void Start()
    {
        print(i2);
        print(str2);
    }
    private void Update()
    {
        //print(i);
    }
}
