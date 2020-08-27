using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IContenedor
{
    void Meter();
    void Quitar();
}
class Contenedor : IContenedor
{
    //The required method of the interface must be public
    public void Meter()
    {
        Debug.Log("Metiendo");
    }

    public void Quitar()
    {
        Debug.Log("Quitando");
    }
}

class OtroContenedor : IContenedor
{
    //The required method of the interface must be public
    public void Meter()
    {
        Debug.Log("Metiendo");
    }

    public void Quitar()
    {
        Debug.Log("Quitando");
    }

    private void OtherFunction()
    {
        Debug.Log("Another func");
    }
}

class Test1Interfaces : MonoBehaviour
{
    void Start()
    {
        IContenedor ic = new Contenedor();
        Contenedor c = new Contenedor();
        OtroContenedor oc = new OtroContenedor();
        Test1(ic);
        Test1(c);
        Test1(oc);
    }

    public void Test1(IContenedor c)
    {
        c.Meter();
        c.Quitar();
        Debug.Log("Whatever");
    }
}
