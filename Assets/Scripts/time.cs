using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public TextMeshProUGUI TimeText01;
    public DateTime NowSystemTime;

    // ����һ����ǰʱ���ַ������� NowTime_Str
    private string NowTime_Str;

    // ʵʱ��ȡ��ǰϵͳʱ�� ��ת��Ϊ�ַ�����ʽ
    void System_Time_Get()
    {
        // ��ȡ��ǰʱ��
        NowSystemTime = DateTime.Now.ToLocalTime();
        // ת��Ϊ�ַ�����ʽ
        NowTime_Str = string.Format("{0:D}{1:D}{2:D}{3:D}{4:D}{5:D}",
            NowSystemTime.Year, NowSystemTime.Month, NowSystemTime.Day, NowSystemTime.Hour, NowSystemTime.Minute, NowSystemTime.Second);
    }

    // Update is called once per frame
    void Update()
    {
        System_Time_Get();
        // TimeText01.text ��ʾ "2022��8��16��10:20:36"
        TimeText01.text = NowSystemTime.Year + "/" + NowSystemTime.Month + "/" + NowSystemTime.Day + "/"
            + NowSystemTime.Hour + ":" + NowSystemTime.Minute + ":" + NowSystemTime.Second;
    }
}
