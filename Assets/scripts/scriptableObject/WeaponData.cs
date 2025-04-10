using UnityEngine;

[CreateAssetMenu(menuName = "WeaponData")]
public class WeaponData : ScriptableObject
{
    public string weaponCode;
    public Sprite weaponIcon;
    public string weaponType;
    public string weaponName;
    public string weaponValue;
    public string weaponIngredient;
}
