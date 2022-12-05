using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
        #region Transform��Ҫ�������
        //��Ϸ����GameObject��λ�ơ���ת�����š����ӹ�ϵ������ת������ز�������������
        //����Unity�ṩ�ļ�����Ҫ����
        #endregion

        #region �ر�֪ʶ�� Vector3����
        //Vector3��Ҫ��������ʾ��ά����ϵ�е�һ���������һ������
        //����
        Vector3 v = new Vector3();
        v.x = 10;
        v.y = 10;
        v.z = 10;

        //ֻ��xy��Ĭ��z��0
        Vector3 v2 = new Vector3(10, 10);

        //��xyz
        Vector3 v3 = new Vector3(10, 10, 10);

        //Ĭ��0��0��0
        Vector3 v4;

        //Vector�Ļ�������
        //+ - * /
        Vector3 v5 = new Vector3(1, 1, 1);
        Vector3 v6 = new Vector3(2, 2, 2);
        print(v5 + v6);
        print(v5 - v6);
        print(v5 * 2);
        print(v5 / 2);

        //����
        print(Vector3.zero);//0,0,0
        print(Vector3.right);//1,0,0
        print(Vector3.left);//-1,0,0
        print(Vector3.forward);//0,0,1
        print(Vector3.back);//0,0,-1
        print(Vector3.up);//0,1,0
        print(Vector3.down);//0,-1,0

        //���õķ���
        //����������֮��ľ���ķ���
        Vector3.Distance(v5, v6);

        #endregion

        #region λ��
        //�����������ϵ
        //ͨ��position�õ���λ�����������������ϵ��ԭ���λ�ã����ܺ��������ʾ�Ĳ�һ��
        //��Ϊ��������и��ӹ�ϵ�����Ҹ�����λ�ò���ԭ�㣬��ô������Ͽ϶�
        print(this.transform.position);

        //��Ը�����
        //��������������Ǻ���Ҫ������������������Ϊ׼������λ�����ã���һ����ͨ��localPosition����������
        print(this.transform.localPosition);

        //��������һ�������
        //1.����������� ������������ϵԭ��0,0,0
        //2.����û�и�����

        //ע�⣺λ�õĸ�ֵ����ֱ�Ӹı�x,y,z��ֻ������ı�
        this.transform.position = new Vector3(10, 10, 10);
        this.transform.localPosition = Vector3.up * 10;

        //���ֻ���һ��ֵ
        //1.ֱ�Ӹ�ֵ
        this.transform.position = new Vector3(20, this.transform.position.y, this.transform.position.z);
        //2.��ȡ�����ٸ�ֵ
        //��Ȼ����ֱ�Ӹ� transform��xyz������Vector3�ǿ���ֱ�Ӹ�xyz��
        //���Կ�����ȡ������Vector3�����¸�ֵ
        Vector3 vPos = this.transform.position;
        vPos.x = 10;
        this.transform.position = vPos;

        //����ǰ�ĸ�����
        //����ǰ���泯��z��
        print(this.transform.forward);
        //����ǰ��ͷ������y��
        print(this.transform.up);
        //����ǰ���ҳ���z��
        print(this.transform.right);

        #endregion


    }

    // Update is called once per frame
    void Update()
    {
        #region λ��
        //�������ϵ�µ�λ�Ƽ��㹫ʽ
        //·�� = ���� * �ٶ� * ʱ��

        //��ʽһ �Լ�����
        //�仯�ľ���position
        //�õ�ǰ��λ��+��Ҫ���೤���룬�õ��������ڵ�λ��
        //this.transform.position = this.transform.position + this.transform.forward * 1 * Time.deltaTime;
        //this.transform.position += this.transform.forward * 1 * Time.deltaTime;

        //��ʽ�� API
        //����һ����ʾλ�ƶ���
        //����������ʾ�������ϵ,Ĭ����������Լ�����ϵ��

        //�����������ϵ��Z�ᶯ
        this.transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.World);

        //�������������ϵ���Լ����泯��
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.World);

        //������Լ�����ϵ���泯�򶯣�һ���������Լ������ƶ���
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.Self);

        //ע�⣺һ����API������λ��
        #endregion
    }
    //�ܽ�
    //Vector3
    //��������ṩ�ĳ��þ�̬���ԣ���һ���������ķ���
    //λ��
    //�������������ϵ������ڸ��������������������
    //���ܹ������޸�xyz��ֻ��ͳһ��
    //λ��
    //�Լ���μ���������λ��
    //API���ĸ�����������λ�ƣ�ʹ��ʱҪע��

}
