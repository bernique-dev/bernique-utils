using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  Source: https://stackoverflow.com/questions/50054786/how-to-serialise-hashset-for-usage-in-inspector

[System.Serializable]
public class Set<T> : List<T> {
    public List<T> values = new List<T>();

    public new void Add(T item) {
        if (!Contains(item)) {
            base.Add(item);
        }
    }

}
