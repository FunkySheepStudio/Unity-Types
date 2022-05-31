using FunkySheep.SimpleJSON;
using UnityEngine;

namespace FunkySheep.Types
{
    [CreateAssetMenu(menuName = "FunkySheep/Type/Vector3")]
    public class Vector3 : Type<UnityEngine.Vector3>
    {
        override public JSONNode toJSONNode()
        {
            return (JSONNode)this.value.ToString();
        }
        override public void fromJSONNode(JSONNode node)
        {
            string nodeStr = node.ToString();
            string[] temp = nodeStr.Substring(1, nodeStr.Length - 2).Split(',');
            UnityEngine.Vector3 value = new UnityEngine.Vector3(float.Parse(temp[0]), float.Parse(temp[1]), float.Parse(temp[2]));
            this.value = value;
        }

        public override void OnEnable()
        {
            if (reset)
            {
                this.value = UnityEngine.Vector3.zero;
            }
        }
    }
}