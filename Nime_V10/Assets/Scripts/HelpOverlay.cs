using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HelpOverlay : MonoBehaviour
{
    public GameObject PanelMenu;
    //public Sprite helpOverlaySprite;
    //public Image image;


    public void ChangeOverlay()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
        //image.sprite = helpOverlaySprite;

        if(PanelMenu != null)
        {
            bool isActive = PanelMenu.activeSelf;
            //image.sprite = helpOverlaySprite;
            PanelMenu.SetActive(!isActive);

        }

    }

    public void ChangeOverlay2()
    {
        Debug.Log("Im out");
        PanelMenu.SetActive(false);
    }
}
