using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuInterection : MonoBehaviour {

    public Image button;
	
	void Start () {

        
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        RaycastHit hit;

        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity))
        {

            if(hit.collider.name == "Start_Button")
            {
                button.color = new Color(1, 1, 1, 1);
                if (Input.GetMouseButton(0))
                {
                    SceneManager.LoadScene("1");
                }
            }
            
            

        }
        else
        {
            button.color = new Color(1, 1, 1, 0.5f);
        }
    }
}
