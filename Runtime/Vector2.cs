using FunkySheep.SimpleJSON;
using UnityEngine;

namespace FunkySheep.Types
{
    [CreateAssetMenu(menuName = "FunkySheep/Type/Vector2")]
    public class Vector2 : Type<UnityEngine.Vector2>
    {
        override public JSONNode toJSONNode()
        {
            return (JSONNode)this.value.ToString();
        }
        override public void fromJSONNode(JSONNode node)
        {
            string nodeStr = node.ToString();
            string[] temp = nodeStr.Substring(1, nodeStr.Length - 2).Split(',');
            UnityEngine.Vector2 value = new UnityEngine.Vector2(float.Parse(temp[0]), float.Parse(temp[1]));
            this.value = value;
        }

        public override void OnEnable()
        {
            if (reset)
            {
                this.value = UnityEngine.Vector2.zero;
            }
        }
    }
}