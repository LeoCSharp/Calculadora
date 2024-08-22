namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textNumero1 = new DevExpress.XtraEditors.TextEdit();
            this.textNumero2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnCalcular = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.CboCalc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtResultado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textNumero1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumero2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboCalc.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNumero1
            // 
            this.textNumero1.Location = new System.Drawing.Point(348, 218);
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNumero1.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.textNumero1.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textNumero1.Properties.Appearance.Options.UseBackColor = true;
            this.textNumero1.Properties.Appearance.Options.UseFont = true;
            this.textNumero1.Properties.Appearance.Options.UseForeColor = true;
            this.textNumero1.Size = new System.Drawing.Size(100, 24);
            this.textNumero1.TabIndex = 1;
            this.textNumero1.EditValueChanged += new System.EventHandler(this.textNumero1_EditValueChanged);
            this.textNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumero1_KeyPress);
            // 
            // textNumero2
            // 
            this.textNumero2.Location = new System.Drawing.Point(348, 265);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNumero2.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.textNumero2.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textNumero2.Properties.Appearance.Options.UseBackColor = true;
            this.textNumero2.Properties.Appearance.Options.UseFont = true;
            this.textNumero2.Properties.Appearance.Options.UseForeColor = true;
            this.textNumero2.Size = new System.Drawing.Size(100, 24);
            this.textNumero2.TabIndex = 2;
            this.textNumero2.EditValueChanged += new System.EventHandler(this.textNumero2_EditValueChanged);
            this.textNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumero2_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(242, 220);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Número 1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(242, 268);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Número 2";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(348, 388);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(95, 27);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(348, 421);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(95, 27);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.svgImageBox1.Location = new System.Drawing.Point(336, 75);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(111, 102);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 7;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // CboCalc
            // 
            this.CboCalc.EditValue = "Escolher";
            this.CboCalc.Location = new System.Drawing.Point(347, 308);
            this.CboCalc.Name = "CboCalc";
            this.CboCalc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CboCalc.Properties.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.CboCalc.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CboCalc.Properties.Appearance.Options.UseBackColor = true;
            this.CboCalc.Properties.Appearance.Options.UseFont = true;
            this.CboCalc.Properties.Appearance.Options.UseForeColor = true;
            this.CboCalc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CboCalc.Properties.Items.AddRange(new object[] {
            "Soma",
            "Subtração",
            "Multiplicação",
            "Divisão"});
            this.CboCalc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CboCalc.Size = new System.Drawing.Size(100, 24);
            this.CboCalc.TabIndex = 8;
            this.CboCalc.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // TxtResultado
            // 
            this.TxtResultado.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TxtResultado.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.TxtResultado.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtResultado.Appearance.Options.UseBackColor = true;
            this.TxtResultado.Appearance.Options.UseFont = true;
            this.TxtResultado.Appearance.Options.UseForeColor = true;
            this.TxtResultado.Location = new System.Drawing.Point(363, 348);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(85, 18);
            this.TxtResultado.TabIndex = 9;
            this.TxtResultado.Text = "RESULTADO";
            this.TxtResultado.TabIndexChanged += new System.EventHandler(this.textNumero1_EditValueChanged);
            this.TxtResultado.Click += new System.EventHandler(this.TxtResultado_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(242, 310);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(100, 18);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Tipo de Cálculo";
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.AllowSnap = false;
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.simpleButton1);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(823, 33);
            this.sidePanel1.TabIndex = 11;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton1.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton1.AutoSize = true;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(765, -1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 36);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 18);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "CALCULADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(802, 574);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.CboCalc);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textNumero1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNumero2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboCalc.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit textNumero1;
        private DevExpress.XtraEditors.TextEdit textNumero2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnCalcular;
        private DevExpress.XtraEditors.SimpleButton BtnLimpar;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.ComboBoxEdit CboCalc;
        private DevExpress.XtraEditors.LabelControl TxtResultado;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

