using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour
{
    public bool isDragging = false;
    private bool isDraggable = true;
    private bool debugBoardSpots = false; //change to true to see targeting of board zones
    


    
#region isOverPlayerRow
    //---------isOverPlayerRow1------------
   private bool isOverPlayerRow1Zone1 = false;
   private bool isOverPlayerRow1Zone2 = false;
   private bool isOverPlayerRow1Zone3 = false;
   private bool isOverPlayerRow1Zone4 = false;
   private bool isOverPlayerRow1Zone5 = false;
   private bool isOverPlayerRow1Zone6 = false;

   //---------isOverPlayerRow2------------
   private bool isOverPlayerRow2Zone1 = false;
   private bool isOverPlayerRow2Zone2 = false;
   private bool isOverPlayerRow2Zone3 = false;
   private bool isOverPlayerRow2Zone4 = false;
   private bool isOverPlayerRow2Zone5 = false;
   private bool isOverPlayerRow2Zone6 = false;

   //---------isOverPlayerRow3------------
   private bool isOverPlayerRow3Zone1 = false;
   private bool isOverPlayerRow3Zone2 = false;
   private bool isOverPlayerRow3Zone3 = false;
   private bool isOverPlayerRow3Zone4 = false;
   private bool isOverPlayerRow3Zone5 = false;
   private bool isOverPlayerRow3Zone6 = false;

   //---------isOverPlayerRow4------------
   private bool isOverPlayerRow4Zone1 = false;
   private bool isOverPlayerRow4Zone2 = false;
   private bool isOverPlayerRow4Zone3 = false;
   private bool isOverPlayerRow4Zone4 = false;
   private bool isOverPlayerRow4Zone5 = false;
   private bool isOverPlayerRow4Zone6 = false;

   //---------isOverPlayerRow5------------
   private bool isOverPlayerRow5Zone1 = false;
   private bool isOverPlayerRow5Zone2 = false;
   private bool isOverPlayerRow5Zone3 = false;
   private bool isOverPlayerRow5Zone4 = false;
   private bool isOverPlayerRow5Zone5 = false;
   private bool isOverPlayerRow5Zone6 = false;

   private bool isOverFierceAndSabotageZone = false;
   private bool isOverSearchPlayerHandZone = false;

#endregion

   private Vector2 startPosition;
   public static GameObject Zone;
   private bool selectedCard = false;
   public static GameObject cardSelected;

   

    void Start(){
        
    }
    // Update is called once per frame
    void Update()
    {
        if(isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        
    }

#region OnCollisionEnter2D
    private void OnCollisionEnter2D(Collision2D collision){
        //--------------PlayerRow1------------------------
        if(collision.gameObject.tag == "PlayerRow1Zone1" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is over PlayerRow1Zone1");
            }
            Zone = collision.gameObject;
            isOverPlayerRow1Zone1 = true;
        }
        if(collision.gameObject.tag == "PlayerRow1Zone2" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow1Zone2");
            }
            Zone = collision.gameObject;
            isOverPlayerRow1Zone2 = true;
        }
        if(collision.gameObject.tag == "PlayerRow1Zone3" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow1Zone3");
            }
            Zone = collision.gameObject;
            isOverPlayerRow1Zone3 = true;
        }
        if(collision.gameObject.tag == "PlayerRow1Zone4" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow1Zone4");
            }
            Zone = collision.gameObject;
            isOverPlayerRow1Zone4 = true;
        }
        if(collision.gameObject.tag == "PlayerRow1Zone5" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow1Zone5");
            }
            Zone = collision.gameObject;
            isOverPlayerRow1Zone5 = true;
        }
        if(collision.gameObject.tag == "PlayerRow1Zone6" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow1Zone6");
            }
            Zone = collision.gameObject;
            isOverPlayerRow1Zone6 = true;
        }
        //--------------PlayerRow2------------------------
        if(collision.gameObject.tag == "PlayerRow2Zone1" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow2Zone1");
            }
            Zone = collision.gameObject;
            isOverPlayerRow2Zone1 = true;
        }
        if(collision.gameObject.tag == "PlayerRow2Zone2" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow2Zone2");
            }
            Zone = collision.gameObject;
            isOverPlayerRow2Zone2 = true;
        }
        if(collision.gameObject.tag == "PlayerRow2Zone3" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow2Zone3");
            }
            Zone = collision.gameObject;
            isOverPlayerRow2Zone3 = true;
        }
        if(collision.gameObject.tag == "PlayerRow2Zone4" && Game.searchForCard == false)
        {
        if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow2Zone4");
            }
            Zone = collision.gameObject;
            isOverPlayerRow2Zone4 = true;
        }
        if(collision.gameObject.tag == "PlayerRow2Zone5" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow2Zone5");
            }
            Zone = collision.gameObject;
            isOverPlayerRow2Zone5 = true;
        }
        if(collision.gameObject.tag == "PlayerRow2Zone6" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow2Zone6");
            }
            Zone = collision.gameObject;
            isOverPlayerRow2Zone6 = true;
        }
        //--------------PlayerRow3------------------------
        if(collision.gameObject.tag == "PlayerRow3Zone1" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow3Zone1");
            }
            Zone = collision.gameObject;
            isOverPlayerRow3Zone1 = true;
        }
        if(collision.gameObject.tag == "PlayerRow3Zone2" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow3Zone2");
            }
            Zone = collision.gameObject;
            isOverPlayerRow3Zone2 = true;
        }
        if(collision.gameObject.tag == "PlayerRow3Zone3" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow3Zone3");
            }
            Zone = collision.gameObject;
            isOverPlayerRow3Zone3 = true;
        }
        if(collision.gameObject.tag == "PlayerRow3Zone4" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow3Zone4");
            }
            Zone = collision.gameObject;
            isOverPlayerRow3Zone4 = true;
        }
        if(collision.gameObject.tag == "PlayerRow3Zone5" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow3Zone5");
            }
            Zone = collision.gameObject;
            isOverPlayerRow3Zone5 = true;
        }
        if(collision.gameObject.tag == "PlayerRow3Zone6" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow3Zone6");
            }
            Zone = collision.gameObject;
            isOverPlayerRow3Zone6 = true;
        }
        //--------------PlayerRow4------------------------
        if(collision.gameObject.tag == "PlayerRow4Zone1" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow4Zone1");
            }
            Zone = collision.gameObject;
            isOverPlayerRow4Zone1 = true;
        }
        if(collision.gameObject.tag == "PlayerRow4Zone2" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow4Zone2");
            }
            Zone = collision.gameObject;
            isOverPlayerRow4Zone2 = true;
        }
        if(collision.gameObject.tag == "PlayerRow4Zone3" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow4Zone3");
            }
            Zone = collision.gameObject;
            isOverPlayerRow4Zone3 = true;
        }
        if(collision.gameObject.tag == "PlayerRow4Zone4" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow4Zone4");
            }
            Zone = collision.gameObject;
            isOverPlayerRow4Zone4 = true;
        }
        if(collision.gameObject.tag == "PlayerRow4Zone5" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow4Zone5");
            }
            Zone = collision.gameObject;
            isOverPlayerRow4Zone5 = true;
        }
        if(collision.gameObject.tag == "PlayerRow4Zone6" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow4Zone6");
            }
            Zone = collision.gameObject;
            isOverPlayerRow4Zone6 = true;
        }
        //--------------PlayerRow5------------------------
        if(collision.gameObject.tag == "PlayerRow5Zone1" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow5Zone1");
            }
            Zone = collision.gameObject;
            isOverPlayerRow5Zone1 = true;
        }
        if(collision.gameObject.tag == "PlayerRow5Zone2" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow5Zone2");
            }
            Zone = collision.gameObject;
            isOverPlayerRow5Zone2 = true;
        }
        if(collision.gameObject.tag == "PlayerRow5Zone3" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow5Zone3");
            }
            Zone = collision.gameObject;
            isOverPlayerRow5Zone3 = true;
        }
        if(collision.gameObject.tag == "PlayerRow5Zone4" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow5Zone4");
            }
            Zone = collision.gameObject;
            isOverPlayerRow5Zone4 = true;
        }
        if(collision.gameObject.tag == "PlayerRow5Zone5" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow5Zone5");
            }
            Zone = collision.gameObject;
            isOverPlayerRow5Zone5 = true;
        }
        if(collision.gameObject.tag == "PlayerRow5Zone6" && Game.searchForCard == false)
        {
            if(debugBoardSpots.Equals(true))
            {
            Debug.Log("The card is over PlayerRow5Zone6");
            }
            Zone = collision.gameObject;
            isOverPlayerRow5Zone6 = true;
        }

        //
        if(collision.gameObject.tag == "FierceAndSabotageZone" && Game.searchForCard == false)
        {
            //Debug.Log("The card is over FierceAndSabotageZone");
            Zone = collision.gameObject;
            isOverFierceAndSabotageZone = true;
        }

        //FierceSabotageSelection
        if(collision.gameObject.tag == "Top" && this.gameObject.name == "DestroyClothing(Clone)" && Game.searchForCard == false || collision.gameObject.tag == "Bottom" && this.gameObject.name == "DestroyClothing(Clone)" && Game.searchForCard == false || collision.gameObject.tag == "Shoes" && this.gameObject.name == "DestroyClothing(Clone)" && Game.searchForCard == false ||collision.gameObject.tag == "Accessory" && this.gameObject.name == "DestroyClothing(Clone)" && Game.searchForCard == false)
        {
            
            Debug.Log("The current name of Zone is: " + Zone);
            
            cardSelected = collision.gameObject;
            selectedCard = true;
            Debug.Log(cardSelected + " is being targeted!");
            Debug.Log("The card being moved during Selection: " + gameObject.name);
        }
        if(collision.gameObject.tag == "SearchPlayerHand" && Game.searchForCard == true){
            Zone = collision.gameObject;
            isOverSearchPlayerHandZone = true;
        }

    }
