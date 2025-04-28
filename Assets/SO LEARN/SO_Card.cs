using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu (menuName = "Profile/Card")]
public class SO_Card : ScriptableObject
{
    [Header("Card Info")]
    public string Name;
    public string Description;
    public Type ElementalType;

    [Space, ShowAssetPreview]
    public Sprite CharacterImage;

    [Header("Card Stats")]

    public int Cost;
    public int Health;
    public int ATK;


}

public enum Type
{
    Fire,
    Water,
    Earth,
    Lightning,
    Ice,
    Wind
}