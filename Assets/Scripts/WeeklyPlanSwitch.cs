using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyPlanSwitch : MonoBehaviour
{
    void WeeklyPlan()
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        foreach (string day in daysOfWeek)
        {
            SwitchPrint(day);
        }
    }

    void SwitchPrint(string day)
    {
        switch (day)
        {
            case "Monday":
                Console.WriteLine("Monday: p1 meeting with Dan");
                break;
            case "Tuesday":
                Console.WriteLine("Tuesday: IKDU lecture");
                break;
            case "Wednesday":
                Console.WriteLine("Wednesday: PBL Lecture");
                break;
            case "Thursday":
                Console.WriteLine("Thursday: IKDU Lecture again");
                break;
            case "Friday":
                Console.WriteLine("Friday: Write p1 analysis chapter");
                break;
            case "Saturday":
                Console.WriteLine("Saturday: Write more p1 analysis");
                break;
            case "Sunday":
                Console.WriteLine("Sunday: Relax");
                break;
            default:
                Console.WriteLine("Not a day");
                break;
        }
    }
}