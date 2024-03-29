﻿using System;
using System.Windows.Forms;

namespace MTS.GUI.MTS
{
    public partial class MtsSpecificationQuantityOldEditFm : DevExpress.XtraEditors.XtraForm
    {
        public MtsSpecificationQuantityOldEditFm()
        {
            InitializeComponent();
            ControlValidation();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //private void saveBtn_Click(object sender, EventArgs e)
        //{
        //    DialogResult = DialogResult.OK;
        //    this.Close();
        //}

        public int Return()
        {
            return Convert.ToInt32(quantityEdit.EditValue);
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void quantityEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }
        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        //private void cancelBtn3_Click(object sender, EventArgs e)
        //{
        //    DialogResult = DialogResult.Cancel;
        //    this.Close();
        //}
    }
}