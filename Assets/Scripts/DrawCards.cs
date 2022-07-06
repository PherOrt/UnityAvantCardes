using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCards : MonoBehaviour
{
    public GameObject PlayerArea;
    public GameObject EnemyArea;
    private bool ModelsChosen = false;
    private int numOfModelsInDeck = 7;
    public bool isShuffled = false;
    public int CardsInHand = 0;

#region void Start()
    void Start(){}
#endregion

    public void OnClick(){
        
        //Game.ShowCardsInPlayerDeck();
        //Game.ShowCardsInOpponentDeck();

        //Models add to hand to choose opening 3 models
        if(Game.gameSetup.Equals(true)){
        for(var l = 0; l < numOfModelsInDeck; l++){
            for(var k = 0; k < CardsInGame.RandomizedPlayerDeck.Count; k++){           
                if(CardsInGame.RandomizedPlayerDeck[k].name == "TestModel" + (l + 1))
                {
                    int FirstModel = CardsInGame.RandomizedPlayerDeck.IndexOf(CardsInGame.RandomizedPlayerDeck[k]);
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[k]);
                    GameObject TestDeckCard = Instantiate(CardsInGame.RandomizedPlayerDeck[k], new Vector3(0, 0, 0), Quaternion.identity);
                    TestDeckCard.transform.SetParent(PlayerArea.transform, false);
                    }
                }
            }
            Game.gameSetup = false;
            //Debug.Log("Models in hand " + CardsInGame.playerHand[0]);
            Debug.Log("Number of cards in hand:" + CardsInGame.playerHand.Count);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = "Draw Opening Hand";
            GameObject.Find("Button").GetComponentInChildren<Text>().color = Color.red;

            GameObject.Find("PlayerRow4Zone1").GetComponentInChildren<Image>().color = Color.red;
            GameObject.Find("PlayerRow5Zone1").GetComponentInChildren<Image>().color = Color.red;
        }
        
        //Game.ShowCardsInDeck();

        if(Game.NumOfStartingModels.Equals(3)){
            Debug.Log("Models Have Been Chosen!");
            //Game.ShowCardsInDeck();
            
            int cards = CardsInGame.playerHand.Count;
            
            for(var i = 0; i < cards; i++){
                for(var j = 0; j < CardsInGame.playerHand.Count; j++){
                    GameObject card = GameObject.Find(CardsInGame.playerHand[j].name + "(Clone)");
                    CardsInGame.playerHand.Remove(CardsInGame.playerHand[j]);
                    Destroy(card);
                }
            }
            Game.StartingModelsPicked = true;
            ModelsChosen = true;
            Game.NumOfStartingModels = 0;
            GameObject.Find("PlayerRow4Zone1").GetComponentInChildren<Image>().color = Color.white;
            GameObject.Find("PlayerRow5Zone1").GetComponentInChildren<Image>().color = Color.white;
        }

        //Debug.Log("Models in Hand: " + CardsInGame.playerHand.Count);
        //Game.ShowCardsInDeck();

        if(Game.StartingModelsPicked.Equals(true)){
            if(ModelsChosen.Equals(true)){ //Added to try and figure out how to pick models in the beginning.

                for (var i = 0; i < 7; i++){

                //Drawing Players Hand
                GameObject TestDeckCard = Instantiate(CardsInGame.RandomizedPlayerDeck[i], new Vector3(0, 0, 0), Quaternion.identity);
                TestDeckCard.transform.SetParent(PlayerArea.transform, false);
                
                //Drawing Opponents Hand
                GameObject enemyCard = Instantiate(CardsInGame.RandomOpponentDeck[i], new Vector3(0,0,0), Quaternion.identity);
                enemyCard.transform.SetParent(EnemyArea.transform, false);
                
                    }
                    
                    Game.GameStart = true;
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[0]);
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[1]);
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[2]);
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[3]);
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[4]);
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[5]);
                    CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[6]);

                    CardsInGame.RandomizedPlayerDeck.RemoveRange( 0, 7);
                    //Debug.Log(CardsInGame.RandomizedPlayerDeck.Count);
                    ModelsChosen = false;
                    GameObject.Find("Button").GetComponentInChildren<Text>().text = "Draw Card";
            }
        //After Game Has Started Draws One Card
            else
            {
                
                GameObject TestDeckCard = Instantiate(CardsInGame.RandomizedPlayerDeck[0], new Vector3(0, 0, 0), Quaternion.identity);
                TestDeckCard.transform.SetParent(PlayerArea.transform, false);
                CardsInGame.playerHand.Add(CardsInGame.RandomizedPlayerDeck[0]);
                CardsInGame.RandomizedPlayerDeck.Remove(CardsInGame.RandomizedPlayerDeck[0]);
            }

        } 
    }
    
}
