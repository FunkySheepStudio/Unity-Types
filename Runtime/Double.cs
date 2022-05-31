using FunkySheep.SimpleJSON;
using UnityEngine;

namespace FunkySheep.Types
{
    [CreateAssetMenu(menuName = "FunkySheep/Type/Double")]
    public class Double : Type<System.Double>
    {
        override public JSONNode toJSONNode()
        {
            return (JSONNode)this.value;
        }
        override public void fromJSONNode(JSONNode node)
        {
            value = node.AsDouble;
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