
namespace Prog_lab2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.расчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomBorderField = new System.Windows.Forms.TextBox();
            this.accuracyField = new System.Windows.Forms.TextBox();
            this.topBorderField = new System.Windows.Forms.TextBox();
            this.formulaField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label5 = new System.Windows.Forms.Label();
            this.answerField = new System.Windows.Forms.TextBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // расчитатьToolStripMenuItem
            // 
            this.расчитатьToolStripMenuItem.Name = "расчитатьToolStripMenuItem";
            this.расчитатьToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.расчитатьToolStripMenuItem.Text = "Расчитать";
            this.расчитатьToolStripMenuItem.Click += new System.EventHandler(this.расчитатьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // bottomBorderField
            // 
            this.bottomBorderField.Location = new System.Drawing.Point(22, 52);
            this.bottomBorderField.Name = "bottomBorderField";
            this.bottomBorderField.Size = new System.Drawing.Size(110, 22);
            this.bottomBorderField.TabIndex = 1;
            // 
            // accuracyField
            // 
            this.accuracyField.Location = new System.Drawing.Point(303, 52);
            this.accuracyField.Name = "accuracyField";
            this.accuracyField.Size = new System.Drawing.Size(110, 22);
            this.accuracyField.TabIndex = 2;
            // 
            // topBorderField
            // 
            this.topBorderField.Location = new System.Drawing.Point(159, 52);
            this.topBorderField.Name = "topBorderField";
            this.topBorderField.Size = new System.Drawing.Size(110, 22);
            this.topBorderField.TabIndex = 3;
            // 
            // formulaField
            // 
            this.formulaField.Location = new System.Drawing.Point(435, 52);
            this.formulaField.Name = "formulaField";
            this.formulaField.Size = new System.Drawing.Size(240, 22);
            this.formulaField.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "e";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "f(x)";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 205);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(761, 462);
            this.zedGraphControl1.TabIndex = 9;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(19, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ответ";
            // 
            // answerField
            // 
            this.answerField.Location = new System.Drawing.Point(22, 133);
            this.answerField.Name = "answerField";
            this.answerField.Size = new System.Drawing.Size(203, 22);
            this.answerField.TabIndex = 11;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(343, 102);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 17);
            this.errorMessage.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.answerField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formulaField);
            this.Controls.Add(this.topBorderField);
            this.Controls.Add(this.accuracyField);
            this.Controls.Add(this.bottomBorderField);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem расчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.TextBox bottomBorderField;
        private System.Windows.Forms.TextBox accuracyField;
        private System.Windows.Forms.TextBox topBorderField;
        private System.Windows.Forms.TextBox formulaField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox answerField;
        private System.Windows.Forms.Label errorMessage;
    }
}

