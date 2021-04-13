using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class CountryA 
{
    static Dictionary<int, Vector3> position;
    static Dictionary<int, Vector3> scale;

    public static Vector3 GetScale(int year)
    {
        scale = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScalePopulation(12925179), Util.ScalePopulation(12925179), Util.ScalePopulation(12925179)) },
            { 1976, new Vector3(Util.ScalePopulation(13104717), Util.ScalePopulation(13104717), Util.ScalePopulation(13104717)) },
            { 1977, new Vector3(Util.ScalePopulation(13274487), Util.ScalePopulation(13274487), Util.ScalePopulation(13274487)) },
            { 1978, new Vector3(Util.ScalePopulation(13445160), Util.ScalePopulation(13445160), Util.ScalePopulation(13445160)) },
            { 1979, new Vector3(Util.ScalePopulation(13624504), Util.ScalePopulation(13624504), Util.ScalePopulation(13624504)) },
            { 1980, new Vector3(Util.ScalePopulation(13815623), Util.ScalePopulation(13815623), Util.ScalePopulation(13815623)) },
            { 1981, new Vector3(Util.ScalePopulation(14016589), Util.ScalePopulation(14016589), Util.ScalePopulation(14016589)) },
            { 1982, new Vector3(Util.ScalePopulation(14224073), Util.ScalePopulation(14224073), Util.ScalePopulation(14224073)) },
            { 1983, new Vector3(Util.ScalePopulation(14432572), Util.ScalePopulation(14432572), Util.ScalePopulation(14432572)) },
            { 1984, new Vector3(Util.ScalePopulation(14638327), Util.ScalePopulation(14638327), Util.ScalePopulation(14638327)) },
            { 1985, new Vector3(Util.ScalePopulation(14840224), Util.ScalePopulation(14840224), Util.ScalePopulation(14840224)) },
            { 1986, new Vector3(Util.ScalePopulation(15040448), Util.ScalePopulation(15040448), Util.ScalePopulation(15040448)) },
            { 1987, new Vector3(Util.ScalePopulation(15242390), Util.ScalePopulation(15242390), Util.ScalePopulation(15242390)) },
            { 1988, new Vector3(Util.ScalePopulation(15450858), Util.ScalePopulation(15450858), Util.ScalePopulation(15450858)) },
            { 1989, new Vector3(Util.ScalePopulation(15669117), Util.ScalePopulation(15669117), Util.ScalePopulation(15669117)) },
            { 1990, new Vector3(Util.ScalePopulation(15898038), Util.ScalePopulation(15898038), Util.ScalePopulation(15898038)) },
            { 1991, new Vector3(Util.ScalePopulation(16135897), Util.ScalePopulation(16135897), Util.ScalePopulation(16135897)) },
            { 1992, new Vector3(Util.ScalePopulation(16380120), Util.ScalePopulation(16380120), Util.ScalePopulation(16380120)) },
            { 1993, new Vector3(Util.ScalePopulation(16626941), Util.ScalePopulation(16626941), Util.ScalePopulation(16626941)) },
            { 1994, new Vector3(Util.ScalePopulation(16873335), Util.ScalePopulation(16873335), Util.ScalePopulation(16873335)) },
            { 1995, new Vector3(Util.ScalePopulation(17119108), Util.ScalePopulation(17119108), Util.ScalePopulation(17119108)) },
            { 1996, new Vector3(Util.ScalePopulation(17364316), Util.ScalePopulation(17364316), Util.ScalePopulation(17364316)) },
            { 1997, new Vector3(Util.ScalePopulation(17606545), Util.ScalePopulation(17606545), Util.ScalePopulation(17606545)) },
            { 1998, new Vector3(Util.ScalePopulation(17842944), Util.ScalePopulation(17842944), Util.ScalePopulation(17842944)) },
            { 1999, new Vector3(Util.ScalePopulation(18071758), Util.ScalePopulation(18071758), Util.ScalePopulation(18071758)) },
            { 2000, new Vector3(Util.ScalePopulation(18291108), Util.ScalePopulation(18291108), Util.ScalePopulation(18291108)) }
        };
        return scale[year];
    }

    public static Vector3 GetDataFirtsExperiment(int year)
    {
        position = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScaleLifeExpectance(70.26f),Util.ScaleGDPPercapita(3798),  Util.ScaleYear(0)) },
            { 1976, new Vector3(Util.ScaleLifeExpectance(70.62f),Util.ScaleGDPPercapita(4325),  Util.ScaleYear(1)) },
            { 1977, new Vector3(Util.ScaleLifeExpectance(70.98f),Util.ScaleGDPPercapita(4852),  Util.ScaleYear(2)) },
            { 1978, new Vector3(Util.ScaleLifeExpectance(71.34f),Util.ScaleGDPPercapita(5379),  Util.ScaleYear(3)) },
            { 1979, new Vector3(Util.ScaleLifeExpectance(71.7f),Util.ScaleGDPPercapita(5906),  Util.ScaleYear(4)) },
            { 1980, new Vector3(Util.ScaleLifeExpectance(72.06f),Util.ScaleGDPPercapita(6433),  Util.ScaleYear(5)) },
            { 1981, new Vector3(Util.ScaleLifeExpectance(72.42f),Util.ScaleGDPPercapita(6860),  Util.ScaleYear(6)) },
            { 1982, new Vector3(Util.ScaleLifeExpectance(72.78f),Util.ScaleGDPPercapita(7577),  Util.ScaleYear(7)) },
            { 1983, new Vector3(Util.ScaleLifeExpectance(73.14f),Util.ScaleGDPPercapita(8377),  Util.ScaleYear(8)) },
            { 1984, new Vector3(Util.ScaleLifeExpectance(73.5f),Util.ScaleGDPPercapita(9259),  Util.ScaleYear(9)) },
            { 1985, new Vector3(Util.ScaleLifeExpectance(73.84f),Util.ScaleGDPPercapita(10429),  Util.ScaleYear(10)) },
            { 1986, new Vector3(Util.ScaleLifeExpectance(74.18f),Util.ScaleGDPPercapita(10490),  Util.ScaleYear(11)) },
            { 1987, new Vector3(Util.ScaleLifeExpectance(74.52f),Util.ScaleGDPPercapita(11351),  Util.ScaleYear(12)) },
            { 1988, new Vector3(Util.ScaleLifeExpectance(74.86f),Util.ScaleGDPPercapita(12327),  Util.ScaleYear(13)) },
            { 1989, new Vector3(Util.ScaleLifeExpectance(75.2f),Util.ScaleGDPPercapita(13064),  Util.ScaleYear(14)) },
            { 1990, new Vector3(Util.ScaleLifeExpectance(75.38f),Util.ScaleGDPPercapita(13388),  Util.ScaleYear(15)) },
            { 1991, new Vector3(Util.ScaleLifeExpectance(75.56f),Util.ScaleGDPPercapita(14334),  Util.ScaleYear(16)) },
            { 1992, new Vector3(Util.ScaleLifeExpectance(75.74f),Util.ScaleGDPPercapita(15252),  Util.ScaleYear(17)) },
            { 1993, new Vector3(Util.ScaleLifeExpectance(75.92f),Util.ScaleGDPPercapita(16215),  Util.ScaleYear(18)) },
            { 1994, new Vector3(Util.ScaleLifeExpectance(76.1f),Util.ScaleGDPPercapita(16703),  Util.ScaleYear(19)) },
            { 1995, new Vector3(Util.ScaleLifeExpectance(76.39f),Util.ScaleGDPPercapita(17004),  Util.ScaleYear(20)) },
            { 1996, new Vector3(Util.ScaleLifeExpectance(76.69f),Util.ScaleGDPPercapita(17714),  Util.ScaleYear(21)) },
            { 1997, new Vector3(Util.ScaleLifeExpectance(77),Util.ScaleGDPPercapita(18595),  Util.ScaleYear(22)) },
            { 1998, new Vector3(Util.ScaleLifeExpectance(77.3f),Util.ScaleGDPPercapita(19624),  Util.ScaleYear(23)) },
            { 1999, new Vector3(Util.ScaleLifeExpectance(77.6f),Util.ScaleGDPPercapita(20753),  Util.ScaleYear(24)) },
            { 2000, new Vector3(Util.ScaleLifeExpectance(77.89f),Util.ScaleGDPPercapita(21602),  Util.ScaleYear(25)) }
        };

        return position[year];   
    }

};
