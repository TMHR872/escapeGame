using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mondai_B2 : MonoBehaviour
{
    public InputField inputField;
    public GameObject mondaiObject;
    public GameObject seikaiObject;
    public GameObject fuseikaiObject;
    public GameObject cancelObject;
    public GameObject arrowObject;
    public GameObject inventoryObject;
    public GameObject kamiObject;
    public GameObject canOpen_kamiObject;
    public GameObject kinkoObject;
    public GameObject canOpen_kinkoObject;
    public float hideDelay = 2.0f; // 非表示にするまでの時間（秒）
    // Start is called before the first frame update
    void Start()
    {
        inputField = inputField.GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InputText()
    {
        if (inputField.text == "C" || inputField.text == "c" || inputField.text == "Ｃ" || inputField.text == "ｃ")
        {
            seikaiObject.SetActive(true);
            cancelObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            kamiObject.SetActive(true);
            canOpen_kamiObject.SetActive(false);
            Mondai_B4.count++;
            if (Mondai_B4.count >= 3)
            {
                kinkoObject.SetActive(false);
                canOpen_kinkoObject.SetActive(true);
            }

        }
        else
        {
            fuseikaiObject.SetActive(true);
            cancelObject?.SetActive(true);
        }

    }

    /*IEnumerator HideSeikaiObjectAfterDelay()
    {
        yield return new WaitForSeconds(hideDelay); // 指定した秒数待機
        seikaiObject.SetActive(false); // 非表示にする
    }*/
}
