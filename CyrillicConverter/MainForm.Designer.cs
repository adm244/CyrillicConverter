/*
This is free and unencumbered software released into the public domain.

Anyone is free to copy, modify, publish, use, compile, sell, or
distribute this software, either in source code form or as a compiled
binary, for any purpose, commercial or non-commercial, and by any
means.

In jurisdictions that recognize copyright laws, the author or authors
of this software dedicate any and all copyright interest in the
software to the public domain. We make this dedication for the benefit
of the public at large and to the detriment of our heirs and
successors. We intend this dedication to be an overt act of
relinquishment in perpetuity of all present and future rights to this
software under copyright law.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/

namespace CyrillicConverter
{
  partial class MainForm
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
      this.tbTextSource = new System.Windows.Forms.TextBox();
      this.lblSourceText = new System.Windows.Forms.Label();
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.pnlSourceFormat = new System.Windows.Forms.Panel();
      this.lblNoteText = new System.Windows.Forms.Label();
      this.cbSourceFormat = new System.Windows.Forms.ComboBox();
      this.tbTextResult = new System.Windows.Forms.TextBox();
      this.pnlResultFormat = new System.Windows.Forms.Panel();
      this.cbResultFormat = new System.Windows.Forms.ComboBox();
      this.lblResultText = new System.Windows.Forms.Label();
      this.pnlButtons = new System.Windows.Forms.Panel();
      this.btnSwapText = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnConvert = new System.Windows.Forms.Button();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.pnlSourceFormat.SuspendLayout();
      this.pnlResultFormat.SuspendLayout();
      this.pnlButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbTextSource
      // 
      this.tbTextSource.AcceptsTab = true;
      this.tbTextSource.CausesValidation = false;
      this.tbTextSource.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbTextSource.Location = new System.Drawing.Point(5, 18);
      this.tbTextSource.Multiline = true;
      this.tbTextSource.Name = "tbTextSource";
      this.tbTextSource.Size = new System.Drawing.Size(468, 119);
      this.tbTextSource.TabIndex = 0;
      this.tbTextSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTextSource_KeyDown);
      // 
      // lblSourceText
      // 
      this.lblSourceText.AutoSize = true;
      this.lblSourceText.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblSourceText.Location = new System.Drawing.Point(5, 5);
      this.lblSourceText.Name = "lblSourceText";
      this.lblSourceText.Size = new System.Drawing.Size(92, 13);
      this.lblSourceText.TabIndex = 1;
      this.lblSourceText.Text = "Исходный текст:";
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.Location = new System.Drawing.Point(0, 0);
      this.splitContainer.Name = "splitContainer";
      this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.tbTextSource);
      this.splitContainer.Panel1.Controls.Add(this.pnlSourceFormat);
      this.splitContainer.Panel1.Controls.Add(this.lblSourceText);
      this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(5);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.tbTextResult);
      this.splitContainer.Panel2.Controls.Add(this.pnlResultFormat);
      this.splitContainer.Panel2.Controls.Add(this.lblResultText);
      this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5);
      this.splitContainer.Size = new System.Drawing.Size(478, 391);
      this.splitContainer.SplitterDistance = 190;
      this.splitContainer.TabIndex = 2;
      // 
      // pnlSourceFormat
      // 
      this.pnlSourceFormat.Controls.Add(this.lblNoteText);
      this.pnlSourceFormat.Controls.Add(this.cbSourceFormat);
      this.pnlSourceFormat.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlSourceFormat.Location = new System.Drawing.Point(5, 137);
      this.pnlSourceFormat.Name = "pnlSourceFormat";
      this.pnlSourceFormat.Size = new System.Drawing.Size(468, 48);
      this.pnlSourceFormat.TabIndex = 2;
      // 
      // lblNoteText
      // 
      this.lblNoteText.AutoSize = true;
      this.lblNoteText.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblNoteText.Location = new System.Drawing.Point(0, 21);
      this.lblNoteText.Name = "lblNoteText";
      this.lblNoteText.Padding = new System.Windows.Forms.Padding(5);
      this.lblNoteText.Size = new System.Drawing.Size(341, 23);
      this.lblNoteText.TabIndex = 1;
      this.lblNoteText.Text = "Буквы Б,В,Г,Д,Ж,ё,х в кодировке windows-1252 могут теряются";
      // 
      // cbSourceFormat
      // 
      this.cbSourceFormat.Dock = System.Windows.Forms.DockStyle.Top;
      this.cbSourceFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSourceFormat.FormattingEnabled = true;
      this.cbSourceFormat.Location = new System.Drawing.Point(0, 0);
      this.cbSourceFormat.Name = "cbSourceFormat";
      this.cbSourceFormat.Size = new System.Drawing.Size(468, 21);
      this.cbSourceFormat.TabIndex = 0;
      // 
      // tbTextResult
      // 
      this.tbTextResult.AcceptsTab = true;
      this.tbTextResult.CausesValidation = false;
      this.tbTextResult.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbTextResult.Location = new System.Drawing.Point(5, 18);
      this.tbTextResult.Multiline = true;
      this.tbTextResult.Name = "tbTextResult";
      this.tbTextResult.Size = new System.Drawing.Size(468, 149);
      this.tbTextResult.TabIndex = 2;
      this.tbTextResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTextResult_KeyDown);
      // 
      // pnlResultFormat
      // 
      this.pnlResultFormat.Controls.Add(this.cbResultFormat);
      this.pnlResultFormat.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlResultFormat.Location = new System.Drawing.Point(5, 167);
      this.pnlResultFormat.Name = "pnlResultFormat";
      this.pnlResultFormat.Size = new System.Drawing.Size(468, 25);
      this.pnlResultFormat.TabIndex = 4;
      // 
      // cbResultFormat
      // 
      this.cbResultFormat.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbResultFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbResultFormat.FormattingEnabled = true;
      this.cbResultFormat.Location = new System.Drawing.Point(0, 0);
      this.cbResultFormat.Name = "cbResultFormat";
      this.cbResultFormat.Size = new System.Drawing.Size(468, 21);
      this.cbResultFormat.TabIndex = 1;
      // 
      // lblResultText
      // 
      this.lblResultText.AutoSize = true;
      this.lblResultText.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblResultText.Location = new System.Drawing.Point(5, 5);
      this.lblResultText.Name = "lblResultText";
      this.lblResultText.Size = new System.Drawing.Size(62, 13);
      this.lblResultText.TabIndex = 3;
      this.lblResultText.Text = "Результат:";
      // 
      // pnlButtons
      // 
      this.pnlButtons.Controls.Add(this.btnSwapText);
      this.pnlButtons.Controls.Add(this.btnClose);
      this.pnlButtons.Controls.Add(this.btnConvert);
      this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlButtons.Location = new System.Drawing.Point(0, 391);
      this.pnlButtons.Name = "pnlButtons";
      this.pnlButtons.Size = new System.Drawing.Size(478, 40);
      this.pnlButtons.TabIndex = 3;
      // 
      // btnSwapText
      // 
      this.btnSwapText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSwapText.Location = new System.Drawing.Point(228, 9);
      this.btnSwapText.Name = "btnSwapText";
      this.btnSwapText.Size = new System.Drawing.Size(125, 23);
      this.btnSwapText.TabIndex = 2;
      this.btnSwapText.Text = "Поменять местами";
      this.btnSwapText.UseVisualStyleBackColor = true;
      this.btnSwapText.Click += new System.EventHandler(this.btnSwapText_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(12, 9);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(107, 23);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Закрыть";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnConvert
      // 
      this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnConvert.Location = new System.Drawing.Point(359, 9);
      this.btnConvert.Name = "btnConvert";
      this.btnConvert.Size = new System.Drawing.Size(107, 23);
      this.btnConvert.TabIndex = 0;
      this.btnConvert.Text = "Преобразовать";
      this.btnConvert.UseVisualStyleBackColor = true;
      this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(478, 431);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.pnlButtons);
      this.MinimumSize = new System.Drawing.Size(390, 255);
      this.Name = "MainForm";
      this.ShowIcon = false;
      this.Text = "CyrillicConverter";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel1.PerformLayout();
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.Panel2.PerformLayout();
      this.splitContainer.ResumeLayout(false);
      this.pnlSourceFormat.ResumeLayout(false);
      this.pnlSourceFormat.PerformLayout();
      this.pnlResultFormat.ResumeLayout(false);
      this.pnlButtons.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox tbTextSource;
    private System.Windows.Forms.Label lblSourceText;
    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.TextBox tbTextResult;
    private System.Windows.Forms.Label lblResultText;
    private System.Windows.Forms.Panel pnlButtons;
    private System.Windows.Forms.Button btnConvert;
    private System.Windows.Forms.Panel pnlSourceFormat;
    private System.Windows.Forms.Panel pnlResultFormat;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSwapText;
    private System.Windows.Forms.ComboBox cbSourceFormat;
    private System.Windows.Forms.ComboBox cbResultFormat;
    private System.Windows.Forms.Label lblNoteText;
  }
}

