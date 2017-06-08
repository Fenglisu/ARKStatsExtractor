using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKBreedingStats
{
    public class Tribe
    {
        public string TribeName = "";
        public Relation TribeRelation = Tribe.Relation.Neutral;
        public string Note = "";

        public enum Relation
        {
            [Description("中立")]
            Neutral,
            [Description("盟友")]
            Allied,
            [Description("友好")]
            Friendly,
            [Description("敌对")]
            Hostile
        }


    }
}
