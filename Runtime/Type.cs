using FunkySheep.SimpleJSON;
using UnityEngine;
namespace FunkySheep.Types
{
    public abstract class Type : ScriptableObject
    {
        public string apiName = "";
        public bool reset = false;
        public abstract JSONNode toJSONNode();
        public abstract void fromJSONNode(JSONNode node);
        public abstract void OnEnable();
    }
    public abstract class Type<T> : Type
    {
        public T value;
    }
}