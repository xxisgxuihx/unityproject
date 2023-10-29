using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shijiao1 : MonoBehaviour
{

    public Transform target; //目标模型
    private float scale = 10.0f;

    public float sizespeed = 1;    // 定义了一个名为sizespeed的公共（public）浮点型（float）变量，初始值为1
    public float mouseSpeed = 10;  // 定义了一个名为mouseSpeed的公共浮点型变量，初始值为10

    private Vector3 lastMousePosition;    // 定义了一个名为lastMousePosition的私有（private）Vector3类型变量

    // Update is called once per frame
    void Update()
    {    // 定义了一个名为Update的方法，在每一帧（frame）中被调用

        float mouse = -Input.GetAxis("Mouse ScrollWheel");    // 获取鼠标滚轮的输入值，并将其赋值给名为mouse的局部（local）浮点型变量

        // 鼠标中键按住拖动
        if (Input.GetMouseButton(2))
        {    // 检测if语句中的条件是否为真，如果鼠标中键被按住，则执行大括号内的代码块

            Vector3 deltaMousePosition = Input.mousePosition - lastMousePosition;    // 获取当前鼠标位置和上一次鼠标位置之间的差值，并将其赋值给名为deltaMousePosition的局部Vector3类型变量

            transform.Translate(-deltaMousePosition.x * mouseSpeed * Time.deltaTime, -deltaMousePosition.y * mouseSpeed * Time.deltaTime, 0);    // 将摄像机的位置向左右和上下移动，移动的距离由鼠标的移动距离和鼠标速度决定

        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0) //滚轮缩放
        {
            //改变物体大小 
            scale += Input.GetAxis("Mouse ScrollWheel") * 1.0f; //滚轮滑动数值返回0.1
            target.transform.localScale = new Vector3(1 * scale, 1 * scale, 1 * scale);
        }

        transform.Translate(new Vector3(0, mouse * sizespeed, 0) * Time.deltaTime, Space.World);    // 将摄像机的位置向上或向下移动，移动的距离由鼠标滚轮的输入值和大小速度决定

        lastMousePosition = Input.mousePosition;    // 将鼠标当前位置赋值给lastMousePosition变量，以便下一帧计算鼠标位置差值
    }
}