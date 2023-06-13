using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    public TextAsset jsonfile;
    public JsonHelper.food helper = new JsonHelper.food();

    // Start is called before the first frame update
    void Start()
    {
        helper = JsonUtility.FromJson<JsonHelper.food>(jsonfile.text);
        print(helper.items.item[0].batters.batter[1].type);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
