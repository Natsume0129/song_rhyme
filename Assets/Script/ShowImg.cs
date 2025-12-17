using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShowImg : MonoBehaviour
{
    // Start is called before the first frame update
    public Object[] textures;
    public Image img;
    public int picno;
    private Button btnNext;
    public Introduction poemtxt;
    public Introduction poemtxt2;
    void Start()
    {
        img=GetComponent<Image>();
        picno=0;
        img.sprite=(Sprite)textures[picno];

        btnNext = GameObject.Find("Next").GetComponent<Button>();
        btnNext.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnButtonClick(){
        picno+=1;
        if(picno>=2)
        {
            picno=0;
            SceneManager.LoadScene("FinalScene");
        }
        img.sprite=(Sprite)textures[picno];
        poemtxt.poem1.text=poemtxt.allLines[picno];
        poemtxt2.poem1.text=poemtxt2.allLines[picno];
    }
}
