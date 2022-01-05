﻿namespace MTS.GUI.StoreHouse
{
    partial class StoreHouseRemainFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreHouseRemainFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.printBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addToInvoicesBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.storeHouseRemainsGrid = new DevExpress.XtraGrid.GridControl();
            this.storeHouseRemainsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nomenclaturesCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remainsQuantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.unitLocalNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remainsSumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.debitNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::MTS.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseRemainsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseRemainsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.dateEdit,
            this.showBtn,
            this.printBtn,
            this.addToInvoicesBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1383, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // dateEdit
            // 
            this.dateEdit.Caption = "Залишки на дату: ";
            this.dateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dateEdit.Edit = this.repositoryItemDateEdit2;
            this.dateEdit.EditWidth = 100;
            this.dateEdit.Id = 2;
            this.dateEdit.Name = "dateEdit";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // showBtn
            // 
            this.showBtn.Caption = "Показати";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 3;
            this.showBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showBtn.LargeGlyph")));
            this.showBtn.Name = "showBtn";
            this.showBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showBtn_ItemClick);
            // 
            // printBtn
            // 
            this.printBtn.Caption = "Сформувати звіт";
            this.printBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("printBtn.Glyph")));
            this.printBtn.Id = 4;
            this.printBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("printBtn.LargeGlyph")));
            this.printBtn.Name = "printBtn";
            this.printBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printBtn_ItemClick);
            // 
            // addToInvoicesBtn
            // 
            this.addToInvoicesBtn.Caption = "Додати до вимоги";
            this.addToInvoicesBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addToInvoicesBtn.Glyph")));
            this.addToInvoicesBtn.Id = 6;
            this.addToInvoicesBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addToInvoicesBtn.LargeGlyph")));
            this.addToInvoicesBtn.Name = "addToInvoicesBtn";
            this.addToInvoicesBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Формування даних";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.dateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.showBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Формування даних";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.printBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Функції";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.storeHouseRemainsGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 95);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1383, 614);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Залишки на складі";
            // 
            // storeHouseRemainsGrid
            // 
            this.storeHouseRemainsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeHouseRemainsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storeHouseRemainsGrid.Location = new System.Drawing.Point(2, 20);
            this.storeHouseRemainsGrid.MainView = this.storeHouseRemainsGridView;
            this.storeHouseRemainsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storeHouseRemainsGrid.MenuManager = this.ribbonControl1;
            this.storeHouseRemainsGrid.Name = "storeHouseRemainsGrid";
            this.storeHouseRemainsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit,
            this.repositoryItemSpinEdit});
            this.storeHouseRemainsGrid.Size = new System.Drawing.Size(1379, 592);
            this.storeHouseRemainsGrid.TabIndex = 0;
            this.storeHouseRemainsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.storeHouseRemainsGridView});
            // 
            // storeHouseRemainsGridView
            // 
            this.storeHouseRemainsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nomenclaturesCol,
            this.nameCol,
            this.receiptNumCol,
            this.orderDateCol,
            this.remainsQuantityCol,
            this.unitLocalNameCol,
            this.unitPriceCol,
            this.remainsSumCol,
            this.totalPriceCol,
            this.debitNumCol});
            this.storeHouseRemainsGridView.GridControl = this.storeHouseRemainsGrid;
            this.storeHouseRemainsGridView.Name = "storeHouseRemainsGridView";
            this.storeHouseRemainsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.storeHouseRemainsGridView.OptionsView.ShowAutoFilterRow = true;
            this.storeHouseRemainsGridView.OptionsView.ShowFooter = true;
            this.storeHouseRemainsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // nomenclaturesCol
            // 
            this.nomenclaturesCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclaturesCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclaturesCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.nomenclaturesCol.Caption = "Номенклатурний номер";
            this.nomenclaturesCol.FieldName = "Nomenclatures";
            this.nomenclaturesCol.Name = "nomenclaturesCol";
            this.nomenclaturesCol.OptionsColumn.AllowEdit = false;
            this.nomenclaturesCol.OptionsColumn.AllowFocus = false;
            this.nomenclaturesCol.Visible = true;
            this.nomenclaturesCol.VisibleIndex = 0;
            this.nomenclaturesCol.Width = 145;
            // 
            // nameCol
            // 
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.nameCol.Caption = "Найменування";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            this.nameCol.Width = 247;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.receiptNumCol.Caption = "Номер надходження";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsColumn.AllowFocus = false;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.VisibleIndex = 2;
            this.receiptNumCol.Width = 108;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.orderDateCol.Caption = "Дата";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 3;
            this.orderDateCol.Width = 108;
            // 
            // remainsQuantityCol
            // 
            this.remainsQuantityCol.AppearanceHeader.Options.UseTextOptions = true;
            this.remainsQuantityCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.remainsQuantityCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.remainsQuantityCol.Caption = "Залишок, кількість";
            this.remainsQuantityCol.ColumnEdit = this.repositoryItemSpinEdit;
            this.remainsQuantityCol.FieldName = "RemainsQuantity";
            this.remainsQuantityCol.Name = "remainsQuantityCol";
            this.remainsQuantityCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RemainsQuantity", "{0:### ### ##0.##}")});
            this.remainsQuantityCol.Visible = true;
            this.remainsQuantityCol.VisibleIndex = 4;
            this.remainsQuantityCol.Width = 108;
            // 
            // repositoryItemSpinEdit
            // 
            this.repositoryItemSpinEdit.AutoHeight = false;
            this.repositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit.Name = "repositoryItemSpinEdit";
            // 
            // unitLocalNameCol
            // 
            this.unitLocalNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitLocalNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitLocalNameCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.unitLocalNameCol.Caption = "Один. вимірювань";
            this.unitLocalNameCol.FieldName = "UnitLocalName";
            this.unitLocalNameCol.Name = "unitLocalNameCol";
            this.unitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.unitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.unitLocalNameCol.Visible = true;
            this.unitLocalNameCol.VisibleIndex = 5;
            this.unitLocalNameCol.Width = 195;
            // 
            // unitPriceCol
            // 
            this.unitPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitPriceCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.unitPriceCol.Caption = "Ціна за одиницю";
            this.unitPriceCol.FieldName = "UnitPrice";
            this.unitPriceCol.Name = "unitPriceCol";
            this.unitPriceCol.OptionsColumn.AllowEdit = false;
            this.unitPriceCol.OptionsColumn.AllowFocus = false;
            this.unitPriceCol.Visible = true;
            this.unitPriceCol.VisibleIndex = 6;
            this.unitPriceCol.Width = 92;
            // 
            // remainsSumCol
            // 
            this.remainsSumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.remainsSumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.remainsSumCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.remainsSumCol.Caption = "Сума залишку";
            this.remainsSumCol.FieldName = "RemainsSum";
            this.remainsSumCol.Name = "remainsSumCol";
            this.remainsSumCol.OptionsColumn.AllowEdit = false;
            this.remainsSumCol.OptionsColumn.AllowFocus = false;
            this.remainsSumCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RemainsSum", "{0:### ### ##0.##}")});
            this.remainsSumCol.Visible = true;
            this.remainsSumCol.VisibleIndex = 7;
            this.remainsSumCol.Width = 89;
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.totalPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.totalPriceCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.totalPriceCol.Caption = "Сума надходження";
            this.totalPriceCol.FieldName = "TotalPrice";
            this.totalPriceCol.Name = "totalPriceCol";
            this.totalPriceCol.OptionsColumn.AllowEdit = false;
            this.totalPriceCol.OptionsColumn.AllowFocus = false;
            this.totalPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:### ### ##0.##}")});
            this.totalPriceCol.Visible = true;
            this.totalPriceCol.VisibleIndex = 8;
            this.totalPriceCol.Width = 89;
            // 
            // debitNumCol
            // 
            this.debitNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.debitNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.debitNumCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.debitNumCol.Caption = "Дебет";
            this.debitNumCol.FieldName = "DebitNum";
            this.debitNumCol.Name = "debitNumCol";
            this.debitNumCol.OptionsColumn.AllowEdit = false;
            this.debitNumCol.OptionsColumn.AllowFocus = false;
            this.debitNumCol.Visible = true;
            this.debitNumCol.VisibleIndex = 9;
            this.debitNumCol.Width = 133;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCheckEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Caption = "";
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // StoreHouseRemainFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 709);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreHouseRemainFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Залишки на скаладі";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseRemainsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseRemainsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.GridControl storeHouseRemainsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView storeHouseRemainsGridView;
        private DevExpress.XtraBars.BarEditItem dateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraBars.BarButtonItem printBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclaturesCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn receiptNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn remainsQuantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitLocalNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn remainsSumCol;
        private DevExpress.XtraGrid.Columns.GridColumn totalPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn debitNumCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarButtonItem addToInvoicesBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit;
    }
}