using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameChess : MonoBehaviour 
{
    /*public static GameChess Instance { get; private set; }

    public GameObject fileSprite;
    public Sprite FileSprite;
    public Sprite Chessboard;


    //instancio la capa más abajo.
    public void Start()
    {
        SpriteRenderer chess = fileSprite.GetComponent<SpriteRenderer>();
        chess.sortingOrder = -1;

        GameObject FileGameObject = new GameObject("Ficha");
        SpriteRenderer fileSpriteRenderer = FileGameObject.AddComponent<SpriteRenderer>();
        fileSpriteRenderer.sprite = FileSprite;

        fileSpriteRenderer.sortingOrder = 10;
    }



    /*void SpawnFile(Sprite fileSprite)
    {
        GameObject newObject = Instantiate(fileSprite);
    }
   
    /*private void Awake()
    {

        Instance = this;
    }*/
}
