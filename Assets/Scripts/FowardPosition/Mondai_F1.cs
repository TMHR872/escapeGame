using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mondai_F1 : MonoBehaviour
{
    public InputField inputField;
    public GameObject mondaiObject;
    public GameObject seikaiObject;
    public GameObject fuseikaiObject;
    public GameObject cancelObject;
    public GameObject arrowObject;
    public GameObject inventoryObject;
    public GameObject calenderObject;
    public GameObject canOpen_calenderObject;
    public GameObject clockObject;
    //public GameObject hintpanelObject;
    public GameObject canOpen_clockObject;
    public GameObject hint1Object;
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
        if (inputField.text == "�݂A��" || inputField.text == "�݂�,��")
        {
            seikaiObject.SetActive(true);
            cancelObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            calenderObject.SetActive(true);
            canOpen_calenderObject.SetActive(false);
            //hintpanelObject.SetActive(true);
            hint1Object.SetActive(true);
            Mondai_F4.cnt++;
            if (Mondai_F4.cnt >= 3)
            {
                clockObject.SetActive(false);
                canOpen_clockObject.SetActive(true);
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
        yield return new WaitForSeconds(hideDelay); // �w�肵���b���ҋ@
        seikaiObject.SetActive(false); // ��\���ɂ���
    }*/
}
