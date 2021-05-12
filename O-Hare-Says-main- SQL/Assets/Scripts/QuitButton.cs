using UnityEngine;
using UnityEngine.UI;

[System.Obsolete]
public class QuitButton : MonoBehaviour
{
    public Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonPressed);
    }

    public void ButtonPressed()
    {
        Application.ExternalEval(script: "window.location=http://www.flywithbutchohare.com");
        Application.Quit();
    }
}
