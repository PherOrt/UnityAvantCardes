using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchActiveDeactive : MonoBehaviour
{
    public GameObject SearchForACard;
    public GameObject SearchPlayerHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Game.searchForCard){
            SearchForACard.SetActive(true);
            SearchPlayerHand.SetActive(true);
        }

        if(!Game.searchForCard){
            SearchForACard.SetActive(false);
            SearchPlayerHand.SetActive(false);
        }
    }
}
