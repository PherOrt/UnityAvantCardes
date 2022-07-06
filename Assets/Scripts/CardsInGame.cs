using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsInGame : MonoBehaviour
{
    public GameObject TestAccessory1;
    public GameObject TestAccessory11;
    public GameObject TestAccessory2;
    public GameObject TestAccessory22;
    public GameObject TestAccessory3;
    public GameObject TestAccessory33;
    public GameObject TestAccessory4;
    public GameObject TestAccessory44;
    public GameObject TestAccessory5;
    public GameObject TestAccessory55;

    //--------------------------------
    public GameObject TestBottom1;
    public GameObject TestBottom2;
    public GameObject TestBottom3;
    public GameObject TestBottom4;
    public GameObject TestBottom5;
    //--------------------------------
    public GameObject TestTop1;
    public GameObject TestTop2;
    public GameObject TestTop3;
    public GameObject TestTop4;
    public GameObject TestTop5;
    //--------------------------------
    public GameObject TestShoes1;
    public GameObject TestShoes2;
    public GameObject TestShoes3;
    public GameObject TestShoes4;
    public GameObject TestShoes5;
    //--------------------------------
    public GameObject TestModel1;
    public GameObject TestModel2;   
    public GameObject TestModel3;
    public GameObject TestModel4;
    public GameObject TestModel5;
    public GameObject TestModel6;
    public GameObject TestModel7;
    public GameObject DrawThreeCards;
    public GameObject DestroyClothing;
    public GameObject SearchForClothing;

    List <GameObject> opponentDeck = new List<GameObject>();
    public static List <GameObject> opponentDiscards = new List<GameObject>();
    
    List <GameObject> PlayerDeck = new List<GameObject>();
    public static List <GameObject> playerDiscards = new List<GameObject>();
    public static List <GameObject> RandomizedPlayerDeck = new List<GameObject>();
    public static List <GameObject> RandomOpponentDeck = new List<GameObject>();
    public static List <GameObject> playerHand = new List<GameObject>();
    public static List <GameObject> playerField = new List<GameObject>();
    public static List <GameObject> DeckSearchCards = new List<GameObject>();

    List<T> GetRandomDeck<T>(List<T> inputList, int count)
        {
        List<T> outputList = new List<T>();
            for(int i = 0; i < count; i++)
            {
                int index = Random.Range(0, inputList.Count);
                outputList.Add(inputList[index]);
                inputList.Remove(inputList[index]);
            }
            return outputList;
        }
    // Start is called before the first frame update
    void Start()
    {
        //----------------------------------------
        PlayerDeck.Add(TestAccessory1);
        PlayerDeck.Add(TestAccessory2);
        PlayerDeck.Add(TestAccessory3);
        PlayerDeck.Add(TestAccessory4);
        PlayerDeck.Add(TestAccessory5);
        PlayerDeck.Add(TestAccessory11);
        PlayerDeck.Add(TestAccessory22);
        PlayerDeck.Add(TestAccessory33);
        PlayerDeck.Add(TestAccessory44);
        PlayerDeck.Add(TestAccessory55);

        PlayerDeck.Add(TestBottom1);
        PlayerDeck.Add(TestBottom2);
        PlayerDeck.Add(TestBottom3);
        PlayerDeck.Add(TestBottom4);
        PlayerDeck.Add(TestBottom5);
        PlayerDeck.Add(TestTop1);
        PlayerDeck.Add(TestTop2);
        PlayerDeck.Add(TestTop3);
        PlayerDeck.Add(TestTop4);
        PlayerDeck.Add(TestTop5);

        PlayerDeck.Add(TestShoes1);
        PlayerDeck.Add(TestShoes2);
        PlayerDeck.Add(TestShoes3);
        PlayerDeck.Add(TestShoes4);
        PlayerDeck.Add(TestShoes5);
        PlayerDeck.Add(TestModel1);
        PlayerDeck.Add(TestModel2);
        PlayerDeck.Add(TestModel3);
        PlayerDeck.Add(TestModel4);
        PlayerDeck.Add(TestModel5);

        PlayerDeck.Add(TestModel6);
        PlayerDeck.Add(TestModel7);
        PlayerDeck.Add(DrawThreeCards);
        PlayerDeck.Add(DrawThreeCards);
        PlayerDeck.Add(DrawThreeCards);
        PlayerDeck.Add(DrawThreeCards);
        PlayerDeck.Add(DestroyClothing);
        PlayerDeck.Add(DestroyClothing);
        PlayerDeck.Add(DestroyClothing);
        PlayerDeck.Add(SearchForClothing);

        PlayerDeck.Add(SearchForClothing);
        PlayerDeck.Add(SearchForClothing);
//----------------------------------------

        opponentDeck.Add(TestAccessory1);
        opponentDeck.Add(TestAccessory2);
        opponentDeck.Add(TestAccessory3);
        opponentDeck.Add(TestAccessory4);
        opponentDeck.Add(TestAccessory5);
        opponentDeck.Add(TestAccessory11);
        opponentDeck.Add(TestAccessory22);
        opponentDeck.Add(TestAccessory33);
        opponentDeck.Add(TestAccessory44);
        opponentDeck.Add(TestAccessory55);

        opponentDeck.Add(TestBottom1);
        opponentDeck.Add(TestBottom2);
        opponentDeck.Add(TestBottom3);
        opponentDeck.Add(TestBottom4);
        opponentDeck.Add(TestBottom5);
        opponentDeck.Add(TestTop1);
        opponentDeck.Add(TestTop2);
        opponentDeck.Add(TestTop3);
        opponentDeck.Add(TestTop4);
        opponentDeck.Add(TestTop5);

        opponentDeck.Add(TestShoes1);
        opponentDeck.Add(TestShoes2);
        opponentDeck.Add(TestShoes3);
        opponentDeck.Add(TestShoes4);
        opponentDeck.Add(TestShoes5);
        opponentDeck.Add(TestModel1);
        opponentDeck.Add(TestModel2);
        opponentDeck.Add(TestModel3);
        opponentDeck.Add(TestModel4);
        opponentDeck.Add(TestModel5);

        opponentDeck.Add(TestModel6);
        opponentDeck.Add(TestModel7);
        
        RandomizedPlayerDeck = GetRandomDeck(PlayerDeck, PlayerDeck.Count); //Comment out this out and uncomment RandomizedPlayerDeck = PlayerDeck;
        //RandomizedPlayerDeck = PlayerDeck; // Doing so will make deck of cards random.

        RandomOpponentDeck = GetRandomDeck(opponentDeck, opponentDeck.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
