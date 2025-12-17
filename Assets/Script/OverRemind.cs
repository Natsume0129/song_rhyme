using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OverRemind : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject overcanvas;
    public Text texts;
    public RandomPic score;
    public Button btn;
    void Start()
    {
        texts=GameObject.Find("Remindtext2").GetComponent<Text>();
        btn = GameObject.Find("Button2").GetComponent<Button>();
        overcanvas=GameObject.Find("Over");
        btn.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        texts.text="游戏结束，\n"+"最终"+score.Scores.text;
    }
    void OnButtonClick()
    {
        overcanvas.SetActive(false);
        score.Score=0;
        SceneManager.LoadScene("WorkScene");
    }
}
