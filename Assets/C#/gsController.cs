using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gsController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Text;
    private AudioSource gsPlayer;
    public AudioClip voice;
    int playvoice = 0;
    void Start()
    {
        gsPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && playvoice == 1 && !gsPlayer.isPlaying)
        {
            gsPlayer.PlayOneShot(voice);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        //玩家触碰高僧
        if (other.tag == "Player")
        {
            gsPlayer.enabled = true;
            playvoice = 1;
            Text.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //玩家离开高僧
        playvoice = 0;
        Text.SetActive(false);
        gsPlayer.Pause();
        gsPlayer.enabled = false;
    }
}
