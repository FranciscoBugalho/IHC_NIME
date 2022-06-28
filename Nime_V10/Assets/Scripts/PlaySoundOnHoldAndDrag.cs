using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnHoldAndDrag : MonoBehaviour
{
    public AudioSource[] sounds;
    private Vector3 mouseStart;
    private Vector3 mouseCur;
    private AudioSource current;
    private int aux = 0;
    // Start is called before the first frame update
    void Start()
    {
        switchSound();
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetMouseButtonDown(0)) {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.collider != null && hit.transform.name == gameObject.name) {
                    if(aux == 0) {
                        aux = 1;
                        mouseStart = Input.mousePosition;
                    }
                }
            }

            if(aux == 1 && !current.isPlaying && (Input.mousePosition != mouseStart)) {
                switchSound();
                current.PlayOneShot(current.clip, 1);
                print("hold&drag");
            }

            if(Input.GetMouseButtonUp(0)) {
                aux = 0;
                current.Stop();
                switchSound();
            }
        }

        void switchSound() {
                int n = Random.Range(0, sounds.Length);
                current = sounds[n];
        }
}
