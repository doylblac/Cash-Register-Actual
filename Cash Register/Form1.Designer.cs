namespace Cash_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.receiptButton = new System.Windows.Forms.Button();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.inputBurgers = new System.Windows.Forms.TextBox();
            this.friesLabel = new System.Windows.Forms.Label();
            this.inputFries = new System.Windows.Forms.TextBox();
            this.inputDrinks = new System.Windows.Forms.TextBox();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeInput = new System.Windows.Forms.TextBox();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Red;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.receiptButton.Location = new System.Drawing.Point(6, 358);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(146, 23);
            this.receiptButton.TabIndex = 0;
            this.receiptButton.Text = "Print Reciept";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.BackColor = System.Drawing.Color.Transparent;
            this.burgerLabel.Location = new System.Drawing.Point(4, 16);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(95, 13);
            this.burgerLabel.TabIndex = 1;
            this.burgerLabel.Text = "Number of Burgers";
            // 
            // inputBurgers
            // 
            this.inputBurgers.Location = new System.Drawing.Point(113, 16);
            this.inputBurgers.Name = "inputBurgers";
            this.inputBurgers.Size = new System.Drawing.Size(48, 20);
            this.inputBurgers.TabIndex = 2;
            this.inputBurgers.Text = "0";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.BackColor = System.Drawing.Color.Transparent;
            this.friesLabel.Location = new System.Drawing.Point(4, 46);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(81, 13);
            this.friesLabel.TabIndex = 3;
            this.friesLabel.Text = "Number of Fries";
            // 
            // inputFries
            // 
            this.inputFries.Location = new System.Drawing.Point(113, 43);
            this.inputFries.Name = "inputFries";
            this.inputFries.Size = new System.Drawing.Size(48, 20);
            this.inputFries.TabIndex = 4;
            this.inputFries.Text = "0";
            // 
            // inputDrinks
            // 
            this.inputDrinks.Location = new System.Drawing.Point(113, 70);
            this.inputDrinks.Name = "inputDrinks";
            this.inputDrinks.Size = new System.Drawing.Size(48, 20);
            this.inputDrinks.TabIndex = 5;
            this.inputDrinks.Text = "0";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.BackColor = System.Drawing.Color.Black;
            this.drinkLabel.Location = new System.Drawing.Point(4, 73);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(89, 13);
            this.drinkLabel.TabIndex = 6;
            this.drinkLabel.Text = "Number of Drinks";
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.Red;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalButton.Location = new System.Drawing.Point(6, 100);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(146, 23);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Calculate Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Red;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Location = new System.Drawing.Point(6, 280);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(146, 23);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Black;
            this.subtotalLabel.Location = new System.Drawing.Point(4, 136);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Black;
            this.taxLabel.Location = new System.Drawing.Point(4, 167);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 13);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Black;
            this.totalLabel.Location = new System.Drawing.Point(4, 197);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.subtotalOutput.Location = new System.Drawing.Point(50, 136);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(110, 31);
            this.subtotalOutput.TabIndex = 12;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.Location = new System.Drawing.Point(50, 167);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(96, 23);
            this.taxOutput.TabIndex = 13;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.Location = new System.Drawing.Point(50, 197);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(99, 23);
            this.totalOutput.TabIndex = 14;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.Black;
            this.tenderedLabel.Location = new System.Drawing.Point(3, 248);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(56, 13);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Black;
            this.changeLabel.Location = new System.Drawing.Point(3, 322);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(47, 13);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change:";
            // 
            // changeInput
            // 
            this.changeInput.Location = new System.Drawing.Point(94, 248);
            this.changeInput.Name = "changeInput";
            this.changeInput.Size = new System.Drawing.Size(64, 20);
            this.changeInput.TabIndex = 19;
            this.changeInput.Text = "0";
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Red;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newOrderButton.Location = new System.Drawing.Point(189, 358);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(143, 23);
            this.newOrderButton.TabIndex = 20;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.Location = new System.Drawing.Point(62, 322);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(96, 33);
            this.changeOutput.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(172, 393);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.changeInput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.inputDrinks);
            this.Controls.Add(this.inputFries);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.inputBurgers);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.receiptButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bob\'s Burger Banaza";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.TextBox inputBurgers;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.TextBox inputFries;
        private System.Windows.Forms.TextBox inputDrinks;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.TextBox changeInput;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label changeOutput;
    }
}

