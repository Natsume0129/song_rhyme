using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poemss : MonoBehaviour
{
    // Start is called before the first frame update
     public TextAsset testTxtFile;
    public Text poem1;
    public Poems pno;
    public int poemno1;
    public string content;
    public string[] allLines;
    void Start()
    {
        poem1=GetComponent<Text>();
        ReadTxt();
    }

    // Update is called once per frame
    void Update()
    {
        poemno1=pno.poemno1;
        poem1.text=allLines[poemno1];
    }
    private void ReadTxt()
    {
        content = testTxtFile.text;//获取到文本内容
        allLines = content.Split('\n');//根据换行符“划分”出多个“行文本”
        
    }
}
