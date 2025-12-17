using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoTodaySong : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Goto);
    }
    public void Goto()
    {
        SceneManager.LoadScene("TodaySong");
    }
}
