using System.Collections.Generic;
using UnityEngine;

public class RoundsContainer : MonoBehaviour
{
    Dictionary<string, int> _rounds = new Dictionary<string, int>();

    private void Awake()
    {
        _rounds.Add("VanDammeVsSchwarz", 1);
        _rounds.Add("VanDammeVsStallone", 2);
        _rounds.Add("VanDammeVsChan", 3);
        _rounds.Add("VanDammeVsDolf", 4);
        _rounds.Add("VanDammeVsSeagal", 5);

        _rounds.Add("SchwarzVsVanDamme", 6);
        _rounds.Add("SchwarzVsStallone", 7);
        _rounds.Add("SchwarzVsChan", 8);
        _rounds.Add("SchwarzVsDolf", 9);
        _rounds.Add("SchwarzVsSeagal", 10);

        _rounds.Add("StalloneVsVanDamme", 11);
        _rounds.Add("StalloneVsSchwarz", 12);
        _rounds.Add("StalloneVsChan", 13);
        _rounds.Add("StalloneVsDolf", 14);
        _rounds.Add("StalloneVsSeagal", 15);

        _rounds.Add("ChanVsVanDamme", 16);
        _rounds.Add("ChanVsSchwarz", 17);
        _rounds.Add("ChanVsStallone", 18);
        _rounds.Add("ChanVsDolf", 19);
        _rounds.Add("ChanVsSeagal", 20);

        _rounds.Add("DolfVsVanDamme", 21);
        _rounds.Add("DolfVsSchwarz", 22);
        _rounds.Add("DolfVsStallone", 23);
        _rounds.Add("DolfVsChan", 24);
        _rounds.Add("DolfVsSeagal", 25);

        _rounds.Add("SeagalVsVanDamme", 26);
        _rounds.Add("SeagalVsSchwarz", 27);
        _rounds.Add("SeagalVsStallone", 28);
        _rounds.Add("SeagalVsChan", 29);
        _rounds.Add("SeagalVsDolf", 30);
    }

    public int GetRoundNumb(int one, int two)
    {
        string key = (Characters)one + "Vs" + (Characters)two;
        Debug.Log(key);
        return _rounds[key];
    }
}

public enum Characters
{
    VanDamme,
    Schwarz,
    Stallone,
    Chan,
    Dolf,
    Seagal
}
