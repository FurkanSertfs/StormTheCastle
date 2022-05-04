using UnityEngine.Events;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

public class intersial : MonoBehaviour
{
    private InterstitialAd interstitialAd;
    public Text reklamtext;
    public string adUnitId = "" ;

     void Start()
    {
        this.RequestAndLoadInterstitialAd();
        MobileAds.Initialize(interstitialAd => { });
        //
    
    }
    
    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        reklamtext.text=("reklam yüklendi");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        reklamtext.text = ("HandleRewardedAdFailedToLoad event received with message: ");

    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        reklamtext.text = ("reklam açık");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        reklamtext.text = ("reklam gösterilirken bir hata oluştu.");
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        reklamtext.text = ("reklamı kapattın neden ? ");
        //   reklams.interactable = false;
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;


    }




    public void RequestAndLoadInterstitialAd()
    {

        if (this.interstitialAd != null)
        {
            this.interstitialAd.Destroy();
        }

        this.interstitialAd = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitialAd.LoadAd(request);
        // Reklam çağırma işlemi başarılı ise
        this.interstitialAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Reklam çağırma işlemi başarısız ise
        this.interstitialAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // reklam gösterilmeye başlandığında
        this.interstitialAd.OnAdOpening += HandleRewardedAdOpening;
        // reklam gösterilmesinde hata olduysa
        this.interstitialAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
     // Reklam erkenden kapatılırsa
        this.interstitialAd.OnAdClosed += HandleRewardedAdClosed;

    }

    public void ShowInterstitialAd()
    {
        if (this.interstitialAd.IsLoaded())
        {
            this.interstitialAd.Show();
        }




        StartCoroutine(bekleme());
    }

    public void DestroyInterstitialAd()
    {
        if (this.interstitialAd != null)
        {
            this.interstitialAd.Destroy();
        }
    }

    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(0.5f);
        RequestAndLoadInterstitialAd();
    }
}
