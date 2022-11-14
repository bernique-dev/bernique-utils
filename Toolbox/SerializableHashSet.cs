using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  Source: https://stackoverflow.com/questions/50054786/how-to-serialise-hashset-for-usage-in-inspector

[System.Serializable]
public class SerializableHashSet<T> : HashSet<T>, ISerializationCallbackReceiver {
    public List<T> values = new List<T>();

    public void OnBeforeSerialize() {
        var cur = new HashSet<T>(values);

        foreach (var val in this) {
            if (!cur.Contains(val)) {
                values.Add(val);
            }
        }
    }

    public void OnAfterDeserialize() {
        this.Clear();

        foreach (var val in values) {
            this.Add(val);
        }
    }
}
