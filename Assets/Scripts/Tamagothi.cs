using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tamagothi : MonoBehaviour
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }

    public int HP { get; set; }

    public int Energy { get; set; }

   protected abstract void SetHp();
    protected abstract void SetEnergy();

}
