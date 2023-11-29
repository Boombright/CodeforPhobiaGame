using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveSystem : MonoBehaviour
{
    // Start is called before the first frame update
    
    public PlayerUI player;
    public playerMoney money;

    public void SaveData()
    {
        PlayerPrefs.SetFloat("UpdatedHealth", GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerUI>().UpdatedHealth);
        PlayerPrefs.SetFloat("UpdatedStat", GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerUI>().UpdatedStat);
        PlayerPrefs.SetInt("money", GameObject.FindGameObjectWithTag("Money").GetComponent<playerMoney>().money);
        PlayerPrefs.Save();
        Debug.Log("Data saved!");
        Debug.Log("Current health: " + GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerUI>().UpdatedHealth);
        Debug.Log("Current stat: " + GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerUI>().UpdatedStat);
        Debug.Log("Current money: " + GameObject.FindGameObjectWithTag("Money").GetComponent<playerMoney>().money);
        
    }

    public void LoadData()
    {
        player.UpdatedHealth = PlayerPrefs.GetFloat("UpdatedHealth", GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerUI>().UpdatedHealth);
        player.UpdatedStat = PlayerPrefs.GetFloat("UpdatedStat", GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerUI>().UpdatedStat);
        money.money = PlayerPrefs.GetInt("money", GameObject.FindGameObjectWithTag("Money").GetComponent<playerMoney>().money);
        //UpHealth = PlayerPrefs.GetFloat("UpdatedHealth", GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerUI>().UpdatedHealth);
        //PlayerPrefs.GetFloat("UpdatedStat", GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerUI>().UpdatedStat);
        Debug.Log("Data Load!");
    }

    public void DeleteData()
    {
        //PlayerPrefs.GetInt
    }
}
