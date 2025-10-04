using NUnit.Framework.Internal;
using UnityEngine;

public class YearChange : MonoBehaviour
{
    public int yearChange;
    

    void Update()
    {
        
    }

    public int GetYear()
    {
        return yearChange;
    }

    public void SetYear(int year)
    {
       yearChange = year;
    }

}
