using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mondai : MonoBehaviour
{
    public InputField inputField;
    public GameObject mondaiObject;
    //public GameObject seikaiObject;
    public GameObject arrowObject;
    public GameObject inventoryObject;
    public GameObject kamiObject;
    public GameObject keyObject;
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
        if (inputField.text == "20")
        {
            //seikaiObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            kamiObject.SetActive(false);
            keyObject.SetActive(true);
            //seikaiObject.SetActive(false);

        }

    }

    /*IEnumerator HideSeikaiObjectAfterDelay()
    {
        yield return new WaitForSeconds(hideDelay); // �w�肵���b���ҋ@
        seikaiObject.SetActive(false); // ��\���ɂ���
    }*/
}
