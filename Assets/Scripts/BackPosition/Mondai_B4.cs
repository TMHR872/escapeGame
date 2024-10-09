using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MondaiB4 : MonoBehaviour
{
    public InputField inputField;
    public GameObject mondaiObject;
    //public GameObject seikaiObject;
    public GameObject arrowObject;
    public GameObject inventoryObject;
    public GameObject hiObject;
    public GameObject canOpen_hiObject;
    public int count;
    public float hideDelay = 2.0f; // 非表示にするまでの時間（秒）
    // Start is called before the first frame update
    void Start()
    {
        inputField = inputField.GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 1)
        {
            hiObject.SetActive(false);
            canOpen_hiObject.SetActive(true);
        }
    }

    public void InputText()
    {
        if (inputField.text == "A" || inputField.text == "a")
        {
            //seikaiObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            hiObject.SetActive(true);
            canOpen_hiObject.gameObject.SetActive(false);
            //seikaiObject.SetActive(false);

        }

    }

    /*IEnumerator HideSeikaiObjectAfterDelay()
    {
        yield return new WaitForSeconds(hideDelay); // 指定した秒数待機
        seikaiObject.SetActive(false); // 非表示にする
    }*/
}
