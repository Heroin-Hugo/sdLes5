using TMPro;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public enum WeaponType
    {
        Banana,
        Apple,
        Kiwi,
        Pineapple,
        Unarmed
    }
    public WeaponType weaponType = WeaponType.Banana;

    [SerializeField] private TextMeshProUGUI currentlyEquipped;

    private void Start() => SwitchWeapon(0);
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SwitchWeapon(1);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SwitchWeapon(2);
        if (Input.GetKeyDown(KeyCode.Alpha3)) SwitchWeapon(3);
        if (Input.GetKeyDown(KeyCode.Alpha4)) SwitchWeapon(4);
        if (Input.GetKeyDown(KeyCode.Alpha0)) SwitchWeapon(0);
    }

    private void SwitchWeapon(int weaponInt)
    {

        switch (weaponInt)
        {
            case 1:
                weaponType = WeaponType.Banana;
                currentlyEquipped.text = "Banana - 25DAM - 1.0SP";
                break;
            case 2:
                weaponType = WeaponType.Apple;
                currentlyEquipped.text = "Apple - 20DAM - 1.5SP";
                break;
            case 3:
                weaponType = WeaponType.Kiwi;
                currentlyEquipped.text = "Kiwi - 35DAM - 0.7SP";
                break;
            case 4:
                weaponType = WeaponType.Pineapple;
                currentlyEquipped.text = "Pineapple - 15DAM - 2.0SP";
                break;
            default:
                weaponType = WeaponType.Unarmed;
                currentlyEquipped.text = "Unarmed - 10DAM - 1SP";
                break;
        }
    }
}
