using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Sprite[] Items;
    public Image ItemPrefab;
    public RectTransform Container;

    // Start is called before the first frame update
    void Start()
    {
        foreach (RectTransform item in Container)
        {
            Destroy(item.gameObject);
        }

        foreach (Sprite item in Items)
        {
            var newItem = Instantiate(ItemPrefab, Container);
            newItem.sprite = item;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
