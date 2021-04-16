using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextExample : MonoBehaviour
{
    public Text unityText;
    public TextMeshProUGUI tmpText;

    // Start is called before the first frame update
    void Start()
    {
        unityText.text = "UNITY TEXT";
        tmpText.text = "TMP TEXT";
    }
}
