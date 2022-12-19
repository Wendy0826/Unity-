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
        //ģ�ⱬը����һ��������ϣ��������ըЧ��Ӱ��Ķ���
        //����Ҫ���ǵĸ�����ִ������������Ŷ���Ч��
        rig.AddExplosionForce(10,Vector3.zero,10);
        #endregion

        #region ���ļ���ģʽ
        //�ڶ���������������ģʽ����Ҫ�����þ��Ǽ��㷽ʽ��ͬ
        //�������ּ��㷽ʽ�Ĳ�ͬ�����յ��ƶ��ٶȾͻ᲻ͬ
        rig.AddForce(10 * Vector3.forward, ForceMode.Force);

        //��������
        //Ft = mv
        // v = Ft/m;
        //F:��
        //t:ʱ��
        //m:����
        //v:�ٶ�

        //1.Acceleration
        //������һ�������ļ��ٶȣ�����������
        //v = Ft/m
        //F:��0,0,10��
        //t:0.02s
        //m:Ĭ��Ϊ1
        //v = 10 * 0.02 / 1 = 0.2m/s
        //ÿ����֡�ƶ�0.2m/s * 0.02 = 0.004m

        //2.Force
        //���������һ������������������������й�
        //F:��0,0,10��
        //t:0.02s
        //m:2kg
        //v = 10 * 0.02 / 2 = 0.1m/s
        //ÿ����֡�ƶ�0.1m/s * 0.02 = 0.002m

        //3.Impulse
        //���������һ��˲�������������������йأ�����ʱ�䣬Ĭ��Ϊ1
        // v = Ft / m
        //F:��0,0,10��
        //t:Ĭ��Ϊ1
        //m:2kg
        //v = 10 * 1 / 2 = 5m/s
        //ÿ����֡�ƶ�5m/s * 0.02 = 0.1m

        //4.VelocityChange
        //���������һ��˲ʱ�ٶȣ���������
        // v = Ft / m
        //F:��0,0,10��
        //t:Ĭ��Ϊ1
        //m:Ĭ��Ϊ1
        //v = 10 * 1 / 1 = 10m/s
        //ÿ����֡�ƶ�10m/s * 0.02 = 0.2m
        #endregion

        #region �����ű�
        //Unity�Դ�Constant Force�ű�
        //��ӽű�ʱ���Զ���Ӹ������
        #endregion

        #region ���� ���������
        //��ȡ�����Ƿ�������״̬
        if (rig.IsSleeping())
        {
            //����ڣ��ͻ�����
            rig.WakeUp();
        }
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //�����ϣ����ʹ������Ҳϣ������һֱ�����Ǿ�һֱ�ƾͿ�����
        //rig.AddForce(Vector3.forward * 10);

    }
}
