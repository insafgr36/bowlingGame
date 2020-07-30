using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bowling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Text score;
    public Text ganner;
    private int compteur = 0;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Pin")
        {
            compteur++;

            score.text = "Score : " + compteur.ToString();
            if (compteur == 10)
            {
                ganner.text = compteur.ToString() + "    gangner!!";
            }
            else if (compteur >= 6)
            {
                ganner.text = compteur.ToString() + "    moyenne !!";
            }
           else if(compteur==10)
            {
               Application.LoadLevel("MenuVectoire");
            }
        }
       
       
    }
}