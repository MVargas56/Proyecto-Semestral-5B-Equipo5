using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour {

    public Scrollbar vida_UI;
    float vida;
	// Use this for initialization
	void Start () {
        vida = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        vida_UI.size = vida;

        //if (vida)
        {

        }
		
	}
}
