using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ����
        //��ײ�����ı�Ҫ����
        //�������嶼����ײ��������һ�������и���

        #region RigidBody�����Ϣ
        //Mass ������Ĭ��ΪKG��
        //����Խ�����Խ��

        //Drag ��������
        //�������ƶ�����ʱӰ�����Ŀ���������С
        //0��ʾû�п�������

        //Angluar Drag
        //����Ť����ת����ʱӰ�����Ŀ���������С
        //0��ʾû�п�������

        //Use Gravity �Ƿ�������Ӱ��

        //Is Kinematic
        //������ô�ѡ�����󽫲��ᱻ��������������ֻ��ͨ����Transform��������в���
        //�����ƶ�ƽ̨���������Ҫ������������HingeJoint�ĸ��壬�����Խ��ǳ�����

        //Interpolate ��ֵ����
        //�ø��������ƶ���ƽ��
        //  None ��Ӧ�ò�ֵ����
        //  Interpolate ����ǰһ֡�ı任��ƽ���任
        //  Extrapolate ��ֵ���㣬������һ֡�Ĺ��Ʊ仯��ƽ���任

        //Collision Detection����ײ���ģʽ��
        //���ڷ��ÿ����ƶ��Ķ��󴩹�����������������ײ
        //  Discrete ��ɢ���
        //      �Գ���������������ײ��ʹ����ɢ��ײ��⡣������ײ���ڲ�����ײʱ��ʹ����ɢ��ײ��⡣����������ײ��Ĭ��ֵ��
        //  Continuous �������
        //      �Զ�̬��ײ�壨���и��壩ʹ����ɢ��ײ���
        //      ���Ծ�̬��ײ�壨û�и��壩ʹ��������ײ���
        //      ����Ϊ������̬��Continuous Dynamic���ĸ��彫�ڲ�����ø������ײʱʹ��������ײ��⡣�������Զ��������кܴ�Ӱ�죬���û�п��ٶ������ײ�����뽫�䱣��ΪDiscrete���ã�
        //      �������彫ʹ����ɢ��ײ���
        //  Continuous Dynamic (������̬���)�������ĸ�
        //      ������Ϊ������Continuous����������̬��Continuous Dynamic����ײ����Ϸ����ʹ��������ײ��⡣�����Ծ�̬��ײ�壨û�и��壩ʹ��������ײ���
        //      ��������������ײ�壬ʹ����ɢ��ײ��⡣���ڿ����ƶ��Ķ���
        //  Continuous Speculative�������Ʋ��⣩
        //      �Ը������ײ��ʹ���Ʋ���������ײ��⡣�÷���ͨ����������ײ���ĳɱ�����

        //Constrants Լ��
        //�Ը����˶�������
        //  Freeze Position
        //      ��ѡ���ֹͣ����������X��Y��Z����ƶ�
        //  Freeze Position
        //      ��ѡ���ֹͣ����Χ�ƾֲ�X��Y��Z����ת
        #endregion
        #endregion

        #region ��ײ��
        //��ײ����ʾ������������״��
        //������������������ײ���㣬ģ����ʵ����ײЧ���������������

        #region 1.3D��ײ������
        //1.��״
        //2.��״
        //3.����
        //4.����
        //5.��̥
        //6.����

        #endregion

        #region 2.��ͬ����
        //Is Trigger
        //�Ƿ��Ǵ�������������ô�����
        //�����ײ�彫���ڴ����¼������������������
        //��Ҫ���ڽ���û������Ч������ײ���

        //Material
        //������ʣ�����ȷ����ײ�������������ײʱ�Ľ��������֣���ʽ

        //Center
        //��ײ���ڶ���ֲ��ռ��е����ĵ�λ��

        #endregion

        #region 3.������ײ��
        //Box Collider ��״��ײ��
        //  Size ��ײ����X��Y��Z�Ϸ���Ĵ�С

        //Sphere Collider ��״��ײ��
        //  Radius ������ײ��İ뾶��С

        //Capsule Collider ������ײ��
        //  Radius ������İ뾶
        //  Height ������ĸ߶�
        //  Direction �������ڶ���ֲ��ռ��е�����

        #endregion

        #region 4.��������ʹ�ö�����ײ�����
        //���������Ӷ�����ײ����Ϣ������ײ���
        #endregion

        #region ��������ײ��
        //Mesh Collider ������ײ��
        //  Convex
        //      ��ѡ�˸�ѡ�������Convex��������ô����ԣ���Mesh Collider��������Mesh Collider������ײ
        //      Convex Mesh Collider���255��������
        //  Cooking Options
        //      ���û��ӹӰ�����������������ʽ����������ѡ��
        //  Mesh
        //      ������Ҫ������ײ������

        //Wheel Collider ��̥��ײ��

        //Terrain Collider ������ײ��
        #endregion
        #endregion

        #region �������
        //�����������

        //������ʲ���
        //  Dynamic Friction
        //      �����ƶ�ʱʹ�õ�Ħ������ͨ��Ϊ0-1֮���ֵ��ֵΪ������һ����ֵΪ1��ʹ����Ѹ�پ�ֹ�������úܴ�����������ƶ�����
        //  Static Friction
        //      ������ֹ�ڱ�����ʱʹ�õ�Ħ������ͨ��Ϊ0-1֮���ֵ��ֵΪ������һ����ֵΪ1�����º����ö����ƶ�
        //  Bounciness
        //      ���浯����Σ�ֵΪ0�����ᷴ����ֵΪ1ʱ�ڷ���ʱ�������κ�������ʧ��Ԥ�ƻ���һЩ����ֵ����ֻ���ܻ��ģ��������������
        //  Friction Combine
        //      ������ײ�����Ħ��������Ϸ�ʽ
        //      -Average ������Ħ��ֵ��ƽ��ֵ
        //      -Minimun ʹ������ֵ�е���Сֵ
        //      -Maximun ʹ������ֵ�е����ֵ
        //      -Multiply ����Ħ��ֵ���
        //  Unce Combine
        //      ������ײ����ĵ��Ե���Ϸ�ʽ����ģʽ��Friction Combineģʽ��ͬ
        #endregion

        

    }

    #region ��ײ��⺯��
    #region ע�⣺��ײ�ʹ�����Ӧ����������������������ں�����Ҳ��ͨ���������

    #endregion

    #region ������ײ�����Ӧ����
    //��ײ�����Ӵ�ʱ�����Զ������������
    private void OnCollisionEnter(Collision collision)
    {
        //Collision���͵Ĳ����������������Լ��Ķ���������Ϣ

        // �ؼ�����
        //1.��ײ���Ķ�����ײ������Ϣ
        //collision.collider
        //2.��ײ�������������GameObject��
        //collision.gameObject
        //3.��ײ��������������λ����Ϣ
        //collision.transform
        //4.�����������
        //collision.contactCount
        //�Ӵ�����������
        //collision.contacts
        //ֻҪ�õ�����ײ���Ķ����������Ϣ���Ϳ��Եõ�����������Ϣ
        print(this.name + "��" + collision.gameObject.name + "ײ����");
    }

    //��ײ��������ʱ�����Զ�ִ�еĺ���
    private void OnCollisionExit(Collision collision)
    {
        print(this.name + "��" + collision.gameObject.name + "������ײ��");
    }

    //����������Ӵ�Ħ��ʱ���ͻ�һֱ���øú���
    private void OnCollisionStay(Collision collision)
    {
        print(this.name + "��" + collision.gameObject.name + "��ײ��");
    }

    #endregion

    #region �����������Ӧ����
    //������ʼ�ĺ�������һ�νӴ�ʱ���Զ�����
    private void OnTriggerEnter(Collider other)
    {
        print(this.name + "��" + other.gameObject.name + "�Ӵ�����");
    }
    //���������ĺ����������Ӵ�ʱ���Զ�����
    private void OnTriggerExit(Collider other)
    {
        print(this.name + "��" + other.gameObject.name + "�����Ӵ���");
    }
    //��������Ӵ��л᲻ͣ�ĵ���
    protected virtual void OnTriggerStay(Collider other)
    {
        print(this.name + "��" + other.gameObject.name + "�Ӵ���");
    }
    #endregion

    #region Ҫ��ȷʲôʱ�����Ӧ����
    //1.ֻҪ���صĶ����ܸ�������������ײ���ߴ�������ô��Ӧ�����������������ܱ���Ӧ
    //2.�����������Ƕ�Ҫʹ�ã������ʹ�ø�������
    //3.���ʱһ���������壬�����ڸ������ϣ��������ͨ���Ӷ���ҽű������ײ�ǲ��еģ�������ص����常������
    //4.Ҫ��ȷ������ײ�ʹ�������Ӧ������
    #endregion

    #region ��ײ�ʹ���������������д���麯�� ������ȥ��д�߼�
    //һ������Ҫ��д����ײ�ͳ�������Я�̱������͵ģ�û��Ҫд��public����Ϊ�����Լ��ֶ����ã�����unity�Լ�����
    #endregion
    #endregion
    // Update is called once per frame
    void Update()
    {
        
    }
}
