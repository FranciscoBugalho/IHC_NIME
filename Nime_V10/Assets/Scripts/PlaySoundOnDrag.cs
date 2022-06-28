using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnDrag : MonoBehaviour
{
    public AudioSource[] sounds;
    private Vector3 mouseDown;
    private Vector3 mouseUp;
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
                mouseDown = Input.mousePosition;
            }
        }

        if(Input.GetMouseButtonUp(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.transform.name == gameObject.name) {
                mouseUp = Input.mousePosition;
                if(mouseDown != mouseUp) {
                    int n = Random.Range(0, sounds.Length);
                    AudioSource sound = sounds[n];
                    //sound.Play();
                    sound.PlayOneShot(sound.clip, 1);
                    print("drag");
                }
            }
        }
    }
}
