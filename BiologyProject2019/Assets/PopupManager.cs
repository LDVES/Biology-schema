using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject CurrentPopup;
    public Sprite Unchecked;
    public Sprite Checked;


    public void SwitchPopups()
    {
        CurrentPopup.SetActive(false);
        CurrentPopup.transform.parent.GetComponent<ClickDetector>().SwitchGraphicsTounchecked();
    }
}