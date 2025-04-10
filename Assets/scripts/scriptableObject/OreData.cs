using UnityEngine;

[CreateAssetMenu(menuName = "OreData")]
public class OreData : ScriptableObject
{
    public string oreCode;
    public Sprite oreIcon;
    public string oreName;
    [TextArea] public string oreDescription;
}
