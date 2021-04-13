using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryD
{
    static Dictionary<int, Vector3> position;
    static Dictionary<int, Vector3> scale;

    public static Vector3 GetScale(int year)
    {
        scale = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScalePopulation(497455), Util.ScalePopulation(497455), Util.ScalePopulation(497455)) },
            { 1976, new Vector3(Util.ScalePopulation(514510), Util.ScalePopulation(514510), Util.ScalePopulation(514510)) },
            { 1977, new Vector3(Util.ScalePopulation(532494), Util.ScalePopulation(532494), Util.ScalePopulation(532494)) },
            { 1978, new Vector3(Util.ScalePopulation(551036), Util.ScalePopulation(551036), Util.ScalePopulation(551036)) },
            { 1979, new Vector3(Util.ScalePopulation(569883), Util.ScalePopulation(569883), Util.ScalePopulation(569883)) },
            { 1980, new Vector3(Util.ScalePopulation(589013), Util.ScalePopulation(589013), Util.ScalePopulation(589013)) },
            { 1981, new Vector3(Util.ScalePopulation(608563), Util.ScalePopulation(608563), Util.ScalePopulation(608563)) },
            { 1982, new Vector3(Util.ScalePopulation(628627), Util.ScalePopulation(628627), Util.ScalePopulation(628627)) },
            { 1983, new Vector3(Util.ScalePopulation(649352), Util.ScalePopulation(649352), Util.ScalePopulation(649352)) },
            { 1984, new Vector3(Util.ScalePopulation(670884), Util.ScalePopulation(670884), Util.ScalePopulation(670884)) },
            { 1985, new Vector3(Util.ScalePopulation(693208), Util.ScalePopulation(693208), Util.ScalePopulation(693208)) },
            { 1986, new Vector3(Util.ScalePopulation(716401), Util.ScalePopulation(716401), Util.ScalePopulation(716401)) },
            { 1987, new Vector3(Util.ScalePopulation(740807), Util.ScalePopulation(740807), Util.ScalePopulation(740807)) },
            { 1988, new Vector3(Util.ScalePopulation(766861), Util.ScalePopulation(766861), Util.ScalePopulation(766861)) },
            { 1989, new Vector3(Util.ScalePopulation(794870), Util.ScalePopulation(794870), Util.ScalePopulation(794870)) },
            { 1990, new Vector3(Util.ScalePopulation(824989), Util.ScalePopulation(824989), Util.ScalePopulation(824989)) },
            { 1991, new Vector3(Util.ScalePopulation(857122), Util.ScalePopulation(857122), Util.ScalePopulation(857122)) },
            { 1992, new Vector3(Util.ScalePopulation(891000), Util.ScalePopulation(891000), Util.ScalePopulation(891000)) },
            { 1993, new Vector3(Util.ScalePopulation(926218), Util.ScalePopulation(926218), Util.ScalePopulation(926218)) },
            { 1994, new Vector3(Util.ScalePopulation(962473), Util.ScalePopulation(962473), Util.ScalePopulation(962473)) },
            { 1995, new Vector3(Util.ScalePopulation(999635), Util.ScalePopulation(999635), Util.ScalePopulation(999635)) },
            { 1996, new Vector3(Util.ScalePopulation(1037763), Util.ScalePopulation(1037763), Util.ScalePopulation(1037763)) },
            { 1997, new Vector3(Util.ScalePopulation(1076967), Util.ScalePopulation(1076967), Util.ScalePopulation(1076967)) },
            { 1998, new Vector3(Util.ScalePopulation(1117431), Util.ScalePopulation(1117431), Util.ScalePopulation(1117431)) },
            { 1999, new Vector3(Util.ScalePopulation(1159255), Util.ScalePopulation(1159255), Util.ScalePopulation(1159255)) },
            { 2000, new Vector3(Util.ScalePopulation(1202420), Util.ScalePopulation(1202420), Util.ScalePopulation(1202420)) }
        };
        return scale[year];
    }

    public static Vector3 GetDataFirtsExperiment(int year)
    {
        position = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScaleLifeExpectance(35.5f),Util.ScaleGDPPercapita(400),  Util.ScaleYear(0)) },
            { 1976, new Vector3(Util.ScaleLifeExpectance(36.19f),Util.ScaleGDPPercapita(452),  Util.ScaleYear(1)) },
            { 1977, new Vector3(Util.ScaleLifeExpectance(36.9f),Util.ScaleGDPPercapita(504),  Util.ScaleYear(2)) },
            { 1978, new Vector3(Util.ScaleLifeExpectance(37.59f),Util.ScaleGDPPercapita(556),  Util.ScaleYear(3)) },
            { 1979, new Vector3(Util.ScaleLifeExpectance(38.3f),Util.ScaleGDPPercapita(608),  Util.ScaleYear(4)) },
            { 1980, new Vector3(Util.ScaleLifeExpectance(39),Util.ScaleGDPPercapita(660),  Util.ScaleYear(5)) },
            { 1981, new Vector3(Util.ScaleLifeExpectance(39.69f),Util.ScaleGDPPercapita(701),  Util.ScaleYear(6)) },
            { 1982, new Vector3(Util.ScaleLifeExpectance(40.4f),Util.ScaleGDPPercapita(785),  Util.ScaleYear(7)) },
            { 1983, new Vector3(Util.ScaleLifeExpectance(41.09f),Util.ScaleGDPPercapita(820),  Util.ScaleYear(8)) },
            { 1984, new Vector3(Util.ScaleLifeExpectance(41.8f),Util.ScaleGDPPercapita(924),  Util.ScaleYear(9)) },
            { 1985, new Vector3(Util.ScaleLifeExpectance(42.55f),Util.ScaleGDPPercapita(1010),  Util.ScaleYear(10)) },
            { 1986, new Vector3(Util.ScaleLifeExpectance(43.32f),Util.ScaleGDPPercapita(1043),  Util.ScaleYear(11)) },
            { 1987, new Vector3(Util.ScaleLifeExpectance(44.08f),Util.ScaleGDPPercapita(1206),  Util.ScaleYear(12)) },
            { 1988, new Vector3(Util.ScaleLifeExpectance(44.84f),Util.ScaleGDPPercapita(1164),  Util.ScaleYear(13)) },
            { 1989, new Vector3(Util.ScaleLifeExpectance(45.6f),Util.ScaleGDPPercapita(1197),  Util.ScaleYear(14)) },
            { 1990, new Vector3(Util.ScaleLifeExpectance(46.34f),Util.ScaleGDPPercapita(1398),  Util.ScaleYear(15)) },
            { 1991, new Vector3(Util.ScaleLifeExpectance(47.08f),Util.ScaleGDPPercapita(1168),  Util.ScaleYear(16)) },
            { 1992, new Vector3(Util.ScaleLifeExpectance(47.82f),Util.ScaleGDPPercapita(1222),  Util.ScaleYear(17)) },
            { 1993, new Vector3(Util.ScaleLifeExpectance(48.55f),Util.ScaleGDPPercapita(1401),  Util.ScaleYear(18)) },
            { 1994, new Vector3(Util.ScaleLifeExpectance(49.3f),Util.ScaleGDPPercapita(1484),  Util.ScaleYear(19)) },
            { 1995, new Vector3(Util.ScaleLifeExpectance(49.96f),Util.ScaleGDPPercapita(1469),  Util.ScaleYear(20)) },
            { 1996, new Vector3(Util.ScaleLifeExpectance(50.62f),Util.ScaleGDPPercapita(1456),  Util.ScaleYear(21)) },
            { 1997, new Vector3(Util.ScaleLifeExpectance(51.28f),Util.ScaleGDPPercapita(1478),  Util.ScaleYear(22)) },
            { 1998, new Vector3(Util.ScaleLifeExpectance(51.94f),Util.ScaleGDPPercapita(1463),  Util.ScaleYear(23)) },
            { 1999, new Vector3(Util.ScaleLifeExpectance(52.6f),Util.ScaleGDPPercapita(1452),  Util.ScaleYear(24)) },
            { 2000, new Vector3(Util.ScaleLifeExpectance(53.26f),Util.ScaleGDPPercapita(1467),  Util.ScaleYear(25)) }
        };

        return position[year];
    }
}
