using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shijiao1 : MonoBehaviour
{

    public Transform target; //Ŀ��ģ��
    private float scale = 10.0f;

    public float sizespeed = 1;    // ������һ����Ϊsizespeed�Ĺ�����public�������ͣ�float����������ʼֵΪ1
    public float mouseSpeed = 10;  // ������һ����ΪmouseSpeed�Ĺ��������ͱ�������ʼֵΪ10

    private Vector3 lastMousePosition;    // ������һ����ΪlastMousePosition��˽�У�private��Vector3���ͱ���

    // Update is called once per frame
    void Update()
    {    // ������һ����ΪUpdate�ķ�������ÿһ֡��frame���б�����

        float mouse = -Input.GetAxis("Mouse ScrollWheel");    // ��ȡ�����ֵ�����ֵ�������丳ֵ����Ϊmouse�ľֲ���local�������ͱ���

        // ����м���ס�϶�
        if (Input.GetMouseButton(2))
        {    // ���if����е������Ƿ�Ϊ�棬�������м�����ס����ִ�д������ڵĴ����

            Vector3 deltaMousePosition = Input.mousePosition - lastMousePosition;    // ��ȡ��ǰ���λ�ú���һ�����λ��֮��Ĳ�ֵ�������丳ֵ����ΪdeltaMousePosition�ľֲ�Vector3���ͱ���

            transform.Translate(-deltaMousePosition.x * mouseSpeed * Time.deltaTime, -deltaMousePosition.y * mouseSpeed * Time.deltaTime, 0);    // ���������λ�������Һ������ƶ����ƶ��ľ����������ƶ����������ٶȾ���

        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0) //��������
        {
            //�ı������С 
            scale += Input.GetAxis("Mouse ScrollWheel") * 1.0f; //���ֻ�����ֵ����0.1
            target.transform.localScale = new Vector3(1 * scale, 1 * scale, 1 * scale);
        }

        transform.Translate(new Vector3(0, mouse * sizespeed, 0) * Time.deltaTime, Space.World);    // ���������λ�����ϻ������ƶ����ƶ��ľ����������ֵ�����ֵ�ʹ�С�ٶȾ���

        lastMousePosition = Input.mousePosition;    // ����굱ǰλ�ø�ֵ��lastMousePosition�������Ա���һ֡�������λ�ò�ֵ
    }
}