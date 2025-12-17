using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ywlController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Text;
    private AudioSource ywlPlayer;
    public AudioClip voice;
    int playvoice = 0;
    void Start()
    {
        ywlPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && playvoice == 1 && !ywlPlayer.isPlaying)
        {
            ywlPlayer.PlayOneShot(voice);
        }
     }
    private void OnTriggerEnter(Collider other)
    {
        //Íæ¼Ò´¥Åö
        if (other.tag == "Player")
        {
            ywlPlayer.enabled = true;
            playvoice = 1;
            Text.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Íæ¼ÒÀë¿ª
        playvoice = 0;
        Text.SetActive(false);
        ywlPlayer.Pause();
        ywlPlayer.enabled = false;
    }

}
