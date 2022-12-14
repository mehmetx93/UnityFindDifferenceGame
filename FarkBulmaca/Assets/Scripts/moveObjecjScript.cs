using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveObjecjScript : MonoBehaviour
{

    private Vector3 position;
    private float width;
    private float height;

    private void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {


            transform.position = Input.mousePosition;

        }
        if (Input.GetMouseButtonUp(0))
        {
            checkLocation.tryCheck = true;
        }
       

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            // Move the cube if the screen has the finger moving.
            if (touch.phase == TouchPhase.Moved)
            {

                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                pos.y = (pos.y - height) / height;
                position = new Vector3(-pos.x, pos.y, 0);

                // Position the cube.
                transform.position = position;
                checkLocation.tryCheck = true;
          
            }

        }

    }

}
