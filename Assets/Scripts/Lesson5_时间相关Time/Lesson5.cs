using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        #region Time���������Ҫ������ɶ
        //ʱ�����������Ҫ������Ϸ�в���λ�ơ���ʱ��ʱ����ͣ��
        #endregion

        #region ʱ�����ű���
        //ʱ��ֹͣ
        Time.timeScale = 0;
        //�ָ�����
        Time.timeScale = 1;
        //2����
        Time.timeScale = 2;
        #endregion

        #region ֡���ʱ��
        //֡���ʱ����Ҫ��������λ��
        //·��=ʱ��*�ٶ�
        //��������ѡ��������ļ��ʱ��
        //���ϣ����Ϸ��ͣʱ�Ͳ����� �Ǿ�ʹ��deltatime
        //���ϣ����Ϸ������ͬӰ��Ϳ���ʹ��unscaledDeltaTime

        //֡���ʱ�䣺�����һ֡���˶���ʱ�䣨�룩
        //��ScaleӰ��
        print("֡���ʱ��" + Time.deltaTime);

        //����ScaleӰ��
        print("����ScaleӰ���֡���ʱ��" + Time.unscaledDeltaTime);

        #endregion

        #region ��Ϸ��ʼ�����ڵ�ʱ��
        //��Ҫ������ʱ��������Ϸ�м�ʱ
        //��ScaleӰ��
        print("��Ϸ��ʼ�����ڵ�ʱ��" + Time.time);

        //����ScaleӰ��
        print("����ScaleӰ�����Ϸ��ʼ�����ڵ�ʱ��" + Time.unscaledTime);

        #endregion

        #region ֡��
        //�ӿ�ʼ��������Ϸ���˶���֡����ѭ����
        print(Time.frameCount);
        #endregion
    }
    void FixedUpdate()
    {
        #region ����֡����ʱ�� FixedUpdate
        //��ScaleӰ��
        print("����֡����ʱ��" + Time.fixedDeltaTime);

        //����ScaleӰ��
        print("����ScaleӰ�������֡����ʱ��" + Time.fixedUnscaledDeltaTime);

        #endregion
    }

    //�ܽ�
    //Time��ص�����
    //��õľ������ǵ�
    //1.֡���ʱ�䣬����λ���������
    //2.ʱ�����ű���������ճ�����߱��ٵȵ�
    //3.֡����֡ͬ����
}
