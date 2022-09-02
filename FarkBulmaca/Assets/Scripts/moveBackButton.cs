using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveBackButton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Mathf.Abs(this.transform.position.x - Input.mousePosition.x) < 20 && Mathf.Abs(this.transform.position.y - Input.mousePosition.y) <20)
            {
                this.transform.position = Input.mousePosition;
            } }
       
    }
}
