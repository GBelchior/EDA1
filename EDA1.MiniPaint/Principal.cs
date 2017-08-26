using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Paint
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmPrincipal : System.Windows.Forms.Form
	{
		#region Atributos 
        private bool desenhando = false;
        private Point pontoAnterior;

        private System.Windows.Forms.PictureBox pbImagem;
		private System.Windows.Forms.OpenFileDialog ofdImagem;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnCor;
		private System.Windows.Forms.ColorDialog cdCor;
		private System.Windows.Forms.Panel pCor;
		/// <summary>
		/// Required designer variable.
		/// </summary>
        private System.ComponentModel.Container components = null;
        private CheckBox cbCaneta;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Label lblArea;
        private Label label1;
        private Panel panel1;
        #endregion

		#region Inicialização

        public Bitmap Image
        {
            get { return pbImagem.Image as Bitmap;
            }
        }

		public frmPrincipal()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmPrincipal());
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.btnCor = new System.Windows.Forms.Button();
            this.cdCor = new System.Windows.Forms.ColorDialog();
            this.pCor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCaneta = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagem
            // 
            this.pbImagem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbImagem.ErrorImage = null;
            this.pbImagem.Image = global::Paint.Properties.Resources.teste;
            this.pbImagem.InitialImage = null;
            this.pbImagem.Location = new System.Drawing.Point(17, 18);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(500, 500);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImagem.TabIndex = 0;
            this.pbImagem.TabStop = false;
            this.pbImagem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImagem_MouseDown);
            this.pbImagem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImagem_MouseMove);
            this.pbImagem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImagem_MouseUp);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(6, 67);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(88, 32);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "&Abrir...";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ofdImagem
            // 
            this.ofdImagem.DefaultExt = "BMP";
            this.ofdImagem.Filter = "Bitmap Files (*.BMP) | *.BMP";
            // 
            // btnCor
            // 
            this.btnCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCor.Location = new System.Drawing.Point(6, 117);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(88, 32);
            this.btnCor.TabIndex = 3;
            this.btnCor.Text = "&Colorir...";
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // pCor
            // 
            this.pCor.BackColor = System.Drawing.Color.Black;
            this.pCor.Location = new System.Drawing.Point(6, 155);
            this.pCor.Name = "pCor";
            this.pCor.Size = new System.Drawing.Size(86, 32);
            this.pCor.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbImagem);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 546);
            this.panel1.TabIndex = 5;
            // 
            // cbCaneta
            // 
            this.cbCaneta.AutoSize = true;
            this.cbCaneta.Location = new System.Drawing.Point(8, 208);
            this.cbCaneta.Name = "cbCaneta";
            this.cbCaneta.Size = new System.Drawing.Size(86, 24);
            this.cbCaneta.TabIndex = 7;
            this.cbCaneta.Tag = "Caneta";
            this.cbCaneta.Text = "Caneta";
            this.cbCaneta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnCor);
            this.groupBox1.Controls.Add(this.cbCaneta);
            this.groupBox1.Controls.Add(this.pCor);
            this.groupBox1.Location = new System.Drawing.Point(572, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 247);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandos:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "&Novo";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblArea);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(572, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 293);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área Colorida:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(8, 46);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(16, 18);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "0";
            // 
            // frmPrincipal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(748, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPrincipal";
            this.Text = "MiniPaint";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#endregion

		#region Eventos da Interface
		// Abrindo a imagem
		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			if (ofdImagem.ShowDialog() == DialogResult.OK)
			{
				Bitmap b = new Bitmap(ofdImagem.FileName);
				pbImagem.Image = b;
			}
		}

		// Escolhendo a Cor
		private void btnCor_Click(object sender, System.EventArgs e)
		{
			if (cdCor.ShowDialog() == DialogResult.OK)
			{
				pCor.BackColor = cdCor.Color;
			}
            pbImagem.Cursor = Cursors.Cross;
        }

		// Chamando função para colorir a partir do ponto escolhido
		private void pbImagem_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            desenhando = false;
            if (pbImagem.Cursor == Cursors.Cross)
            {
                Pintor p = new Pintor();
                Bitmap b = pbImagem.Image as Bitmap;
                lblArea.Text = p.Colorir(e.X, e.Y, pCor.BackColor, b).ToString() + " pixels";
                pbImagem.Image = b;
                pbImagem.Cursor = Cursors.Arrow;
            }
		}
		#endregion

        private void pbImagem_MouseDown(object sender, MouseEventArgs e)
        {
            if (cbCaneta.Checked)
            {
                desenhando = true;
                pontoAnterior = new Point(e.X, e.Y);
            }
        }

        private void pbImagem_MouseMove(object sender, MouseEventArgs e)
        {
            if (desenhando)
            {
                Graphics g = Graphics.FromImage(pbImagem.Image);
                g.DrawLine(new Pen(Color.Black, 2), pontoAnterior, new Point(e.X, e.Y));
                pbImagem.Refresh();

                pontoAnterior = new Point(e.X, e.Y);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(600, 600);
            Graphics g = Graphics.FromImage(b);
            g.FillRectangle(Brushes.White, 0, 0, b.Width, b.Height);
            pbImagem.Image = b;
            pbImagem.Refresh();

        }
	}
}
