using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mondai_B4 : MonoBehaviour
{
    public InputField inputField;
    public GameObject mondaiObject;
    public GameObject seikaiObject;
    public GameObject fuseikaiObject;
    public GameObject cancelObject;
    public GameObject arrowObject;
    public GameObject inventoryObject;
    public GameObject hintkinkoObject;
    public GameObject canOpen_kinkoObject;
    public static int count = 0;
    public float hideDelay = 2.0f; // îÒï\é¶Ç…Ç∑ÇÈÇ‹Ç≈ÇÃéûä‘ÅiïbÅj
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
        if (inputField.text == "CAT" || inputField.text == "cat" || inputField.text == "ÇbÇ`Çs")
        {
            seikaiObject.SetActive(true);
            cancelObject.SetActive(true);
            mondaiObject.SetActive(false);
            arrowObject.SetActive(true);
            inventoryObject.SetActive(true);
            hintkinkoObject.SetActive(true);
            canOpen_kinkoObject.gameObject.SetActive(false);

        }
        else
        {
            fuseikaiObject.SetActive(true);
            cancelObject.SetActive(true);
        }

    }

    /*IEnumerator HideSeikaiObjectAfterDelay()
    {
        yield return new WaitForSeconds(hideDelay); // éwíËÇµÇΩïbêîë“ã@
        seikaiObject.SetActive(false); // îÒï\é¶Ç…Ç∑ÇÈ
    }*/
}