#endregion

#region OnCollisionExit2D
    private void OnCollisionExit2D(Collision2D collision)
    {
        //--------------PlayerRow1------------------------
        if(collision.gameObject.tag == "PlayerRow1Zone1")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow1Zone1");
            }
        Zone = null;
        isOverPlayerRow1Zone1 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow1Zone1Available = " + Game.PlayerRow1Zone1Available);
            }
        }
        if(collision.gameObject.tag == "PlayerRow1Zone2")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow1Zone2");
            }
        Zone = null;
        isOverPlayerRow1Zone2 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow1Zone2Available = " + Game.PlayerRow1Zone2Available);
            }
        }
        if(collision.gameObject.tag == "PlayerRow1Zone3")
        
        if(debugBoardSpots.Equals(true))
        {
                if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow1Zone3");
            }
        Zone = null;
        isOverPlayerRow1Zone3 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow1Zone3Available = " + Game.PlayerRow1Zone3Available);
            }
        }
        if(collision.gameObject.tag == "PlayerRow1Zone4")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow1Zone4");
            }
        Zone = null;
        isOverPlayerRow1Zone4 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow1Zone4Available = " + Game.PlayerRow1Zone4Available);
            }
        }
        if(collision.gameObject.tag == "PlayerRow1Zone5")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow1Zone5");
            }
        Zone = null;
        isOverPlayerRow1Zone5 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow1Zone5Available = " + Game.PlayerRow1Zone5Available);
            }
        }
        if(collision.gameObject.tag == "PlayerRow1Zone6")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow1Zone6");
            }
        Zone = null;
        isOverPlayerRow1Zone6 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow1Zone6Available = " + Game.PlayerRow1Zone6Available);
            }
        }
        //--------------PlayerRow2------------------------
        if(collision.gameObject.tag == "PlayerRow2Zone1")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow2Zone1");
            }
        Zone = null;
        isOverPlayerRow2Zone1 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow2Zone1Available = " + Game.PlayerRow2Zone1Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow2Zone2")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow2Zone2");
            }
        Zone = null;
        isOverPlayerRow2Zone2 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow2Zone2Available = " + Game.PlayerRow2Zone2Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow2Zone3")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow2Zone3");
            }
        Zone = null;
        isOverPlayerRow2Zone3 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow2Zone3Available = " + Game.PlayerRow2Zone3Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow2Zone4"){
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow2Zone4");
            }
        Zone = null;
        isOverPlayerRow2Zone4 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow2Zone4Available = " + Game.PlayerRow2Zone4Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow2Zone5")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow2Zone5");
            }
        Zone = null;
        isOverPlayerRow2Zone5 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow2Zone5Available = " + Game.PlayerRow2Zone5Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow2Zone6")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow2Zone6");
            }
        Zone = null;
        isOverPlayerRow2Zone6 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow2Zone6Available = " + Game.PlayerRow2Zone6Available);
            }
        }
        //--------------PlayerRow3------------------------
        if(collision.gameObject.tag == "PlayerRow3Zone1")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow3Zone1");
            }
        Zone = null;
        isOverPlayerRow3Zone1 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow3Zone1Available = " + Game.PlayerRow3Zone1Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow3Zone2")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow3Zone2");
            }
        Zone = null;
        isOverPlayerRow3Zone2 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow3Zone2Available = " + Game.PlayerRow3Zone2Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow3Zone3")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow3Zone3");
            }
        Zone = null;
        isOverPlayerRow3Zone3 = false;if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow3Zone3Available = " + Game.PlayerRow3Zone3Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow3Zone4")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow3Zone4");
            }
        Zone = null;
        isOverPlayerRow3Zone4 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow3Zone4Available = " + Game.PlayerRow3Zone4Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow3Zone5")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow3Zone5");
            }
        Zone = null;
        isOverPlayerRow3Zone5 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow3Zone5Available = " + Game.PlayerRow3Zone5Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow3Zone6")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow3Zone6");
            }
        Zone = null;
        isOverPlayerRow3Zone6 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow3Zone6Available = " + Game.PlayerRow3Zone6Available);
            }
        }
        //--------------PlayerRow4------------------------
        if(collision.gameObject.tag == "PlayerRow4Zone1")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow4Zone1");
            }
        Zone = null;
        isOverPlayerRow4Zone1 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow4Zone1Available = " + Game.PlayerRow4Zone1Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow4Zone2")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow4Zone2");
            }
        Zone = null;
        isOverPlayerRow4Zone2 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow4Zone2Available = " + Game.PlayerRow4Zone2Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow4Zone3")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow4Zone3");
            }
        Zone = null;
        isOverPlayerRow4Zone3 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow4Zone3Available = " + Game.PlayerRow4Zone3Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow4Zone4")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow4Zone4");
            }
        Zone = null;
        isOverPlayerRow4Zone4 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow4Zone4Available = " + Game.PlayerRow4Zone4Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow4Zone5")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow4Zone5");
            }
        Zone = null;
        isOverPlayerRow4Zone5 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow4Zone5Available = " + Game.PlayerRow4Zone5Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow4Zone6")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow4Zone6");
            }
        Zone = null;
        isOverPlayerRow4Zone6 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow4Zone6Available = " + Game.PlayerRow4Zone6Available);
            }
        }
        //--------------PlayerRow5------------------------
        if(collision.gameObject.tag == "PlayerRow5Zone1")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow5Zone1");
            }
        Zone = null;
        isOverPlayerRow5Zone1 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow5Zone1Available = " + Game.PlayerRow5Zone1Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow5Zone2")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow5Zone2");
            }
        Zone = null;
        isOverPlayerRow5Zone2 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow5Zone2Available = " + Game.PlayerRow5Zone2Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow5Zone3")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow5Zone3");
            }
        Zone = null;
        isOverPlayerRow5Zone3 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow5Zone3Available = " + Game.PlayerRow5Zone3Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow5Zone4")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow5Zone4");
            }
        Zone = null;
        isOverPlayerRow5Zone4 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow5Zone4Available = " + Game.PlayerRow5Zone4Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow5Zone5")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow5Zone5");
            }
        Zone = null;
        isOverPlayerRow5Zone5 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow5Zone5Available = " + Game.PlayerRow5Zone5Available);
            }
        }

        if(collision.gameObject.tag == "PlayerRow5Zone6")
        {
            if(debugBoardSpots.Equals(true))
            {
                Debug.Log("The card is NOT over PlayerRow5Zone6");
            }
        Zone = null;
        isOverPlayerRow5Zone6 = false;
        if(debugBoardSpots.Equals(true))
            {
                Debug.Log("PlayerRow5Zone6Available = " + Game.PlayerRow5Zone6Available);
            }
        }

        //------------
        if(collision.gameObject.tag == "FierceAndSabotageZone")
        {
            
        //Debug.Log("The card is NOT over FierceAndSabotageZone");
            
        Zone = null;
        isOverFierceAndSabotageZone = false;
        
        }

         //FierceSabotageSelection
        if(collision.gameObject.tag == "Top" && this.gameObject.name == "DestroyClothing(Clone)" || collision.gameObject.tag == "Bottom" && this.gameObject.name == "DestroyClothing(Clone)" || collision.gameObject.tag == "Shoes" && this.gameObject.name == "DestroyClothing(Clone)" ||collision.gameObject.tag == "Accessory" && this.gameObject.name == "DestroyClothing(Clone)")
        {
            Zone = null;
            cardSelected = null;
            selectedCard = false;
            Debug.Log(cardSelected + " is no longer being targeted.");
        }

        if(collision.gameObject.tag == "SearchPlayerHand" && Game.searchForCard == true){
            Zone = null;
            isOverSearchPlayerHandZone = false;
        }
    }
