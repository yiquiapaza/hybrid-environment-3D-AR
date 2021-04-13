using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryE
{
    static Dictionary<int, Vector3> position;
    static Dictionary<int, Vector3> scale;

    public static Vector3 GetScale(int year)
    {
        scale = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScalePopulation(10375077), Util.ScalePopulation(10375077), Util.ScalePopulation(10375077)) },
            { 1976, new Vector3(Util.ScalePopulation(10412747), Util.ScalePopulation(10412747), Util.ScalePopulation(10412747)) },
            { 1977, new Vector3(Util.ScalePopulation(10450803), Util.ScalePopulation(10450803), Util.ScalePopulation(10450803)) },
            { 1978, new Vector3(Util.ScalePopulation(10490380), Util.ScalePopulation(10490380), Util.ScalePopulation(10490380)) },
            { 1979, new Vector3(Util.ScalePopulation(10531820), Util.ScalePopulation(10531820), Util.ScalePopulation(10531820)) },
            { 1980, new Vector3(Util.ScalePopulation(10575974), Util.ScalePopulation(10575974), Util.ScalePopulation(10575974)) },
            { 1981, new Vector3(Util.ScalePopulation(10621216), Util.ScalePopulation(10621216), Util.ScalePopulation(10621216)) },
            { 1982, new Vector3(Util.ScalePopulation(10662416), Util.ScalePopulation(10662416), Util.ScalePopulation(10662416)) },
            { 1983, new Vector3(Util.ScalePopulation(10692745), Util.ScalePopulation(10692745), Util.ScalePopulation(10692745)) },
            { 1984, new Vector3(Util.ScalePopulation(10707472), Util.ScalePopulation(10707472), Util.ScalePopulation(10707472)) },
            { 1985, new Vector3(Util.ScalePopulation(10705147), Util.ScalePopulation(10705147), Util.ScalePopulation(10705147)) },
            { 1986, new Vector3(Util.ScalePopulation(10687680), Util.ScalePopulation(10687680), Util.ScalePopulation(10687680)) },
            { 1987, new Vector3(Util.ScalePopulation(10657974), Util.ScalePopulation(10657974), Util.ScalePopulation(10657974)) },
            { 1988, new Vector3(Util.ScalePopulation(10620517), Util.ScalePopulation(10620517), Util.ScalePopulation(10620517)) },
            { 1989, new Vector3(Util.ScalePopulation(10579093), Util.ScalePopulation(10579093), Util.ScalePopulation(10579093)) },
            { 1990, new Vector3(Util.ScalePopulation(10533787), Util.ScalePopulation(10533787), Util.ScalePopulation(10533787)) },
            { 1991, new Vector3(Util.ScalePopulation(10484994), Util.ScalePopulation(10484994), Util.ScalePopulation(10484994)) },
            { 1992, new Vector3(Util.ScalePopulation(10437192), Util.ScalePopulation(10437192), Util.ScalePopulation(10437192)) },
            { 1993, new Vector3(Util.ScalePopulation(10395900), Util.ScalePopulation(10395900), Util.ScalePopulation(10395900)) },
            { 1994, new Vector3(Util.ScalePopulation(10364840), Util.ScalePopulation(10364840), Util.ScalePopulation(10364840)) },
            { 1995, new Vector3(Util.ScalePopulation(10346394), Util.ScalePopulation(10346394), Util.ScalePopulation(10346394)) },
            { 1996, new Vector3(Util.ScalePopulation(10339149), Util.ScalePopulation(10339149), Util.ScalePopulation(10339149)) },
            { 1997, new Vector3(Util.ScalePopulation(10338252), Util.ScalePopulation(10338252), Util.ScalePopulation(10338252)) },
            { 1998, new Vector3(Util.ScalePopulation(10336581), Util.ScalePopulation(10336581), Util.ScalePopulation(10336581)) },
            { 1999, new Vector3(Util.ScalePopulation(10328967), Util.ScalePopulation(10328967), Util.ScalePopulation(10328967)) },
            { 2000, new Vector3(Util.ScalePopulation(10313830), Util.ScalePopulation(10313830), Util.ScalePopulation(10313830)) }
        };
        return scale[year];
    }

    public static Vector3 GetDataFirtsExperiment(int year)
    {
        position = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScaleLifeExpectance(69.21f),Util.ScaleGDPPercapita(2102),  Util.ScaleYear(0)) },
            { 1976, new Vector3(Util.ScaleLifeExpectance(69.24f),Util.ScaleGDPPercapita(2366),  Util.ScaleYear(1)) },
            { 1977, new Vector3(Util.ScaleLifeExpectance(69.25f),Util.ScaleGDPPercapita(2630),  Util.ScaleYear(2)) },
            { 1978, new Vector3(Util.ScaleLifeExpectance(69.28f),Util.ScaleGDPPercapita(2894),  Util.ScaleYear(3)) },
            { 1979, new Vector3(Util.ScaleLifeExpectance(69.3f),Util.ScaleGDPPercapita(3158),  Util.ScaleYear(4)) },
            { 1980, new Vector3(Util.ScaleLifeExpectance(69.32f),Util.ScaleGDPPercapita(3422),  Util.ScaleYear(5)) },
            { 1981, new Vector3(Util.ScaleLifeExpectance(69.34f),Util.ScaleGDPPercapita(3911),  Util.ScaleYear(6)) },
            { 1982, new Vector3(Util.ScaleLifeExpectance(69.36f),Util.ScaleGDPPercapita(4170),  Util.ScaleYear(7)) },
            { 1983, new Vector3(Util.ScaleLifeExpectance(69.38f),Util.ScaleGDPPercapita(4868),  Util.ScaleYear(8)) },
            { 1984, new Vector3(Util.ScaleLifeExpectance(69.4f),Util.ScaleGDPPercapita(5274),  Util.ScaleYear(9)) },
            { 1985, new Vector3(Util.ScaleLifeExpectance(69.34f),Util.ScaleGDPPercapita(6056),  Util.ScaleYear(10)) },
            { 1986, new Vector3(Util.ScaleLifeExpectance(69.28f),Util.ScaleGDPPercapita(6696),  Util.ScaleYear(11)) },
            { 1987, new Vector3(Util.ScaleLifeExpectance(69.22f),Util.ScaleGDPPercapita(6945),  Util.ScaleYear(12)) },
            { 1988, new Vector3(Util.ScaleLifeExpectance(69.16f),Util.ScaleGDPPercapita(7467),  Util.ScaleYear(13)) },
            { 1989, new Vector3(Util.ScaleLifeExpectance(69.1f),Util.ScaleGDPPercapita(7708),  Util.ScaleYear(14)) },
            { 1990, new Vector3(Util.ScaleLifeExpectance(69.17f),Util.ScaleGDPPercapita(8032),  Util.ScaleYear(15)) },
            { 1991, new Vector3(Util.ScaleLifeExpectance(69.25f),Util.ScaleGDPPercapita(8606),  Util.ScaleYear(16)) },
            { 1992, new Vector3(Util.ScaleLifeExpectance(69.34f),Util.ScaleGDPPercapita(8922),  Util.ScaleYear(17)) },
            { 1993, new Vector3(Util.ScaleLifeExpectance(69.42f),Util.ScaleGDPPercapita(9463),  Util.ScaleYear(18)) },
            { 1994, new Vector3(Util.ScaleLifeExpectance(69.5f),Util.ScaleGDPPercapita(9470),  Util.ScaleYear(19)) },
            { 1995, new Vector3(Util.ScaleLifeExpectance(69.5f),Util.ScaleGDPPercapita(8605),  Util.ScaleYear(20)) },
            { 1996, new Vector3(Util.ScaleLifeExpectance(69.5f),Util.ScaleGDPPercapita(8477),  Util.ScaleYear(21)) },
            { 1997, new Vector3(Util.ScaleLifeExpectance(69.5f),Util.ScaleGDPPercapita(8604),  Util.ScaleYear(22)) },
            { 1998, new Vector3(Util.ScaleLifeExpectance(69.5f),Util.ScaleGDPPercapita(9086),  Util.ScaleYear(23)) },
            { 1999, new Vector3(Util.ScaleLifeExpectance(69.5f),Util.ScaleGDPPercapita(9462),  Util.ScaleYear(24)) },
            { 2000, new Vector3(Util.ScaleLifeExpectance(69.5f),Util.ScaleGDPPercapita(9844),  Util.ScaleYear(25)) }
        };

        return position[year];
    }
}
