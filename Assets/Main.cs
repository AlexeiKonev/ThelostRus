using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate string GetNameDelegate();

public class Main : MonoBehaviour
{
    public static Main Instance;

    public List<Transport> TransportList;

    public Action action;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;

        }

        TransportList = new List<Transport>();
        TransportList.Add(new Aeroplane());
        TransportList.Add(new Train());

        foreach (var t in TransportList)
        {


            action += t.Move;

            Debug.Log("subscribe " + t.GetNameDel.Invoke());


        }

        Instance.action += Move;


    }

    // Update is called once per frame
    void Update()
    {
        ///при однократном нажатии
        if (Input.GetKeyDown(KeyCode.Space))
        {
            action.Invoke();

        }
    }
    public void Move()
    {
        Debug.Log("событие движ");
    }
}

public abstract class Transport : IMove
{
    public GetNameDelegate GetNameDel { get; set; }
    public abstract string GetName();

    public abstract void Move();

}
public class Aeroplane : Transport
{
    public string Name = "plane";
    public Aeroplane()
    {
        GetNameDel = GetName;
    }
    public override void Move()
    {
        Debug.Log("я самолет лечу!");
    }
    public override string GetName()
    {
        return Name;
    }
}
public class Train : Transport
{
    public string Name = "train";
    public Train()
    {
        GetNameDel = GetName;
    }

    public override void Move()
    {
        Debug.Log("я поезд я тыкдык тыкдык!");
    }
    public override string GetName()
    {
        return Name;
    }
}
public interface IMove
{

}