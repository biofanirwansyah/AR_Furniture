using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void menu_meja()
    {
        Application.LoadLevel("menumeja");
    }

    public void menu_kursi()
    {
        Application.LoadLevel("menukursi");
    }

    public void menu_kasur()
    {
        Application.LoadLevel("menukasur");
    }

    public void menu_lemari()
    {
        Application.LoadLevel("menulemari");
    }

    public void menu_utama()
    {
        Application.LoadLevel("menuutama");
    }
}