#endregion


    public void StartDrag()
    {
        
        if(!isDraggable) return;
        startPosition = transform.position;
        isDragging = true;
        Game.stopZoomWhileDragging = true;
        Debug.Log("The card being moved is: " + gameObject.name);
        
    }

    public void EndDrag()
    {
        if(!isDraggable) return;
        isDragging = false;
        Game.stopZoomWhileDragging = false;
        //--------------------PlayerRow1-----------------------------------------------
        if (isOverPlayerRow1Zone1 && Game.PlayerRow1Zone1Available && gameObject.CompareTag("Model")){
            Game.PlayerRow1Zone1Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            string card = this.gameObject.name.Replace("(Clone)","");
            //Debug.Log(card);

            //Removes Model from Hand List
            for(var i = 0; i<CardsInGame.playerHand.Count; i++)
            {
                for (var j= 0; j<CardsInGame.RandomizedPlayerDeck.Count; j++)
                {
                    string card1 = CardsInGame.playerHand[i].name.Replace(" (UnityEngine.GameObject)", "");
                    if(CardsInGame.playerHand[i].name.Contains(card))
                    {
                        if(CardsInGame.RandomizedPlayerDeck[j].name.Contains(card1))
                        {
                            CardsInGame.RandomizedPlayerDeck.Remove(CardsInGame.RandomizedPlayerDeck[j]);
                            CardsInGame.playerField.Add(CardsInGame.playerHand[i]);
                            CardsInGame.playerHand.Remove(CardsInGame.playerHand[i]);
                                if( i>0){
                                i = i - 1;
                            }
                        }
                    }
                }
            }
            //Debug.Log("First Card in Hand List is " + CardsInGame.playerHand[0].name);

            if(Game.StartingModelsPicked.Equals(false))
            {
            Game.NumOfStartingModels++;
            Debug.Log("Number of Models Played: " + Game.NumOfStartingModels);
            }
            
        }
        else if (isOverPlayerRow1Zone2 && Game.PlayerRow1Zone2Available && gameObject.CompareTag("Top")){
            Game.PlayerRow1Zone2Available = false;
            Debug.Log("R1Z2 is: " + Game.PlayerRow1Zone2Available);
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow1Zone3 && Game.PlayerRow1Zone3Available && gameObject.CompareTag("Bottom")){
            Game.PlayerRow1Zone3Available = false;
            Debug.Log("R1Z3 is: " + Game.PlayerRow1Zone3Available);
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow1Zone4 && Game.PlayerRow1Zone4Available && gameObject.CompareTag("Shoes")){
            Game.PlayerRow1Zone4Available = false;
            Debug.Log("R1Z4 is: " + Game.PlayerRow1Zone4Available);
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow1Zone5 && Game.PlayerRow1Zone5Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow1Zone5Available = false;
            Debug.Log("R1Z5 is: " + Game.PlayerRow1Zone5Available);
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow1Zone6 && Game.PlayerRow1Zone6Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow1Zone6Available = false;
            Debug.Log("R1Z6 is: " + Game.PlayerRow1Zone6Available);
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        

        //--------------------PlayerRow2-----------------------------------------------

        else if (isOverPlayerRow2Zone1 && Game.PlayerRow2Zone1Available && gameObject.CompareTag("Model")){
            Game.PlayerRow2Zone1Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            string card = this.gameObject.name.Replace("(Clone)","");
            //Debug.Log(card);

            //Removes Model from Hand List
            for(var i = 0; i<CardsInGame.playerHand.Count; i++)
            {
                for (var j= 0; j<CardsInGame.RandomizedPlayerDeck.Count; j++)
                {
                    string card1 = CardsInGame.playerHand[i].name.Replace(" (UnityEngine.GameObject)", "");
                    if(CardsInGame.playerHand[i].name.Contains(card))
                    {
                        if(CardsInGame.RandomizedPlayerDeck[j].name.Contains(card1))
                        {
                            CardsInGame.RandomizedPlayerDeck.Remove(CardsInGame.RandomizedPlayerDeck[j]);
                            CardsInGame.playerField.Add(CardsInGame.playerHand[i]);
                            CardsInGame.playerHand.Remove(CardsInGame.playerHand[i]);
                            if( i>0){
                                i = i - 1;
                            }
                        }
                    }
                }
            }
            
            //Debug.Log("First Card in Hand List is " + CardsInGame.playerHand[0].name);

            if(Game.StartingModelsPicked.Equals(false)){
            Game.NumOfStartingModels++;
            Debug.Log("Number of Models Played: " + Game.NumOfStartingModels);
            }
        }
        else if (isOverPlayerRow2Zone2 && Game.PlayerRow2Zone2Available && gameObject.CompareTag("Top")){
            Game.PlayerRow2Zone2Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow2Zone3 && Game.PlayerRow2Zone3Available && gameObject.CompareTag("Bottom")){
            Game.PlayerRow2Zone3Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow2Zone4 && Game.PlayerRow2Zone4Available && gameObject.CompareTag("Shoes")){
            Game.PlayerRow2Zone4Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow2Zone5 && Game.PlayerRow2Zone5Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow2Zone5Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow2Zone6 && Game.PlayerRow2Zone6Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow2Zone6Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }

        //--------------------PlayerRow3-----------------------------------------------

        else if (isOverPlayerRow3Zone1 && Game.PlayerRow3Zone1Available && gameObject.CompareTag("Model")){
            Game.PlayerRow3Zone1Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            string card = this.gameObject.name.Replace("(Clone)","");
            //Debug.Log(card);

            //Removes Model from Hand List
            for(var i = 0; i<CardsInGame.playerHand.Count; i++)
            {
                for (var j= 0; j<CardsInGame.RandomizedPlayerDeck.Count; j++)
                {
                    string card1 = CardsInGame.playerHand[i].name.Replace(" (UnityEngine.GameObject)", "");
                    if(CardsInGame.playerHand[i].name.Contains(card))
                    {
                        if(CardsInGame.RandomizedPlayerDeck[j].name.Contains(card1))
                        {
                            CardsInGame.RandomizedPlayerDeck.Remove(CardsInGame.RandomizedPlayerDeck[j]);
                            CardsInGame.playerField.Add(CardsInGame.playerHand[i]);
                            CardsInGame.playerHand.Remove(CardsInGame.playerHand[i]);
                            if( i>0){
                                i = i - 1;
                            }
                        }
                    }
                }
            }
            
            //Debug.Log("First Card in Hand List is " + CardsInGame.playerHand[0].name);

            if(Game.StartingModelsPicked.Equals(false)){
            Game.NumOfStartingModels++;
            Debug.Log("Number of Models Played: " + Game.NumOfStartingModels);
            }
        }
        else if (isOverPlayerRow3Zone2 && Game.PlayerRow3Zone2Available && gameObject.CompareTag("Top")){
            Game.PlayerRow3Zone2Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow3Zone3 && Game.PlayerRow3Zone3Available && gameObject.CompareTag("Bottom")){
            Game.PlayerRow3Zone3Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow3Zone4 && Game.PlayerRow3Zone4Available && gameObject.CompareTag("Shoes")){
            Game.PlayerRow3Zone4Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow3Zone5 && Game.PlayerRow3Zone5Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow3Zone5Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow3Zone6 && Game.PlayerRow3Zone6Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow3Zone6Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }

        //--------------------PlayerRow4-----------------------------------------------

        else if (isOverPlayerRow4Zone1 && Game.PlayerRow4Zone1Available && gameObject.CompareTag("Model") && Game.StartingModelsPicked.Equals(true)){
            Game.PlayerRow4Zone1Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow4Zone2 && Game.PlayerRow4Zone2Available && gameObject.CompareTag("Top")){
            Game.PlayerRow4Zone2Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow4Zone3 && Game.PlayerRow4Zone3Available && gameObject.CompareTag("Bottom")){
            Game.PlayerRow4Zone3Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow4Zone4 && Game.PlayerRow4Zone4Available && gameObject.CompareTag("Shoes")){
            Game.PlayerRow4Zone4Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow4Zone5 && Game.PlayerRow4Zone5Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow4Zone5Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow4Zone6 && Game.PlayerRow4Zone6Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow4Zone6Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }

        //--------------------PlayerRow5-----------------------------------------------

        else if (isOverPlayerRow5Zone1 && Game.PlayerRow5Zone1Available && gameObject.CompareTag("Model") && Game.StartingModelsPicked.Equals(true)){
            Game.PlayerRow5Zone1Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow5Zone2 && Game.PlayerRow5Zone2Available && gameObject.CompareTag("Top")){
            Game.PlayerRow5Zone2Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow5Zone3 && Game.PlayerRow5Zone3Available && gameObject.CompareTag("Bottom")){
            Game.PlayerRow5Zone3Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow5Zone4 && Game.PlayerRow5Zone4Available && gameObject.CompareTag("Shoes")){
            Game.PlayerRow5Zone4Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow5Zone5 && Game.PlayerRow5Zone5Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow5Zone5Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }
        else if (isOverPlayerRow5Zone6 && Game.PlayerRow5Zone6Available && gameObject.CompareTag("Accessory")){
            Game.PlayerRow5Zone6Available = false;
            transform.SetParent(Zone.transform, false);
            isDraggable = false;
            MoveCardFromHandToField();
        }

        //--------------------FierceAndSabotageZone-----------------------------------------------
        else if (isOverFierceAndSabotageZone && gameObject.CompareTag("FierceAndSabotageZone")){
            GameObject Canvas;
            GameObject zoomCard;
            Sprite zoomSprite;
            GameObject Card = gameObject;
            Canvas = GameObject.Find("Canvas");
            zoomSprite = gameObject.GetComponent<Image>().sprite;
            zoomCard = Instantiate(Zone, new Vector2((Game.gameWidth/2), (Game.gameHeight/2)), Quaternion.identity);
            zoomCard.GetComponent<Image>().sprite = zoomSprite;
            Game.stopZoomWhileDragging = true;
            zoomCard.transform.SetParent(Canvas.transform, true);
            RectTransform rect = zoomCard.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2((Game.gameWidth/4), (Game.gameHeight/2)+150);
            Game.zoomCard = zoomCard;
            Game.Card = Card;
            Game.cardPlayed = true;
            
            //Removes Card from hand to discard pile
            for(int j = 0; j<CardsInGame.playerHand.Count; j++){
                string card3 = Card.name.Replace("(Clone)", "");
                string card4 = CardsInGame.playerHand[j].name.Replace(" (UnityEngine.GameObject)", "");
                //Debug.Log(card3);
                //Debug.Log(card4);
                if(card4.Equals(card3)){
                    CardsInGame.playerDiscards.Add(CardsInGame.playerHand[j]);
                    CardsInGame.playerHand.Remove(CardsInGame.playerHand[j]);
                }
            }
            
        }
        else if (selectedCard == true){
            GameObject Canvas;
            GameObject zoomCard;
            Sprite zoomSprite;
            GameObject Card = gameObject;
            Canvas = GameObject.Find("Canvas");
            zoomSprite = gameObject.GetComponent<Image>().sprite;
            zoomCard = Instantiate(Card, new Vector2((Game.gameWidth/2), (Game.gameHeight/2)), Quaternion.identity);
            zoomCard.GetComponent<Image>().sprite = zoomSprite;
            Game.stopZoomWhileDragging = true;
            zoomCard.transform.SetParent(Canvas.transform, true);
            RectTransform rect = zoomCard.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2((Game.gameWidth/4), (Game.gameHeight/2)+150);
            gameObject.transform.localScale = new Vector3(0,0,0); //Make Object Invisible. new Vector(1,1,1) make object visible. This is making small card not zoomed invisible.
            name = Zone.name + "Available";

            
            
            //Removes Card from field to discard pile
            for(int i = 0; i<CardsInGame.playerField.Count; i++){
                string card1 = cardSelected.name.Replace("(Clone)","");
                string card2 = CardsInGame.playerField[i].name.Replace(" (UnityEngine.GameObject)", "");
                if(card2.Equals(card1)){
                    CardsInGame.playerDiscards.Add(CardsInGame.playerField[i]);
                    CardsInGame.playerField.Remove(CardsInGame.playerField[i]);
                }
            }
            //Removes Card from hand to discard pile
            for(int j = 0; j<CardsInGame.playerHand.Count; j++){
                string card3 = zoomCard.name.Replace("(Clone)(Clone)", "");
                string card4 = CardsInGame.playerHand[j].name.Replace(" (UnityEngine.GameObject)", "");
                //Debug.Log(card3);
                if(card4.Equals(card3)){
                    CardsInGame.playerDiscards.Add(CardsInGame.playerHand[j]);
                    CardsInGame.playerHand.Remove(CardsInGame.playerHand[j]);
                }
            }
            Debug.Log("The name of the card being played is : " + zoomCard);
            Destroy(cardSelected);
            Game.zoomCard = zoomCard;
            Game.Card = Card;
            selectedCard = false;
            Game.cardPlayed = true; 

            if("PlayerRow1Zone2Available".Equals(name)){Game.PlayerRow1Zone2Available = true;}
            else if("PlayerRow1Zone3Available".Equals(name)){Game.PlayerRow1Zone3Available = true;}
            else if("PlayerRow1Zone4Available".Equals(name)){Game.PlayerRow1Zone4Available = true;}
            else if("PlayerRow1Zone5Available".Equals(name)){Game.PlayerRow1Zone5Available = true;}
            else if("PlayerRow1Zone6Available".Equals(name)){Game.PlayerRow1Zone6Available = true;}
            
            else if("PlayerRow2Zone2Available".Equals(name)){Game.PlayerRow2Zone2Available = true;}
            else if("PlayerRow2Zone3Available".Equals(name)){Game.PlayerRow2Zone3Available = true;}
            else if("PlayerRow2Zone4Available".Equals(name)){Game.PlayerRow2Zone4Available = true;}
            else if("PlayerRow2Zone5Available".Equals(name)){Game.PlayerRow2Zone5Available = true;}
            else if("PlayerRow2Zone6Available".Equals(name)){Game.PlayerRow2Zone6Available = true;}
            
            else if("PlayerRow3Zone2Available".Equals(name)){Game.PlayerRow3Zone2Available = true;}
            else if("PlayerRow3Zone3Available".Equals(name)){Game.PlayerRow3Zone3Available = true;}
            else if("PlayerRow3Zone4Available".Equals(name)){Game.PlayerRow3Zone4Available = true;}
            else if("PlayerRow3Zone5Available".Equals(name)){Game.PlayerRow3Zone5Available = true;}
            else if("PlayerRow3Zone6Available".Equals(name)){Game.PlayerRow3Zone6Available = true;}
            
            else if("PlayerRow4Zone2Available".Equals(name)){Game.PlayerRow4Zone2Available = true;}
            else if("PlayerRow4Zone3Available".Equals(name)){Game.PlayerRow4Zone3Available = true;}
            else if("PlayerRow4Zone4Available".Equals(name)){Game.PlayerRow4Zone4Available = true;}
            else if("PlayerRow4Zone5Available".Equals(name)){Game.PlayerRow4Zone5Available = true;}
            else if("PlayerRow4Zone6Available".Equals(name)){Game.PlayerRow4Zone6Available = true;}
            
            else if("PlayerRow5Zone2Available".Equals(name)){Game.PlayerRow5Zone2Available = true;}
            else if("PlayerRow5Zone3Available".Equals(name)){Game.PlayerRow5Zone3Available = true;}
            else if("PlayerRow5Zone4Available".Equals(name)){Game.PlayerRow5Zone4Available = true;}
            else if("PlayerRow5Zone5Available".Equals(name)){Game.PlayerRow5Zone5Available = true;}
            else if("PlayerRow5Zone6Available".Equals(name)){Game.PlayerRow5Zone6Available = true;}
        }

         else if (isOverSearchPlayerHandZone && Game.searchForCard)
        {
            Game.SearchCardSelected = this.gameObject; 
            Game.SearchForCardSelected = true;
        }

        else{

            transform.position = startPosition;
        }
    }
    private void MoveCardFromHandToField(){
        string card = this.gameObject.name.Replace("(Clone)","");
            //Removes Model from Hand List
            for(var i = 0; i<CardsInGame.playerHand.Count; i++)
            {
                    //string card1 = CardsInGame.playerHand[i].name.Replace(" (UnityEngine.GameObject)", "");
                    if(CardsInGame.playerHand[i].name.Contains(card))
                    {
                            CardsInGame.playerField.Add(CardsInGame.playerHand[i]);
                            CardsInGame.playerHand.Remove(CardsInGame.playerHand[i]);
                                if( i>0){
                                i = i - 1;
                        }
                    }
            }
    }
}
