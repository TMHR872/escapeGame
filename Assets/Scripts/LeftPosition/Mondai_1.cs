using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mondai_1 : MonoBehaviour
{
    public InputField inputField;
    public GameObject mondaiObject;
    //public GameObject seikaiObject;
    public GameObject arrowObject;
    public GameObject inventoryObject;
    public GameObject game1Object;
    public GameObject canopen_game1Object;
    public GameObject messageObject;
    public GameObject cancelObject;
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
        if (inputField.text == "フィッシングメール")
        {
            //seikaiObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            game1Object.SetActive(false);
            canopen_game1Object.SetActive(true);
            messageObject.SetActive(true);
            cancelObject.SetActive(true);
            //seikaiObject.SetActive(false);

        }

    }

    /*IEnumerator HideSeikaiObjectAfterDelay()
    {
        yield return new WaitForSeconds(hideDelay); // 指定した秒数待機
        seikaiObject.SetActive(false); // 非表示にする
    }*/
}
