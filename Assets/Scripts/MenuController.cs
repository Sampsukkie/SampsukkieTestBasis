using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;




public class MenuController : MonoBehaviour
{
    public GameObject RulesScreen;

    //Kuvan koon pitää olla asetettuna 0.2, 0.2, 1.
    public Image RulesImage;

    public Button SettingsBtn;

    private void Start()
    {
        RulesScreen.SetActive(false);
    }

    public void PlayIsPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SettingsIsPressed()
    {
        


        if (RulesScreen.activeSelf)
        { //menee pois päältä
            Invoke("StartPositionAnimation", 0.1f);
            Invoke("ToggleScreen", 0.2f); //menee oikeasti pois päältä


        }
        else { //ei näy mitään screenillä
            //käsky: menee päälle
            Invoke("ToggleScreen", 0.01f); //menee oikeasti päälle
            RulesImage.transform.DOScale(new Vector3(7.5f, 0.2f, 1), 0.1f);

            Invoke("SettingAnimation", 0.1f);
            
        }


        SettingsBtn.enabled = false;
        Invoke("PressingSettingsTrue", 0.5f);



        //Invoke("SettingAnimation", 0.21f);
    }

    public void QuitIsPressed()
    {
        Application.Quit();
    }

    void SettingAnimation()
    {
        RulesImage.transform.DOScale(new Vector3(7.5f, 7.5f, 1), 0.2f);
    }


    void StartPositionAnimation()
    {
        RulesImage.transform.DOScale(new Vector3(.2f, .2f, 1), 0.1f);
    }

    void ToggleScreen()
    {
        RulesScreen.SetActive(!RulesScreen.activeSelf);
    }




    void PressingSettingsTrue()
    {
        SettingsBtn.enabled = true;

    }
}
