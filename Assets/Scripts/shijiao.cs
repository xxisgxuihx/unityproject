using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shijiao : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameObject FirstCamera;
    // Use this for initialization
    public bool IsClock;
    // Start is called before the first frame update
    void Start()
    {
        IsClock = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsClock)
        {

        }
        else
        {

            // �����굱ǰλ�õ�X��Y

            float mouseX = Input.GetAxis("Mouse X") * moveSpeed;

            float mouseY = Input.GetAxis("Mouse Y") * moveSpeed;


            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Confined;
            // �����Y���ϵ��ƶ���תΪ������������˶�����������X�ᷴ����ת

            FirstCamera.transform.localRotation = FirstCamera.transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);

            // �����X���ϵ��ƶ�תΪ�������ҵ��ƶ���ͬʱ������������������������ƶ�

            transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0);

        }

    }
}
