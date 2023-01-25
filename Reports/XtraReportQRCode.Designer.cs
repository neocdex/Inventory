namespace Inventory.Reports
{
    partial class XtraReportQRCode
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrQRCode = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabelID = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.MainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uow = new DevExpress.Xpo.UnitOfWork(this.components);
            this.pProductID = new DevExpress.XtraReports.Parameters.Parameter();
            this.xpCollection = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrQRCode,
            this.xrLabelID});
            this.Detail.HeightF = 200F;
            this.Detail.MultiColumn.ColumnWidth = 200F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrQRCode
            // 
            this.xrQRCode.Alignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrQRCode.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
            this.xrQRCode.Module = 4F;
            this.xrQRCode.Name = "xrQRCode";
            this.xrQRCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrQRCode.ShowText = false;
            this.xrQRCode.SizeF = new System.Drawing.SizeF(195.9999F, 170F);
            this.xrQRCode.StylePriority.UseBorderWidth = false;
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.Q;
            this.xrQRCode.Symbology = qrCodeGenerator1;
            // 
            // xrLabelID
            // 
            this.xrLabelID.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "productcode")});
            this.xrLabelID.LocationFloat = new DevExpress.Utils.PointFloat(26.00002F, 170F);
            this.xrLabelID.Name = "xrLabelID";
            this.xrLabelID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelID.SizeF = new System.Drawing.SizeF(160F, 20.00002F);
            this.xrLabelID.StylePriority.UseTextAlignment = false;
            this.xrLabelID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 5F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 5F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // MainBindingSource
            // 
            this.MainBindingSource.DataSource = this.xpCollection;
            // 
            // uow
            // 
            this.uow.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists;
            this.uow.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.uow.TrackPropertiesModifications = false;
            // 
            // pProductID
            // 
            this.pProductID.Description = "product id parameter";
            this.pProductID.Name = "pProductID";
            this.pProductID.Type = typeof(int);
            this.pProductID.ValueInfo = "0";
            this.pProductID.Visible = false;
            // 
            // xpCollection
            // 
            this.xpCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNone;
            this.xpCollection.DisplayableProperties = "This;product_id;name;description;serialnumber;serie;model;brand_id!;brand_id!Key;" +
    "brand_id;barcode_digits;productcode";
            this.xpCollection.ObjectType = typeof(Inventory.ORMDataModelCode.Products);
            this.xpCollection.Session = this.uow;
            // 
            // XtraReportQRCode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataSource = this.xpCollection;
            this.DisplayName = "XtraReportQRCode";
            this.Margins = new System.Drawing.Printing.Margins(0, 3, 5, 5);
            this.PageHeight = 200;
            this.PageWidth = 199;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pProductID});
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.MainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRBarCode xrQRCode;
        private DevExpress.XtraReports.UI.XRLabel xrLabelID;
        private System.Windows.Forms.BindingSource MainBindingSource;
        private DevExpress.Xpo.XPCollection xpCollection;
        private DevExpress.Xpo.UnitOfWork uow;
        public DevExpress.XtraReports.Parameters.Parameter pProductID;
    }
}
