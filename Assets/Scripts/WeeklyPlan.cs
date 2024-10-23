using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyPlan : MonoBehaviour
{

    //if else version of the weekly plan.
    void WeeklyPlanner()
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        foreach (string day in daysOfWeek)
        {
            IfElsePrint(day);
        }
    }

    void IfElsePrint(string day)
    {
        if (day == "Monday")
        {
            Console.WriteLine("Monday: p1 meeting with Dan");
        }
        else if (day == "Tuesday")
        {
            Console.WriteLine("Tuesday: IKDU lecture");
        }
        else if (day == "Wednesday")
        {
            Console.WriteLine("Wednesday: PBL Lecture");
        }
        else if (day == "Thursday")
        {
            Console.WriteLine("Thursday: IKDU Lecture again");
        }
        else if (day == "Friday")
        {
            Console.WriteLine("Friday: Write p1 analysis chapter");
        }
        else if (day == "Saturday")
        {
            Console.WriteLine("Saturday: Write more p1 analysis");
        }
        else if (day == "Sunday")
        {
            Console.WriteLine("Sunday: Relax");
        }
        else
        {
            Console.WriteLine("Not a day");
        }
    }
}