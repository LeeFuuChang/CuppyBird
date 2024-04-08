
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    // Start is called before the first frame update
    TMP_Text text_ui;

    void Awake()
    {
        text_ui = GetComponent<TMP_Text>();
    }

    void Update()
    {
        text_ui.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
