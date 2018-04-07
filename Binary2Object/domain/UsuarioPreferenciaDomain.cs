namespace Binary2Object.domain {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Table("TUsuarioPreferencia")]
    public partial class UsuarioPreferenciaDomain {

        [Key]
        public int ID { get; set; }

        public int ID_Usuario { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_Programa { get; set; }

        [Required]
        [StringLength(50)]
        public string DS_Tipo { get; set; }

        [StringLength(50)]
        public string NM_Objeto { get; set; }

        public byte[] OB_Valor { get; set; }

        public List<model.PreferenceDataGridModel> DataGridPreference {
            get {
                if (DS_Tipo.Equals("DataGridView")) {
                    using (MemoryStream ms = new MemoryStream(OB_Valor)) {
                        BinaryFormatter formatter = new BinaryFormatter();
                        List<model.PreferenceDataGridModel> datagrid = (List<model.PreferenceDataGridModel>)formatter.Deserialize(ms);
                        return datagrid;
                    }
                }
                return null;
            }
        }
    }
}
