using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public StatToChange statToChange = new StatToChange();
    public int amountToChangeStat;
    public AttributesToChange attributesToChange = new AttributesToChange();
    public int amountToChangeAttribute;


    //ใช้ไอเทมแล้วจะได้อะไร
    public void UseItem()
    {
        if(statToChange == StatToChange.health)
        {

        }
    }

    public enum StatToChange
    {
        none,
        health,
        stat
    }

    public enum AttributesToChange
    {
        none
    }

}
