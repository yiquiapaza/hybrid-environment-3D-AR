using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryF 
{
    static Dictionary<int, Vector3> position;
    static Dictionary<int, Vector3> scale;

    public static Vector3 GetScale(int year)
    {
        scale = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScalePopulation(561427382), Util.ScalePopulation(561427382), Util.ScalePopulation(561427382)) },
            { 1976, new Vector3(Util.ScalePopulation(573901785), Util.ScalePopulation(573901785), Util.ScalePopulation(573901785)) },
            { 1977, new Vector3(Util.ScalePopulation(586762819), Util.ScalePopulation(586762819), Util.ScalePopulation(586762819)) },
            { 1978, new Vector3(Util.ScalePopulation(600044316), Util.ScalePopulation(600044316), Util.ScalePopulation(600044316)) },
            { 1979, new Vector3(Util.ScalePopulation(613767233), Util.ScalePopulation(613767233), Util.ScalePopulation(613767233)) },
            { 1980, new Vector3(Util.ScalePopulation(627941825), Util.ScalePopulation(627941825), Util.ScalePopulation(627941825)) },
            { 1981, new Vector3(Util.ScalePopulation(642552661), Util.ScalePopulation(642552661), Util.ScalePopulation(642552661)) },
            { 1982, new Vector3(Util.ScalePopulation(657562064), Util.ScalePopulation(657562064), Util.ScalePopulation(657562064)) },
            { 1983, new Vector3(Util.ScalePopulation(672916902), Util.ScalePopulation(672916902), Util.ScalePopulation(672916902)) },
            { 1984, new Vector3(Util.ScalePopulation(688575418), Util.ScalePopulation(688575418), Util.ScalePopulation(688575418)) },
            { 1985, new Vector3(Util.ScalePopulation(704519770), Util.ScalePopulation(704519770), Util.ScalePopulation(704519770)) },
            { 1986, new Vector3(Util.ScalePopulation(720749252), Util.ScalePopulation(720749252), Util.ScalePopulation(720749252)) },
            { 1987, new Vector3(Util.ScalePopulation(737259342), Util.ScalePopulation(737259342), Util.ScalePopulation(737259342)) },
            { 1988, new Vector3(Util.ScalePopulation(754050696), Util.ScalePopulation(754050696), Util.ScalePopulation(754050696)) },
            { 1989, new Vector3(Util.ScalePopulation(771120552), Util.ScalePopulation(771120552), Util.ScalePopulation(771120552)) },
            { 1990, new Vector3(Util.ScalePopulation(788442870), Util.ScalePopulation(788442870), Util.ScalePopulation(788442870)) },
            { 1991, new Vector3(Util.ScalePopulation(805998670), Util.ScalePopulation(805998670), Util.ScalePopulation(805998670)) },
            { 1992, new Vector3(Util.ScalePopulation(823799168), Util.ScalePopulation(823799168), Util.ScalePopulation(823799168)) },
            { 1993, new Vector3(Util.ScalePopulation(841864119), Util.ScalePopulation(841864119), Util.ScalePopulation(841864119)) },
            { 1994, new Vector3(Util.ScalePopulation(860195242), Util.ScalePopulation(860195242), Util.ScalePopulation(860195242)) },
            { 1995, new Vector3(Util.ScalePopulation(878789217), Util.ScalePopulation(878789217), Util.ScalePopulation(878789217)) },
            { 1996, new Vector3(Util.ScalePopulation(897599210), Util.ScalePopulation(897599210), Util.ScalePopulation(897599210)) },
            { 1997, new Vector3(Util.ScalePopulation(916529257), Util.ScalePopulation(916529257), Util.ScalePopulation(916529257)) },
            { 1998, new Vector3(Util.ScalePopulation(935455492), Util.ScalePopulation(935455492), Util.ScalePopulation(935455492)) },
            { 1999, new Vector3(Util.ScalePopulation(954281733), Util.ScalePopulation(954281733), Util.ScalePopulation(954281733)) },
            { 2000, new Vector3(Util.ScalePopulation(972968477), Util.ScalePopulation(972968477), Util.ScalePopulation(972968477)) }
        };
        return scale[year];
    }

    public static Vector3 GetDataFirtsExperiment(int year)
    {
        position = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScaleLifeExpectance(47.72f),Util.ScaleGDPPercapita(344),  Util.ScaleYear(0)) },
            { 1976, new Vector3(Util.ScaleLifeExpectance(48.44f),Util.ScaleGDPPercapita(366),  Util.ScaleYear(1)) },
            { 1977, new Vector3(Util.ScaleLifeExpectance(49.16f),Util.ScaleGDPPercapita(388),  Util.ScaleYear(2)) },
            { 1978, new Vector3(Util.ScaleLifeExpectance(49.88f),Util.ScaleGDPPercapita(410),  Util.ScaleYear(3)) },
            { 1979, new Vector3(Util.ScaleLifeExpectance(50.6f),Util.ScaleGDPPercapita(432),  Util.ScaleYear(4)) },
            { 1980, new Vector3(Util.ScaleLifeExpectance(51.32f),Util.ScaleGDPPercapita(454),  Util.ScaleYear(5)) },
            { 1981, new Vector3(Util.ScaleLifeExpectance(52.04f),Util.ScaleGDPPercapita(506),  Util.ScaleYear(6)) },
            { 1982, new Vector3(Util.ScaleLifeExpectance(52.76f),Util.ScaleGDPPercapita(560),  Util.ScaleYear(7)) },
            { 1983, new Vector3(Util.ScaleLifeExpectance(53.48f),Util.ScaleGDPPercapita(560),  Util.ScaleYear(8)) },
            { 1984, new Vector3(Util.ScaleLifeExpectance(54.2f),Util.ScaleGDPPercapita(636),  Util.ScaleYear(9)) },
            { 1985, new Vector3(Util.ScaleLifeExpectance(54.68f),Util.ScaleGDPPercapita(726),  Util.ScaleYear(10)) },
            { 1986, new Vector3(Util.ScaleLifeExpectance(55.16f),Util.ScaleGDPPercapita(784),  Util.ScaleYear(11)) },
            { 1987, new Vector3(Util.ScaleLifeExpectance(55.64f),Util.ScaleGDPPercapita(855),  Util.ScaleYear(12)) },
            { 1988, new Vector3(Util.ScaleLifeExpectance(56.12f),Util.ScaleGDPPercapita(905),  Util.ScaleYear(13)) },
            { 1989, new Vector3(Util.ScaleLifeExpectance(56.6f),Util.ScaleGDPPercapita(965),  Util.ScaleYear(14)) },
            { 1990, new Vector3(Util.ScaleLifeExpectance(56.98f),Util.ScaleGDPPercapita(1013),  Util.ScaleYear(15)) },
            { 1991, new Vector3(Util.ScaleLifeExpectance(57.36f),Util.ScaleGDPPercapita(1064),  Util.ScaleYear(16)) },
            { 1992, new Vector3(Util.ScaleLifeExpectance(57.74f),Util.ScaleGDPPercapita(1188),  Util.ScaleYear(17)) },
            { 1993, new Vector3(Util.ScaleLifeExpectance(58.12f),Util.ScaleGDPPercapita(1287),  Util.ScaleYear(18)) },
            { 1994, new Vector3(Util.ScaleLifeExpectance(58.5f),Util.ScaleGDPPercapita(1388),  Util.ScaleYear(19)) },
            { 1995, new Vector3(Util.ScaleLifeExpectance(58.84f),Util.ScaleGDPPercapita(1424),  Util.ScaleYear(20)) },
            { 1996, new Vector3(Util.ScaleLifeExpectance(59.18f),Util.ScaleGDPPercapita(1505),  Util.ScaleYear(21)) },
            { 1997, new Vector3(Util.ScaleLifeExpectance(59.52f),Util.ScaleGDPPercapita(1583),  Util.ScaleYear(22)) },
            { 1998, new Vector3(Util.ScaleLifeExpectance(59.86f),Util.ScaleGDPPercapita(1704),  Util.ScaleYear(23)) },
            { 1999, new Vector3(Util.ScaleLifeExpectance(60.2f),Util.ScaleGDPPercapita(1836),  Util.ScaleYear(24)) },
            { 2000, new Vector3(Util.ScaleLifeExpectance(60.54f),Util.ScaleGDPPercapita(1971),  Util.ScaleYear(25)) }
        };

        return position[year];
    }
}
