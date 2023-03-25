using CapaEntidades;
using Dapper;
using System.Data;

namespace CapaDatos {
    public class D_estudiantes {
        public void Nuevo() {
            using (var conn = ConexionSql.GetConnection()) {
                conn.Open();
                conn.Execute("SP_estudiante_nuevo",
                    commandType: CommandType.StoredProcedure);
            }
        }
        public DataTable Estudiantes(string idUser) {
            DataTable dataTable = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {
                var response = conn.ExecuteReader("SP_estudiantes_lista",
                                       new { idUser },
                                      commandType: CommandType.StoredProcedure);
                dataTable.Load(response);
            }
            return dataTable;
        }
        public DataTable Lista_materias(int id_materia) {
            DataTable data = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {
                conn.Open();
                var dr = conn.ExecuteReader("SP_estudiante_materias",
                    new { id_materia },
                    commandType: CommandType.StoredProcedure);
                data.Load(dr);
            }
            return data;
        }
        public void Actualizar_nota(AlumnosMaterias alumnosMaterias) {
            using (var conn = ConexionSql.GetConnection()) {
                conn.Execute("SP_Actualizar_notas",
                    new { 
                        alumnosMaterias.Id_materia,
                        alumnosMaterias.Id_alumno,
                        alumnosMaterias.Nota
                    },
                    commandType:CommandType.StoredProcedure);
            }
        }
    }
}
