using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region ע�⣺����������ݿ϶���д��Update�е�

        #endregion

        #region �������Ļλ��
        //��Ļ�����ԭ����Ļ�����½ǣ�������x��������������y��������
        //����ֵ��Vector3������ֻ��x��y��ֵ��zһֱ��0����Ļ��������2D�ģ�������Z��
        //print(Input.mousePosition);
        #endregion

        #region ����������
        //��갴��һ˲�����
        //0��� 1�Ҽ� 2�м�
        //ֻ�а��µ�һ˲�����һ��
        if (Input.GetMouseButtonDown(0))
        {
            print("��갴��");
        }

        //���̧��һ˲�����
        if (Input.GetMouseButtonUp(0))
        {
            print("���̧��");
        }

        //��곤������̧�𶼻����
        //����ס��������ʱ��һֱ��������ж�
        if (Input.GetMouseButton(1))
        {
            print("����Ҽ�����");
        }
        //�м�����
        //����ֵ��y -1�»� 0�޻��� 1�ϻ�
        //����ֵ��Vector2��ֵ������м���������ı����е�yֵ
        print(Input.mouseScrollDelta);

        #endregion

        #region ����������
        //���̰���
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("����W");
        }

        //�����ַ���������
        //������ַ���������Сд����Ȼ�ᱨ��
        if (Input.GetKeyDown("q"))
        {
            print("����Q");
        }

        //����̧��
        if (Input.GetKeyUp(KeyCode.W))
        {
            print("̧��W");
        }

        //���̳���
        if (Input.GetKey(KeyCode.E))
        {
            print("E������");
        }
        #endregion

        #region ���Ĭ��������
        //���ͼ���������Ҫ��������������ҵ���ת��λ�Ƶ�
        //����Unity�ṩ�˸�����ķ��������������ǿ��ƶ������ת��λ��

        //����AD����ʱ������-1��1֮��ı任
        //������Edit->ProjectSetting->Input Manager����
        //�õ������ֵ�������ǵķ�������Ҳ����ͨ�������������ƶ��������ƶ�����ת
        print(Input.GetAxis("Horizontal"));

        //����SW����ʱ������-1��1֮��ı任
        //�õ������ֵ�������ǵķ�������Ҳ����ͨ�������������ƶ��������ƶ�����ת
        print(Input.GetAxis("Vertical"));

        //�������ƶ�ʱ��-1��1��ʾ����
        print(Input.GetAxis("Mouse X"));

        //��������ƶ�ʱ��-1��1��ʾ����
        print(Input.GetAxis("Mouse Y"));

        //GetAxis�������н���ģ����-1~0~1֮�����С��
        //GetAxisRaw������GetAxisʹ�÷�ʽ��ͬ
        //ֻ�������ķ���ֵֻ���� -1 0 1 �������м�ֵ
        #endregion

        #region ����
        //�Ƿ������������곤��
        if (Input.anyKey)
        {
            print("���������");
        }

        //�Ƿ������������갴��
        if (Input.anyKeyDown)
        {
            print("���������");
            //��һ֡�ļ�������
            print(Input.inputString);
        }

        //�ֱ����뿪��
        //�õ����ӵ��ֱ������а�ť����
        string[] strs= Input.GetJoystickNames();

        //ĳһ���ֱ�����
        if (Input.GetButtonDown("Jump"))
        {

        }

        //ĳһ���ֱ�̧��
        if (Input.GetButtonUp("Jump"))
        {

        }
        //ĳһ���ֱ�����
        if (Input.GetButton("Jump"))
        {

        }

        //�ƶ��豸�������
        if (Input.touchCount > 0) 
        {
            Touch t1 = Input.touches[0];

            //λ��
            print(t1.position);
            //����ϴ�λ�õı仯
            print(t1.deltaPosition);
        }
        //�Ƿ����ö�㴥��
        Input.multiTouchEnabled= false;

        //�����ǣ�������Ӧ��
        //�Ƿ��������ǣ����뿪������������ʹ��
        Input.gyro.enabled= true;

        //�������ٶ�����
        print(Input.gyro.gravity);

        //��ת�ٶ�
        print(Input.gyro.rotationRate);

        //�����ǵ�ǰ����ת��Ԫ��
        //����������Ƕ���Ϣ�������Ƴ�����һ��3D�����ܵ�����Ӱ��
        //�ֻ���ô��������ô��
        print(Input.gyro.attitude);
        #endregion
    }

    //�ܽ�
    //Input���ṩ�˴󲿷ֺ�������ص�����
    //��ꡢ���̡��������ֱ���������Ӧ
}
