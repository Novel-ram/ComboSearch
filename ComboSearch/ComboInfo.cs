using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboSearch
{
    public class ComboInfo
    {
        public string Combo { get; set; } = "";

        public string Damage { get; set; } = "";

        public string CategoryCombo { get; set; } = "";

        public string Attribute { get; set; } = "";

        public string Note { get; set; } = "";

        /// <summary>
        /// アイテム名を表示する
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return Combo;  
        }
    }
}
