using TMPro;
using UnityEngine;

public class PackageManager : MonoBehaviour
{
    public string color;
    public string adress;
    public int year;
    [SerializeField] private SpriteRenderer package;
    [SerializeField] private TextMeshProUGUI text; 


    private void Start()
    {
        PackageSelector();
    }
    public void PackageSelector()
    {
        int packageColor = Random.Range(0, 3);
        switch (packageColor)
        {
            case 0: color = "blue";
                year = 1844;
                package.color = Color.blue;
                break;
            case 1: color = "red";
                year = 2099;
                package.color = Color.red;
                break;
            case 2: color = "orange";
                year = 1957;
                package.color = Color.orange;
                break;
            case 3: color = "green";
                year = 1037;
                package.color = Color.green;
                break;
        }

        int packageAdress = Random.Range(0, 3);
        switch(packageAdress)
        {
            case 0: adress = "A3";
                break;
            case 1: adress = "G9";
                break;
            case 2: adress = "H7";
                break;
            case 3: adress = "N5";
                break;
        }

        text.text = "Entregue a encomenda neste local: " + adress;
    }

    
}
