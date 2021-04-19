using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emissionRate : MonoBehaviour
{
    private ParticleSystem ps;
    public float hSliderValue = 0f;
    public float StarLifeValue = 0f;

    public GameObject Player;
    CharacterData PlayerData;
   
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        
    }

    void Update()
    {
        GameObject PlayerGameObject = Player;
        PlayerData = PlayerGameObject.GetComponent<CharacterData>();
        var emission = ps.emission;
        emission.rateOverTime = hSliderValue;
        ps.startLifetime = StarLifeValue;


        if ((PlayerData.CurrentHealth < PlayerData.Health * 1f) && (PlayerData.CurrentHealth > PlayerData.Health * 0.7f))
        {
            StarLifeValue = 0.5f;
            hSliderValue = 50f;
        }
        if ((PlayerData.CurrentHealth < PlayerData.Health * 0.7f) && (PlayerData.CurrentHealth > PlayerData.Health * 0.6f))
        {
            StarLifeValue = 1f;
            hSliderValue = 100f;
        }
        if ((PlayerData.CurrentHealth < PlayerData.Health * 0.6f) && (PlayerData.CurrentHealth > PlayerData.Health * 0.5f))
        {
            StarLifeValue = 2f;
            hSliderValue = 100f;
        }
        if ((PlayerData.CurrentHealth < PlayerData.Health * 0.5f) && (PlayerData.CurrentHealth > PlayerData.Health * 0.4f))
        {
            StarLifeValue = 3f;
            hSliderValue = 100f;
        }
        if ((PlayerData.CurrentHealth < PlayerData.Health * 0.4f) && (PlayerData.CurrentHealth > PlayerData.Health * 0.35f))
        {
            StarLifeValue = 4f;
            hSliderValue = 500f;
        }
        if (PlayerData.CurrentHealth < PlayerData.Health * 0.35f)
        {
            StarLifeValue = 5f;
            hSliderValue = 1000f;
        }
    }

   /* void OnGUI()
    {
        hSliderValue = GUI.HorizontalSlider(new Rect(25, 45, 100, 30), hSliderValue, 5.0f, 200.0f);
    }*/
}
