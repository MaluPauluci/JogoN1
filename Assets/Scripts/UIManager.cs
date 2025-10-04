using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject Map;
    [SerializeField] private GameObject Package;
    [SerializeField] private GameObject Note;


    public void ButtonOpen(GameObject panel)
    {

        if(Map.activeSelf == true || Package.activeSelf == true || Note.activeSelf == true)
        {
            Map.SetActive(false);
            Package.SetActive(false);
            Note.SetActive(false);
        }

        panel.SetActive(true);
    }

    public void ButtonClose(GameObject panel)
    {
        panel.SetActive(false);
    }
}
