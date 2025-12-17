using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Skip : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(SkipToNext);
    }
    public void SkipToNext()
    {
        SceneManager.LoadScene("OptionScene");
    }
}
