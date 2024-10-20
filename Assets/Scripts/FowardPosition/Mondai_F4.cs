using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mondai_F4 : MonoBehaviour
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
    public GameObject closedoorObject;
    public GameObject opendoorObject;
    public static int cnt = 0;
    //public AudioClip correctSound;       // 正解音のAudioClip
    //private AudioSource audioSource;     // AudioSourceを格納する変数
    public float hideDelay = 2.0f; // 非表示にするまでの時間（秒）
    // Start is called before the first frame update
    void Start()
    {
        inputField = inputField.GetComponent<InputField>();
        //audioSource = gameObject.AddComponent<AudioSource>(); // AudioSourceを追加
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InputText()
    {
        if (inputField.text == "きみつ、かよう、かんぜん" || inputField.text == "きみつ,かよう,かんぜん")
        {
            //audioSource.PlayOneShot(correctSound); // 音声を再生
            seikaiObject.SetActive(true);
            cancelObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            clockObject.SetActive(true);
            canopen_clockObject.SetActive(false);
            closedoorObject.SetActive(false);
            opendoorObject.SetActive(true);

        }
        else
        {
            fuseikaiObject.SetActive(true);
            cancelObject.SetActive(true);
        }

    }

    /*IEnumerator HideSeikaiObjectAfterDelay()
    {
        yield return new WaitForSeconds(hideDelay); // 指定した秒数待機
        seikaiObject.SetActive(false); // 非表示にする
    }*/
}
