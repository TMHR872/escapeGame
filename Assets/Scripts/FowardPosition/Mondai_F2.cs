using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mondai_F2 : MonoBehaviour
{
    public InputField inputField;
    public GameObject mondaiObject;
    public GameObject seikaiObject;
    public GameObject fuseikaiObject;
    public GameObject cancelObject;
    public GameObject arrowObject;
    public GameObject inventoryObject;
    public GameObject clockObject;
    public GameObject canopen_clockObject;
    public AudioClip correctSound;       // ��������AudioClip
    private AudioSource audioSource;     // AudioSource���i�[����ϐ�
    public float hideDelay = 2.0f; // ��\���ɂ���܂ł̎��ԁi�b�j
    // Start is called before the first frame update
    void Start()
    {
        inputField = inputField.GetComponent<InputField>();
        audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource��ǉ�
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InputText()
    {
        if (inputField.text == "���݂A���悤�A���񂺂�" || inputField.text == "���݂�,���悤,���񂺂�")
        {
            audioSource.PlayOneShot(correctSound); // �������Đ�
            seikaiObject.SetActive(true);
            cancelObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            clockObject.SetActive(true);
            canopen_clockObject.SetActive(false);

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
