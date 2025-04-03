using ComboSearch;
using ComboSerch.Parameter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboSerch
{
    public partial class ComboEdit : Form
    {
        public CharacterParameter CharacterParameter = new CharacterParameter();

        public List<ComboInfo> ParameterList = new List<ComboInfo>();

        public ComboEdit()
        {

            InitializeComponent();
        }

        
    }
}
