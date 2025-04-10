using UnityEngine;

[CreateAssetMenu(menuName = "WeaponData")]
public class WeaponData : ScriptableObject
{
    public string weaponCode;
    public Sprite weaponIcon;
    public string weaponName;
    public string weaponType;
    public string weaponIngredient;
}
