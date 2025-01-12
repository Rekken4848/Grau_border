using UnityEngine;
using TMPro;

public class CountryList : MonoBehaviour
{
    public GameObject countryPrefab; // Prefab para un elemento de la lista (un texto).
    public Transform listContainer; // Contenedor de la lista.
    string[] allowedCountries;

    void Start()
    {
        allowedCountries = new string[] { "España", "Francia", "Italia", "Alemania" };

        foreach (string country in allowedCountries)
        {
            GameObject newCountry = Instantiate(countryPrefab, listContainer);
            newCountry.GetComponent<TextMeshProUGUI>().text = country;
        }
    }

    public string[] AllowedCountries
    {
        get { return allowedCountries; }
    }
}