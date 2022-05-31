using FunkySheep.SimpleJSON;
using UnityEngine;

namespace FunkySheep.Types
{
    [CreateAssetMenu(menuName = "FunkySheep/Type/Vector2Int")]
    public class Vector2Int : Type<UnityEngine.Vector2Int>
    {
        override public JSONNode toJSONNode()
        {
            return (JSONNode)this.value.ToString();
        }
        override public void fromJSONNode(JSONNode node)
        {
            string nodeStr = node.ToString();
            string[] temp = nodeStr.Substring(1, nodeStr.Length - 2).Split(',');
            UnityEngine.Vector2Int value = new UnityEngine.Vector2Int(int.Parse(temp[0]), int.Parse(temp[1]));
            this.value = value;
        }

        public override void OnEnable()
        {
            if (reset)
            {
                this.value = UnityEngine.Vector2Int.zero;
            }
        }
    }
}