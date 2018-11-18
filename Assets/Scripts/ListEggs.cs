using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListEggs
{

    public Sprite[] eggs;
    private Sprite tempEgg;
    int eggsCount;
    public ListEggs()
    {


        eggsCount = eggs.Length;
        tempEgg = new Sprite();
    }

    public Sprite Next()
    {
        if (eggsCount > eggs.Length - 1)
        {
            return eggs[eggsCount];
        }
        else
        {
            eggsCount++;
            return eggs[eggsCount];
        }
    }
    public Sprite Previous()
    {
        if (eggsCount == 0)
        {
            return eggs[eggsCount];
        }
        else if (eggsCount < 0)
        {
            return eggs[0];
        }
        else
        {
            eggsCount--;
            return eggs[eggsCount];
        }
    }
}

