using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : MonoBehaviour
{


    /*public GameObject fileSprite;*/
    public Sprite FileSprite;
    /*public Sprite Chessboard;*/


    public GameObject Ficha;
    private int LimitAX = -2;
    private int LimitAY = -7;







    /*public void Start()
    {
        

        GameObject FileGameObject = new GameObject("Ficha");
        SpriteRenderer fileSpriteRenderer = FileGameObject.AddComponent<SpriteRenderer>();
        fileSpriteRenderer.sprite = FileSprite;

        fileSpriteRenderer.sortingOrder = 10;

        
        
    }*/



    private float spaceBetweenSquares = 0.5f;
    private float timer;
    private float spawnRate = 1f;

    
    private List<Vector3> positionOcupied = new List<Vector3>();


    int RandomSquareIndex()
    {
        return Random.Range(0, 8); //hay 64 cuadraditos
    }
    Vector2 SpawnPosition()
    {

        float PosX = LimitAX + (RandomSquareIndex() * spaceBetweenSquares);
        float PosY = LimitAY + (-RandomSquareIndex() * spaceBetweenSquares);


        Vector3 spawnPosition = new Vector2(PosX, PosY);
        return spawnPosition;

    }

    private void Intantiating()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            timer -= spawnRate;

            Vector3 spawnPos = SpawnPosition();


            if (!positionOcupied.Contains(spawnPos))
            {
                Instantiate(Ficha, SpawnPosition(), Quaternion.identity);
                positionOcupied.Add(spawnPos);
            }

        }
    }

    private void Start()
    {

        GameObject FileGameObject = new GameObject("Ficha");
        SpriteRenderer fileSpriteRenderer = FileGameObject.AddComponent<SpriteRenderer>();
        fileSpriteRenderer.sprite = FileSprite;

        fileSpriteRenderer.sortingOrder = 10;

        positionOcupied = new List<Vector3>();



    }

    private void Update()
    {
        Intantiating();
    }

    //Maria esto está más guarro que la pezuña de un chancho, mil perdones.
}
