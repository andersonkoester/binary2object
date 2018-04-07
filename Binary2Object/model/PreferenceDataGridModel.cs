namespace Binary2Object.model {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.Serialization;

    [Serializable()]
    public class PreferenceDataGridModel {

        public string Name { get; set; }
        public int Index { get; set; }
        public bool Visible { get; set; }

    }
}
