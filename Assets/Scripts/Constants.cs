using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants 
{

    public const float MAX_VALUE_POPULATION = 1225679701;
    public const float MAX_VALUE_GPD_PERCAPITA = 29084;
    public const float MAX_VALUE_ENERGY_CONSUMPTION = 3688795;
    public const float MAX_VALUE_ARABLE_AREA = 190624;
    public const float MAX_VALUE_LIFE_EXPECTANCE_WOMEN = 81.06F;
    public const float MAX_VALUE_LIFE_EXPECTANCE_MEN = 76.5F;
    public const float MAX_VALUE_LIFE_EXPECTANCE = 78.75F;
    public const float MAX_VALUE_INFANT_MORTALITY = 179.1F;
    public const float MAX_VALUE_NUMBER_PERSONAL_COMPUTER = 35.9F;

    public const float MAX_SIZE_SPHERE = 0.2F;
    public const float MIN_SIZE_SPHERE = 0.05F;
    public const float MAX_SIZE_AXE_X = 0.5F;
    public const float MAX_SIZE_AXE_Y = 0.5F;

    public const int MAX_AXES = 1;
    public const int MIN_AXES = 0;

    public const int MAX_VALUE_YEAR = 2000;
    public const int MIN_VALUE_YEAR = 1975;

    public const string NAME_FILE = "data.json";
    public const string NAME_DIRECTORY = "Data";

    public const string ENDPOINT_RAWDATA = "http://192.168.0.104:3000/";
    public const string ENDPOINT_COUNTRY = "http://192.168.0.104:3000/country";

    public const int POPULATION = 0;
    public const int AREBLE_AREA = 1;
    public const int ENERGY_CONSUMPTION = 2;
    public const int GDP_PER_CAPITA = 3;
    public const int LIFE_EXPECTANCY_WOMEN = 4;
    public const int LIFE_EXPECTANCY_MEN = 5;
    public const int LIFE_EXPECTANCY = 6;
    public const int INFANT_MORTALITY = 7;
    public const int NUMBER_PERSONAL_COMPUTER = 8;
    public const int INDEXED_POPULATION = 9;
    public const int INDEXED_ENERGY_CONSUMPTION = 10;
    public const int INDEXES_GDP = 11;

    public const string COUNTRY_A = "A";
    public const string COUNTRY_B = "B";
    public const string COUNTRY_C = "C";
    public const string COUNTRY_D = "D";
    public const string COUNTRY_E = "E";
    public const string COUNTRY_F = "F";
    public const string COUNTRY_G = "G";
    public const string COUNTRY_H = "H";
    public const string COUNTRY_I = "I";
    public const string COUNTRY_J = "J";
    public const string COUNTRY_K = "K";
    public const string COUNTRY_L = "L";
    public const string COUNTRY_M = "M";
    public const string COUNTRY_N = "N";
    public const string COUNTRY_O = "O";
    public const string COUNTRY_P = "P";

    public static readonly float[] COUNTRY_A_POPULATION = { 12925179, 13104717, 13274487, 13445160, 13624504, 13815623, 14016589, 14224073, 14432572, 14638327, 14840224, 15040448, 15242390, 15450858, 15669117, 15898038, 16135897, 16380120, 16626941, 16873335, 17119108, 17364316, 17606545, 17842944, 18071758, 18291108 };
    public static readonly float[] COUNTRY_A_ENERGY_CONSUMPTION = { 57974, 60888, 64772, 69743, 73933, 76596, 82607, 86295, 91232, 96135, 101480, 105329, 106287, 112947, 120996, 126211, 131523, 139017, 147788, 155077, 156851, 159761, 163747, 167513, 173384, 177672};
    public static readonly float[] COUNTRY_A_GDP_PER_CAPITA = { 3798, 4325, 4852, 5379, 5906, 6433, 6860, 7577, 8377, 9259, 10429, 10490, 11351, 12327, 13064, 13388, 14334, 15252, 16215, 16703, 17004, 17714, 18595, 19624, 20753, 21602};
}
