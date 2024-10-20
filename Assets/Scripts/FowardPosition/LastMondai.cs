using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastMondai : MonoBehaviour
{
    public InputField inputField;
    public GameObject mondaiObject;
    public GameObject seikaiObject;
    public GameObject fuseikaiObject;
    public GameObject cancelObject;
    public GameObject arrowObject;
    public GameObject inventoryObject;
    public GameObject doorObject;
    public GameObject canOpen_doorObject;
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
        if (inputField.text == "ゲームプレイありがとう！" || inputField.text == "ゲームプレイありがとう!")
        {
            seikaiObject.SetActive(true);
            cancelObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            doorObject.SetActive(false);
            canOpen_doorObject.SetActive(true);

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
