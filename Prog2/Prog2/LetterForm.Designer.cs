namespace UPVApp
{
    partial class LetterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.originAddressBx = new System.Windows.Forms.ComboBox();
            this.destinationAddressBx = new System.Windows.Forms.ComboBox();
            this.fixedCostBx = new System.Windows.Forms.TextBox();
            this.originError = new System.Windows.Forms.ErrorProvider(this.components);
            this.destinationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.fixedCostError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Ok_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedCostError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origin Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fixed Cost:";
            // 
            // originAddressBx
            // 
            this.originAddressBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originAddressBx.FormattingEnabled = true;
            this.originAddressBx.Location = new System.Drawing.Point(157, 20);
            this.originAddressBx.Name = "originAddressBx";
            this.originAddressBx.Size = new System.Drawing.Size(121, 24);
            this.originAddressBx.TabIndex = 3;
            this.originAddressBx.Validating += new System.ComponentModel.CancelEventHandler(this.originAddressBx_Validating);
            this.originAddressBx.Validated += new System.EventHandler(this.originAddressBx_Validated);
            // 
            // destinationAddressBx
            // 
            this.destinationAddressBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationAddressBx.FormattingEnabled = true;
            this.destinationAddressBx.Location = new System.Drawing.Point(157, 65);
            this.destinationAddressBx.Name = "destinationAddressBx";
            this.destinationAddressBx.Size = new System.Drawing.Size(121, 24);
            this.destinationAddressBx.TabIndex = 4;
            this.destinationAddressBx.Validating += new System.ComponentModel.CancelEventHandler(this.destinationAddressBx_Validating);
            this.destinationAddressBx.Validated += new System.EventHandler(this.destinationAddressBx_Validated);
            // 
            // fixedCostBx
            // 
            this.fixedCostBx.Location = new System.Drawing.Point(157, 109);
            this.fixedCostBx.Name = "fixedCostBx";
            this.fixedCostBx.Size = new System.Drawing.Size(121, 22);
            this.fixedCostBx.TabIndex = 5;
            this.fixedCostBx.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostBx_Validating);
            this.fixedCostBx.Validated += new System.EventHandler(this.fixedCostBx_Validated);
            // 
            // originError
            // 
            this.originError.ContainerControl = this;
            // 
            // destinationError
            // 
            this.destinationError.ContainerControl = this;
            // 
            // fixedCostError
            // 
            this.fixedCostError.ContainerControl = this;
            // 
            // Ok_Button
            // 
            this.Ok_Button.Location = new System.Drawing.Point(76, 158);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(75, 23);
            this.Ok_Button.TabIndex = 6;
            this.Ok_Button.Text = "OK";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Click += new System.EventHandler(this.Ok_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(203, 158);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // LetterForm
            // 
            this.AcceptButton = this.Ok_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 213);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Ok_Button);
            this.Controls.Add(this.fixedCostBx);
            this.Controls.Add(this.destinationAddressBx);
            this.Controls.Add(this.originAddressBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedCostError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox originAddressBx;
        private System.Windows.Forms.ComboBox destinationAddressBx;
        private System.Windows.Forms.TextBox fixedCostBx;
        private System.Windows.Forms.ErrorProvider originError;
        private System.Windows.Forms.ErrorProvider destinationError;
        private System.Windows.Forms.ErrorProvider fixedCostError;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Ok_Button;
    }
}