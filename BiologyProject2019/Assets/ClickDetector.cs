using UnityEngine;
using TMPro;

public class ClickDetector : MonoBehaviour
{

    private GameObject popup;
    private PopupManager popupManager;

    private void Start()
    {
        popupManager = GameObject.FindGameObjectWithTag("PopupManager").GetComponent<PopupManager>();
        popup = gameObject.transform.GetChild(0).gameObject;
    }

    private void OnMouseDown()
    {
        popupManager.SwitchPopups();
        SwitchGraphicsToChecked();
        SetCurrentPopup();
    }

    public void SetCurrentPopup()
    {
        popupManager.CurrentPopup = popup;
        popup.SetActive(true);
    }

    public void SwitchGraphicsToChecked()
    {
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = popupManager.Checked;
    }

    public void SwitchGraphicsTounchecked()
    {
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = popupManager.Unchecked;
    }
}
