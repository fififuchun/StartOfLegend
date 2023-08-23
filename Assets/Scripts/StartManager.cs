using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartManager : MonoBehaviour
{
    public TextMeshProUGUI startText;

    void Start()
    {
        // startText = GameObject.Find("");
    }

    // Update is called once per frame
    void Update()
    {
        startText.color = new Color(1.0f, 1.0f, 1.0f, 0.6f + (Mathf.Sin(3 * Time.time) / 3));
    }

    public void PushGoSelectButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
