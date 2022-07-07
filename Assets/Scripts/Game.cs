using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{   
    public static int gameHeight = UnityEngine.Screen.height;
    public static int gameWidth = UnityEngine.Screen.width;
    
    //-----------PlayerRow1----------------------
    public static bool PlayerRow1Zone1Available = true;
    public static bool PlayerRow1Zone2Available = true;
    public static bool PlayerRow1Zone3Available = true;
    public static bool PlayerRow1Zone4Available = true;
    public static bool PlayerRow1Zone5Available = true;
    public static bool PlayerRow1Zone6Available = true;

    //-----------PlayerRow2----------------------
    public static bool PlayerRow2Zone1Available = true;
    public static bool PlayerRow2Zone2Available = true;
    public static bool PlayerRow2Zone3Available = true;
    public static bool PlayerRow2Zone4Available = true;
    public static bool PlayerRow2Zone5Available = true;
    public static bool PlayerRow2Zone6Available = true;

    //-----------PlayerRow3----------------------
    public static bool PlayerRow3Zone1Available = true;
    public static bool PlayerRow3Zone2Available = true;
    public static bool PlayerRow3Zone3Available = true;
    public static bool PlayerRow3Zone4Available = true;
    public static bool PlayerRow3Zone5Available = true;
    public static bool PlayerRow3Zone6Available = true;

    //-----------PlayerRow4----------------------
    public static bool PlayerRow4Zone1Available = true;
    public static bool PlayerRow4Zone2Available = true;
    public static bool PlayerRow4Zone3Available = true;
    public static bool PlayerRow4Zone4Available = true;
    public static bool PlayerRow4Zone5Available = true;
    public static bool PlayerRow4Zone6Available = true;

    //-----------PlayerRow5----------------------
    public static bool PlayerRow5Zone1Available = true;
    public static bool PlayerRow5Zone2Available = true;
    public static bool PlayerRow5Zone3Available = true;
    public static bool PlayerRow5Zone4Available = true;
    public static bool PlayerRow5Zone5Available = true;
    public static bool PlayerRow5Zone6Available = true;

    public static bool GameStart = false;

    public static bool StartingModelsPicked = false;
    public static int NumOfStartingModels = 0;
    
    public static bool gameSetup = true;

    public static bool stopZoomWhileDragging = false;

    public static bool cardPlayed = false;
    public GameObject PlayerArea;

    public static int PlayerCardsRemainingInDeck; 
    public static int LastCardInDiscardPile;
    private int LastCard = 0;
    public static bool searchForCard = false;

    public GameObject SearchForACard;
    public static bool SearchForCardSelected = false;
    public static GameObject SearchCardSelected;
    
    public int GetLastCard()
    {
        return LastCard;
    }

    public static void ShowCardsInPlayerDeck(){
        Debug.Log("---------------------------------------------");
        Debug.Log("-----------Cards in Players Deck-------------");
        Debug.Log("---------------------------------------------");
        for (var j = 0; j< CardsInGame.RandomizedPlayerDeck.Count; j++){
            Debug.Log("Card: "+ j + " Card Name: " + CardsInGame.RandomizedPlayerDeck[j]); //UnComment to see deck contents.
            }
        Debug.Log("---------------------------------------------");
    }

    public static void ShowCardsInPlayerDiscardPile(){
        Debug.Log("---------------------------------------------");
        Debug.Log("-----------Cards in Players Discard Pile-------------");
        Debug.Log("---------------------------------------------");
        for (var j = 0; j< CardsInGame.playerDiscards.Count; j++){
            Debug.Log("Card: "+ j + " Card Name: " + CardsInGame.playerDiscards[j]); //UnComment to see deck contents.
            }
        Debug.Log("---------------------------------------------");
    }

    public static void ShowCardsInPlayerHand(){
        Debug.Log("---------------------------------------------");
        Debug.Log("-----------Cards in Players Hand-------------");
        Debug.Log("---------------------------------------------");
        for (var j = 0; j< CardsInGame.playerHand.Count; j++){
            Debug.Log("Card: "+ j + " Card Name: " + CardsInGame.playerHand[j]); //UnComment to see deck contents.
            }
        Debug.Log("---------------------------------------------");
    }

    public static void ShowCardsOnPlayerField(){
        Debug.Log("---------------------------------------------");
        Debug.Log("-----------Cards on Players Field-------------");
        Debug.Log("---------------------------------------------");
        for (var j = 0; j< CardsInGame.playerField.Count; j++){
            Debug.Log("Card: "+ j + " Card Name: " + CardsInGame.playerField[j]); //UnComment to see deck contents.
            }
        Debug.Log("---------------------------------------------");
    }

    public static void ShowCardsInOpponentDeck(){
        Debug.Log("---------------------------------------------");
        Debug.Log("----------Cards in Opponents Deck------------");
        Debug.Log("---------------------------------------------");
        for (var j = 0; j< CardsInGame.RandomOpponentDeck.Count; j++){
            Debug.Log("Card: "+ j + " Card Name: " + CardsInGame.RandomOpponentDeck[j]); //UnComment to see deck contents.
            }
        Debug.Log("---------------------------------------------");
    }

    public static void DrawCards(int num, GameObject hand)
    {
        for(var i = 0; i < num; i++)
                {
                    GameObject TestDeckCard = Instantiate(CardsInGame.RandomizedPlayerDeck[0], new Vector3(0, 0, 0), Quaternion.identity);
                    TestDeckCard.transform.SetParent(hand.transform, false);
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[0]);
                    CardsInGame.RandomizedPlayerDeck.Remove(CardsInGame.RandomizedPlayerDeck[0]);
                }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NumOfStartingModels.Equals(3)){
            GameObject.Find("Button").GetComponentInChildren<Text>().color = Color.black;
        }

        if(cardPlayed == true){
            StartCoroutine(cardDelay());
            cardPlayed = false;
        }
        
        //Shows Number of Cards Left In Deck
        PlayerCardsRemainingInDeck = CardsInGame.RandomizedPlayerDeck.Count;
        GameObject.Find("DeckCount").GetComponent<Text>().text = PlayerCardsRemainingInDeck.ToString();

        //Set the picture of the discard pile as the last card in discard pile
        LastCardInDiscardPile = CardsInGame.playerDiscards.Count;
        if(LastCard < LastCardInDiscardPile )
        {
            LastCard++;
            
            if(LastCardInDiscardPile == 0){
                GameObject.Find("PlayerDiscardZone").GetComponent<Image>().sprite= CardsInGame.playerDiscards[LastCardInDiscardPile].GetComponent<Image>().sprite;

            }
            GameObject.Find("PlayerDiscardZone").GetComponent<Image>().sprite= CardsInGame.playerDiscards[LastCardInDiscardPile-1].GetComponent<Image>().sprite;
            Debug.Log("The Last Card in Discard Pile is: " + CardsInGame.playerDiscards[LastCardInDiscardPile-1]);
            
        }
        if(SearchForCardSelected == true)
        {
            Debug.Log("The name of the Searched card is: " + SearchCardSelected.name);
            string CardNumString = SearchCardSelected.name.Replace("(Clone", "");
            int CardNumInt; 
            int.TryParse(CardNumString, out CardNumInt);
            CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[CardNumInt]);
            
            
            GameObject SearchedCard = Instantiate(CardsInGame.RandomizedPlayerDeck[CardNumInt], new Vector3(0, 0, 0), Quaternion.identity);
            SearchedCard.transform.SetParent(PlayerArea.transform, false);
            CardsInGame.RandomizedPlayerDeck.Remove(CardsInGame.RandomizedPlayerDeck[CardNumInt]);
            Debug.Log("The name of gameObject while it is selected: " + gameObject);
            for (var i = 0; i < CardsInGame.RandomizedPlayerDeck.Count; i++){
                string card1 = SearchCardSelected.name.Replace("(Clone)","");
                string card2 = CardsInGame.RandomizedPlayerDeck[i].name.Replace(" (UnityEngine.GameObject)", "");
                if(card1.Equals(card2))
                {
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[i]);
                    GameObject TestDeckCard = Instantiate(CardsInGame.RandomizedPlayerDeck[i], new Vector3(0, 0, 0), Quaternion.identity);
                    TestDeckCard.transform.SetParent(PlayerArea.transform, false);
                    CardsInGame.RandomizedPlayerDeck.Remove(CardsInGame.RandomizedPlayerDeck[i]);
                    CardsInGame.DeckSearchCards.Remove(CardsInGame.RandomizedPlayerDeck[i]);
                    Debug.Log("Number of cards in DeckSearch List: "+ CardsInGame.DeckSearchCards.Count);
                    Destroy(SearchCardSelected);
                }
            } 
             foreach (Transform child in SearchForACard.transform){
                GameObject.Destroy(child.gameObject);
             }
            // int deck = CardsInGame.DeckSearchCards.Count;
            
            //         for(var k = 0; k < deck; k++){
            //             while(0 < CardsInGame.DeckSearchCards.Count){
            //                 Debug.Log("The name of the card at: " + CardsInGame.DeckSearchCards[0].name);
            //                 //Debug.Log("The first card in players deck is: " + CardsInGame.RandomizedPlayerDeck[0].name);
                        
            //             int index = CardsInGame.RandomizedPlayerDeck.IndexOf(CardsInGame.DeckSearchCards[0]);
            //             GameObject card7 = GameObject.Find();
                        
            //             Debug.Log("The index for the first card in hand is:  " + index);
            //             Debug.Log("Name of the card being destroyed: " + card7);
            //             Debug.Log("Number of cards in DeckSearch List: "+ CardsInGame.DeckSearchCards.Count);
            //             Destroy(card7);
            //             CardsInGame.DeckSearchCards.Remove(CardsInGame.DeckSearchCards[0]);
            //             break;
                         
            //         } 
            //     }
                    
            SearchForCardSelected = false;
            searchForCard =false;
            Debug.Log(CardsInGame.DeckSearchCards.Count);
        }
    }

    public static GameObject zoomCard;
    public static GameObject Card;
    
    IEnumerator cardDelay(){

        Debug.Log("Now Waiting");
        Cursor.lockState = CursorLockMode.Locked;
        yield return new WaitForSeconds(2);
        Debug.Log("No Longer Waiting");
        
        //DrawThreeCards Ability
        if(Card.name == "DrawThreeCards(Clone)"){

            DrawCards(3, PlayerArea);
            
            }

        if(Card.name == "SearchForClothing(Clone)"){

            Debug.Log("Search for clothing was played!");
            searchForCard = true;
            Cursor.lockState = CursorLockMode.None;
            
                for (var i = 0; i < CardsInGame.RandomizedPlayerDeck.Count; i++)
                {
                    if(CardsInGame.RandomizedPlayerDeck[i].tag == "Top"){
                GameObject TestDeckCard = Instantiate(CardsInGame.RandomizedPlayerDeck[i], new Vector3(0, 0, 0), Quaternion.identity);
                TestDeckCard.name = i.ToString();
                TestDeckCard.transform.SetParent(SearchForACard.transform, false);
                CardsInGame.DeckSearchCards.Add(CardsInGame.RandomizedPlayerDeck[i]);
                    }
                }
        }

        Debug.Log("The name of Card in cardDelay is: " + Card);
        Destroy(zoomCard);
        Destroy(Card);
        LastCard++;
        Cursor.lockState = CursorLockMode.None;
    }
}