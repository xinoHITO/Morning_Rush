using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public Sprite[] Sprites;
    private SpriteRenderer Renderer;
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, Sprites.Length);
        Renderer = GetComponent<SpriteRenderer>();
        Renderer.sprite = Sprites[randomIndex];
    }

}
