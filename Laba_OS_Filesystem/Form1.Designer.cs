namespace Laba_OS_Filesystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SortedTextbox = new System.Windows.Forms.TextBox();
            this.UnsortedTextbox = new System.Windows.Forms.TextBox();
            this.Elipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.ChooseFileButton = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.ExitButton = new Guna.UI.WinForms.GunaButton();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // SortedTextbox
            // 
            this.SortedTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.SortedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SortedTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SortedTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortedTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.SortedTextbox.Location = new System.Drawing.Point(314, 39);
            this.SortedTextbox.Multiline = true;
            this.SortedTextbox.Name = "SortedTextbox";
            this.SortedTextbox.ReadOnly = true;
            this.SortedTextbox.Size = new System.Drawing.Size(270, 203);
            this.SortedTextbox.TabIndex = 11;
            this.SortedTextbox.MouseEnter += new System.EventHandler(this.MouseEnterSortedFile);
            this.SortedTextbox.MouseLeave += new System.EventHandler(this.MouseLeaveSortedFile);
            // 
            // UnsortedTextbox
            // 
            this.UnsortedTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.UnsortedTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnsortedTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.UnsortedTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnsortedTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.UnsortedTextbox.Location = new System.Drawing.Point(7, 39);
            this.UnsortedTextbox.Multiline = true;
            this.UnsortedTextbox.Name = "UnsortedTextbox";
            this.UnsortedTextbox.ReadOnly = true;
            this.UnsortedTextbox.Size = new System.Drawing.Size(280, 203);
            this.UnsortedTextbox.TabIndex = 10;
            this.UnsortedTextbox.MouseEnter += new System.EventHandler(this.MouseEnterYourFile);
            this.UnsortedTextbox.MouseLeave += new System.EventHandler(this.MouseLeaveYourFile);
            // 
            // Elipse
            // 
            this.Elipse.Radius = 7;
            this.Elipse.TargetControl = this;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(591, 32);
            this.TopPanel.TabIndex = 13;
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.AnimationHoverSpeed = 0.07F;
            this.ChooseFileButton.AnimationSpeed = 0.03F;
            this.ChooseFileButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ChooseFileButton.BorderColor = System.Drawing.Color.Black;
            this.ChooseFileButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ChooseFileButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ChooseFileButton.CheckedForeColor = System.Drawing.Color.White;
            this.ChooseFileButton.CheckedImage = null;
            this.ChooseFileButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ChooseFileButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChooseFileButton.FocusedColor = System.Drawing.Color.Empty;
            this.ChooseFileButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.ChooseFileButton.ForeColor = System.Drawing.Color.White;
            this.ChooseFileButton.Image = null;
            this.ChooseFileButton.ImageSize = new System.Drawing.Size(52, 52);
            this.ChooseFileButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChooseFileButton.Location = new System.Drawing.Point(12, 248);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ChooseFileButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChooseFileButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ChooseFileButton.OnHoverImage = null;
            this.ChooseFileButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChooseFileButton.OnPressedColor = System.Drawing.Color.Black;
            this.ChooseFileButton.Size = new System.Drawing.Size(567, 37);
            this.ChooseFileButton.TabIndex = 14;
            this.ChooseFileButton.Text = "Choose Test File";
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AnimationHoverSpeed = 0.07F;
            this.ExitButton.AnimationSpeed = 0.03F;
            this.ExitButton.BaseColor = System.Drawing.Color.Transparent;
            this.ExitButton.BorderColor = System.Drawing.Color.Black;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.FocusedColor = System.Drawing.Color.Empty;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ExitButton.Location = new System.Drawing.Point(552, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitButton.OnHoverImage = null;
            this.ExitButton.OnPressedColor = System.Drawing.Color.Black;
            this.ExitButton.Size = new System.Drawing.Size(27, 25);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(591, 297);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SortedTextbox);
            this.Controls.Add(this.UnsortedTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.TextBox SortedTextbox;
        private System.Windows.Forms.TextBox UnsortedTextbox;
        private Guna.UI.WinForms.GunaElipse Elipse;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaDragControl TopPanelDragControl;
        private Guna.UI.WinForms.GunaAdvenceTileButton ChooseFileButton;
        private Guna.UI.WinForms.GunaButton ExitButton;
    }
}

