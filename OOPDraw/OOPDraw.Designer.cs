namespace OOPDraw
{
    partial class OOPDraw
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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.LineWidth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColourOption = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrushOption = new System.Windows.Forms.ComboBox();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.ActionOption = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.Window;
            this.Canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Canvas.Location = new System.Drawing.Point(679, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(922, 793);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // LineWidth
            // 
            this.LineWidth.FormattingEnabled = true;
            this.LineWidth.Items.AddRange(new object[] {
            "Thin",
            "Medium",
            "Thick"});
            this.LineWidth.Location = new System.Drawing.Point(552, 31);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(121, 21);
            this.LineWidth.TabIndex = 1;
            this.LineWidth.SelectedIndexChanged += new System.EventHandler(this.LineWidth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Line Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colour";
            // 
            // ColourOption
            // 
            this.ColourOption.FormattingEnabled = true;
            this.ColourOption.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.ColourOption.Location = new System.Drawing.Point(552, 84);
            this.ColourOption.Name = "ColourOption";
            this.ColourOption.Size = new System.Drawing.Size(121, 21);
            this.ColourOption.TabIndex = 3;
            this.ColourOption.SelectedIndexChanged += new System.EventHandler(this.ColourOption_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brush";
            // 
            // BrushOption
            // 
            this.BrushOption.FormattingEnabled = true;
            this.BrushOption.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Ellipse",
            "Circle"});
            this.BrushOption.Location = new System.Drawing.Point(552, 136);
            this.BrushOption.Name = "BrushOption";
            this.BrushOption.Size = new System.Drawing.Size(121, 21);
            this.BrushOption.TabIndex = 5;
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Location = new System.Drawing.Point(549, 170);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(37, 13);
            this.ActionLabel.TabIndex = 8;
            this.ActionLabel.Text = "Action";
            // 
            // ActionOption
            // 
            this.ActionOption.FormattingEnabled = true;
            this.ActionOption.Items.AddRange(new object[] {
            "Draw",
            "Move",
            "Select"});
            this.ActionOption.Location = new System.Drawing.Point(552, 186);
            this.ActionOption.Name = "ActionOption";
            this.ActionOption.Size = new System.Drawing.Size(121, 21);
            this.ActionOption.TabIndex = 7;
            // 
            // OOPDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 817);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.ActionOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrushOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColourOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LineWidth);
            this.Controls.Add(this.Canvas);
            this.DoubleBuffered = true;
            this.Name = "OOPDraw";
            this.Text = "OOPDraw";
            this.Load += new System.EventHandler(this.OOPDraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.ComboBox LineWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ColourOption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BrushOption;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.ComboBox ActionOption;
    }
}

