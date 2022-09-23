using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    Vector3 mousePos, transPos, cursorPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition; // mousePosition 마우스 위치 받기 
        Debug.Log(mousePos);
        transPos = Camera.main.ScreenToWorldPoint(mousePos); // screen world 좌표로 바꾸기
        cursorPos = new Vector3(transPos.x, transPos.y, 0); // 그걸 다시 vector3로 
        transform.position = new Vector3(cursorPos.x, cursorPos.y, cursorPos.z); // 본체 바꾸기
    }
}
