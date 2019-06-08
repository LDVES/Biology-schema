using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject CurrentPopup;

    public void SwitchPopups()
    {
        CurrentPopup.SetActive(false);
    }
}