using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(BackMenuScene);
    }
    public void BackMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
