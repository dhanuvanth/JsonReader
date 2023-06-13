using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class JsonHelper
{
    [Serializable]
    public class food
    {
        public Items items;
    }

    [Serializable]
    public class Items
    {
        public Item[] item;
    }

    [Serializable]
    public class Item
    {
        public string id;
        public string type;
        public string name;
        public float ppu;
        public Batter batters;
        public Info[] topping;
    }

    [Serializable]
    public class Batter
    {
        public Info[] batter;
    }

    //Info for id and type
    [Serializable]
    public class Info
    {
        public string id;
        public string type;
    }
}
