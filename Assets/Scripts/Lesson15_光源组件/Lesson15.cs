using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        #region ������
        #region type ��Դ����
        //Spot �۹��
        //  Range ���ⷶΧ����
        //  Spot Angle ��ά�Ƕ�
        //Diretional ����⣨�����⣩
        //Point ���Դ
        //Area ���Դ
        #endregion

        #region Color ��ɫ

        #endregion

        #region Mode ��Դģʽ
        //Realtime ʵʱ��Դ
        //ÿ֡ʵʱ���㣬Ч���ã��������Ĵ�

        //Baked �決��Դ
        //���ȼ���ã��޷���̬�仯

        //Mixed ��Ϲ�Դ
        //Ԥ�ȼ���+ʵʱ����
        #endregion

        #region intensity ��Դ����

        #endregion

        #region Shadow Type ��Ӱ����
        //NoShadows �ر���Ӱ
        //HardShadows ��Ӳ��Ӱ
        //SoftShadows �����Ӱ
        #endregion

        #region Cookie ͶӰ����

        #endregion

        #region Draw Halo ���ι⻷����

        #endregion

        #region Flare ҫ��

        #endregion

        #region Culling Mask �޳����ֲ�
        //������Щ��Ķ����ܵ��ù�ԴӰ��

        #endregion

        #region ����
        #region Indirect Multiplier �ı��ӹ��ǿ��
        //����1��ÿ�η�����ʹ�����
        //����1��ÿ�η�����ʹ�����
        #endregion

        #region RealTimeShadows ��Ӱ��ز���
        //Strength ��Ӱ����
        //0-1֮�䣬Խ��Խ��

        //Resolution ��Ӱ��ͼ��Ⱦ�ֱ���
        //Խ��Խ���棬����Խ��

        //Bias ��Ӱ�����Դ�ľ���

        //Noraml Bias ��ӰͶ�����ط�����������

        //Near Panel ��Ⱦ��Ӱ�Ľ�������
        #endregion

        #region Cookies Size

        #endregion

        #region Render Mode ��Ⱦ���ȼ�
        //Auto ����ʱȷ��

        //Important ����������Ϊ��λ������Ⱦ��Ч�����棬���Ĵ�

        //Not Important �Կ���ģʽ������Ⱦ
        #endregion

        #endregion

        #endregion

        #region �������
        //������Զ�����ͨ�������ʹ��
        light.intensity = 1.0f;

        #endregion

        #region ��������
        //Window->Rendering->Lighting

        //Environment �����������
        //1.Skybox Material ��պв���
        //  ���Ըı���պ�
        //2.Sun Source ̫����Դ
        //  �����û�Ĭ��ʹ�ó����������ķ�������̫��
        //3.Environment Lighting ����������
        //  a.Source ������Դ��ɫ
        //      Skybox ��պͲ�����Ϊ��������ɫ
        //      Gradient ����Ϊ��ա���ƽ�ߡ����浥��ѡ����ɫ������֮����
        //  b.Intersity Muiltiplier ����������
        //  c.Ambient Mode ȫ�ֹ�������
        //      ֻ��������ʵʱȫ�ֺ�ȫ�ֺ決ʱ������
        //      Realtime�������ã�
        //      Baked


        //Other Settings ��������
        //1.Fog ����
        //  a.Color ����ɫ
        //  b.Mode �����ģʽ
        //      I.Linear �������������
        //          Start ���������Զ��ʼ����
        //          End ���������Զ��ȫ�ڵ�
        //      II.Exponential �����ָ������
        //          Density ǿ��
        //      III.Exponential Quare ������ָ�����������
        //          Density ǿ��
        //2.Halo Texture ��Դ��Χ�⻷������
        //3.Halo Strength �⻷�ɼ���
        //4.Flare Fade Speed ҫ�ߵ���ʱ�䣬�������֮�󵭳���ʱ��
        //5.Flare Strength ҫ�߿ɼ���
        //6.Spot Cookie �۹�Ƽ�Ӱ����
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
