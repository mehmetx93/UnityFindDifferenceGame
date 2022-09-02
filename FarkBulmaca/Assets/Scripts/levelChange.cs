using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelChange : MonoBehaviour
{
    public static int levelID=0;

    public Sprite[] images;
    public Vector2[] locations;

    public GameObject myImage;
    public GameObject myTarget;

    // Start is called before the first frame update
    void Start()
    {
        locations  = new Vector2[24]; ;
        locations[0] = new Vector2(231, -61);
        locations[1] = new Vector2(296, 161);
        locations[2] = new Vector2(127, -49);
        locations[3] = new Vector2(224, 35);
        locations[4] = new Vector2(95, -196);
        locations[5] = new Vector2(210, -128);
        locations[6] = new Vector2(300, -99);
        locations[7] = new Vector2(170, -59);
        locations[8] = new Vector2(242, 153);
        locations[9] = new Vector2(60, 32);
        locations[10] = new Vector2(362, -86);
        locations[11] = new Vector2(126, -17);
        locations[12] = new Vector2(246, 23);
        locations[13] = new Vector2(53, -111);
        locations[14] = new Vector2(181, 193);
        locations[15] = new Vector2(335, 88);
        locations[16] = new Vector2(90, -138);
        locations[17] = new Vector2(356, -80);
        locations[18] = new Vector2(277, 44);
        locations[19] = new Vector2(38, -52);
        locations[20] = new Vector2(79, -26);
        locations[21] = new Vector2(241, 145);
        locations[22] = new Vector2(308, 132);
        locations[23] = new Vector2(13, -18);



        myImage.GetComponent<Image>().sprite = images[levelID];
        myTarget.transform.localPosition = locations[levelID];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateLevel()
    {
        myImage.GetComponent<Image>().sprite = images[levelID];
        myTarget.transform.localPosition = locations[levelID];
    }
}
