using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Syspox_Cobros
{
    class data
    {
        static string db = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\RIKU.FDB";
        SqlConnection con = new SqlConnection(@"Server="+Syspox_Cobros.Properties.Settings.Default.servername+";Database=syspox;User Id=syspox;Password=syspox1234;");
        public string activeUserId = "No Identificado";

        public string moneyFormat(string amount)
        {
            amount = amount.Replace("RD$:", "");
            decimal moneyvalue = decimal.Parse(amount);
            string h = moneyvalue.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            return "RD" + h;
        }

        public string VersionLabel
        {
            get
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name).ToUpper();
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name).ToUpper();
                }
            }
        }

        internal string getSingleField(string campo,string table,string conditionals)
        {
            try
            {
                if (conditionals == string.Empty)
                {
                    conditionals = "1=1";
                }
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select top (1)"+campo+" from "+table+" where "+conditionals+";";
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dl = new DataTable();
                adaptador.Fill(dl);
                if (dl.Rows.Count == 1)
                {
                    string tipo = dl.Rows[0][0].ToString().ToUpper();
                    return tipo;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        internal string getCustomerId(string cedula)
        {
            try
            {
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select id from clientes where cedula= '" + cedula+"'";
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dl = new DataTable();
                adaptador.Fill(dl);
                if (dl.Rows.Count == 1)
                {
                    string nombre = dl.Rows[0][0].ToString().ToUpper();
                   
                    return nombre;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        internal string getAdressMonto(string id)
        {
            try
            {
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select monto from direcciones where id=" + id;
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dl = new DataTable();
                adaptador.Fill(dl);
                if (dl.Rows.Count == 1)
                {
                    string nombre = dl.Rows[0][0].ToString().ToUpper();
                    return nombre;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        internal string getAdress(string id)
        {
            try
            {
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select nombre,calle,numero,manzana,sector,municipio,monto,comentarios from direcciones where id="+id;
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dl = new DataTable();
                adaptador.Fill(dl);
                if (dl.Rows.Count == 1)
                {
                    string nombre = dl.Rows[0][0].ToString().ToUpper();
                    string calle = dl.Rows[0][1].ToString().ToUpper();
                    string numero = dl.Rows[0][2].ToString().ToUpper();
                    string sector = dl.Rows[0][4].ToString().ToUpper();
                    string municipio = dl.Rows[0][5].ToString().ToUpper();
                    return nombre+" - "+calle+" numero "+numero+", "+sector+". "+municipio;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        public bool probar()
        {
            try
            {
                this.abrir();
                this.cerrar();
                return true;
            }
            catch (Exception ex)
            {
                string p = ex.ToString();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

       

        public string rnc(string campo)
        {
            return campo;
        }

        public void borrarTabla(string tabla)
        {
            try
            {
                string query = "delete from " + tabla + ";";
                abrir();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = query;
                comando.Connection = ver();
                comando.ExecuteNonQuery();
                cerrar();

            }
            catch (Exception ex)
            {
                showError(ex);
            }
            finally
            {
                cerrar();
            }
        }

        public void delete(string tabla, string conditionals)
        {
            try
            {
                if (conditionals == "")
                {
                    return;
                }
                else
                {
                    string query = "delete from " + tabla + " where " + conditionals + ";";
                    abrir();
                    SqlCommand comando = new SqlCommand();
                    comando.CommandText = query;
                    comando.Connection = ver();
                    comando.ExecuteNonQuery();
                    cerrar();
                }

            }
            catch (Exception ex)
            {
                showError(ex);
            }
            finally
            {
                cerrar();
            }
        }



        public List<string> getUserInfo(string id)
        {
            try
            {
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select * from usuarios where id = '" + id + "';";
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dl = new DataTable();
                adaptador.Fill(dl);

                if (dl.Rows.Count == 1)
                {
                    //string tipo = dl.Rows[0][0].ToString().ToUpper();
                    var datox = new List<string>();
                    foreach (var ddfrs in dl.Rows)
                    {
                        datox.Add(dl.Rows[0][0].ToString().ToUpper());
                        datox.Add(dl.Rows[0][1].ToString().ToUpper());
                        datox.Add(dl.Rows[0][2].ToString().ToUpper());
                        datox.Add(dl.Rows[0][3].ToString().ToUpper());
                        datox.Add(dl.Rows[0][4].ToString().ToUpper());
                        datox.Add(dl.Rows[0][5].ToString().ToUpper());
                        datox.Add(dl.Rows[0][6].ToString().ToUpper());
                        datox.Add(dl.Rows[0][7].ToString().ToUpper());
                        datox.Add(dl.Rows[0][8].ToString().ToUpper());
                        datox.Add(dl.Rows[0][9].ToString().ToUpper());
                        datox.Add(dl.Rows[0][10].ToString().ToUpper());
                        datox.Add(dl.Rows[0][11].ToString().ToUpper());
                    }
                    return datox;


                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }
        public List<string> getClienteInfo(string id)
        {
            if (id==null)
            {
                return new List<string>();
            }
            try
            {
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select * from clientes where id = '" + id + "';";
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dl = new DataTable();
                adaptador.Fill(dl);
                if (dl.Rows.Count == 1)
                {
                    List<string> datax = new List<string>();
                    string idd = dl.Rows[0][0].ToString().ToUpper();
                    string cedula = dl.Rows[0][1].ToString().ToUpper();
                    string nombre = dl.Rows[0][2].ToString().ToUpper();
                    string addressid = dl.Rows[0][3].ToString().ToUpper();
                    string telefono = dl.Rows[0][3].ToString().ToUpper();
                    string celular = dl.Rows[0][3].ToString().ToUpper();
                    string comentario = dl.Rows[0][3].ToString().ToUpper();
                    datax.Add(idd);
                    datax.Add(cedula);
                    datax.Add(nombre);
                    datax.Add(addressid);
                    datax.Add(telefono);
                    datax.Add(celular);
                    datax.Add(comentario);
                    return datax;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }
        public string getClienteNombre(string id)
        {
            try
            {
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select nombre from clientes where idcliente = '" + id + "';";
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dl = new DataTable();
                adaptador.Fill(dl);
                if (dl.Rows.Count == 1)
                {
                    string tipo = dl.Rows[0][0].ToString().ToUpper();
                    return tipo;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        public void inform(string texto)
        {
            if (texto.Length >= 1)
            {
                System.Windows.Forms.MessageBox.Show(texto);
            }
        }

        public void showError(Exception f)
        {
            System.Windows.Forms.MessageBox.Show(f.Message);
        }

        public bool saveMultiple(string table, string fields, string values)
        {
            try
            {
                //string sql = "INSERT or REPLACE INTO " + table + " (" + fields + ")VALUES" + values + "";
                string sql = "INSERT INTO " + table + " (" + fields + ")VALUES" + values + "";
                abrir();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = sql;
                comando.Connection = ver();
                comando.ExecuteNonQuery();
                cerrar();
                return true;
            }
            catch (Exception ex)
            {
                showError(ex);
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        public bool save(string table, string fields, string values)
        {
            try
            {
                string sql = "INSERT INTO " + table + " (" + fields + ")VALUES(" + values + ")";
                abrir();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = sql;
                comando.Connection = ver();
                comando.ExecuteNonQuery();
                cerrar();
                return true;
            }
            catch (Exception ex)
            {
                showError(ex);
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        public bool update(string table, string modifications, string conditionals)
        {
            try
            {
                if (conditionals != "")
                {
                    string sql = "update " + table + " set " + modifications + " where " + conditionals;
                    abrir();
                    SqlCommand comando = new SqlCommand();
                    comando.CommandText = sql;
                    comando.Connection = ver();
                    comando.ExecuteNonQuery();
                    cerrar();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                showError(ex);
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        public string[] getContribuyentes(string id)
        {
            try
            {
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select * from contribuyentes where rnc = '" + id + "';";
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dl = new DataTable();
                adaptador.Fill(dl);
                if (dl.Rows.Count == 1)
                {
                    string nombre = dl.Rows[0][1].ToString().ToUpper();
                    string descripcion = dl.Rows[0][2].ToString().ToUpper();
                    string fecha = dl.Rows[0][3].ToString().ToUpper();
                    string estado = dl.Rows[0][4].ToString().ToUpper();
                    string condicion = dl.Rows[0][5].ToString().ToUpper();
                    string[] paquete = { nombre, descripcion, fecha, estado, condicion };
                    return paquete;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        public bool login(string user, string pass)
        {

            try
            {
                if (user == "" || pass == "")
                {
                    return false;
                }
                string mSQL = "select * from users where name = '" + user + "' and pass = '" + pass + "';";
                abrir();
                SqlCommand cmd = new SqlCommand(mSQL, ver());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataReader lector;
                lector = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                foreach (DataRow dtRow in dt.Rows) ;
                Boolean hayRegistros = lector.HasRows;
                if (hayRegistros)
                {
                    //MessageBox.Show("Bienvenido al sistema " + textBox1.Text);
                    cerrar();
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                //string error = Convert.ToString(ex);
                //MessageBox.Show("ERROR         " + error);
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cerrar();
            }
        }

        public void abrir()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            else
            {
                cerrar();
                abrir();
            }
        }
        public void cerrar()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }


        public string selector(string table, string returnField)
        {
            try
            {
                UI.selector formOptions = new UI.selector(table);
                formOptions.ShowDialog();
                if (formOptions.row != null)
                {
                    System.Windows.Forms.DataGridViewRow myString = formOptions.row;
                    return myString.Cells[returnField].Value.ToString();
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public string getTipo(string usuario)
        {
            try
            {
                string id = getIdUsuario(usuario);
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select tipo from usuarios where id = '" + id + "';";
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dl = new DataTable();
                adaptador.Fill(dl);
                if (dl.Rows.Count == 1)
                {
                    string tipo = dl.Rows[0][0].ToString().ToUpper();
                    return tipo;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string getIdUsuario(string usuario)
        {
            try
            {
                if (usuario != null)
                {
                    abrir();
                    DataTable dt = new DataTable();
                    string consulta = "select id from usuarios where usuario = '" + usuario + "';";
                    SqlCommand comando = new SqlCommand(consulta, ver());
                    SqlDataAdapter adap = new SqlDataAdapter(comando);
                    DataTable ff = new DataTable();
                    adap.Fill(ff);
                    if (ff.Rows.Count == 1)
                    {
                        string id = ff.Rows[0][0].ToString();
                        return id;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string getModuloById(string id)
        {
            try
            {
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select name from modulos where id = '" + id + "';";
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                DataTable ff = new DataTable();
                adap.Fill(ff);
                if (ff.Rows.Count == 1)
                {
                    string name = ff.Rows[0][0].ToString();
                    return name;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string getModuleIdByname(string name)
        {
            try
            {
                abrir();
                DataTable dt = new DataTable();
                string consulta = "select id from modulos where name = '" + name + "';";
                SqlCommand comando = new SqlCommand(consulta, ver());
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                DataTable ff = new DataTable();
                adap.Fill(ff);
                if (ff.Rows.Count == 1)
                {
                    string id = ff.Rows[0][0].ToString();
                    return id;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }






        public bool isAdmin(string usuario)
        {
            try
            {
                if (usuario == string.Empty || usuario == null)
                {
                    return false;
                }
                //string comando = "select * from usuarios where ;", connect;
                abrir();
                SqlCommand command = new SqlCommand("select * from usuarios where usuario = '" + usuario + "';", ver());
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    string field = dt.Rows[0][3].ToString();
                    if (field.ToLower() == "administrador")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {

                    Exception rr = new Exception("Este usuario tiene duplicidad en la base de datos.");
                    System.Windows.Forms.MessageBox.Show(rr.Message);
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cerrar();
            }
        }



        public bool checkInter()
        {
            bool connection = NetworkInterface.GetIsNetworkAvailable();
            bool acceso = false;
            if (connection == true)
            {
                acceso = true;
            }
            else
            {
                acceso = false;
            }
            return acceso;
        }


        public SqlConnection ver()
        {
            return con;
        }

        public int getCount(string table, string conditionals)
        {
            try
            {
                if (conditionals == string.Empty)
                {
                    conditionals = " where 1=1;";
                }
                else
                {
                    conditionals = " where " + conditionals;
                }
                abrir();
                //SqlCommand comm = new SqlCommand("SELECT * FROM "+table+conditionals, ver()) ;
                ////Int32 countk = (Int32)comm.ExecuteScalar();
                //int count = Convert.ToInt32(comm.ExecuteScalar());
                //return count;
                SqlCommand cmd = new SqlCommand("select count(*) from " + table + conditionals, ver());
                int kount = Convert.ToInt32(cmd.ExecuteScalar());
                //int total_rows_in_resultset = reader.StepCount;
                int total_rows_in_resultset = kount;
                return total_rows_in_resultset;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("ERROR" + ex.ToString());
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                cerrar();
            }

        }
        public DataTable getTableSPwithAttribute(string sp,string atributeName,string atributeValue)
        {
            try
            {
                DataTable table = new DataTable();
                using (var con = ver())
                using (var cmd = new SqlCommand(sp, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@"+atributeName, SqlDbType.VarChar, 30).Value = atributeValue;
                    da.Fill(table);
                }
                return table;
            }
            catch (SqlException fbex)
            {
                //throw fbex;
                showError(fbex);
                return null;
            }
            finally
            {
                cerrar();
            }
        }
        public DataTable getTableSP(string sp)
        {
            try
            {
                DataTable table = new DataTable();
                using (var con = ver())
                using (var cmd = new SqlCommand(sp, con))                
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.Fill(table);
                }
                return table;
            }
            catch (SqlException fbex)
            {
                //throw fbex;
                showError(fbex);
                return null;
            }
            finally
            {
                cerrar();
            }
        }


        public DataTable getTableCustomQuery(string query)
        {
            try
            {

                abrir();
                string mSQL = query;
                SqlCommand cmd = new SqlCommand(mSQL, ver());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException fbex)
            {
                //throw fbex;
                showError(fbex);
                return null;
            }
            finally
            {
                cerrar();
            }
        }

        public DataTable getTable(string table, string conditionals)
        {
            try
            {
                if (conditionals == string.Empty)
                {
                    conditionals = "1=1";
                }

                abrir();
                string mSQL = "Select * from " + table + " where " + conditionals;
                SqlCommand cmd = new SqlCommand(mSQL, ver());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException fbex)
            {
                //throw fbex;
                showError(fbex);
                return null;
            }
            finally
            {
                cerrar();
            }
        }


    
}
}
