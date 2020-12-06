
namespace GridSampleLiveData
{
    partial class FormFinNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinNews));
            this.gridControlNews = new DevExpress.XtraGrid.GridControl();
            this.gridViewNews = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnHeadline = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRelated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridColumnPublishedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUnixTimeStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFunctions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.simpleButtonShowLatestData = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNews
            // 
            this.gridControlNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNews.Location = new System.Drawing.Point(0, 0);
            this.gridControlNews.MainView = this.gridViewNews;
            this.gridControlNews.Name = "gridControlNews";
            this.gridControlNews.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemHypertextLabel1});
            this.gridControlNews.Size = new System.Drawing.Size(1019, 681);
            this.gridControlNews.TabIndex = 0;
            this.gridControlNews.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNews});
            // 
            // gridViewNews
            // 
            this.gridViewNews.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnHeadline,
            this.gridColumnCategory,
            this.gridColumnSource,
            this.gridColumnImage,
            this.gridColumnRelated,
            this.gridColumnSummary,
            this.gridColumnUrl,
            this.gridColumnPublishedDate,
            this.gridColumnUnixTimeStamp,
            this.gridColumnFunctions});
            this.gridViewNews.GridControl = this.gridControlNews;
            this.gridViewNews.GroupCount = 1;
            this.gridViewNews.Name = "gridViewNews";
            this.gridViewNews.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewNews.OptionsBehavior.ReadOnly = true;
            this.gridViewNews.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewNews.OptionsView.ShowPreview = true;
            this.gridViewNews.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnCategory, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewNews.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridViewNews.CustomDrawRowPreview += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridViewNews_CustomDrawRowPreview);
            this.gridViewNews.MeasurePreviewHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.gridViewNews_MeasurePreviewHeight);
            this.gridViewNews.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNews_FocusedRowChanged);
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            // 
            // gridColumnHeadline
            // 
            this.gridColumnHeadline.Caption = "Headline";
            this.gridColumnHeadline.FieldName = "Headline";
            this.gridColumnHeadline.Name = "gridColumnHeadline";
            this.gridColumnHeadline.Visible = true;
            this.gridColumnHeadline.VisibleIndex = 0;
            this.gridColumnHeadline.Width = 476;
            // 
            // gridColumnCategory
            // 
            this.gridColumnCategory.Caption = "Category";
            this.gridColumnCategory.FieldName = "Category";
            this.gridColumnCategory.Name = "gridColumnCategory";
            this.gridColumnCategory.Visible = true;
            this.gridColumnCategory.VisibleIndex = 1;
            this.gridColumnCategory.Width = 218;
            // 
            // gridColumnSource
            // 
            this.gridColumnSource.Caption = "Source";
            this.gridColumnSource.FieldName = "Source";
            this.gridColumnSource.Name = "gridColumnSource";
            this.gridColumnSource.Width = 73;
            // 
            // gridColumnImage
            // 
            this.gridColumnImage.Caption = "Image";
            this.gridColumnImage.FieldName = "Image";
            this.gridColumnImage.Name = "gridColumnImage";
            this.gridColumnImage.Width = 902;
            // 
            // gridColumnRelated
            // 
            this.gridColumnRelated.Caption = "Related";
            this.gridColumnRelated.FieldName = "Related";
            this.gridColumnRelated.Name = "gridColumnRelated";
            // 
            // gridColumnSummary
            // 
            this.gridColumnSummary.Caption = "Summary";
            this.gridColumnSummary.FieldName = "Summary";
            this.gridColumnSummary.Name = "gridColumnSummary";
            this.gridColumnSummary.Width = 771;
            // 
            // gridColumnUrl
            // 
            this.gridColumnUrl.Caption = "Url";
            this.gridColumnUrl.ColumnEdit = this.repositoryItemHyperLinkEdit1;
            this.gridColumnUrl.DisplayFormat.FormatString = "more...";
            this.gridColumnUrl.FieldName = "Url";
            this.gridColumnUrl.Name = "gridColumnUrl";
            this.gridColumnUrl.Visible = true;
            this.gridColumnUrl.VisibleIndex = 1;
            this.gridColumnUrl.Width = 200;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Caption = "Double click for more info.";
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.repositoryItemHyperLinkEdit1_OpenLink);
            // 
            // gridColumnPublishedDate
            // 
            this.gridColumnPublishedDate.Caption = "PublishedDate";
            this.gridColumnPublishedDate.DisplayFormat.FormatString = "G";
            this.gridColumnPublishedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnPublishedDate.FieldName = "PublishedDate";
            this.gridColumnPublishedDate.Name = "gridColumnPublishedDate";
            this.gridColumnPublishedDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumnPublishedDate.Visible = true;
            this.gridColumnPublishedDate.VisibleIndex = 2;
            this.gridColumnPublishedDate.Width = 106;
            // 
            // gridColumnUnixTimeStamp
            // 
            this.gridColumnUnixTimeStamp.Caption = "UnixTimeStamp";
            this.gridColumnUnixTimeStamp.FieldName = "datetime";
            this.gridColumnUnixTimeStamp.Name = "gridColumnUnixTimeStamp";
            // 
            // gridColumnFunctions
            // 
            this.gridColumnFunctions.Caption = "Functions";
            this.gridColumnFunctions.FieldName = "Functions";
            this.gridColumnFunctions.Name = "gridColumnFunctions";
            this.gridColumnFunctions.UnboundExpression = resources.GetString("gridColumnFunctions.UnboundExpression");
            this.gridColumnFunctions.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumnFunctions.Visible = true;
            this.gridColumnFunctions.VisibleIndex = 3;
            this.gridColumnFunctions.Width = 212;
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            this.repositoryItemHypertextLabel1.ReadOnly = true;
            // 
            // simpleButtonShowLatestData
            // 
            this.simpleButtonShowLatestData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButtonShowLatestData.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.simpleButtonShowLatestData.Appearance.Options.UseBackColor = true;
            this.simpleButtonShowLatestData.Location = new System.Drawing.Point(433, 0);
            this.simpleButtonShowLatestData.Name = "simpleButtonShowLatestData";
            this.simpleButtonShowLatestData.Size = new System.Drawing.Size(153, 23);
            this.simpleButtonShowLatestData.TabIndex = 1;
            this.simpleButtonShowLatestData.Text = "Show Latest Data";
            this.simpleButtonShowLatestData.Visible = false;
            this.simpleButtonShowLatestData.Click += new System.EventHandler(this.simpleButtonShowLatestData_Click);
            // 
            // FormFinNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 681);
            this.Controls.Add(this.simpleButtonShowLatestData);
            this.Controls.Add(this.gridControlNews);
            this.Name = "FormFinNews";
            this.Text = "Financial News";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNews;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonShowLatestData;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNews;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHeadline;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnImage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRelated;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSummary;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUrl;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPublishedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUnixTimeStamp;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFunctions;
    }
}

