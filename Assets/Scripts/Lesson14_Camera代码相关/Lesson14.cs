using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        #region ��Ҫ��̬��Ա
        //1.��ȡ�����
        //��������Ļ�ȡ
        //���������tagһ��Ҫ��MainCarema���ܻ�ȡ
        print(Camera.main.name);

        //��ȡ�����������
        print(Camera.allCamerasCount);

        //�õ����������
        Camera[] allCamera = Camera.allCameras;
        print(allCamera.Length);

        //2.��Ⱦ���ί��
        //������޳�ǰ�����ί��
        Camera.onPreCull += (c) => { };

        //�������Ⱦǰ�����ί��
        Camera.onPreRender += (c) => { };

        //�������Ⱦ�����ί��
        Camera.onPostRender += (c) => { };
        #endregion

        #region ��Ҫ��Ա
        //1.�����ϵĲ�����������camera�л�ȡ��
        Camera.main.depth = 0;

        //2.��������ת��Ļ����
        //ת����X��Y������Ļλ�ã�Z���������������֮��ľ���
        Vector3 v = Camera.main.WorldToScreenPoint(this.transform.position);
        print(v);

        

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //3.��Ļ����ת��������
        //������ı䣬zĬ��Ϊ0��ת��Ϊ��������ϵ�ĵ㣬��Զ�����ӿ��ཻ�Ľ���
        //����ı���z����ôת����ȥ����������ϵ�ĵ㣬��������������ǰ�����پ���ĺ�����ϵĵ�
        Vector3 v = Input.mousePosition;
        v.z = 10;
        obj.position = Camera.main.ScreenToWorldPoint(v);
    }
}
