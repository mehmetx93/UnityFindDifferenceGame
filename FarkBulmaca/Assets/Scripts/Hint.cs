using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public GameObject targetObject;
    GameObject tempHint;
    float scaleNumber = 10;
    float temptime = 10;
    public Sprite passive, active, hint;

    public void getHint()
    {

        if (temptime <= 0)
        {
            if (scaleNumber > 2) scaleNumber -= 2;
            temptime = 100;
            tempHint = Instantiate(targetObject, targetObject.transform);
            tempHint.transform.position = targetObject.transform.position;
            tempHint.GetComponent<Image>().sprite = hint;
            tempHint.GetComponent<Image>().color = Color.white;
            tempHint.GetComponent<Image>().enabled = true;

            tempHint.transform.localScale = new Vector3(scaleNumber, scaleNumber, scaleNumber);
            ;
            Destroy(tempHint, 1);
        }
    }
    bool waiting = true;
    IEnumerator oneSecondWait()
    {

        waiting = false;
        yield return new WaitForSeconds(0.01f); //Bekleme
        if (temptime >= 0) temptime -= 0.1f;
        waiting = true;

    }

    private void LateUpdate()
    {
        if (waiting)
            StartCoroutine("oneSecondWait");
        if (temptime >= 0)
        {
            transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 0, this.transform.rotation.z), Quaternion.Euler(0, 0, temptime * 3.6f), 1);
            this.GetComponent<Image>().sprite = passive;
        }
        else
        {
            this.GetComponent<Image>().sprite = active;
        }


    }

}
