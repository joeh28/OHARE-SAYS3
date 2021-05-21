using UnityEngine;
using UnityEngine.UI;

[System.Obsolete]
public class QuitButton : MonoBehaviour
{
    public Button button;
    public string Url;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonPressed);
    }

    public void ButtonPressed()
    {
        Application.OpenURL(Url);
        Application.Quit();
        Debug.Log("Game is exiting");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        //Application.ExternalEval(script: "window.location=http://www.flywithbutchohare.com");
        //Application.Quit();
    }
}
