using CapaEntidades;
using Dapper;
using System;
using System.Data;

namespace CapaDatos {
    public  class D_profesores {
        public void Nuevo(ProfesorMaterias profesorMaterias) {
            try {
                using (var conn = ConexionSql.GetConnection()) { 
                    conn.Open();
                    conn.Execute("SP_profesor_nuevo", 
                        new { profesorMaterias.Id_profesor,
                              profesorMaterias.Id_materia
                        }, commandType:CommandType.StoredProcedure);
                }
            }
            catch (Exception ex) {

                throw new Exception(ex.Message);
            }
        }
        public DataTable Lista() {
            DataTable dataTable = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {

                var response = conn.ExecuteReader("SP_profesor_lista",commandType: CommandType.StoredProcedure);
                dataTable.Load(response);
            }
            return dataTable;
        }
        public DataTable lista_alumnos(string idProfesor) {
            DataTable dataTable = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {

                var response = conn.ExecuteReader("SP_profesores_alumnos",
                                                  new { idProfesor },
                                                  commandType:CommandType.StoredProcedure);
                dataTable.Load(response);
            }
            return dataTable;
        }
        public DataTable lista_materias(string idProfesor) {
            DataTable dataTable = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {

                var response = conn.ExecuteReader("SP_profesores_materias",
                                                  new { idProfesor },
                                                  commandType: CommandType.StoredProcedure);
                dataTable.Load(response);
            }
            return dataTable;
        }
    }
}
