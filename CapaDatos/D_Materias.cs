using CapaEntidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos {
    public class D_Materias {
        public void Nueva(Materias materias) {
            using (var conn = ConexionSql.GetConnection()) {
                conn.Execute("SP_materia_nueva",
                new {
                    detalle = materias.Detalle,
                    costo = materias.Costo,
                    aula = materias.Aula,
                    horario = materias.Horario
                }, commandType: CommandType.StoredProcedure);
            }
        }
        public void Modificar(Materias materias) {
            using (var conn = ConexionSql.GetConnection()) {
                conn.Execute("SP_materia_modificar",
                    new {
                        idMateria = materias.IdMateria,
                        detalle = materias.Detalle,
                        costo = materias.Costo,
                        aula = materias.Aula,
                        horario = materias.Horario
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
        public List<Materias> GetMaterias(string detalle) {
            using (var conn = ConexionSql.GetConnection()) {
                return conn.Query<Materias>("SP_materia_lista",
                    new { detalle }, 
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
