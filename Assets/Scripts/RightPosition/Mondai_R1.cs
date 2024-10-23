using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mondai_R1 : MonoBehaviour
{
    public InputField inputField;
    public GameObject mondaiObject;
    public GameObject seikaiObject;
    public GameObject fuseikaiObject;
    public GameObject cancelObject;
    public GameObject arrowObject;
    public GameObject inventoryObject;
    public GameObject hikoukiObject;
    public GameObject canopen_hikoukiObject;
    public float hideDelay = 2.0f; // ��\���ɂ���܂ł̎��ԁi�b�j
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
        if (inputField.text == "3" || inputField.text == "�R")
        {
            cancelObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            hikoukiObject.SetActive(true);
            canopen_hikoukiObject.SetActive(false);
            seikaiObject.SetActive(true);

        }
        else
        {
            fuseikaiObject.SetActive(true);
            cancelObject.SetActive(true);
        }

    }

    /*IEnumerator HideSeikaiObjectAfterDelay()
    {
        yield return new WaitForSeconds(hideDelay); // �w�肵���b���ҋ@
        seikaiObject.SetActive(false); // ��\���ɂ���
    }*/
}
