using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Text;
    private AudioSource lyPlayer;
    public AudioClip voice;
    int playvoice = 0;
    void Start()
    {
        lyPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)&&playvoice==1&&!lyPlayer.isPlaying)
        {
            lyPlayer.PlayOneShot(voice);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Íæ¼Ò´¥Åö
        if (other.tag == "Player")
        {
            lyPlayer.enabled = true;
            playvoice = 1;
            Text.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Íæ¼ÒÀë¿ª
        playvoice = 0;
        Text.SetActive(false);
        lyPlayer.Pause();
        lyPlayer.enabled = false;
    }
}
