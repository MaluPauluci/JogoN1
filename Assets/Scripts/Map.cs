using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public Vector2 startPos;

    [SerializeField] private PackageManager packageManager;


    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == UnityEngine.TouchPhase.Began)
            {
                Vector2 position = Camera.main.ScreenToWorldPoint(touch.position);

                Collider2D hit = Physics2D.OverlapPoint(position);

                if (hit != null)
                {
                        int year = FindAnyObjectByType<YearChange>().GetYear();
                        string adress = hit.gameObject.GetComponent<Adress>().adress;

                        CheckHit(year, adress);
                }

            }

        }

    }

    private void CheckHit(int yearChange, string adress)
    {
        if (yearChange == packageManager.year && adress == packageManager.adress)
        {
            Debug.Log("Está correto");
            FindAnyObjectByType<Coins>().coins++;
        }

        else
        {
            if(yearChange == packageManager.year)
            {
                Debug.Log("Ano correto. Local errado, tente novamente!");
            }
            else
            {
                SceneManager.LoadScene("Perdeu");
            }
        }
    }
}
