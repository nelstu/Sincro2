using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using System.Diagnostics;

namespace Sincro2
{
    class Test
    {
       

            public static void leerxml(string beginpath,string dxml,string dsal,string ip, string user, string pa, string database)
            {
                Test tm0 = new Test();
                XmlDocument xDoc = new XmlDocument();
                String fi = dxml+ beginpath;
                String fiout = dsal + beginpath;
                xDoc.Load(fi);
            XmlNodeList xDte1 = xDoc.GetElementsByTagName("Adicional");
            XmlNodeList xDte = xDoc.GetElementsByTagName("Encabezado");
                XmlNodeList xFolio = ((XmlElement)xDte[0]).GetElementsByTagName("Folio");
                XmlNodeList xFchEmis = ((XmlElement)xDte[0]).GetElementsByTagName("FchEmis");
            XmlNodeList xFchVenc = ((XmlElement)xDte[0]).GetElementsByTagName("FchVenc");
            XmlNodeList xTipoDTE = ((XmlElement)xDte[0]).GetElementsByTagName("TipoDTE");

            XmlNodeList xTipoDespacho = ((XmlElement)xDte[0]).GetElementsByTagName("TipoDespacho");
            XmlNodeList xIndTraslado = ((XmlElement)xDte[0]).GetElementsByTagName("IndTraslado");

            XmlNodeList xRUTRecep = ((XmlElement)xDte[0]).GetElementsByTagName("RUTRecep");
                XmlNodeList xRznSocRecep = ((XmlElement)xDte[0]).GetElementsByTagName("RznSocRecep");
                XmlNodeList xGiroRecep = ((XmlElement)xDte[0]).GetElementsByTagName("GiroRecep");
                XmlNodeList xDirRecep = ((XmlElement)xDte[0]).GetElementsByTagName("DirRecep");
                XmlNodeList xCmnaRecep = ((XmlElement)xDte[0]).GetElementsByTagName("CmnaRecep");
                XmlNodeList xCiudadRecep = ((XmlElement)xDte[0]).GetElementsByTagName("CiudadRecep");

                XmlNodeList xMntNeto = ((XmlElement)xDte[0]).GetElementsByTagName("MntNeto");
                XmlNodeList xIVA = ((XmlElement)xDte[0]).GetElementsByTagName("IVA");
                XmlNodeList xMntTotal = ((XmlElement)xDte[0]).GetElementsByTagName("MntTotal");

            XmlNodeList xPatente = ((XmlElement)xDte[0]).GetElementsByTagName("Patente");
            XmlNodeList xDirDest = ((XmlElement)xDte[0]).GetElementsByTagName("DirDest");
            XmlNodeList xCmnaDest = ((XmlElement)xDte[0]).GetElementsByTagName("CmnaDest");
            XmlNodeList xCiudadDest = ((XmlElement)xDte[0]).GetElementsByTagName("CiudadDest");
            //nodo emisor
            XmlNodeList xCodven= ((XmlElement)xDte[0]).GetElementsByTagName("CdgVendedor");
            XmlNodeList xA1 = ((XmlElement)xDte1[0]).GetElementsByTagName("A1");

            //fin nodo emisor


            string xFol = "";
                string xFch = ""; string xFch2 = "";
            string xrutr = "";
                string xrazonr = "";
                string xdirr = "";
                string xcomr = "";
                string xciur = "";
                string xgirr = "";
                string xTDTE = "";
            string xTipo = "";
            string xInd = "";
            string xneto = ""; string xiv = ""; string xtot = "";
            string xPat = "";string xDirD = "";string xCmnaD = "";string xCiudadD = "";
            string xTpoDoc = ""; string xforef = ""; string xFchR = ""; string xRazRe="";string xCodRe = "";string xA = "";
            string xCodv = "";

            //forma
            foreach (XmlElement nodo in xA1)
            {
                xA = nodo.InnerText;
               // Console.WriteLine(xA);
               // Trace.Indent();
               // Trace.WriteLine("Forma:");
               // Console.WriteLine(xA);
               
               // Trace.Unindent();
               // Trace.Flush();
            }

            //vendedor
            foreach (XmlElement nodo in xCodven)
            {
                xCodv = nodo.InnerText;
                Console.WriteLine(xCodv);
            }
            //folio
            foreach (XmlElement nodo in xFolio)
                {
                    xFol = nodo.InnerText;
                    Console.WriteLine(xFol);
                }

                //fecha emision
                foreach (XmlElement nodo in xFchEmis)
                {
                    xFch = nodo.InnerText;
                    Console.WriteLine(xFch);
                }

            //FchVenc
            //
            foreach (XmlElement nodo in xFchVenc)
            {
                xFch2 = nodo.InnerText;
                Console.WriteLine(xFch2);
            }

            //Tipo DTE
            foreach (XmlElement nodo in xTipoDTE)
                {
                     xTDTE = nodo.InnerText;
                    Console.WriteLine(xTDTE);
                }

            //Tipo Despacho
            foreach (XmlElement nodo in xTipoDespacho)
            {
                xTipo = nodo.InnerText;
                Console.WriteLine(xTipo);
            }
            //Tipo Ind Despacho
            foreach (XmlElement nodo in xIndTraslado)
            {
                xInd = nodo.InnerText;
                Console.WriteLine(xInd);
            }

            //transporte
            foreach (XmlElement nodo in xPatente)
            {
                xPat = nodo.InnerText;
                Console.WriteLine(xPatente);
            }

            foreach (XmlElement nodo in xDirDest)
            {
                xDirD = nodo.InnerText;
                Console.WriteLine(xDirD);
            }


            foreach (XmlElement nodo in xCmnaDest)
            {
                xCmnaD = nodo.InnerText;
                Console.WriteLine(xCmnaD);
            }


            foreach (XmlElement nodo in xCiudadDest)
            {
                xCiudadD = nodo.InnerText;
                Console.WriteLine(xCiudadD);
            }


            //fin transporte






            //Tipo RutReceptor
            foreach (XmlElement nodo in xRUTRecep)
                {
                    xrutr = nodo.InnerText;
                    Console.WriteLine(xrutr);
                }

                //Tipo RazonReceptor
                foreach (XmlElement nodo in xRznSocRecep)
                {
                    xrazonr = nodo.InnerText;
                    Console.WriteLine(xrazonr);
                }

                //Tipo Giro
                foreach (XmlElement nodo in xGiroRecep)
                {
                    xgirr = nodo.InnerText;
                    Console.WriteLine(xgirr);
                }


                //Tipo Direccion
                foreach (XmlElement nodo in xDirRecep)
                {
                    xdirr = nodo.InnerText;
                    Console.WriteLine(xdirr);
                }

                //Tipo Comuna
                foreach (XmlElement nodo in xCmnaRecep)
                {
                    xcomr = nodo.InnerText;
                    Console.WriteLine(xcomr);
                }

                //Tipo Ciudad
                foreach (XmlElement nodo in xCiudadRecep)
                {
                    xciur = nodo.InnerText;
                    Console.WriteLine(xciur);
                }


                //Tipo Neto
                foreach (XmlElement nodo in xMntNeto)
                {
                    xneto = nodo.InnerText;
                    Console.WriteLine(xneto);
                }

                //Tipo Iva
                foreach (XmlElement nodo in xIVA)
                {
                    xiv = nodo.InnerText;
                    Console.WriteLine(xiv);
                }

                //Tipo Total
                foreach (XmlElement nodo in xMntTotal)
                {
                    xtot = nodo.InnerText;
                    Console.WriteLine(xtot);
                }
            if (String.Equals(xTDTE, "61") || String.Equals(xTDTE, "33"))
            {
                Console.WriteLine("Si ahi Referencia");
                //referencia
                XmlNodeList xRef = xDoc.GetElementsByTagName("Referencia");
                if (xRef.Count!=0) {

                XmlNodeList xTpoDocRef = ((XmlElement)xRef[0]).GetElementsByTagName("TpoDocRef");
                foreach (XmlElement nodo in xTpoDocRef)
                {
                    xTpoDoc = nodo.InnerText;
                    Console.WriteLine(xTpoDoc);
                }
              


            XmlNodeList xFolioRef = ((XmlElement)xRef[0]).GetElementsByTagName("FolioRef");

                foreach (XmlElement nodo in xFolioRef)
                {
                    xforef = nodo.InnerText;
                    Console.WriteLine(xforef);
                }

                XmlNodeList xFchRef = ((XmlElement)xRef[0]).GetElementsByTagName("FchRef");
                foreach (XmlElement nodo in xFchRef)
                {
                    xFchR = nodo.InnerText;
                    Console.WriteLine(xFchR);
                }


                    XmlNodeList xCodRef = ((XmlElement)xRef[0]).GetElementsByTagName("CodRef");
                    foreach (XmlElement nodo in xCodRef)
                    {
                        xCodRe = nodo.InnerText;
                        Console.WriteLine(xCodRe);
                    }


                    XmlNodeList xRazRef = ((XmlElement)xRef[0]).GetElementsByTagName("RazonRef");
                foreach (XmlElement nodo in xRazRef)
                {
                    xRazRe = nodo.InnerText;
                    Console.WriteLine(xRazRe);
                }
                    insertref( xFol, xforef, xFchR, xTpoDoc, xRazRe, ip, user, pa, database);


                }

            }
            else
            {
                Console.WriteLine("No ahi Referencia");
            }
            //fin referencia

         

            XmlNodeList xDtedetalle = xDoc.GetElementsByTagName("Detalle");


                // Guardamos los nodos hijos de personas (que se llaman persona) en la variable 'nodosPersona'
                XmlNodeList nodosPersona = xDoc.GetElementsByTagName("Detalle");

                // Recorremos el nodo personas
                string dnombre = ""; string dcant = ""; string dpre = ""; string dmon = "";
                foreach (XmlElement nodoPersona in nodosPersona)
                {

                    foreach (XmlElement nodoNombre in nodoPersona.GetElementsByTagName("NmbItem"))
                        dnombre = nodoNombre.InnerText.ToString();
                    Console.WriteLine(dnombre);

                    foreach (XmlElement nodoApellido1 in nodoPersona.GetElementsByTagName("QtyItem"))
                        dcant = nodoApellido1.InnerText.ToString();
                    Console.WriteLine(dcant);

                    foreach (XmlElement nodoApellido2 in nodoPersona.GetElementsByTagName("PrcItem"))
                        dpre = nodoApellido2.InnerText.ToString();
                    Console.WriteLine(dpre);

                    foreach (XmlElement nodoTelefono in nodoPersona.GetElementsByTagName("MontoItem"))
                        dmon = nodoTelefono.InnerText.ToString();
                    Console.WriteLine(dmon);





                    insertdetalle(xTDTE,xFol, dnombre, dcant, dpre, dmon,ip,user,pa,database);

                }

                insertregistro(xA,xCodv,xFch2, xCodRe,xTpoDoc, xforef, xFchR, xRazRe, xTipo, xInd,xTDTE, xFol, xFch, xrutr, xrazonr, xdirr, xcomr, xciur, xgirr, xneto, xiv, xtot, ip, user, pa, database);



                //mover registro
                File.Move(fi, fiout);
                Console.WriteLine("{0} was moved to {1}.", fi, fiout);

                //fin mover registro


            }
        //   insertref( xFol, xforef, xFchR, xCodRe, xRazRe);
        public static void insertref( string xFol, string xforef, string xFchR, string xCodRe, string xRazRe, string ip, string user, string pa, string database)
        {
            //your MySQL connection string
            string connStr = "server=" + ip + ";user=" + user + ";database=" + database + ";port=3306;password=" + pa;

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();


                MySqlCommand comm = conn.CreateCommand();
                String sql = "";
           
                    sql = "INSERT INTO dteref(tporef,feref,folioref,dte) VALUES (@tporef,@feref,@folioref, @dte)";

                Console.WriteLine("sql->"+sql);

                comm.CommandText = sql;
           

                comm.Parameters.AddWithValue("@tporef", xCodRe);
                comm.Parameters.AddWithValue("@feref", xFchR);
                comm.Parameters.AddWithValue("@folioref", xforef);
                comm.Parameters.AddWithValue("@dte", xFol);

                Console.WriteLine("sql->" + xCodRe+ "-" +xFchR +"-" +xforef+"-"+xFol);


                comm.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception err)
            {
                
                Console.WriteLine(err.ToString());
            }

