namespace Convertir_CSV_a_Excel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            BtnAbrirCSV = new Button();
            TxtRutaCSV = new TextBox();
            DgvExcel = new DataGridView();
            BtnConvertirExcel = new Button();
            BtnMostarArchivo = new Button();
            Ofd = new OpenFileDialog();
            BtnLimpiarDatos = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvExcel).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Archivo CSV";
            // 
            // BtnAbrirCSV
            // 
            BtnAbrirCSV.Location = new Point(26, 64);
            BtnAbrirCSV.Name = "BtnAbrirCSV";
            BtnAbrirCSV.Size = new Size(146, 23);
            BtnAbrirCSV.TabIndex = 1;
            BtnAbrirCSV.Text = "Abrir CSV";
            BtnAbrirCSV.UseVisualStyleBackColor = true;
            BtnAbrirCSV.Click += BtnAbrirCSV_Click;
            // 
            // TxtRutaCSV
            // 
            TxtRutaCSV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtRutaCSV.Location = new Point(151, 33);
            TxtRutaCSV.Name = "TxtRutaCSV";
            TxtRutaCSV.Size = new Size(1133, 23);
            TxtRutaCSV.TabIndex = 2;
            // 
            // DgvExcel
            // 
            DgvExcel.AllowUserToAddRows = false;
            DgvExcel.AllowUserToDeleteRows = false;
            DgvExcel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvExcel.Location = new Point(26, 106);
            DgvExcel.Name = "DgvExcel";
            DgvExcel.Size = new Size(1258, 623);
            DgvExcel.TabIndex = 4;
            // 
            // BtnConvertirExcel
            // 
            BtnConvertirExcel.Location = new Point(197, 64);
            BtnConvertirExcel.Name = "BtnConvertirExcel";
            BtnConvertirExcel.Size = new Size(146, 23);
            BtnConvertirExcel.TabIndex = 5;
            BtnConvertirExcel.Text = "Convertir a Excel";
            BtnConvertirExcel.UseVisualStyleBackColor = true;
            BtnConvertirExcel.Click += BtnConvertirExcel_Click;
            // 
            // BtnMostarArchivo
            // 
            BtnMostarArchivo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMostarArchivo.Location = new Point(1138, 64);
            BtnMostarArchivo.Name = "BtnMostarArchivo";
            BtnMostarArchivo.Size = new Size(146, 23);
            BtnMostarArchivo.TabIndex = 6;
            BtnMostarArchivo.Text = "Mostrar Archivo Excel";
            BtnMostarArchivo.UseVisualStyleBackColor = true;
            BtnMostarArchivo.Click += BtnMostarArchivo_Click;
            // 
            // Ofd
            // 
            Ofd.FileName = "openFileDialog1";
            // 
            // BtnLimpiarDatos
            // 
            BtnLimpiarDatos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnLimpiarDatos.Location = new Point(958, 64);
            BtnLimpiarDatos.Name = "BtnLimpiarDatos";
            BtnLimpiarDatos.Size = new Size(146, 23);
            BtnLimpiarDatos.TabIndex = 7;
            BtnLimpiarDatos.Text = "Limpiar Datos";
            BtnLimpiarDatos.UseVisualStyleBackColor = true;
            BtnLimpiarDatos.Click += BtnLimpiarDatos_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1109, 737);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 8;
            label2.Text = "Roberto Reyes García, Julio 2024";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1004, 737);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Versión 1.5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 761);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnLimpiarDatos);
            Controls.Add(BtnMostarArchivo);
            Controls.Add(BtnConvertirExcel);
            Controls.Add(DgvExcel);
            Controls.Add(TxtRutaCSV);
            Controls.Add(BtnAbrirCSV);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Convertir CSV a Excel";
            ((System.ComponentModel.ISupportInitialize)DgvExcel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnAbrirCSV;
        private TextBox TxtRutaCSV;
        private DataGridView DgvExcel;
        private Button BtnConvertirExcel;
        private Button BtnMostarArchivo;
        private OpenFileDialog Ofd;
        private Button BtnLimpiarDatos;
        private Label label2;
        private Label label3;
    }
}
