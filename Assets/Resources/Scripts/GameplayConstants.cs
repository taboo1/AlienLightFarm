﻿using UnityEngine;
using System.Collections;

public class GameplayConstants {

    public const float AlienFullLiveTime = 10f;
    public const float AlienMaxWaitTime = 3f;
    public const float AlienMinWaitTime = 1f;
    public const float AlienNormalSpeed = 40f;
    public const float AlienHungrySpeed = 70f;

    public static int[] AlienClampDistance = { 5, 10, 20, 34 };
    public const int AlienMinDistance = 2;

    public const float AlienHungryCoef = 0.5f;
    public const float AlienVeryHungryCoef = 0.2f;

    public const int AlienStartBorningCount = 3;


    // Скорость появления алиенов
    public const float AlienBornTime = 0.3f;
    public const float AlienBorningDelay = 4f;



    public static float[] FountainButtonReloadTime = {3.2f,3.6f,4f,4.4f};
    public const float SafeCupolButtonReloadTime = 3f;
    public static float HealingButtonReloadTime = 10f;
    //public static float PusherButtonReloadTime = 5f;
    public static float BlackHoleButtonReloadTime = 5f;



    //    public const float WallButtonReloadTime = 1f;



    public const float FountainMaxLife = 80f;
    public const float FountainMinLife = 10f;

    public const float FountainGrowCoef = 1.2f;
    public const float FountainRecoveryCoef = 1.9f;

    public const float WallLifeTime = 7f;
    public const float SafeCupolLifeTime = 5f;

    public const float BlackHoleClosedSpeed = 1f;

    public const float AlienCoefRateFountain = 6f;
    // public const float FountainCoefRestitution = 8f;

    public const int MaxAgro = 100;
    //  public static float[] AgroCoef = {60,40,25,20,15};
    public static float AgroCoef = 100f;
  //  public static int[] AgroCoefAlienCountTreshold = { 0, 10, 15, 20, 25 };
    public const float RecoveryAgroCoef = 7.5f;



    /*
    public const int FountainTreshold = 0;
    public const int WallTreshold = 1000000;
    public const int SafeCupolTreshold = 10;
    public const int BlackHoleTreshold = 1000000;
    public const int PusherTreshold = 20;
    public const int HealingTreshold = 30;
    */
    public static int[] AliensTresholds = /*{ 0, 0, 0, 0 };*/ { 0, 5, 12, 18 };

    public const int PusherRange = 3;
    public const float PusherExpansionSpeed = 5f;

    public const float ExpulsionAlienSpeed = 7f;

    public const float LentaReloadTime = 2f;

    public const int AdMoneyReward = 20;
    public const int EnterVkGroupReward = 100;
    public const int PostVkReward = 50;

    public const int PurchasePrice = 200;

    public static int[] OrderOpeningReward = {0, 1 };

    public const int MoneyDevider = 2;

    public const string marketURL = "https://play.google.com/store/apps/details?id=com.sveta.alienescape";
}
