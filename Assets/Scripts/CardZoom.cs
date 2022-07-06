using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardZoom : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject ZoomCard;
    private GameObject zoomCard;
    private Sprite zoomSprite;


    public void Awake()
    {
        Canvas = GameObject.Find("Canvas");
        zoomSprite = gameObject.GetComponent<Image>().sprite;
    }

   
   public void OnHoverEnter()
   {
       if(Game.stopZoomWhileDragging.Equals(false))
       {
           if(Game.searchForCard == false)
           {
            zoomCard = Instantiate(ZoomCard, new Vector2((Game.gameWidth/2), (Game.gameHeight/2)), Quaternion.identity);
            zoomCard.GetComponent<Image>().sprite = zoomSprite;
            zoomCard.transform.SetParent(Canvas.transform, true);
       
            RectTransform rect = zoomCard.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2((Game.gameWidth/4), (Game.gameHeight/2)+150); //Doubles the size of the card. Will need to change this when modifying cards on the field.
           }

           if(Game.searchForCard ==true)
           {
            zoomCard = Instantiate(ZoomCard, new Vector2((Game.gameWidth-400), (Game.gameHeight/2)), Quaternion.identity);
            zoomCard.GetComponent<Image>().sprite = zoomSprite;
            zoomCard.transform.SetParent(Canvas.transform, true);
       
            RectTransform rect = zoomCard.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2((Game.gameWidth/4), (Game.gameHeight/2)+150); //Doubles the size of the card. Will need to change this when modifying cards on the field.
           }
       }


       
   }

   public void OnHoverExit()
   { 
        Destroy(zoomCard);
   }
}
