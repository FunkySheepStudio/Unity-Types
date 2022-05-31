using FunkySheep.SimpleJSON;
using UnityEngine;

namespace FunkySheep.Types
{
    [CreateAssetMenu(menuName = "FunkySheep/Type/Int32")]
    public class Int32 : Type<System.Int32>
    {
        override public JSONNode toJSONNode()
        {
            return (JSONNode)this.value;
        }
        override public void fromJSONNode(JSONNode node)
        {
            value = node.AsInt;
        }
        public override void OnEnable()
        {
            if (reset)
            {
                value = 0;
            }
        }
    }
}