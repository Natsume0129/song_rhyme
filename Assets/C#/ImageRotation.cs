using UnityEngine;

//开始界面瓷器旋转
public class ImageRotation : MonoBehaviour
{
    private float rot;
    public GameObject Image;

    // Update is called once per frame
    void Update()
    {
        rot += Time.deltaTime * 15.0f;
        Quaternion quaternion = Quaternion.Euler(0, 0, rot);
        Image.transform.rotation = quaternion;
    }
}
