using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour
{
    public AudioSource[] sounds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.transform.name == gameObject.name) {
                int n = Random.Range(0, sounds.Length);
                AudioSource sound = sounds[n];
                //sound.Play();
                sound.PlayOneShot(sound.clip, 1);
                print("click");
            }
        }
    }
}
