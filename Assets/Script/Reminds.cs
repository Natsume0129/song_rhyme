using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Reminds : MonoBehaviour
{
    // Start is called before the first frame update
    public RandomPic randomPics;
    public Poems poemtxt;
    public Poemss poemtxt2;
    public Text texts;

    
    GameObject overcanvas;
    private Button btn;

    public int count=0;
    
    void Start()
    {
        texts=GameObject.Find("Remindtext").GetComponent<Text>();
        overcanvas=GameObject.Find("Over");
        btn = GameObject.Find("Button").GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        if(randomPics.flag){
            
            texts.text="恭喜，鉴定正确";
        }
        else{
            texts.text="很遗憾，鉴定错误";
        }
    }
    void OnButtonClick()
    {
        randomPics.tmp=false;
        // int re1=Random.Range(0,randomPics.textures.Length);
        // while(re1==randomPics.picno)
        // {
        //     re1=Random.Range(0,randomPics.textures.Length);
        // }
        randomPics.picno+=1;
        if(randomPics.picno>9)
        {
            randomPics.picno=0;
        }
        randomPics.img.sprite=(Sprite)randomPics.textures[randomPics.picno];
        

        int re2=Random.Range(0,poemtxt.allLines.Length);
        while(re2==randomPics.picno)
        {
            re2=Random.Range(0,poemtxt.allLines.Length);
        }
        poemtxt.poemno1=re2;
        poemtxt.poem1.text=poemtxt.allLines[poemtxt.poemno1];
        poemtxt2.poem1.text=poemtxt2.allLines[poemtxt.poemno1];
        count+=1; 
    }
   
}
