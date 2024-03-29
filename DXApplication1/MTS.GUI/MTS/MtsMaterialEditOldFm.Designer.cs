﻿namespace MTS.GUI.MTS
{
    partial class MtsMaterialEditOldFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.quantityEdit = new DevExpress.XtraEditors.TextEdit();
            this.guageEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameBuyDetailEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.mtsMaterialValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.saveBtn1 = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn2 = new DevExpress.XtraEditors.SimpleButton();
            this.directoryBuyDetailsBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guageEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBuyDetailEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsMaterialValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityEdit
            // 
            this.quantityEdit.Location = new System.Drawing.Point(129, 73);
            this.quantityEdit.Name = "quantityEdit";
            this.quantityEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityEdit.Properties.Appearance.Options.UseFont = true;
            this.quantityEdit.Properties.Mask.EditMask = "f3";
            this.quantityEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.quantityEdit.Size = new System.Drawing.Size(352, 24);
            this.quantityEdit.TabIndex = 15;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Не вказано кількість ";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule1.Value1 = 0;
            this.mtsMaterialValidationProvider.SetValidationRule(this.quantityEdit, conditionValidationRule1);
            this.quantityEdit.EditValueChanged += new System.EventHandler(this.quantityEdit_EditValueChanged);
            // 
            // guageEdit
            // 
            this.guageEdit.Location = new System.Drawing.Point(128, 43);
            this.guageEdit.Name = "guageEdit";
            this.guageEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guageEdit.Properties.Appearance.Options.UseFont = true;
            this.guageEdit.Properties.ReadOnly = true;
            this.guageEdit.Size = new System.Drawing.Size(352, 24);
            this.guageEdit.TabIndex = 18;
            this.guageEdit.EditValueChanged += new System.EventHandler(this.guageEdit_EditValueChanged);
            // 
            // nameBuyDetailEdit
            // 
            this.nameBuyDetailEdit.Location = new System.Drawing.Point(129, 12);
            this.nameBuyDetailEdit.Name = "nameBuyDetailEdit";
            this.nameBuyDetailEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBuyDetailEdit.Properties.Appearance.Options.UseFont = true;
            this.nameBuyDetailEdit.Properties.ReadOnly = true;
            this.nameBuyDetailEdit.Size = new System.Drawing.Size(315, 24);
            this.nameBuyDetailEdit.TabIndex = 17;
            this.nameBuyDetailEdit.EditValueChanged += new System.EventHandler(this.nameBuyDetailEdit_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Кількість";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сортамент";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Найменування";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 110);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 49;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            this.validateLbl.Click += new System.EventHandler(this.validateLbl_Click);
            // 
            // mtsMaterialValidationProvider
            // 
            this.mtsMaterialValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.mtsMaterialValidationProvider_ValidationFailed);
            this.mtsMaterialValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.mtsMaterialValidationProvider_ValidationSucceeded);
            // 
            // saveBtn1
            // 
            this.saveBtn1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn1.Appearance.Options.UseFont = true;
            this.saveBtn1.Location = new System.Drawing.Point(296, 103);
            this.saveBtn1.Name = "saveBtn1";
            this.saveBtn1.Size = new System.Drawing.Size(87, 23);
            this.saveBtn1.TabIndex = 16;
            this.saveBtn1.Text = "Зберегти";
            this.saveBtn1.Click += new System.EventHandler(this.saveBtn1_Click);
            // 
            // cancelBtn2
            // 
            this.cancelBtn2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn2.Appearance.Options.UseFont = true;
            this.cancelBtn2.Location = new System.Drawing.Point(389, 103);
            this.cancelBtn2.Name = "cancelBtn2";
            this.cancelBtn2.Size = new System.Drawing.Size(91, 23);
            this.cancelBtn2.TabIndex = 51;
            this.cancelBtn2.Text = "Відмінити";
            this.cancelBtn2.Click += new System.EventHandler(this.cancelBtn2_Click);
            // 
            // directoryBuyDetailsBtn
            // 
            this.directoryBuyDetailsBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directoryBuyDetailsBtn.Appearance.Options.UseFont = true;
            this.directoryBuyDetailsBtn.Location = new System.Drawing.Point(450, 10);
            this.directoryBuyDetailsBtn.Name = "directoryBuyDetailsBtn";
            this.directoryBuyDetailsBtn.Size = new System.Drawing.Size(30, 27);
            this.directoryBuyDetailsBtn.TabIndex = 52;
            this.directoryBuyDetailsBtn.Text = "...";
            this.directoryBuyDetailsBtn.Click += new System.EventHandler(this.directoryBuyDetailsBtn_Click_1);
            // 
            // MtsMaterialEditOldFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 137);
            this.Controls.Add(this.directoryBuyDetailsBtn);
            this.Controls.Add(this.cancelBtn2);
            this.Controls.Add(this.saveBtn1);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.quantityEdit);
            this.Controls.Add(this.guageEdit);
            this.Controls.Add(this.nameBuyDetailEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MtsMaterialEditOldFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування матеріалів";
            this.Load += new System.EventHandler(this.MtsMaterialEditOldFm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MtsMaterialEditOldFm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guageEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBuyDetailEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsMaterialValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit quantityEdit;
        private DevExpress.XtraEditors.TextEdit guageEdit;
        private DevExpress.XtraEditors.TextEdit nameBuyDetailEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider mtsMaterialValidationProvider;
        private DevExpress.XtraEditors.SimpleButton saveBtn1;
        private DevExpress.XtraEditors.SimpleButton cancelBtn2;
        private DevExpress.XtraEditors.SimpleButton directoryBuyDetailsBtn;
    }
}