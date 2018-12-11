using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Artwork", menuName = "Pieces")]
public class ArtInfo : ScriptableObject
{
    public string title;
    public string painter;
    public string date;
    public string description;
}
