using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class GameInterection : MonoBehaviour {
    
    public Image POI_0,POI_1,POI_2;
    public Text scoreCollected,timer;
    public GameObject POI_0g, POI_1g, POI_2g, winner_Panel, loser_Panel;
    public GameObject b0, b1, b2, b3, b4, b5, b6, b7, b8;
    public int score;
    float timerr = 90;
    
    
    
    

    void Update()
    {
        timerr = timerr - Time.deltaTime;
        timer.text = timerr.ToString("0");

        if(timer.text == "0")
        {
            loser_Panel.SetActive(true);
        }
        else if(score == 9)
        {
            winner_Panel.SetActive(true);
        }
    }

    

    void FixedUpdate () {

        
        

        RaycastHit hit;
        

        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Banana"))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    score++;
                    scoreCollected.text = score.ToString();
                    hit.collider.gameObject.SetActive(false);
                }
            }



            if (hit.collider.name == "POI0")
            {

                

                POI_0.color = new Color(0, 1, 0, 1);

                if (Input.GetMouseButton(0))
                {
                    
                    
                    POI_1g.SetActive(true);
                    POI_2g.SetActive(true);
                    POI_0g.SetActive(false);
                    b0.SetActive(true);
                    b1.SetActive(true);
                    b2.SetActive(true);
                    transform.localPosition = new Vector3(-4f, 9f, -27f);

                }
                
                    
                    

            }

        



        if (hit.collider.name == "POI1")
            {

                

                POI_1.color = new Color(0, 1, 0, 1);
                if (Input.GetMouseButtonDown(0))
                {
                    POI_1g.SetActive(false);
                    POI_2g.SetActive(true);
                    POI_0g.SetActive(true);
                    b3.SetActive(true);
                    b4.SetActive(true);
                    b5.SetActive(true);
                    transform.localPosition = new Vector3(-28f, 10f, 8f);

                }


            }
            if (hit.collider.name == "POI2")
            {

               

                POI_2.color = new Color(0, 1, 0, 1);
                if (Input.GetMouseButtonDown(0))
                {
                    POI_2g.SetActive(false);
                    POI_0g.SetActive(true);
                    POI_1g.SetActive(true);
                    b6.SetActive(true);
                    b7.SetActive(true);
                    b8.SetActive(true);
                    transform.localPosition = new Vector3(14f, 12f, 16f);

                }

            }
            }

        
        else
        {

            POI_0.color = new Color(1, 1, 1, 1);
            POI_1.color = new Color(1, 1, 1, 1);
            POI_2.color = new Color(1, 1, 1, 1);
        }
		
	}
}
