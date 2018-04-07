using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary2Object {
    public partial class Form : System.Windows.Forms.Form {
        public Form() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {
            using(var context = new domain.Context()) {
                var uPref = context.UsuarioPreferencia.FirstOrDefault();
                if( uPref.DataGridPreference != null) {
                    List<model.PreferenceDataGridModel> datagrid = uPref.DataGridPreference;
                    foreach(var data in datagrid) {
                        Console.WriteLine($"{data.Name} - {data.Index} - {data.Visible}");
                    }
                }
            }
        }
    }
}
