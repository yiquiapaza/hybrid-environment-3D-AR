using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryB 
{
    static Dictionary<int, Vector3> position;
    static Dictionary<int, Vector3> scale;

    public static Vector3 GetScale(int year)
    {
        scale = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScalePopulation(851410624), Util.ScalePopulation(851410624), Util.ScalePopulation(851410624)) },
            { 1976, new Vector3(Util.ScalePopulation(871825538), Util.ScalePopulation(871825538), Util.ScalePopulation(871825538)) },
            { 1977, new Vector3(Util.ScalePopulation(891587287), Util.ScalePopulation(891587287), Util.ScalePopulation(891587287)) },
            { 1978, new Vector3(Util.ScalePopulation(910328330), Util.ScalePopulation(910328330), Util.ScalePopulation(910328330)) },
            { 1979, new Vector3(Util.ScalePopulation(927807624), Util.ScalePopulation(927807624), Util.ScalePopulation(927807624)) },
            { 1980, new Vector3(Util.ScalePopulation(943877441), Util.ScalePopulation(943877441), Util.ScalePopulation(943877441)) },
            { 1981, new Vector3(Util.ScalePopulation(958635696), Util.ScalePopulation(958635696), Util.ScalePopulation(958635696)) },
            { 1982, new Vector3(Util.ScalePopulation(972412497), Util.ScalePopulation(972412497), Util.ScalePopulation(972412497)) },
            { 1983, new Vector3(Util.ScalePopulation(985695522), Util.ScalePopulation(985695522), Util.ScalePopulation(985695522)) },
            { 1984, new Vector3(Util.ScalePopulation(998877093), Util.ScalePopulation(998877093), Util.ScalePopulation(998877093)) },
            { 1985, new Vector3(Util.ScalePopulation(1011976337), Util.ScalePopulation(1011976337), Util.ScalePopulation(1011976337)) },
            { 1986, new Vector3(Util.ScalePopulation(1024987016), Util.ScalePopulation(1024987016), Util.ScalePopulation(1024987016)) },
            { 1987, new Vector3(Util.ScalePopulation(1038240611), Util.ScalePopulation(1038240611), Util.ScalePopulation(1038240611)) },
            { 1988, new Vector3(Util.ScalePopulation(1052132282), Util.ScalePopulation(1052132282), Util.ScalePopulation(1052132282)) },
            { 1989, new Vector3(Util.ScalePopulation(1066906060), Util.ScalePopulation(1066906060), Util.ScalePopulation(1066906060)) },
            { 1990, new Vector3(Util.ScalePopulation(1082759055), Util.ScalePopulation(1082759055), Util.ScalePopulation(1082759055)) },
            { 1991, new Vector3(Util.ScalePopulation(1099532095), Util.ScalePopulation(1099532095), Util.ScalePopulation(1099532095)) },
            { 1992, new Vector3(Util.ScalePopulation(1116665305), Util.ScalePopulation(1116665305), Util.ScalePopulation(1116665305)) },
            { 1993, new Vector3(Util.ScalePopulation(1133368548), Util.ScalePopulation(1133368548), Util.ScalePopulation(1133368548)) },
            { 1994, new Vector3(Util.ScalePopulation(1149068978), Util.ScalePopulation(1149068978), Util.ScalePopulation(1149068978)) },
            { 1995, new Vector3(Util.ScalePopulation(1163550191), Util.ScalePopulation(1163550191), Util.ScalePopulation(1163550191)) },
            { 1996, new Vector3(Util.ScalePopulation(1176963429), Util.ScalePopulation(1176963429), Util.ScalePopulation(1176963429)) },
            { 1997, new Vector3(Util.ScalePopulation(1189550675), Util.ScalePopulation(1189550675), Util.ScalePopulation(1189550675)) },
            { 1998, new Vector3(Util.ScalePopulation(1201711768), Util.ScalePopulation(1201711768), Util.ScalePopulation(1201711768)) },
            { 1999, new Vector3(Util.ScalePopulation(1213731655), Util.ScalePopulation(1213731655), Util.ScalePopulation(1213731655)) },
            { 2000, new Vector3(Util.ScalePopulation(1225679701), Util.ScalePopulation(1225679701), Util.ScalePopulation(1225679701)) }
        };
        return scale[year];
    }

    public static Vector3 GetDataFirtsExperiment(int year)
    {
        position = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScaleLifeExpectance(61.52f),Util.ScaleGDPPercapita(206),  Util.ScaleYear(0)) },
            { 1976, new Vector3(Util.ScaleLifeExpectance(61.94f),Util.ScaleGDPPercapita(211),  Util.ScaleYear(1)) },
            { 1977, new Vector3(Util.ScaleLifeExpectance(62.36f),Util.ScaleGDPPercapita(216),  Util.ScaleYear(2)) },
            { 1978, new Vector3(Util.ScaleLifeExpectance(62.78f),Util.ScaleGDPPercapita(221),  Util.ScaleYear(3)) },
            { 1979, new Vector3(Util.ScaleLifeExpectance(63.2f),Util.ScaleGDPPercapita(226),  Util.ScaleYear(4)) },
            { 1980, new Vector3(Util.ScaleLifeExpectance(63.62f),Util.ScaleGDPPercapita(231),  Util.ScaleYear(5)) },
            { 1981, new Vector3(Util.ScaleLifeExpectance(64.04f),Util.ScaleGDPPercapita(261),  Util.ScaleYear(6)) },
            { 1982, new Vector3(Util.ScaleLifeExpectance(64.46f),Util.ScaleGDPPercapita(308),  Util.ScaleYear(7)) },
            { 1983, new Vector3(Util.ScaleLifeExpectance(64.88f),Util.ScaleGDPPercapita(355),  Util.ScaleYear(8)) },
            { 1984, new Vector3(Util.ScaleLifeExpectance(65.3f),Util.ScaleGDPPercapita(412),  Util.ScaleYear(9)) },
            { 1985, new Vector3(Util.ScaleLifeExpectance(65.34f),Util.ScaleGDPPercapita(468),  Util.ScaleYear(10)) },
            { 1986, new Vector3(Util.ScaleLifeExpectance(65.38f),Util.ScaleGDPPercapita(532),  Util.ScaleYear(11)) },
            { 1987, new Vector3(Util.ScaleLifeExpectance(65.42f),Util.ScaleGDPPercapita(603),  Util.ScaleYear(12)) },
            { 1988, new Vector3(Util.ScaleLifeExpectance(65.46f),Util.ScaleGDPPercapita(711),  Util.ScaleYear(13)) },
            { 1989, new Vector3(Util.ScaleLifeExpectance(65.5f),Util.ScaleGDPPercapita(823),  Util.ScaleYear(14)) },
            { 1990, new Vector3(Util.ScaleLifeExpectance(65.86f),Util.ScaleGDPPercapita(904),  Util.ScaleYear(15)) },
            { 1991, new Vector3(Util.ScaleLifeExpectance(66.22f),Util.ScaleGDPPercapita(1021),  Util.ScaleYear(16)) },
            { 1992, new Vector3(Util.ScaleLifeExpectance(66.58f),Util.ScaleGDPPercapita(1157),  Util.ScaleYear(17)) },
            { 1993, new Vector3(Util.ScaleLifeExpectance(66.94f),Util.ScaleGDPPercapita(1229),  Util.ScaleYear(18)) },
            { 1994, new Vector3(Util.ScaleLifeExpectance(67.3f),Util.ScaleGDPPercapita(1303),  Util.ScaleYear(19)) },
            { 1995, new Vector3(Util.ScaleLifeExpectance(67.58f),Util.ScaleGDPPercapita(1454),  Util.ScaleYear(20)) },
            { 1996, new Vector3(Util.ScaleLifeExpectance(67.86f),Util.ScaleGDPPercapita(1680),  Util.ScaleYear(21)) },
            { 1997, new Vector3(Util.ScaleLifeExpectance(68.14f),Util.ScaleGDPPercapita(1944),  Util.ScaleYear(22)) },
            { 1998, new Vector3(Util.ScaleLifeExpectance(68.42f),Util.ScaleGDPPercapita(2217),  Util.ScaleYear(23)) },
            { 1999, new Vector3(Util.ScaleLifeExpectance(68.7f),Util.ScaleGDPPercapita(2518),  Util.ScaleYear(24)) },
            { 2000, new Vector3(Util.ScaleLifeExpectance(68.98f),Util.ScaleGDPPercapita(2789),  Util.ScaleYear(25)) }
        };

        return position[year];
    }
}
