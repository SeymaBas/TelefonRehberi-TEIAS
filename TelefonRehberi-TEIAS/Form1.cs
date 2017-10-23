using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace TelefonRehberi_TEIAS
{
    public partial class Form1 : Form
    {
        public Form1() {

            InitializeComponent();
            
            //DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }


        WebServiceTelefonRehberi.WebServiceRehber2SoapClient ws = new WebServiceTelefonRehberi.WebServiceRehber2SoapClient();
       


        //Form1 yüklenirken gridControlDahili'yi veritabanından gelen verilerle doldur
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.VeriGoster();
            gridControlDahili.DataSource = ds.Tables[0];

        }



        //IsımAra datasetinden gelen verileri textEditIsmeGoreAra texteditine getir.
        private void textEditIsmeGoreArama_TextChanged(object sender, EventArgs e)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.IsimAra(textEditIsmeGoreArama.Text);
            gridControlDahili.DataSource = ds.Tables[0];

        

        }
        
        //BolumAra datasetinden gelen verileri textEditBolumeGoreAra texteditine getir.
        private void textEditBirimeGoreArama_TextChanged(object sender, EventArgs e)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.BolumAra(textEditBirimeGoreArama.Text);
            gridControlDahili.DataSource = ds.Tables[0];
            

        }

        //TrafoMerkeziAra datasetinden gelen verileri textEditTrafoMerkeziAra texteditine getir.
        private void textEditTrafoMerkeziArama_TextChanged(object sender, EventArgs e)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.TrafoAra(textEditTrafoMerkeziArama.Text);
            gridControlTrafo.DataSource = ds.Tables[0];
           

        }

        private void gridControlTrafo_Load(object sender, EventArgs e)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.VeriGoster2();
            gridControlTrafo.DataSource = ds.Tables[0];
        }
    }

    }









