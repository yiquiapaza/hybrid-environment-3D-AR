using System;
using System.Collections.Generic;
using UnityEngine;

public class Util 
{
    public static int Year(float value)
    {
        return (int)(Constants.MIN_VALUE_YEAR + (value * (Constants.MAX_VALUE_YEAR - Constants.MIN_VALUE_YEAR)) / Constants.MAX_AXES);
    }

    public static float ScalePopulation(float value)
    {
        return Constants.MIN_SIZE_SPHERE + (value  * (Constants.MAX_SIZE_SPHERE - Constants.MIN_SIZE_SPHERE)/ (Constants.MAX_VALUE_POPULATION));
    }

    public static float ScaleGDPPercapita(float value)
    {
        return value / Constants.MAX_VALUE_GPD_PERCAPITA;
    }

    public static float ScaleEnergyConsumption(float value)
    {
        return value / Constants.MAX_VALUE_ENERGY_CONSUMPTION;
    }

    public static float ScaleArableArea(float value)
    {
        return value / Constants.MAX_VALUE_ARABLE_AREA;
    }

    public static float ScaleLifeExpectanceWomen(float value)
    {
        return value / Constants.MAX_VALUE_LIFE_EXPECTANCE_WOMEN;
    }

    public static float ScaleLifeExpectanceMen(float value)
    {
        return value / Constants.MAX_VALUE_LIFE_EXPECTANCE_MEN;
    }

    public static float ScaleLifeExpectance(float value)
    {
        return value / Constants.MAX_VALUE_LIFE_EXPECTANCE;
    }

    public static float ScaleInfantMortality(float value)
    {
        return value / Constants.MAX_VALUE_INFANT_MORTALITY;
    }
    
    public static float ScaleNumberPersonalComputer(float value)
    {
        return value / Constants.MAX_VALUE_NUMBER_PERSONAL_COMPUTER;
    }

    public static float ScaleYear(float value)
    {
        return value / 25;
    }
}
