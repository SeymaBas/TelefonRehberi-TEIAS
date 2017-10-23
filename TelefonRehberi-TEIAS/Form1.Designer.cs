namespace TelefonRehberi_TEIAS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlDahili = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPageHarici = new DevExpress.XtraTab.XtraTabPage();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.gridControlTrafo = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEditTrafoMerkeziArama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageDahili = new DevExpress.XtraTab.XtraTabPage();
            this.textEditBirimeGoreArama = new DevExpress.XtraEditors.TextEdit();
            this.labelControlBirimeGoreArama = new DevExpress.XtraEditors.LabelControl();
            this.textEditIsmeGoreArama = new DevExpress.XtraEditors.TextEdit();
            this.labelControlIsmeGoreArama = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControlDahili = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDahili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.xtraTabPageHarici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrafo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTrafoMerkeziArama.Properties)).BeginInit();
            this.xtraTabPageDahili.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBirimeGoreArama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIsmeGoreArama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlDahili)).BeginInit();
            this.xtraTabControlDahili.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlDahili;
            this.gridView3.Name = "gridView3";
            // 
            // gridControlDahili
            // 
            this.gridControlDahili.Location = new System.Drawing.Point(9, 163);
            this.gridControlDahili.MainView = this.gridView1;
            this.gridControlDahili.Name = "gridControlDahili";
            this.gridControlDahili.Size = new System.Drawing.Size(840, 306);
            this.gridControlDahili.TabIndex = 4;
            this.gridControlDahili.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView4,
            this.gridView3});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlDahili;
            this.gridView1.Name = "gridView1";
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControlDahili;
            this.gridView4.Name = "gridView4";
            // 
            // xtraTabPageHarici
            // 
            this.xtraTabPageHarici.Controls.Add(this.ribbonControl2);
            this.xtraTabPageHarici.Controls.Add(this.ribbonStatusBar1);
            this.xtraTabPageHarici.Controls.Add(this.gridControlTrafo);
            this.xtraTabPageHarici.Controls.Add(this.textEditTrafoMerkeziArama);
            this.xtraTabPageHarici.Controls.Add(this.labelControl2);
            this.xtraTabPageHarici.Name = "xtraTabPageHarici";
            this.xtraTabPageHarici.Size = new System.Drawing.Size(880, 476);
            this.xtraTabPageHarici.Text = "TRAFO MERKEZİ NUMARASI ARAMA";
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem2});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 2;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Size = new System.Drawing.Size(880, 47);
            this.ribbonControl2.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl2.Toolbar.ItemLinks.Add(this.skinRibbonGalleryBarItem2);
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem2.GalleryDropDown = this.galleryDropDown1;
            this.skinRibbonGalleryBarItem2.Id = 1;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = null;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 449);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(880, 27);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(880, 47);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.GalleryDropDown = this.galleryDropDown1;
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // gridControlTrafo
            // 
            this.gridControlTrafo.Location = new System.Drawing.Point(32, 96);
            this.gridControlTrafo.MainView = this.gridView2;
            this.gridControlTrafo.Name = "gridControlTrafo";
            this.gridControlTrafo.Size = new System.Drawing.Size(786, 358);
            this.gridControlTrafo.TabIndex = 2;
            this.gridControlTrafo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControlTrafo.Load += new System.EventHandler(this.gridControlTrafo_Load);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlTrafo;
            this.gridView2.Name = "gridView2";
            // 
            // textEditTrafoMerkeziArama
            // 
            this.textEditTrafoMerkeziArama.Location = new System.Drawing.Point(184, 70);
            this.textEditTrafoMerkeziArama.Name = "textEditTrafoMerkeziArama";
            this.textEditTrafoMerkeziArama.Size = new System.Drawing.Size(625, 20);
            this.textEditTrafoMerkeziArama.TabIndex = 1;
            this.textEditTrafoMerkeziArama.EditValueChanged += new System.EventHandler(this.textEditTrafoMerkeziArama_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "TRAFO MERKEZİ ARAMA:";
            // 
            // xtraTabPageDahili
            // 
            this.xtraTabPageDahili.Controls.Add(this.ribbonControl1);
            this.xtraTabPageDahili.Controls.Add(this.gridControlDahili);
            this.xtraTabPageDahili.Controls.Add(this.textEditBirimeGoreArama);
            this.xtraTabPageDahili.Controls.Add(this.labelControlBirimeGoreArama);
            this.xtraTabPageDahili.Controls.Add(this.textEditIsmeGoreArama);
            this.xtraTabPageDahili.Controls.Add(this.labelControlIsmeGoreArama);
            this.xtraTabPageDahili.Name = "xtraTabPageDahili";
            this.xtraTabPageDahili.Size = new System.Drawing.Size(880, 476);
            this.xtraTabPageDahili.Text = "DAHİLİ NUMARA ARAMA";
            // 
            // textEditBirimeGoreArama
            // 
            this.textEditBirimeGoreArama.Location = new System.Drawing.Point(213, 117);
            this.textEditBirimeGoreArama.Name = "textEditBirimeGoreArama";
            this.textEditBirimeGoreArama.Size = new System.Drawing.Size(527, 20);
            this.textEditBirimeGoreArama.TabIndex = 3;
            this.textEditBirimeGoreArama.EditValueChanged += new System.EventHandler(this.textEditBirimeGoreArama_TextChanged);
            // 
            // labelControlBirimeGoreArama
            // 
            this.labelControlBirimeGoreArama.Location = new System.Drawing.Point(53, 120);
            this.labelControlBirimeGoreArama.Name = "labelControlBirimeGoreArama";
            this.labelControlBirimeGoreArama.Size = new System.Drawing.Size(109, 13);
            this.labelControlBirimeGoreArama.TabIndex = 2;
            this.labelControlBirimeGoreArama.Text = "BİRİME GÖRE ARAMA:";
            // 
            // textEditIsmeGoreArama
            // 
            this.textEditIsmeGoreArama.Location = new System.Drawing.Point(213, 59);
            this.textEditIsmeGoreArama.Name = "textEditIsmeGoreArama";
            this.textEditIsmeGoreArama.Size = new System.Drawing.Size(527, 20);
            this.textEditIsmeGoreArama.TabIndex = 1;
            this.textEditIsmeGoreArama.EditValueChanged += new System.EventHandler(this.textEditIsmeGoreArama_TextChanged);
            // 
            // labelControlIsmeGoreArama
            // 
            this.labelControlIsmeGoreArama.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControlIsmeGoreArama.Location = new System.Drawing.Point(53, 62);
            this.labelControlIsmeGoreArama.Name = "labelControlIsmeGoreArama";
            this.labelControlIsmeGoreArama.Size = new System.Drawing.Size(98, 13);
            this.labelControlIsmeGoreArama.TabIndex = 0;
            this.labelControlIsmeGoreArama.Text = "İSME GÖRE ARAMA:";
            // 
            // xtraTabControlDahili
            // 
            this.xtraTabControlDahili.Location = new System.Drawing.Point(2, 110);
            this.xtraTabControlDahili.Name = "xtraTabControlDahili";
            this.xtraTabControlDahili.SelectedTabPage = this.xtraTabPageDahili;
            this.xtraTabControlDahili.Size = new System.Drawing.Size(886, 504);
            this.xtraTabControlDahili.TabIndex = 0;
            this.xtraTabControlDahili.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageDahili,
            this.xtraTabPageHarici});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.xtraTabControlDahili);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDahili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.xtraTabPageHarici.ResumeLayout(false);
            this.xtraTabPageHarici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTrafo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTrafoMerkeziArama.Properties)).EndInit();
            this.xtraTabPageDahili.ResumeLayout(false);
            this.xtraTabPageDahili.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditBirimeGoreArama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIsmeGoreArama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlDahili)).EndInit();
            this.xtraTabControlDahili.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridControlDahili;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHarici;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraGrid.GridControl gridControlTrafo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit textEditTrafoMerkeziArama;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDahili;
        private DevExpress.XtraEditors.TextEdit textEditBirimeGoreArama;
        private DevExpress.XtraEditors.LabelControl labelControlBirimeGoreArama;
        private DevExpress.XtraEditors.TextEdit textEditIsmeGoreArama;
        private DevExpress.XtraEditors.LabelControl labelControlIsmeGoreArama;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlDahili;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
    }
}

