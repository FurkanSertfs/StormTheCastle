using UnityEngine;
using System.Collections;
using System.Collections.Generic;



    [CreateAssetMenu(menuName = "Managers/ResourcesManager")]
    public class ResourcesManager : ScriptableObject
    {
    public int SLM;
}


/*
 * 
    public List<Guns> allItems = new List<Guns>();
    Dictionary<string, Guns> itemDict = new Dictionary<string, Guns>();



    public void Init()
    {
        for (int i = 0; i < allItems.Count; i++)
        {
            if (!itemDict.ContainsKey(allItems[i].name))
            {
                itemDict.Add(allItems[i].name, allItems[i]);
            }
            else
                Debug.LogError("Bu isimde birden çok item var " + allItems[i].name);
        }
    }

    public Guns GetItemInstance(string targetID)
    {
    Guns defaultItem = GetItem(targetID);
    Guns newItem = Instantiate(defaultItem);
        newItem.name = defaultItem.name;

        return newItem;
    }




Guns GetItem(string targetID)
    {
    Guns retVal;
        itemDict.TryGetValue(targetID, out retVal);

        return retVal;
    }
 */
