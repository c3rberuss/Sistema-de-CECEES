﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class VerificacionMatricula : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
        try
        {
            string sql = "Select * from alumnospremat where NIE='" + Session["NIE"].ToString() + "';";
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "mysql5013.smarterasp.net";
            builder.UserID = "a131fe_bd";
            builder.Password = "prueba123";
            builder.Database = "db_a131fe_bd";
            MySqlConnection con = new MySqlConnection(builder.ToString());
        con.Open();
        MySqlCommand Ejecutar_Consulta = new MySqlCommand(sql, con);
            MySqlDataReader rdr = Ejecutar_Consulta.ExecuteReader();
        if (!rdr.Read())
        {
            Label1.Text = "Es esto man";
        }
            TxtHermNum.Text = rdr["NUMHERMAN"].ToString();
            Label54.Text = Convert.ToString(Session["NIE"]);
            Label1.Text = rdr["ALUMNOAPELLI1"].ToString();
            Label2.Text = rdr["ALUMNOAPELLI2"].ToString();
            Label3.Text = rdr["ALUMNONOMBR1"].ToString();
            Label4.Text = rdr["ALUMNONOMBR2"].ToString();
            Label5.Text = rdr["GENERO"].ToString();
            Label6.Text = rdr["FECHANACIMIENTO"].ToString();
            Label7.Text = rdr["EDAD"].ToString();
            Label8.Text = rdr["LUGNACIMIENTO"].ToString();
            Label9.Text = rdr["ZONARE"].ToString();
            Label10.Text = rdr["DIRECC"].ToString();
            Label11.Text = rdr["NACIONALI"].ToString();
            Label12.Text = rdr["TELCASA"].ToString();
            Label13.Text = rdr["CELULAR"].ToString();
            Label14.Text = rdr["RELIGION"].ToString();

            if (rdr["BAUTIZ"].ToString() == "Si")
            {
                Label15.Text = "- Bautismo.";
                if (rdr["PRIMCOMUN"].ToString() == "Si")
                {
                    Label15.Text = "<br />- Primera comunión.";
                    if (rdr["CONFIRM"].ToString() == "Si")
                    {
                        Label15.Text = "<br />- Confirmación.";

                    }
                }
            }
            Label16.Text = rdr["NUEVOING"].ToString();
            Label17.Text = rdr["INSTPROCE"].ToString();
            Label18.Text = rdr["GRADINGR"].ToString();
            Label19.Text = rdr["PARVULA"].ToString();
            Label20.Text = rdr["HERMAN"].ToString();
            Label21.Text = rdr["NUMHERMAN"].ToString();
            TxtGrado1.Text = rdr["GRADHERMAN1"].ToString();
            TxtGrado2.Text = rdr["GRADHERMAN2"].ToString();
            TxtGrado3.Text = rdr["GRADHERMAN3"].ToString();
            TxtGrado4.Text = rdr["GRADHERMAN4"].ToString();
            TxtGrado5.Text = rdr["GRADHERMAN5"].ToString();
            TxtGrado6.Text = rdr["GRADHERMAN6"].ToString();
            TxtGrado7.Text = rdr["GRADHERMAN7"].ToString();
            TxtGrado8.Text = rdr["GRADHERMAN8"].ToString();
            TxtGrado9.Text = rdr["GRADHERMAN9"].ToString();
            TxtGrado10.Text = rdr["GRADHERMAN10"].ToString();
            TxtGrado11.Text = rdr["GRADHERMAN11"].ToString();
            TxtGrado12.Text = rdr["GRADHERMAN12"].ToString();
            TxtGrado13.Text = rdr["GRADHERMAN13"].ToString();
            TxtGrado14.Text = rdr["GRADHERMAN14"].ToString();
            TxtGrado15.Text = rdr["GRADHERMAN15"].ToString();
            TxtGrado16.Text = rdr["GRADHERMAN16"].ToString();
            TxtGrado17.Text = rdr["GRADHERMAN17"].ToString();
            TxtGrado18.Text = rdr["GRADHERMAN18"].ToString();
            TxtGrado19.Text = rdr["GRADHERMAN19"].ToString();
            TxtGrado20.Text = rdr["GRADHERMAN20"].ToString();
            Label22.Text = rdr["NOMMAD"].ToString();
            Label23.Text = rdr["PROFMAD"].ToString();
            Label24.Text = rdr["LUGTRABMAD"].ToString();
            Label25.Text = rdr["TELTRAB"].ToString();
            Label26.Text = rdr["NOMPAD"].ToString();
            Label27.Text = rdr["PROFPAD"].ToString();
            Label28.Text = rdr["LUGTRABPAD"].ToString();
            Label29.Text = rdr["TELTRABPAD"].ToString();
            Label30.Text = rdr["ESTADOCIV"].ToString();
            Label31.Text = rdr["VIVECON"].ToString();
            Label32.Text = rdr["DISCAP"].ToString();
            Label33.Text = rdr["CUALDISCAP"].ToString();
            Label34.Text = rdr["REPITENTE"].ToString();
            Label35.Text = rdr["VACUNASCOMPLE"].ToString();
            Label36.Text = rdr["PROBLEMASDESAL"].ToString();
            Label37.Text = rdr["EDUCESPECIAL"].ToString();
            Label38.Text = rdr["TRABREMUN"].ToString();
            Label39.Text = rdr["CUALTRAB"].ToString();
            Label40.Text = rdr["RESPON1NOM1"].ToString();
            Label41.Text = rdr["RESPON1NOM2"].ToString();
            Label42.Text = rdr["RESPON1APELL1"].ToString();
            Label43.Text = rdr["RESPON1APELL2"].ToString();
            Label44.Text = rdr["RESPON1DUI"].ToString();
            Label45.Text = rdr["RESPON1TEL"].ToString();
            Label46.Text = rdr["RESPON1CEL"].ToString();
            Label47.Text = rdr["RESPON2NOM1"].ToString();
            Label48.Text = rdr["RESPON2NOM2"].ToString();
            Label49.Text = rdr["RESPON2APELL1"].ToString();
            Label50.Text = rdr["RESPON2APELL2"].ToString();
            Label51.Text = rdr["RESPON2DUI"].ToString();
            Label52.Text = rdr["RESPON2TEL"].ToString();
            Label53.Text = rdr["RESPON2CEL"].ToString();

            if (Label16.Text == "Si")
            {
                Panel1.Visible = true;
            }
            else
            {
                Panel2.Visible = true;
            }
            if (Label20.Text == "Si")
            {
                Panel3.Visible = true;
            }
            if (Label32.Text == "Si")
            {
                Panel4.Visible = true;
            }
            if (Label38.Text == "Si")
            {
                Panel5.Visible = true;
            }

            if (Convert.ToInt16(TxtHermNum.Text) > 0)
            {
                LblGrado1.Visible = true;
                TxtGrado1.Visible = true;

                if (Convert.ToInt16(TxtHermNum.Text) > 1)
                {
                    LblGrado2.Visible = true;
                    TxtGrado2.Visible = true;
                    if (Convert.ToInt16(TxtHermNum.Text) > 2)
                    {
                        LblGrado3.Visible = true;
                        TxtGrado3.Visible = true;
                        if (Convert.ToInt16(TxtHermNum.Text) > 3)
                        {
                            LblGrado4.Visible = true;
                            TxtGrado4.Visible = true;
                            if (Convert.ToInt16(TxtHermNum.Text) > 4)
                            {
                                LblGrado5.Visible = true;
                                TxtGrado5.Visible = true;
                                if (Convert.ToInt16(TxtHermNum.Text) > 5)
                                {
                                    LblGrado6.Visible = true;
                                    TxtGrado6.Visible = true;
                                    if (Convert.ToInt16(TxtHermNum.Text) > 6)
                                    {
                                        LblGrado7.Visible = true;
                                        TxtGrado7.Visible = true;
                                        if (Convert.ToInt16(TxtHermNum.Text) > 7)
                                        {
                                            LblGrado8.Visible = true;
                                            TxtGrado8.Visible = true;
                                            if (Convert.ToInt16(TxtHermNum.Text) > 8)
                                            {
                                                LblGrado9.Visible = true;
                                                TxtGrado9.Visible = true;
                                                if (Convert.ToInt16(TxtHermNum.Text) > 9)
                                                {
                                                    LblGrado10.Visible = true;
                                                    TxtGrado10.Visible = true;
                                                    if (Convert.ToInt16(TxtHermNum.Text) > 10)
                                                    {
                                                        LblGrado11.Visible = true;
                                                        TxtGrado11.Visible = true;
                                                        if (Convert.ToInt16(TxtHermNum.Text) > 11)
                                                        {
                                                            LblGrado12.Visible = true;
                                                            TxtGrado12.Visible = true;
                                                            if (Convert.ToInt16(TxtHermNum.Text) > 12)
                                                            {
                                                                LblGrado13.Visible = true;
                                                                TxtGrado13.Visible = true;
                                                                if (Convert.ToInt16(TxtHermNum.Text) > 13)
                                                                {
                                                                    LblGrado14.Visible = true;
                                                                    TxtGrado14.Visible = true;
                                                                    if (Convert.ToInt16(TxtHermNum.Text) > 14)
                                                                    {
                                                                        LblGrado15.Visible = true;
                                                                        TxtGrado15.Visible = true;
                                                                        if (Convert.ToInt16(TxtHermNum.Text) > 15)
                                                                        {
                                                                            LblGrado16.Visible = true;
                                                                            TxtGrado16.Visible = true;
                                                                            if (Convert.ToInt16(TxtHermNum.Text) > 16)
                                                                            {
                                                                                LblGrado17.Visible = true;
                                                                                TxtGrado17.Visible = true;

                                                                                if (Convert.ToInt16(TxtHermNum.Text) > 17)
                                                                                {
                                                                                    LblGrado18.Visible = true;
                                                                                    TxtGrado18.Visible = true;
                                                                                    if (Convert.ToInt16(TxtHermNum.Text) > 18)
                                                                                    {
                                                                                        LblGrado19.Visible = true;
                                                                                        TxtGrado19.Visible = true;
                                                                                        if (Convert.ToInt16(TxtHermNum.Text) > 19)
                                                                                        {
                                                                                            LblGrado20.Visible = true;
                                                                                            TxtGrado20.Visible = true;

                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception)
        {

        }
      
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string sql1 = "Delete alumnospremat from alumnospremat where NIE='"+Session["NIE"].ToString()+"'";
        string sql2 = "Delete usuariosmat from usuariosmat where NIE='" + Session["NIE"].ToString() + "'";
        conexion cone = new conexion();
        cone.eliminar(sql1);
        cone.eliminar(sql2);
    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        
    }

    protected void Aceptar_Click(object sender, EventArgs e)
    {
        string sql = "Select * from usuariosmat where NIE='" + Session["NIE"].ToString() + "';";

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        builder.Server = "mysql5013.smarterasp.net";
        builder.UserID = "a131fe_bd";
        builder.Password = "prueba123";
        builder.Database = "db_a131fe_bd";
        MySqlConnection con = new MySqlConnection(builder.ToString());
        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = sql;
        MySqlDataReader rdr = cmd.ExecuteReader();
        rdr.Read();
        string COM1 = rdr["COM1"].ToString();
        string COM2 = rdr["COM2"].ToString();
        string COM3 = rdr["COM3"].ToString();
        string COM4 = rdr["COM4"].ToString();
        string COM5 = rdr["COM5"].ToString();
        string COM6 = rdr["COM6"].ToString();
        string COM7 = rdr["COM7"].ToString();
        string COM8 = rdr["COM8"].ToString();
        string COM9 = rdr["COM9"].ToString();
        string COM10 = rdr["COM10"].ToString();
        string COM11 = rdr["COM11"].ToString();
        string COM12 = rdr["COM12"].ToString();
        string COM13 = rdr["COM13"].ToString();
        string COM14 = rdr["COM14"].ToString();
        string COM15 = rdr["COM15"].ToString();
        string COM16 = rdr["COM16"].ToString();
        string COM17 = rdr["COM17"].ToString();
        string COM18 = rdr["COM18"].ToString();
        string COM19 = rdr["COM19"].ToString();
        string COM20 = rdr["COM20"].ToString();

        string consulta = "";

        if (string.IsNullOrEmpty(COM1))
        {
            COM1 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM1) values ('"+COM1+"') where NIE='"+ Session["NIE"] +"'";

        }
        else if (string.IsNullOrEmpty(COM2))
        {
            COM2 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM2) values ('" + COM2 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM3))
        {
            COM3 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM3) values ('" + COM3 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM4))
        {
            COM4 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM4) values ('" + COM4 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM5))
        {
            COM5 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM5) values ('" + COM5 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM6))
        {
            COM6 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM6) values ('" + COM6 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM7))
        {
            COM7 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM7) values ('" + COM7 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM8))
        {
            COM8 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM8) values ('" + COM8 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM9))
        {
            COM9 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM9) values ('" + COM9 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM10))
        {
            COM10 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM10) values ('" + COM10 + "') where NIE='" + Session["NIE"] + "'";


        }
        else if (string.IsNullOrEmpty(COM11))
        {
            COM11 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM11) values ('" + COM11 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM12))
        {
            COM12 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM12) values ('" + COM12 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM13))
        {
            COM13 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM13) values ('" + COM13 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM14))
        {
            COM14 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM14) values ('" + COM14 + "') where NIE='" + Session["NIE"] + "'";


        }
        else if (string.IsNullOrEmpty(COM15))
        {
            COM15 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM15) values ('" + COM15 + "') where NIE='" + Session["NIE"] + "'";


        }
        else if (string.IsNullOrEmpty(COM16))
        {
            COM16 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM2) values ('" + COM2 + "') where NIE='" + Session["NIE"] + "'";


        }
        else if (string.IsNullOrEmpty(COM17))
        {
            COM17 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM17) values ('" + COM17 + "') where NIE='" + Session["NIE"] + "'";


        }
        else if (string.IsNullOrEmpty(COM18))
        {
            COM18 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM18) values ('" + COM18 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM19))
        {
            COM19 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM19) values ('" + COM19 + "') where NIE='" + Session["NIE"] + "'";

        }
        else if (string.IsNullOrEmpty(COM20))
        {
            COM20 = TxtCOM.Text;
            consulta = "Insert into usuarios (COM20) values ('" + COM20 + "') where NIE='" + Session["NIE"] + "'";

        }
        else
        {
            Label56.Text = "Limite de comentarios alcanzados.";
            TxtCOM.Visible = false;
        }
        cmd.CommandText = consulta;
    }
}