using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomPic : MonoBehaviour
{

private Button btnTrue;
private Button btnFalse;
public Object[] textures;
public int picno;
public Poems poem1;
public Reminds reminds;
public int poemsno1;
public Image img;
public bool flag;
public bool tmp=false;
GameObject remindcanvas;
GameObject overcanvas;
public Text Scores;
public int Score=0; 
void Start()
{
    img=GetComponent<Image>();
    btnTrue = GameObject.Find("true").GetComponent<Button>();
    btnTrue.onClick.AddListener(OnButtonClick);
    btnFalse = GameObject.Find("false").GetComponent<Button>();
    btnFalse.onClick.AddListener(OnButtonClick2);
    picno=0;
    img.sprite=(Sprite)textures[picno];
    poemsno1=poem1.poemno1;
    remindcanvas=GameObject.Find("Remind");
    remindcanvas.SetActive(false);
    overcanvas=GameObject.Find("Over");
    overcanvas.SetActive(false);


    Scores=GameObject.Find("Score").GetComponent<Text>();
    Scores.text="分数:"+Score.ToString();
}

void Update()
{
    
    if(tmp)
    {
        remindcanvas.SetActive(true);
    }
    else
    {
        remindcanvas.SetActive(false);
    }
    if(reminds.count>=10)
    {
        overcanvas.SetActive(true);
        reminds.count=0;
    }
    Scores.text="分数:"+Score.ToString();
}
void OnButtonClick()
{
    tmp=true;
    if(picno==poemsno1)
    {
        flag=true;
        Score+=5;
        Scores.text="分数:"+Score.ToString();
    }
    else{
        flag=false;
    }
}
void OnButtonClick2()
{
    tmp=true;
    if(picno!=poemsno1)
    {
        flag=true;
        Score+=5;
        Scores.text="分数:"+Score.ToString();
    }
    else{
        flag=false;
        
    }
}
}