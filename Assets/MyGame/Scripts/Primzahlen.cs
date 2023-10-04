using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Primzahlen : MonoBehaviour
{

    public TMP_InputField InputField;
    public TMP_Text outcome;

    


    public void PruefPrimzahl()
    {
        int zahl;
        if (int.TryParse(InputField.text, out zahl))
        {
            if (IstPrimzahl(zahl))
            {
                outcome.text = "richtig";
            }
            else
            {
                outcome.text = "falsch";
            }
        }
        else
        {
            outcome.text = "ungültige Zahl";
        }
    }

    bool IstPrimzahl(int num)
    {
        if (num <= 1)
        
            return false;

        if (num <= 3)
            return true;
        if (num % 2 == 0 || num % 3 == 0)
            return false;
        for(int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }
        return true;
    }
}
