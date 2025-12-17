using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoGuessGame : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Goto);
    }
    public void Goto()
    {
        SceneManager.LoadScene("GuessGame");
    }
}
