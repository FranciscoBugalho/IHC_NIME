using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnHold : MonoBehaviour
{
    public AudioSource[] sounds;
    private AudioSource current;
    // Start is called before the first frame update
    void Start()
    {
        switchSound();
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButton(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.transform.name == gameObject.name) {
                //sound.Play();
                if(!current.isPlaying) {
                    current.PlayOneShot(current.clip, 1);
                }
                print("hold");
            }
         }
         if(Input.GetMouseButtonUp(0)) {
            current.Stop();
            switchSound();
         }
    }

    void switchSound() {
        int n = Random.Range(0, sounds.Length);
        current = sounds[n];
    }
}
