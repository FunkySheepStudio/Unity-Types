using FunkySheep.SimpleJSON;
using UnityEngine;

namespace FunkySheep.Types
{
    [CreateAssetMenu(menuName = "FunkySheep/Type/String")]
    public class String : Type<System.String>
    {
        /// <summary>
        /// Interpolate au string passing it the variables to replace
        /// </summary>
        /// <param name="variables">The values to set/param>
        /// <param name="names">The names in the interpolated string to replace</param>
        /// <returns></returns>
        public string Interpolate(string[] variables, string[] names)
        {
            string interpolatedValue = this.value;
            for (int i = 0; i < variables.Length; i++)
            {
                interpolatedValue = interpolatedValue.Replace("{" + names[i] + "}", variables[i]);
            }
            return interpolatedValue;
        }

        override public JSONNode toJSONNode()
        {
            return (JSONNode)this.value;
        }
        override public void fromJSONNode(JSONNode node)
        {
            this.value = node.ToString();
        }
        public override void OnEnable()
        {
            if (reset)
            {
                this.value = null;
            }
        }
    }
}