using FunkySheep.SimpleJSON;
using UnityEngine;

namespace FunkySheep.Types
{
    [CreateAssetMenu(menuName = "FunkySheep/Type/Float")]
    public class Float : Type<System.Single>
    {
        override public JSONNode toJSONNode()
        {
            return (JSONNode)this.value;
        }
        override public void fromJSONNode(JSONNode node)
        {
            value = node.AsFloat;
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