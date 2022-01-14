using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public InputField userNameInputField;
    public Button startButton;
    public Text errorLabel;

    public Text highScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        errorLabel.gameObject.SetActive(false);

        userNameInputField.text = GameManager.Instance.playerData.username;
        highScoreLabel.text = "Best Score : " + GameManager.Instance.playerData.bestScore;
    }

    public void SaveUserName()
    {
        GameManager.Instance.SaveUserName(userNameInputField.text);
    }

    public void OnClickedStart()
    {
        if (userNameInputField.text.Length == 0)
        {
            errorLabel.gameObject.SetActive(true);
        }
        else
        {
            SaveUserName();
            SceneManager.LoadScene(1);
        }
    }
}
