namespace UPVApp
{
    partial class AddressForm
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
            this.nameBx = new System.Windows.Forms.TextBox();
            this.addressBx = new System.Windows.Forms.TextBox();
            this.addressBx1 = new System.Windows.Forms.TextBox();
            this.cityBx = new System.Windows.Forms.TextBox();
            this.zipBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stateBx = new System.Windows.Forms.ComboBox();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressError = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressError1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cityError = new System.Windows.Forms.ErrorProvider(this.components);
            this.stateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.zipError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressError1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipError)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBx
            // 
            this.nameBx.Location = new System.Drawing.Point(137, 22);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(100, 22);
            this.nameBx.TabIndex = 0;
            this.nameBx.Validating += new System.ComponentModel.CancelEventHandler(this.nameBx_Validating);
            this.nameBx.Validated += new System.EventHandler(this.nameBx_Validated);
            // 
            // addressBx
            // 
            this.addressBx.Location = new System.Drawing.Point(137, 51);
            this.addressBx.Name = "addressBx";
            this.addressBx.Size = new System.Drawing.Size(100, 22);
            this.addressBx.TabIndex = 1;
            this.addressBx.Validating += new System.ComponentModel.CancelEventHandler(this.addressBx_Validating);
            this.addressBx.Validated += new System.EventHandler(this.addressBx_Validated);
            // 
            // addressBx1
            // 
            this.addressBx1.Location = new System.Drawing.Point(137, 80);
            this.addressBx1.Name = "addressBx1";
            this.addressBx1.Size = new System.Drawing.Size(100, 22);
            this.addressBx1.TabIndex = 2;
            this.addressBx1.Validating += new System.ComponentModel.CancelEventHandler(this.addressBx1_Validating);
            this.addressBx1.Validated += new System.EventHandler(this.addressBx1_Validated);
            // 
            // cityBx
            // 
            this.cityBx.Location = new System.Drawing.Point(137, 109);
            this.cityBx.Name = "cityBx";
            this.cityBx.Size = new System.Drawing.Size(100, 22);
            this.cityBx.TabIndex = 3;
            this.cityBx.Validating += new System.ComponentModel.CancelEventHandler(this.cityBx_Validating);
            this.cityBx.Validated += new System.EventHandler(this.cityBx_Validated);
            // 
            // zipBx
            // 
            this.zipBx.Location = new System.Drawing.Point(137, 167);
            this.zipBx.Name = "zipBx";
            this.zipBx.Size = new System.Drawing.Size(100, 22);
            this.zipBx.TabIndex = 5;
            this.zipBx.Validating += new System.ComponentModel.CancelEventHandler(this.zipBx_Validating);
            this.zipBx.Validated += new System.EventHandler(this.zipBx_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zip";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(76, 213);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(182, 213);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // stateBx
            // 
            this.stateBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateBx.Items.AddRange(new object[] {
            "KY",
            "TX",
            "IN",
            "AZ",
            "NY",
            "FL",
            "AL",
            "CA",
            "CO",
            "TN",
            "OH",
            "MI",
            "WV"});
            this.stateBx.Location = new System.Drawing.Point(137, 136);
            this.stateBx.Name = "stateBx";
            this.stateBx.Size = new System.Drawing.Size(100, 24);
            this.stateBx.TabIndex = 4;
            this.stateBx.Validating += new System.ComponentModel.CancelEventHandler(this.stateBx_Validating);
            this.stateBx.Validated += new System.EventHandler(this.stateBx_Validated);
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // addressError
            // 
            this.addressError.ContainerControl = this;
            // 
            // addressError1
            // 
            this.addressError1.ContainerControl = this;
            // 
            // cityError
            // 
            this.cityError.ContainerControl = this;
            // 
            // stateError
            // 
            this.stateError.ContainerControl = this;
            // 
            // zipError
            // 
            this.zipError.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 255);
            this.Controls.Add(this.stateBx);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zipBx);
            this.Controls.Add(this.cityBx);
            this.Controls.Add(this.addressBx1);
            this.Controls.Add(this.addressBx);
            this.Controls.Add(this.nameBx);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressError1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        internal System.Windows.Forms.TextBox nameBx;
        internal System.Windows.Forms.TextBox addressBx;
        internal System.Windows.Forms.TextBox addressBx1;
        internal System.Windows.Forms.TextBox cityBx;
        internal System.Windows.Forms.TextBox zipBx;
        internal System.Windows.Forms.ComboBox stateBx;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider addressError;
        private System.Windows.Forms.ErrorProvider addressError1;
        private System.Windows.Forms.ErrorProvider cityError;
        private System.Windows.Forms.ErrorProvider stateError;
        private System.Windows.Forms.ErrorProvider zipError;
    }
}