using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenShop()
    {
        Application.OpenURL("https://shop.nationalgallery.ie/?_ga=2.110344706.687976278.1524495960-1479245085.1524495960");
    }

    public void OpenWhatsOn()
    {
        Application.OpenURL("https://www.nationalgallery.ie/whats-on");
    }

    public void OpenArtAndArtists()
    {
        Application.OpenURL("https://www.nationalgallery.ie/art-and-artists");
    }
}
