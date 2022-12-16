using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{

    Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        #region �����Դ�������ķ���
        //�����������Ŀ�����
        //������һ���ٶȣ���ĳһ�������ƶ�

        //1.����Ӧ�û�ȡ�������
        rig= this.GetComponent<Rigidbody>();

        //2.�����
        //�����������
        //����֮������Ƿ�ֹͣ�ƶ�����������������
        //�������Ϊ0����ô����һ����֮��ʼ�ղ���ֹͣ�˶���
        rig.AddForce(Vector3.forward * 10);
        //���������������ϵ�У��ö���������Լ����泯��
        rig.AddForce(this.transform.forward * 10);

        //��Ա�������
        rig.AddRelativeForce(Vector3.forward * 10);

        //3.���Ť������������ת
        //�����������
        rig.AddTorque(Vector3.up * 10);
        //����������ϵ�����Լ���Y��ת��
        rig.AddTorque(this.transform.up * 10);

        //��Ա�������
        rig.AddRelativeTorque(Vector3.up * 10);

        //4.ֱ�Ӹı��ٶ�
        //����ٶȷ������������������ϵ��
        //���Ҫֱ��ͨ���ı��ٶȣ��������ƶ���һ��Ҫע����һ��
        rig.velocity = Vector3.forward * 5;

        //5.ģ�ⱬըЧ��
        rig.AddExplosionForce(10,Vector3.zero,10);
        #endregion

        #region ���ļ���ģʽ

        #endregion

        #region �����ű�

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //�����ϣ����ʹ������Ҳϣ������һֱ�����Ǿ�һֱ�ƾͿ�����
        //rig.AddForce(Vector3.forward * 10);

    }
}
