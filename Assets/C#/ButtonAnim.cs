using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnim : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        panel1.SetActive(true);
        panel2.SetActive(true);
        panel3.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }


}
