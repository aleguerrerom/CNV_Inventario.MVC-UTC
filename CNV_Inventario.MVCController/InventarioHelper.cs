using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CNV_Inventario.MVCModel;
using System.Data;

namespace CNV_Inventario.MVCController
{
    public class InventarioHelper
    {
        Datos cnGeneral = null;
        Inventario objInventario = null;
        DataTable tblDatos = null;


        public InventarioHelper(Inventario parObjInventario)
        {
            objInventario = parObjInventario;
        }
        //RETORA TABLA CON LOS USUARIOS

        public DataTable Listar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objInventario.opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPInventario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        //GUARDA USUARIOS
        public void Guardar()
        {
            try
            {

                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[9];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objInventario.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objInventario.Nombre1;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@tipo";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objInventario.Tipo;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@serialnumber";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objInventario.Serialnumber;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@marca";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objInventario.Marca;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@modelo";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objInventario.Modelo;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@estado";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objInventario.Estado;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@fechamodificacion";
                parParameter[7].SqlDbType = SqlDbType.DateTime;
                parParameter[7].SqlValue = objInventario.Fechamodificacion;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@usuario";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = objInventario.Usuario;

                cnGeneral.EjecutarSP(parParameter, "SPInventario");



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }


        public void Actualizar()
        {

            try
            {
                cnGeneral = new Datos();


                SqlParameter[] parParameter = new SqlParameter[9];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objInventario.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objInventario.Nombre1;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@tipo";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objInventario.Tipo;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@serialnumber";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 50;
                parParameter[3].SqlValue = objInventario.Serialnumber;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@marca";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objInventario.Marca;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@modelo";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objInventario.Modelo;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@estado";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objInventario.Estado;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@fechamodificacion";
                parParameter[7].SqlDbType = SqlDbType.DateTime;
                parParameter[7].SqlValue = objInventario.Fechamodificacion;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@usuario";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = objInventario.Usuario;


                cnGeneral.EjecutarSP(parParameter, "SPInventario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public void Eliminar()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objInventario.opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = objInventario.Usuario;

                cnGeneral.EjecutarSP(parParameter, "SPInventario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        
    }
}
