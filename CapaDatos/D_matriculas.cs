using CapaEntidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos {
    public class D_matriculas {
        public void Nueva(Matricula matricula) {
            using (var conn = ConexionSql.GetConnection()) {
                conn.Open();
                using (var Transaction = conn.BeginTransaction()) {
                    try {
                        //
                        conn.Execute("SP_matricula_nueva",
                                 new {
                                     matricula.Id_estudiante,
                                     matricula.Periodo,
                                     matricula.Monto
                                 },
                                 commandType: CommandType.StoredProcedure,
                                 transaction: Transaction);
                        //
                        foreach (var materia in matricula.Materias) {
                            //MATERIAS MATRICULA
                            conn.Execute("SP_matricula_materia_nueva",
                                new {
                                    materia.IdMateria,
                                    materia.Aula
                                },
                                commandType: CommandType.StoredProcedure,
                                transaction: Transaction);
                            //MATERIAS ESTUDIANTE
                            conn.Execute("SP_alumnos_materias_nuevo",
                                new {
                                    matricula.Id_estudiante,
                                    materia.IdMateria
                                },
                                commandType: CommandType.StoredProcedure,
                                transaction: Transaction);
                        }
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
