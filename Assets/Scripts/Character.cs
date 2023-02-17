using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName ="Character", menuName ="person")]
public class Character : ScriptableObject
{
    public string Player;
    public string Country;
    public string Hometown;
    public string Strength;
    public float Speed;
    public GameObject selected;
    public string GetSpeed()
    {
        return Speed + "KM/H";
    }
    
}