            conn.Close();
            Console.WriteLine("Connection Closed. ...");
            //Console.Read();
            //mysql
        }
        public static void insertdetalle(string xTDTE,string xFol, string dnombre, string dcant, string dpre, string dmon, string ip, string user, string pa, string database)
            {
                string connStr = "server="+ip+";user="+user+";database="+database+";port=3306;password="+pa;

                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    string dun = "";
                    //string dtotal="";
                    string dcodigo = "";
                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();

                    //SQL Query to execute
                    //selecting only first 10 rows for demo
                    //string sql = "select * from documentos limit 0,10;";
                    //MySqlCommand cmd = new MySqlCommand(sql, conn);
                    //MySqlDataReader rdr = cmd.ExecuteReader();

                    //read the data
                    //while (rdr.Read())
                    //{
                    //  Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2]);
                    // }
                    // rdr.Close();

                    MySqlCommand comm = conn.CreateCommand();
                    String sql = "";
                    if (String.Equals(xTDTE, "33"))
                       {
                        sql = "INSERT INTO detdocumentos(ide,numero,codigo,producto,un,precio,cantidad,total) VALUES (@ide,@numero, @codigo, @producto, @un, @precio, @cantidad, @total)";
                       }

                if (String.Equals(xTDTE, "52"))
                {
                    sql = "INSERT INTO detdocumentosgv(ide,numero,codigo,producto,un,precio,cantidad,total) VALUES (@ide,@numero, @codigo, @producto, @un, @precio, @cantidad, @total)";
                }

                if (String.Equals(xTDTE, "61"))
                {
                    sql = "INSERT INTO detdocumentosncv(ide,numero,codigo,producto,un,precio,cantidad,total) VALUES (@ide,@numero, @codigo, @producto, @un, @precio, @cantidad, @total)";
                }

                if (String.Equals(xTDTE, "0"))
                {
                    sql = "INSERT INTO detdocumentosbol(ide,numero,codigo,producto,un,precio,cantidad,total) VALUES (@ide,@numero, @codigo, @producto, @un, @precio, @cantidad, @total)";
                }
                comm.CommandText = sql;
                //comm.CommandText = "INSERT INTO documentos2(fecha) VALUES (@fecha)";

                comm.Parameters.AddWithValue("@ide", xFol);
                comm.Parameters.AddWithValue("@numero", xFol);
                    comm.Parameters.AddWithValue("@codigo", dcodigo);
                    comm.Parameters.AddWithValue("@producto", dnombre);
                    comm.Parameters.AddWithValue("@un", dun);
                    comm.Parameters.AddWithValue("@precio", dpre);
                    comm.Parameters.AddWithValue("@cantidad", dcant);
                    comm.Parameters.AddWithValue("@total", dmon);
                 
                    comm.ExecuteNonQuery();
                    conn.Close();


                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                }

