using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationControls : MonoBehaviour
{
    public Button LeftButton;
    public Button RightButton;

    public GameObject[] Locations;
    public int StartingLocation = 1;

    private int LocationIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        ChangeLocation(StartingLocation);
    }

    public void NavigateToLeft()
    {
        ChangeLocation(LocationIndex - 1);
    }

    public void NavigateToRight() {
        ChangeLocation(LocationIndex + 1);
    }

    public void ChangeLocation(int index) {
        foreach (var location in Locations)
        {
            location.SetActive(false);
        }
        Locations[index].SetActive(true);
        LocationIndex = index;
        
        RightButton.gameObject.SetActive(true);
        LeftButton.gameObject.SetActive(true);

        if (LocationIndex >= Locations.Length - 1)
        {
            RightButton.gameObject.SetActive(false);
        }
        

        if (LocationIndex <= 0)
        {
            LeftButton.gameObject.SetActive(false);
        }
    }
}
