namespace OiniciodofimV2
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.title = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.Label();
            this.btnArma = new System.Windows.Forms.Button();
            this.btn_armadura = new System.Windows.Forms.Button();
            this.btn_item = new System.Windows.Forms.Button();
            this.btn_municao = new System.Windows.Forms.Button();
            this.btn_monstro = new System.Windows.Forms.Button();
            this.btn_veiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.Window;
            this.title.Font = new System.Drawing.Font("Verdana", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(190, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(874, 130);
            this.title.TabIndex = 0;
            this.title.Text = "O Inicio do Fim";
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.BackColor = System.Drawing.SystemColors.Window;
            this.Subtitle.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(312, 169);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(611, 32);
            this.Subtitle.TabIndex = 1;
            this.Subtitle.Text = "Para alguns, o fim é apenas o inicio de tudo";
            // 
            // btnArma
            // 
            this.btnArma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnArma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArma.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArma.Location = new System.Drawing.Point(301, 384);
            this.btnArma.Name = "btnArma";
            this.btnArma.Size = new System.Drawing.Size(126, 39);
            this.btnArma.TabIndex = 2;
            this.btnArma.Text = "Armas";
            this.btnArma.UseVisualStyleBackColor = false;
            this.btnArma.Click += new System.EventHandler(this.btnArma_Click);
            // 
            // btn_armadura
            // 
            this.btn_armadura.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_armadura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_armadura.Location = new System.Drawing.Point(580, 384);
            this.btn_armadura.Name = "btn_armadura";
            this.btn_armadura.Size = new System.Drawing.Size(126, 39);
            this.btn_armadura.TabIndex = 3;
            this.btn_armadura.Text = "Armaduras";
            this.btn_armadura.UseVisualStyleBackColor = false;
            this.btn_armadura.Click += new System.EventHandler(this.btn_armadura_Click);
            // 
            // btn_item
            // 
            this.btn_item.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_item.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item.Location = new System.Drawing.Point(838, 384);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(126, 39);
            this.btn_item.TabIndex = 4;
            this.btn_item.Text = "Itens";
            this.btn_item.UseVisualStyleBackColor = false;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // btn_municao
            // 
            this.btn_municao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_municao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_municao.Location = new System.Drawing.Point(301, 501);
            this.btn_municao.Name = "btn_municao";
            this.btn_municao.Size = new System.Drawing.Size(126, 39);
            this.btn_municao.TabIndex = 5;
            this.btn_municao.Text = "Munição";
            this.btn_municao.UseVisualStyleBackColor = false;
            // 
            // btn_monstro
            // 
            this.btn_monstro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_monstro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_monstro.Location = new System.Drawing.Point(580, 501);
            this.btn_monstro.Name = "btn_monstro";
            this.btn_monstro.Size = new System.Drawing.Size(126, 39);
            this.btn_monstro.TabIndex = 6;
            this.btn_monstro.Text = "Monstros";
            this.btn_monstro.UseVisualStyleBackColor = false;
            // 
            // btn_veiculo
            // 
            this.btn_veiculo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_veiculo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veiculo.Location = new System.Drawing.Point(838, 501);
            this.btn_veiculo.Name = "btn_veiculo";
            this.btn_veiculo.Size = new System.Drawing.Size(126, 39);
            this.btn_veiculo.TabIndex = 7;
            this.btn_veiculo.Text = "Veículos";
            this.btn_veiculo.UseVisualStyleBackColor = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1321, 727);
            this.Controls.Add(this.btn_veiculo);
            this.Controls.Add(this.btn_monstro);
            this.Controls.Add(this.btn_municao);
            this.Controls.Add(this.btn_item);
            this.Controls.Add(this.btn_armadura);
            this.Controls.Add(this.btnArma);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.Text = "O Inicio do Fim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Button btnArma;
        private System.Windows.Forms.Button btn_armadura;
        private System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.Button btn_municao;
        private System.Windows.Forms.Button btn_monstro;
        private System.Windows.Forms.Button btn_veiculo;

    }
}

