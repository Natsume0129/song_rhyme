using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(QuitGame);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR    //如果是在编辑器环境下
                UnityEditor.EditorApplication.isPlaying = false;
        #else   //在打包出来的环境下
                    Application.Quit();
        #endif
    }
}
