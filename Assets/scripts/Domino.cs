//directive declaration
using UnityEngine;

//class declaration, inherits MonoBehaviour
public class Domino : MonoBehaviour 
{

    #region Fields
    //domino sprites for surfaces are declared
    [SerializeField]
    Sprite faceUpSprite;
    [SerializeField]
    Sprite faceDownSprite;

    //other domino state
    //value of left side
    [SerializeField]
    int numLeft;
    //value of right side
    [SerializeField]
    int numRight;
    //stat of card
    [SerializeField]
    bool faceUp;

    //sprite management
    SpriteRenderer spriteRenderer;

    #endregion

    #region Properties
    //property declarations
    //allows external class to access num_left
    public int NumLeft
    {
        get { return numLeft; }
    }
    //allows external class to access num_right
    public int NumRight
    {
        get { return numRight; }
    }
    //allows external class to access faceUp
    public bool FaceUp
    {
        get { return faceUp; }
    }

    #endregion


    #region Methods

    //gateway method for game object this script is attached to
    void Start () {

        spriteRenderer = GetComponent<SpriteRenderer>();

        SetSprite();

        //Interesting  idea that is not allowed in Monobehavior
        //Use controller game object instead
        //DominoHandTally dht = new DominoHandTally();


        print("Hi from Domino Start()");
	}

    //flips changes the state of game object this script is attached to
    public void FlipOver()
    {
        //changes value of boolean
        faceUp = !faceUp;

        //invokes/calls method to change sprite
        SetSprite();
    }
    //changes sprite rendered onto game object given condition of bool faceUp
    void SetSprite()
    {

        if(faceUp)
        {
            spriteRenderer.sprite = faceUpSprite;
        }
        else
        {
            spriteRenderer.sprite = faceDownSprite;
        }
    }

    #endregion


}
