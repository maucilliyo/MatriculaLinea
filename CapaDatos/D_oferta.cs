using CapaEntidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos {
    public class D_oferta {
        public void Nueva(Ofertas ofertas) {
            using (var conn = ConexionSql.GetConnection()) {
                conn.Open();
                using (var Transaction = conn.BeginTransaction()) {
                    try {
                        //INSERTAMOS LA OFERTA
                        conn.Execute("SP_oferta_nueva",
                            new {
                                ofertas.Id_Carrera,
                                ofertas.Id_programa,
                                ofertas.Tipo
                            },
                            commandType: CommandType.StoredProcedure,
                            transaction: Transaction);
                        //INSETAMOS LAS MATERIAS
                        foreach (var materia in ofertas.Materias) {
                            conn.Execute("SP_oferta_materia_nueva",
                                new { materia.Id_materia },
                            commandType: CommandType.StoredProcedure,
                            transaction: Transaction);
                        }

                        //SI TODO SALIO BIEN SE INSERTA
                        Transaction.Commit();
                    }
                    catch (Exception ex) {
                        Transaction.Rollback();
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
    }
}
