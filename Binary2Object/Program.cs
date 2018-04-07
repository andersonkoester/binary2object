using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary2Object {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            //List<model.PreferenceDataGridModel> list = new List<model.PreferenceDataGridModel>();
            //list.Add(new model.PreferenceDataGridModel { Name = "NO_ORDEM", Index = 0, Visible = true });
            //list.Add(new model.PreferenceDataGridModel { Name = "NM_PRODUTO", Index = 1, Visible = true });
            //list.Add(new model.PreferenceDataGridModel { Name = "DS_VERSAO", Index = 2, Visible = true });
            //list.Add(new model.PreferenceDataGridModel { Name = "DS_CLIENTE", Index = 3, Visible = true });
            //list.Add(new model.PreferenceDataGridModel { Name = "DT_CRIADO", Index = 4, Visible = false });
            //list.Add(new model.PreferenceDataGridModel { Name = "DT_ALTERADO", Index = 5, Visible = false });
            //list.Add(new model.PreferenceDataGridModel { Name = "NM_USUARIO", Index = 6, Visible = false });

            //try {
            //    using (var context = new domain.Context()) {
            //        byte[] prefData;
            //        using (MemoryStream ms = new MemoryStream()) {
            //            BinaryFormatter formatter = new BinaryFormatter();
            //            formatter.Serialize(ms, list);

            //            ms.Position = 0;
            //            prefData = ms.ToArray();

            //        }

            //        var uPref = new domain.UsuarioPreferenciaDomain {
            //            ID_Usuario = 1,
            //            ID_Programa = "PROG001",
            //            DS_Tipo = "DataGridView",
            //            NM_Objeto = "dgvOrdems",
            //            OB_Valor = prefData
            //        };

            //        context.UsuarioPreferencia.Add(uPref);
            //        context.SaveChanges();
            //    }

                
            //} catch (DbEntityValidationException e) {
            //    foreach (var eve in e.EntityValidationErrors) {
            //        Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors) {
            //            Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
