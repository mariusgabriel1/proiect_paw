
namespace proiect.View
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConturi = new System.Windows.Forms.TabPage();
            this.tabVenituri = new System.Windows.Forms.TabPage();
            this.tabCheltuieli = new System.Windows.Forms.TabPage();
            this.tabCreditori = new System.Windows.Forms.TabPage();
            this.tabDebitori = new System.Windows.Forms.TabPage();
            this.tabRapoarte = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabConturi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConturi);
            this.tabControl1.Controls.Add(this.tabVenituri);
            this.tabControl1.Controls.Add(this.tabCheltuieli);
            this.tabControl1.Controls.Add(this.tabCreditori);
            this.tabControl1.Controls.Add(this.tabDebitori);
            this.tabControl1.Controls.Add(this.tabRapoarte);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 553);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabConturi
            // 
            this.tabConturi.Controls.Add(this.dataGridView1);
            this.tabConturi.Location = new System.Drawing.Point(4, 39);
            this.tabConturi.Name = "tabConturi";
            this.tabConturi.Padding = new System.Windows.Forms.Padding(3);
            this.tabConturi.Size = new System.Drawing.Size(931, 510);
            this.tabConturi.TabIndex = 0;
            this.tabConturi.Text = "Conturi";
            this.tabConturi.UseVisualStyleBackColor = true;
            // 
            // tabVenituri
            // 
            this.tabVenituri.Location = new System.Drawing.Point(4, 39);
            this.tabVenituri.Name = "tabVenituri";
            this.tabVenituri.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenituri.Size = new System.Drawing.Size(931, 510);
            this.tabVenituri.TabIndex = 1;
            this.tabVenituri.Text = "Venituri";
            this.tabVenituri.UseVisualStyleBackColor = true;
            // 
            // tabCheltuieli
            // 
            this.tabCheltuieli.Location = new System.Drawing.Point(4, 39);
            this.tabCheltuieli.Name = "tabCheltuieli";
            this.tabCheltuieli.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheltuieli.Size = new System.Drawing.Size(931, 510);
            this.tabCheltuieli.TabIndex = 2;
            this.tabCheltuieli.Text = "Cheltuieli";
            this.tabCheltuieli.UseVisualStyleBackColor = true;
            // 
            // tabCreditori
            // 
            this.tabCreditori.Location = new System.Drawing.Point(4, 39);
            this.tabCreditori.Name = "tabCreditori";
            this.tabCreditori.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreditori.Size = new System.Drawing.Size(931, 510);
            this.tabCreditori.TabIndex = 3;
            this.tabCreditori.Text = "Creditori";
            this.tabCreditori.UseVisualStyleBackColor = true;
            // 
            // tabDebitori
            // 
            this.tabDebitori.Location = new System.Drawing.Point(4, 39);
            this.tabDebitori.Name = "tabDebitori";
            this.tabDebitori.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebitori.Size = new System.Drawing.Size(931, 510);
            this.tabDebitori.TabIndex = 4;
            this.tabDebitori.Text = "Debitori";
            this.tabDebitori.UseVisualStyleBackColor = true;
            // 
            // tabRapoarte
            // 
            this.tabRapoarte.Location = new System.Drawing.Point(4, 39);
            this.tabRapoarte.Name = "tabRapoarte";
            this.tabRapoarte.Padding = new System.Windows.Forms.Padding(3);
            this.tabRapoarte.Size = new System.Drawing.Size(931, 510);
            this.tabRapoarte.TabIndex = 5;
            this.tabRapoarte.Text = "Rapoarte";
            this.tabRapoarte.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(931, 503);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Proiect";
            this.tabControl1.ResumeLayout(false);
            this.tabConturi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConturi;
        private System.Windows.Forms.TabPage tabVenituri;
        private System.Windows.Forms.TabPage tabCheltuieli;
        private System.Windows.Forms.TabPage tabCreditori;
        private System.Windows.Forms.TabPage tabDebitori;
        private System.Windows.Forms.TabPage tabRapoarte;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}