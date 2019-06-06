using UnityEngine;
using TMPro;

public class ClickDetector : MonoBehaviour
{
    public GameObject Popup;
    public TextMeshPro TestText;

    private void OnMouseDown()
    {
        print(TestText.text =  gameObject.name);
    }
}
