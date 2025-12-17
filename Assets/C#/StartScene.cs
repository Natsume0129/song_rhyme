using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Begin);
    }
    public void Begin()
    {
        SceneManager.LoadScene("VideoScene");
    }
}
