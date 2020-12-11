using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
	public class ProveedorBLL
	{

            public int Id_proveedor { get; set; }
            public String Nombre_proveedor { get; set; }
            public int Fono_proveedor { get; set; }
            public String Mail_proveedor { get; set; }
            public String Direccion_proveedor { get; set; }
            public String Descripcion { get; set; }

            public static ProveedorBLL instance = null;

            public ProveedorBLL()
            {

            }

            public static ProveedorBLL Getinstancia()
            {
                if (instance == null)
                {
                    instance = new ProveedorBLL();
                }
                return instance;
            }

            public ProveedorBLL(int id_proveedor,
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

        public DataTable getallBebi()
        {
            ProveedorDAL ingDAL = new ProveedorDAL();
            DataTable dt = ingDAL.GetAllBebi();
            return dt;
        }

    }
}
