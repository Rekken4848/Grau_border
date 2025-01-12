
using TMPro; // Necesario para usar TextMeshPro
using UnityEngine;

public class EntryPermitManager : MonoBehaviour
{
    // Referencias a los campos de texto en el permiso
    public TextMeshProUGUI nameField;
    public TextMeshProUGUI passportField;
    public TextMeshProUGUI purposeField;
    public TextMeshProUGUI durationField;
    public TextMeshProUGUI enterByField;

    // Método para actualizar dinámicamente los datos del permiso
    public void UpdatePermit(string name, string passport, string purpose, string duration, string enterBy)
    {
        nameField.text = name;
        passportField.text = passport;
        purposeField.text = purpose;
        durationField.text = duration;
        enterByField.text = enterBy;
    }
}