using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSelection : MonoBehaviour
{

    public Character[] Characters;
    public Transform spot;
    public TextMeshProUGUI title;
    public TextMeshProUGUI country;
    public TextMeshProUGUI home;
    public TextMeshProUGUI strength;
    public TextMeshProUGUI speed;

    private List<GameObject> persons;
    private int currentPerson; 

    private void awake()
    {
        title = title.GetComponent<TextMeshProUGUI>();
        country = country.GetComponent<TextMeshProUGUI>();
        home = home.GetComponent<TextMeshProUGUI>();
        strength = strength.GetComponent<TextMeshProUGUI>();
        speed = speed.GetComponent<TextMeshProUGUI>();
    }

   void Start()
    {
        persons = new List<GameObject>();

        foreach ( var Character in Characters)
        {
            GameObject choice = Instantiate(Character.selected, spot.position, Quaternion.identity);
            choice.SetActive(false);
            choice.transform.SetParent(spot);
            persons.Add(choice);
            
        }
    }

    void ShowPersonFromList()
    {
        persons[currentPerson].SetActive(true);
        title.text ="Name: "+ Characters[currentPerson].Player;
        country.text = "COUNTRY: "+Characters[currentPerson].Country;
        home.text = "HOMETOWN: "+ Characters[currentPerson].Hometown;
        speed.text = "SPEED: "+ Characters[currentPerson].GetSpeed();
        strength.text ="STREGNTH: "+ Characters[currentPerson].Strength;
    }

    public void OnClickNext()
    {
        persons[currentPerson].SetActive(false);
        if (currentPerson < persons.Count - 1)
            ++currentPerson;
        else 
            currentPerson = 0;
        ShowPersonFromList();
    }

    public void OnClickPrev()
    {
        persons[currentPerson].SetActive(false);
        if (currentPerson == 0)
            currentPerson=persons.Count-1;
        else
            --currentPerson;
        ShowPersonFromList();
    }
   
}
