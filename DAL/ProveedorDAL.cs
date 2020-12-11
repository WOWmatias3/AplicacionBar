using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
	public class ProveedorDAL
	{
        public int Id_proveedor { get; set; }
        public String Nombre_proveedor { get; set; }
        public int Fono_proveedor { get; set; }
        public String Mail_proveedor { get; set; }
        public String Direccion_proveedor { get; set; }
        public String Descripcion { get; set; }

        public static ProveedorDAL instance = null;

        public ProveedorDAL()
        {

        }

        public static ProveedorDAL Getinstancia()
        {
            if (instance == null)
            {
                instance = new ProveedorDAL();
            }
            return instance;
        }

        public ProveedorDAL(int id_proveedor,
        String nombre_proveedor,
        int fono_proveedor,
        String mail_proveedor,
        String direccion_proveedor,
        String descripcion)

        {
            this.Id_proveedor = id_proveedor;
            this.Nombre_proveedor = nombre_proveedor;
            this.Fono_proveedor = fono_proveedor;
            this.Mail_proveedor = mail_proveedor;
            this.Direccion_proveedor = direccion_proveedor;
            this.Descripcion = descripcion;
        }

        public DataTable GetAllBebi()
        {
            using (OracleConnection con = new Conexion().conexion())
            {
                OracleCommand cm = new OracleCommand("get_allproveedor", con);
                cm.BindByName = true;
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                OracleParameter output = cm.Parameters.Add("my_cursor", OracleDbType.RefCursor);
                output.Direction = System.Data.ParameterDirection.ReturnValue;
                con.Open();
                cm.ExecuteNonQuery();

                OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();
                con.Close();
                using (DataTable dt = new DataTable())
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(cm);
                    adapter.Fill(dt);
                    return dt;

                }
            }

        }
    }
}
