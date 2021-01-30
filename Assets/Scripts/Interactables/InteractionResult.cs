using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionResult : MonoBehaviour
{
    public Sprite Success;
    public Sprite Fail;

    public SpriteRenderer Sprite;

    public float DestroyDelay = 3;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DestroyDelay);
    }

    public void SetResult(bool success) {
        if (success)
        {
            Sprite.sprite = Success;
        }
        else {
            Sprite.sprite = Fail;
        }
    }

}
