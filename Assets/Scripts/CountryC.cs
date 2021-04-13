using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryC 
{
    static Dictionary<int, Vector3> position;
    static Dictionary<int, Vector3> scale;

    public static Vector3 GetScale(int year)
    {
        scale = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScalePopulation(4959189), Util.ScalePopulation(4959189), Util.ScalePopulation(4959189)) },
            { 1976, new Vector3(Util.ScalePopulation(4987826), Util.ScalePopulation(4987826), Util.ScalePopulation(4987826)) },
            { 1977, new Vector3(Util.ScalePopulation(5014364), Util.ScalePopulation(5014364), Util.ScalePopulation(5014364)) },
            { 1978, new Vector3(Util.ScalePopulation(5038466), Util.ScalePopulation(5038466), Util.ScalePopulation(5038466)) },
            { 1979, new Vector3(Util.ScalePopulation(5059864), Util.ScalePopulation(5059864), Util.ScalePopulation(5059864)) },
            { 1980, new Vector3(Util.ScalePopulation(5078660), Util.ScalePopulation(5078660), Util.ScalePopulation(5078660)) },
            { 1981, new Vector3(Util.ScalePopulation(5094844), Util.ScalePopulation(5094844), Util.ScalePopulation(5094844)) },
            { 1982, new Vector3(Util.ScalePopulation(5107958), Util.ScalePopulation(5107958), Util.ScalePopulation(5107958)) },
            { 1983, new Vector3(Util.ScalePopulation(5117433), Util.ScalePopulation(5117433), Util.ScalePopulation(5117433)) },
            { 1984, new Vector3(Util.ScalePopulation(5123029), Util.ScalePopulation(5123029), Util.ScalePopulation(5123029)) },
            { 1985, new Vector3(Util.ScalePopulation(5124597), Util.ScalePopulation(5124597), Util.ScalePopulation(5124597)) },
            { 1986, new Vector3(Util.ScalePopulation(5122764), Util.ScalePopulation(5122764), Util.ScalePopulation(5122764)) },
            { 1987, new Vector3(Util.ScalePopulation(5119055), Util.ScalePopulation(5119055), Util.ScalePopulation(5119055)) },
            { 1988, new Vector3(Util.ScalePopulation(5115502), Util.ScalePopulation(5115502), Util.ScalePopulation(5115502)) },
            { 1989, new Vector3(Util.ScalePopulation(5113678), Util.ScalePopulation(5113678), Util.ScalePopulation(5113678)) },
            { 1990, new Vector3(Util.ScalePopulation(5114105), Util.ScalePopulation(5114105), Util.ScalePopulation(5114105)) },
            { 1991, new Vector3(Util.ScalePopulation(5116737), Util.ScalePopulation(5116737), Util.ScalePopulation(5116737)) },
            { 1992, new Vector3(Util.ScalePopulation(5121853), Util.ScalePopulation(5121853), Util.ScalePopulation(5121853)) },
            { 1993, new Vector3(Util.ScalePopulation(5129576), Util.ScalePopulation(5129576), Util.ScalePopulation(5129576)) },
            { 1994, new Vector3(Util.ScalePopulation(5139947), Util.ScalePopulation(5139947), Util.ScalePopulation(5139947)) },
            { 1995, new Vector3(Util.ScalePopulation(5153137), Util.ScalePopulation(5153137), Util.ScalePopulation(5153137)) },
            { 1996, new Vector3(Util.ScalePopulation(5169106), Util.ScalePopulation(5169106), Util.ScalePopulation(5169106)) },
            { 1997, new Vector3(Util.ScalePopulation(5187348), Util.ScalePopulation(5187348), Util.ScalePopulation(5187348)) },
            { 1998, new Vector3(Util.ScalePopulation(5207139), Util.ScalePopulation(5207139), Util.ScalePopulation(5207139)) },
            { 1999, new Vector3(Util.ScalePopulation(5227861), Util.ScalePopulation(5227861), Util.ScalePopulation(5227861)) },
            { 2000, new Vector3(Util.ScalePopulation(5249337), Util.ScalePopulation(5249337), Util.ScalePopulation(5249337)) }
        };
        return scale[year];
    }

    public static Vector3 GetDataFirtsExperiment(int year)
    {
        position = new Dictionary<int, Vector3>
        {
            { 1975, new Vector3(Util.ScaleLifeExpectance(73.11f),Util.ScaleGDPPercapita(3535),  Util.ScaleYear(0)) },
            { 1976, new Vector3(Util.ScaleLifeExpectance(73.24f),Util.ScaleGDPPercapita(4355),  Util.ScaleYear(1)) },
            { 1977, new Vector3(Util.ScaleLifeExpectance(73.35f),Util.ScaleGDPPercapita(5175),  Util.ScaleYear(2)) },
            { 1978, new Vector3(Util.ScaleLifeExpectance(73.47f),Util.ScaleGDPPercapita(5995),  Util.ScaleYear(3)) },
            { 1979, new Vector3(Util.ScaleLifeExpectance(73.6f),Util.ScaleGDPPercapita(6815),  Util.ScaleYear(4)) },
            { 1980, new Vector3(Util.ScaleLifeExpectance(73.72f),Util.ScaleGDPPercapita(7635),  Util.ScaleYear(5)) },
            { 1981, new Vector3(Util.ScaleLifeExpectance(73.84f),Util.ScaleGDPPercapita(8156),  Util.ScaleYear(6)) },
            { 1982, new Vector3(Util.ScaleLifeExpectance(73.96f),Util.ScaleGDPPercapita(8850),  Util.ScaleYear(7)) },
            { 1983, new Vector3(Util.ScaleLifeExpectance(74.08f),Util.ScaleGDPPercapita(9953),  Util.ScaleYear(8)) },
            { 1984, new Vector3(Util.ScaleLifeExpectance(74.2f),Util.ScaleGDPPercapita(10874),  Util.ScaleYear(9)) },
            { 1985, new Vector3(Util.ScaleLifeExpectance(74.28f),Util.ScaleGDPPercapita(11753),  Util.ScaleYear(10)) },
            { 1986, new Vector3(Util.ScaleLifeExpectance(74.36f),Util.ScaleGDPPercapita(12918),  Util.ScaleYear(11)) },
            { 1987, new Vector3(Util.ScaleLifeExpectance(74.44f),Util.ScaleGDPPercapita(13645),  Util.ScaleYear(12)) },
            { 1988, new Vector3(Util.ScaleLifeExpectance(74.52f),Util.ScaleGDPPercapita(14738),  Util.ScaleYear(13)) },
            { 1989, new Vector3(Util.ScaleLifeExpectance(74.6f),Util.ScaleGDPPercapita(15743),  Util.ScaleYear(14)) },
            { 1990, new Vector3(Util.ScaleLifeExpectance(74.66f),Util.ScaleGDPPercapita(16672),  Util.ScaleYear(15)) },
            { 1991, new Vector3(Util.ScaleLifeExpectance(74.72f),Util.ScaleGDPPercapita(17052),  Util.ScaleYear(16)) },
            { 1992, new Vector3(Util.ScaleLifeExpectance(74.78f),Util.ScaleGDPPercapita(17860),  Util.ScaleYear(17)) },
            { 1993, new Vector3(Util.ScaleLifeExpectance(74.84f),Util.ScaleGDPPercapita(18615),  Util.ScaleYear(18)) },
            { 1994, new Vector3(Util.ScaleLifeExpectance(74.9f),Util.ScaleGDPPercapita(19546),  Util.ScaleYear(19)) },
            { 1995, new Vector3(Util.ScaleLifeExpectance(74.96f),Util.ScaleGDPPercapita(20416),  Util.ScaleYear(20)) },
            { 1996, new Vector3(Util.ScaleLifeExpectance(75.02f),Util.ScaleGDPPercapita(20828),  Util.ScaleYear(21)) },
            { 1997, new Vector3(Util.ScaleLifeExpectance(75.08f),Util.ScaleGDPPercapita(21069),  Util.ScaleYear(22)) },
            { 1998, new Vector3(Util.ScaleLifeExpectance(75.14f),Util.ScaleGDPPercapita(22592),  Util.ScaleYear(23)) },
            { 1999, new Vector3(Util.ScaleLifeExpectance(75.2f),Util.ScaleGDPPercapita(23487),  Util.ScaleYear(24)) },
            { 2000, new Vector3(Util.ScaleLifeExpectance(75.26f),Util.ScaleGDPPercapita(24394),  Util.ScaleYear(25)) }
        };

        return position[year];
    }
}