                conn.Close();
                Console.WriteLine("Connection Closed. ...");
            }
            public static void insertregistro(string xA,string xCodv,string xFchR2, string xCodRe,string xTpoDoc, string xforef, string xFchR, string xRazRe, string xTipo, string xInd, string xTDTE,string xFol, String xFch, string xrutr, string xrazonr, string xdirr, string xcomr, string xciur, string xgirr, string xneto, string xiv, string xtot, string ip, string user, string pa, string database)
            {
                //mysql

                //your MySQL connection string
                string connStr = "server=" + ip + ";user=" + user + ";database=" + database + ";port=3306;password=" + pa;

            MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();



                    MySqlCommand comm = conn.CreateCommand();
                    String sql = "";
                    if (String.Equals(xTDTE, "33"))
                       {
                        sql = "INSERT INTO documentos(vendedor,venc,fecha,rut,razon,direccion,comuna,ciudad,neto,iva,total,numero,giro,forma) VALUES (@vendedor,@fecha2,@fecha, @rut, @razon, @direccion, @comuna, @ciudad, @neto, @iva, @total, @numero, @giro, @forma)";
                       }

                if (String.Equals(xTDTE, "52"))
                {
                    sql = "INSERT INTO documentosgv(vendedor,IndTraslado,TipoDespacho,fecha,rut,razon,direccion,comuna,ciudad,neto,iva,total,numero,giro,forma) VALUES (@vendedor,@IndTraslado,@TipoDespacho,@fecha, @rut, @razon, @direccion, @comuna, @ciudad, @neto, @iva, @total, @numero, @giro, @forma)";
                }

                if (String.Equals(xTDTE, "61"))
                {
                    sql = "INSERT INTO documentosncv(vendedor,codref,tpodocref, folioref, feref, razonref,fecha,rut,razon,direccion,comuna,ciudad,neto,iva,total,numero,giro,forma) VALUES (@vendedor,@codref,@tpodocref, @folioref, @feref, @razonref,@fecha, @rut, @razon, @direccion, @comuna, @ciudad, @neto, @iva, @total, @numero, @giro, @forma)";
                }

                if (String.Equals(xTDTE, "0"))
                {
                    sql = "INSERT INTO documentosbol(dte,vendedor,fecha,rut,razon,direccion,comuna,ciudad,neto,iva,total,numero,giro,forma) VALUES (@dte,@vendedor,@fecha, @rut, @razon, @direccion, @comuna, @ciudad, @neto, @iva, @total, @numero, @giro, @forma)";
                }
                comm.CommandText =sql ;
                //comm.CommandText = "INSERT INTO documentos2(fecha) VALUES (@fecha)";

                comm.Parameters.AddWithValue("@vendedor", xCodv);
                comm.Parameters.AddWithValue("@fecha", xFch);
                    comm.Parameters.AddWithValue("@fecha2", xFchR2);
                    comm.Parameters.AddWithValue("@rut", xrutr);
                    comm.Parameters.AddWithValue("@razon", xrazonr);
                    comm.Parameters.AddWithValue("@direccion", xdirr);
                    comm.Parameters.AddWithValue("@comuna", xcomr);
                    comm.Parameters.AddWithValue("@ciudad", xciur);
                    comm.Parameters.AddWithValue("@neto", xneto);
                    comm.Parameters.AddWithValue("@iva", xiv);
                    comm.Parameters.AddWithValue("@total", xtot);
                    comm.Parameters.AddWithValue("@numero", xFol);
                comm.Parameters.AddWithValue("@dte", xFol);
                comm.Parameters.AddWithValue("@giro", xgirr);
                    comm.Parameters.AddWithValue("@forma", xA);
                if (String.Equals(xTDTE, "61"))
                {
                    comm.Parameters.AddWithValue("@tpodocref", xTpoDoc);
                    comm.Parameters.AddWithValue("@folioref", xforef);
                    comm.Parameters.AddWithValue("@feref", xFchR);
                    comm.Parameters.AddWithValue("@razonref", xRazRe);
                    comm.Parameters.AddWithValue("@codref", xCodRe);
                }
                if (String.Equals(xTDTE, "52"))
                {
                    comm.Parameters.AddWithValue("@IndTraslado", xInd);
                    comm.Parameters.AddWithValue("@TipoDespacho", xTipo);
                }


                comm.ExecuteNonQuery();
                    conn.Close();


                }
                catch (Exception err)
                {
                    Console.WriteLine(err.ToString());
                }

                conn.Close();
                Console.WriteLine("Connection Closed. ...");
                //Console.Read();
                //mysql
            }


        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=c:\\xml\\base.db3; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return sqlite_conn;
        }

        public void eje(){

           // Trace.Listeners.Add(new TextWriterTraceListener("yourlog.log"));
           // Trace.AutoFlush = true;
           // Trace.Indent();
           // Trace.WriteLine("Entering Main");
           // Console.WriteLine("Hello World.");
           // Trace.WriteLine("Exiting Main");
          //  Trace.Unindent();
          //Tra  Trace.Flush();


            //datos sqlite
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            //  ReadData(sqlite_conn);
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT dxml,dsal,ip,user,pa,base FROM config WHERE id=1";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Configuracion conf = new Configuracion();

            string dxml = "";
            string dsal = "";
            string ip = "";
            string user = "";
            string pa = "";
            string database = "";

            while (sqlite_datareader.Read())
            {
                dxml = sqlite_datareader.GetString(0);
                dsal = sqlite_datareader.GetString(1);
                ip = sqlite_datareader.GetString(2);
                user = sqlite_datareader.GetString(3);
                pa = sqlite_datareader.GetString(4);
                database = sqlite_datareader.GetString(5);
              





                //MessageBox.Show(dxml);
            }
            sqlite_conn.Close();
            //fin datos sqlite


            string dir = dxml;
                Test tm = new Test();
                try
                {
                    foreach (string f in Directory.GetFiles(dir))
                    {
                        String archivo = Path.GetFileName(f);
                        Console.WriteLine(Path.GetFileName(f));
                  //  Trace.Indent();
                  //  Trace.WriteLine(archivo);
                  //  Console.WriteLine(archivo);

                  //  Trace.Unindent();
                  //  Trace.Flush();
                    // tm.leerxml(archivo);
                    leerxml(archivo, dxml, dsal, ip, user,  pa,  database);

                    }
                    foreach (string d in Directory.GetDirectories(dir))
                    {
                        String archivo = Path.GetFileName(d);
                        //Console.WriteLine(archivo);

                        leerxml(archivo, dxml, dsal, ip, user, pa, database);


                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
               // Trace.Indent();
               // Trace.WriteLine(ex.Message);
                Console.WriteLine(ex.Message);
               
               // Trace.Unindent();
               // Trace.Flush();
            }

            }




        }
    }

