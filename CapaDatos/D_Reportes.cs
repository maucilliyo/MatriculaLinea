using Dapper;
using System.Data;

namespace CapaDatos {
    public class D_Reportes {
        public DataTable Usarios(bool activo,string nombre) { 
            DataTable data= new DataTable();
            using (var conn = ConexionSql.GetConnection()) {
                var reader = conn.ExecuteReader("SP_Reporte_Usuarios", new { activo, nombre },commandType:CommandType.StoredProcedure);
                data.Load(reader);
            }
            return data;
        }
        public DataTable Ofertas(string idOferta) {
            DataTable data = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {
                var reader = conn.ExecuteReader("SP_reporte_ofertas", new { idOferta }, commandType: CommandType.StoredProcedure);
                data.Load(reader);
            }
            return data;
        }
        public DataTable NotasEstudiantes(string idAlumno) {
            DataTable data = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {
                var reader = conn.ExecuteReader("SP_reporte_notas_estudiante", 
                                                new { idAlumno }, 
                                                commandType: CommandType.StoredProcedure);
                data.Load(reader);
            }
            return data;
        }
        public DataTable Profesores(string nombre, bool Activo) {
            DataTable data = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {
                var reader = conn.ExecuteReader("SP_reporte_profesores",
                                                new { nombre, Activo },
                                                commandType: CommandType.StoredProcedure);
                data.Load(reader);
            }
            return data;
        }
        public DataTable Aulas( string estado) {
            DataTable data = new DataTable();
            using (var conn = ConexionSql.GetConnection()) {
                var reader = conn.ExecuteReader("SP_Reporte_aulas",
                                                new { estado },
                                                commandType: CommandType.StoredProcedure);
                data.Load(reader);
            }
            return data;
        }
    }
}
