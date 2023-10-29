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

    // 创建一个当前时间字符串变量 NowTime_Str
    private string NowTime_Str;

    // 实时获取当前系统时间 并转化为字符串格式
    void System_Time_Get()
    {
        // 获取当前时间
        NowSystemTime = DateTime.Now.ToLocalTime();
        // 转换为字符串格式
        NowTime_Str = string.Format("{0:D}{1:D}{2:D}{3:D}{4:D}{5:D}",
            NowSystemTime.Year, NowSystemTime.Month, NowSystemTime.Day, NowSystemTime.Hour, NowSystemTime.Minute, NowSystemTime.Second);
    }

    // Update is called once per frame
    void Update()
    {
        System_Time_Get();
        // TimeText01.text 显示 "2022年8月16日10:20:36"
        TimeText01.text = NowSystemTime.Year + "/" + NowSystemTime.Month + "/" + NowSystemTime.Day + "/"
            + NowSystemTime.Hour + ":" + NowSystemTime.Minute + ":" + NowSystemTime.Second;
    }
}
