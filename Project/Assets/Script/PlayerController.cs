using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetKeyDown/GetKey/GetKeyUp: 키를 누른순간/ 누르고 있는 상태/ 뗀 순간
        // KeyCode.LeftArrow/KeyCode.RightArrow: 좌측키/ 우측키
        if(Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x >= -8.27)
            {
                transform.Translate(-0.1f, 0, 0);
            }
            else
                return;
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x <= 8.21)
            {
                transform.Translate(0.1f, 0, 0);
            }
            else
                return;
        }
    }
}
