using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupNameSetter : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponentInChildren<TextMeshPro>().text = gameObject.transform.parent.name;
    }
}
