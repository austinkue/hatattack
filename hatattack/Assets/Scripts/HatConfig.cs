using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HatConfig", menuName = "Game Content/HatConfig")]
public class HatConfig : ScriptableObject
{
    [SerializeField] private Sprite hatSprite;
    [SerializeField] private float hatSpeed;
    [SerializeField] private int hatValue;
    [SerializeField] private string name;

    public float HatSpeed { get => hatSpeed; set => hatSpeed = value; }
    public int HatValue { get => hatValue; set => hatValue = value; }
    public string Name { get => name; set => name = value; }
}