using UnityEngine;
using UnityEngine.SceneManagement;

public class Coins : MonoBehaviour
{
    public int coins;

    private void Start()
    {
        coins = 0;
    }

    private void Update()
    {
       if (coins >= 4)
        {
            SceneManager.LoadScene("Ganhou");
        }
    }
}
