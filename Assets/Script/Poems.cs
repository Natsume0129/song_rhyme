using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poems : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset testTxtFile;
    public Text poem1;
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
        
    }
    private void ReadTxt()
    {
        content = testTxtFile.text;//获取到文本内容
        allLines = content.Split('\n');//根据换行符“划分”出多个“行文本”
        poemno1=Random.Range(0,allLines.Length);
        poem1.text=allLines[poemno1];
    }
    
}
