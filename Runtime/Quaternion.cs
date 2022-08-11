using FunkySheep.SimpleJSON;
using UnityEngine;

namespace FunkySheep.Types
{
    [CreateAssetMenu(menuName = "FunkySheep/Type/Quaternion")]
    public class Quaternion : Type<UnityEngine.Quaternion>
    {
        override public JSONNode toJSONNode()
        {
            return (JSONNode)this.value.ToString();
        }
        override public void fromJSONNode(JSONNode node)
        {
            string nodeStr = node.ToString();
            string[] temp = nodeStr.Substring(1, nodeStr.Length - 2).Split(',');
            UnityEngine.Quaternion value = new UnityEngine.Quaternion(float.Parse(temp[0]), float.Parse(temp[1]), float.Parse(temp[2]), float.Parse(temp[3]));
            this.value = value;
        }

        public override void OnEnable()
        {
            if (reset)
            {
                this.value = UnityEngine.Quaternion.identity;
            }
        }
    }
}