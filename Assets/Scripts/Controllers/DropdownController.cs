using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    public GameObject[] panels;
    public Dropdown dropdownInFrontOf;

    public string[] videos;

    private Dropdown m_Dropdown;
    //private GameObject[] panels = new ArrayList<GameObject>();

    void Start()
    {
        //Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        //Add listener for when the value of the Dropdown changes, to take action
        m_Dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(m_Dropdown);
        });
    }

    //Ouput the new value of the Dropdown into Text
    void DropdownValueChanged(Dropdown change)
    {
        for(var i = 0; i < panels.Length; i++)
        {
            if (!panels[i]) break;
            
            if(i == change.value)
            {
                panels[i].gameObject.SetActive(true);
            } 
            else
            {
                panels[i].gameObject.SetActive(false);
            }
        }

        if (videos[change.value] != null)
        {
            SpaceShip.videoToLoad = videos[change.value];
        } 
        else
        {
            SpaceShip.videoToLoad = "";
        }
        
        dropdownInFrontOf.value = change.value;
    }
}
