using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Age : MonoBehaviour
{
  public  int age = 20;
  public int ageIncrease = 10;
    void Start()
    {
        age = UpdateAge(age, ageIncrease);
        Debug.Log("I am" + age + "years old");
        age = UpdateAge(age);
        Debug.Log("I am" + age + "years old");
    }

    int UpdateAge(int age)
    {
        int newAge = age + 1;
        return (newAge);
    }

    int UpdateAge(int age, int years)
    {
        int newAge = age + years;
        return (newAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
