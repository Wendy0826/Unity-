using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region ��̬����
        #region ����
        //��ǰ��Ļ�ֱ���
        print(Screen.currentResolution);

        //��Ļ���ڵ�ǰ���
        //����õ����ǵ�ǰ���ڵĿ��ߣ������豸�ķֱ���
        //һ��д�����ô��ڿ��������ʱ���������
        print(Screen.width);//��
        print(Screen.height);//��

        //��Ļ����ģʽ
        Screen.sleepTimeout = SleepTimeout.SystemSetting;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        #endregion

        #region ������
        //����ʱ�Ƿ�ȫ��ģʽ
        Screen.fullScreen= true;

        //����ģʽ
        //��ռȫ�� FullScreenMode.ExclusiveFullScreen
        //ȫ������ FullScreenMode.FullScreenWindow
        //��󻯴��� FullScreenMode.MaximizedWindow
        //����ģʽ FullScreenMode.Windowed
        Screen.fullScreenMode = FullScreenMode.Windowed;

        //�ƶ��豸��Ļת�����
        //�����Զ���תΪ����� Home������
        Screen.autorotateToLandscapeLeft = true;
        //�����Զ���תΪ�Һ��� Home������
        Screen.autorotateToLandscapeRight = true;
        //�����Զ���ת������ Home������
        Screen.autorotateToPortrait = true;
        //�����Զ���ת�������ſ� Home������
        Screen.autorotateToPortraitUpsideDown = true;

        //ָ����Ļ��ʾ����
        Screen.orientation = ScreenOrientation.LandscapeLeft;

        #endregion
        #endregion

        #region ��̬����
        //���÷ֱ��ʣ�һ���ƶ��豸��ʹ��
        Screen.SetResolution(1920, 1080, false);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
