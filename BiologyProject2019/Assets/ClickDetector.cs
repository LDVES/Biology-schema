using UnityEngine;
using TMPro;

public class ClickDetector : MonoBehaviour
{
    public TextMeshPro TestText;

    private GameObject popup;
    private PopupManager popupManager;

    private void Start()
    {
        popupManager = GameObject.FindGameObjectWithTag("PopupManager").GetComponent<PopupManager>();
        popup = gameObject.transform.GetChild(0).gameObject;
    }

    private void OnMouseDown()
    {
        print(TestText.text =  gameObject.name);
        popupManager.SwitchPopups();
        SetCurrentPopup();
    }

    public void SetCurrentPopup()
    {
        popupManager.CurrentPopup = popup;
        popup.SetActive(true);
    }
}
