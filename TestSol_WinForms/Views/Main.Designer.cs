namespace TestSol_WinForms
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TCMain = new System.Windows.Forms.TabControl();
            this.TPAdd = new System.Windows.Forms.TabPage();
            this.TPUpdate = new System.Windows.Forms.TabPage();
            this.TPDelete = new System.Windows.Forms.TabPage();
            this.PnlAdd = new System.Windows.Forms.Panel();
            this.LblNameAdd = new System.Windows.Forms.Label();
            this.TxtNameAdd = new System.Windows.Forms.TextBox();
            this.TxtApePatAdd = new System.Windows.Forms.TextBox();
            this.LblApePatAdd = new System.Windows.Forms.Label();
            this.TxtApeMatAdd = new System.Windows.Forms.TextBox();
            this.LblApeMatAdd = new System.Windows.Forms.Label();
            this.LblAreaAdd = new System.Windows.Forms.Label();
            this.LblFechaNacAdd = new System.Windows.Forms.Label();
            this.TxtSueldoAdd = new System.Windows.Forms.TextBox();
            this.LblSueldoAdd = new System.Windows.Forms.Label();
            this.CmbAreaAdd = new System.Windows.Forms.ComboBox();
            this.DTPFechaNacAdd = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlUpdate = new System.Windows.Forms.Panel();
            this.LblNameUp = new System.Windows.Forms.Label();
            this.TxtNameUp = new System.Windows.Forms.TextBox();
            this.LblApePatUp = new System.Windows.Forms.Label();
            this.TxtApePatUp = new System.Windows.Forms.TextBox();
            this.LblApeMatUp = new System.Windows.Forms.Label();
            this.TxtApeMatUp = new System.Windows.Forms.TextBox();
            this.LblAreaUp = new System.Windows.Forms.Label();
            this.CmbAreaUp = new System.Windows.Forms.ComboBox();
            this.LblFechaNacUp = new System.Windows.Forms.Label();
            this.DTPFechaNacUp = new System.Windows.Forms.DateTimePicker();
            this.LblSueldoUp = new System.Windows.Forms.Label();
            this.TxtSueldoUp = new System.Windows.Forms.TextBox();
            this.BtnUp = new System.Windows.Forms.Button();
            this.LblIdUp = new System.Windows.Forms.Label();
            this.TxtIdUp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblIdDel = new System.Windows.Forms.Label();
            this.TxtIdDel = new System.Windows.Forms.TextBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.TPShow = new System.Windows.Forms.TabPage();
            this.PnlShow = new System.Windows.Forms.Panel();
            this.DGVShow = new System.Windows.Forms.DataGridView();
            this.TCMain.SuspendLayout();
            this.TPAdd.SuspendLayout();
            this.TPUpdate.SuspendLayout();
            this.TPDelete.SuspendLayout();
            this.PnlAdd.SuspendLayout();
            this.PnlUpdate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TPShow.SuspendLayout();
            this.PnlShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShow)).BeginInit();
            this.SuspendLayout();
            // 
            // TCMain
            // 
            this.TCMain.Controls.Add(this.TPShow);
            this.TCMain.Controls.Add(this.TPAdd);
            this.TCMain.Controls.Add(this.TPUpdate);
            this.TCMain.Controls.Add(this.TPDelete);
            this.TCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCMain.Location = new System.Drawing.Point(9, 8);
            this.TCMain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TCMain.Name = "TCMain";
            this.TCMain.SelectedIndex = 0;
            this.TCMain.Size = new System.Drawing.Size(716, 445);
            this.TCMain.TabIndex = 0;
            // 
            // TPAdd
            // 
            this.TPAdd.Controls.Add(this.PnlAdd);
            this.TPAdd.Location = new System.Drawing.Point(4, 30);
            this.TPAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TPAdd.Name = "TPAdd";
            this.TPAdd.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.TPAdd.Size = new System.Drawing.Size(708, 411);
            this.TPAdd.TabIndex = 1;
            this.TPAdd.Text = "Agregar";
            this.TPAdd.UseVisualStyleBackColor = true;
            // 
            // TPUpdate
            // 
            this.TPUpdate.Controls.Add(this.PnlUpdate);
            this.TPUpdate.Location = new System.Drawing.Point(4, 30);
            this.TPUpdate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TPUpdate.Name = "TPUpdate";
            this.TPUpdate.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TPUpdate.Size = new System.Drawing.Size(708, 411);
            this.TPUpdate.TabIndex = 2;
            this.TPUpdate.Text = "Actualizar";
            this.TPUpdate.UseVisualStyleBackColor = true;
            // 
            // TPDelete
            // 
            this.TPDelete.Controls.Add(this.panel1);
            this.TPDelete.Location = new System.Drawing.Point(4, 30);
            this.TPDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TPDelete.Name = "TPDelete";
            this.TPDelete.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TPDelete.Size = new System.Drawing.Size(708, 411);
            this.TPDelete.TabIndex = 3;
            this.TPDelete.Text = "Borrar";
            this.TPDelete.UseVisualStyleBackColor = true;
            // 
            // PnlAdd
            // 
            this.PnlAdd.Controls.Add(this.LblNameAdd);
            this.PnlAdd.Controls.Add(this.TxtNameAdd);
            this.PnlAdd.Controls.Add(this.LblApePatAdd);
            this.PnlAdd.Controls.Add(this.TxtApePatAdd);
            this.PnlAdd.Controls.Add(this.LblApeMatAdd);
            this.PnlAdd.Controls.Add(this.TxtApeMatAdd);
            this.PnlAdd.Controls.Add(this.LblAreaAdd);
            this.PnlAdd.Controls.Add(this.CmbAreaAdd);
            this.PnlAdd.Controls.Add(this.LblFechaNacAdd);
            this.PnlAdd.Controls.Add(this.DTPFechaNacAdd);
            this.PnlAdd.Controls.Add(this.LblSueldoAdd);
            this.PnlAdd.Controls.Add(this.TxtSueldoAdd);
            this.PnlAdd.Controls.Add(this.BtnAdd);
            this.PnlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAdd.Location = new System.Drawing.Point(9, 8);
            this.PnlAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PnlAdd.Name = "PnlAdd";
            this.PnlAdd.Size = new System.Drawing.Size(690, 395);
            this.PnlAdd.TabIndex = 0;
            // 
            // LblNameAdd
            // 
            this.LblNameAdd.AutoSize = true;
            this.LblNameAdd.Location = new System.Drawing.Point(45, 38);
            this.LblNameAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblNameAdd.Name = "LblNameAdd";
            this.LblNameAdd.Size = new System.Drawing.Size(73, 21);
            this.LblNameAdd.TabIndex = 0;
            this.LblNameAdd.Text = "Nombre";
            // 
            // TxtNameAdd
            // 
            this.TxtNameAdd.Location = new System.Drawing.Point(49, 64);
            this.TxtNameAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtNameAdd.Name = "TxtNameAdd";
            this.TxtNameAdd.Size = new System.Drawing.Size(164, 27);
            this.TxtNameAdd.TabIndex = 1;
            // 
            // TxtApePatAdd
            // 
            this.TxtApePatAdd.Location = new System.Drawing.Point(268, 64);
            this.TxtApePatAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtApePatAdd.Name = "TxtApePatAdd";
            this.TxtApePatAdd.Size = new System.Drawing.Size(164, 27);
            this.TxtApePatAdd.TabIndex = 3;
            // 
            // LblApePatAdd
            // 
            this.LblApePatAdd.AutoSize = true;
            this.LblApePatAdd.Location = new System.Drawing.Point(264, 38);
            this.LblApePatAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblApePatAdd.Name = "LblApePatAdd";
            this.LblApePatAdd.Size = new System.Drawing.Size(140, 21);
            this.LblApePatAdd.TabIndex = 2;
            this.LblApePatAdd.Text = "Apellido Paterno";
            // 
            // TxtApeMatAdd
            // 
            this.TxtApeMatAdd.Location = new System.Drawing.Point(486, 64);
            this.TxtApeMatAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtApeMatAdd.Name = "TxtApeMatAdd";
            this.TxtApeMatAdd.Size = new System.Drawing.Size(164, 27);
            this.TxtApeMatAdd.TabIndex = 5;
            // 
            // LblApeMatAdd
            // 
            this.LblApeMatAdd.AutoSize = true;
            this.LblApeMatAdd.Location = new System.Drawing.Point(482, 38);
            this.LblApeMatAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblApeMatAdd.Name = "LblApeMatAdd";
            this.LblApeMatAdd.Size = new System.Drawing.Size(146, 21);
            this.LblApeMatAdd.TabIndex = 4;
            this.LblApeMatAdd.Text = "Apellido Materno";
            // 
            // LblAreaAdd
            // 
            this.LblAreaAdd.AutoSize = true;
            this.LblAreaAdd.Location = new System.Drawing.Point(45, 153);
            this.LblAreaAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblAreaAdd.Name = "LblAreaAdd";
            this.LblAreaAdd.Size = new System.Drawing.Size(49, 21);
            this.LblAreaAdd.TabIndex = 6;
            this.LblAreaAdd.Text = "Área";
            // 
            // LblFechaNacAdd
            // 
            this.LblFechaNacAdd.AutoSize = true;
            this.LblFechaNacAdd.Location = new System.Drawing.Point(264, 153);
            this.LblFechaNacAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblFechaNacAdd.Name = "LblFechaNacAdd";
            this.LblFechaNacAdd.Size = new System.Drawing.Size(179, 21);
            this.LblFechaNacAdd.TabIndex = 8;
            this.LblFechaNacAdd.Text = "Fecha de Nacimiento";
            // 
            // TxtSueldoAdd
            // 
            this.TxtSueldoAdd.Location = new System.Drawing.Point(486, 181);
            this.TxtSueldoAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtSueldoAdd.Name = "TxtSueldoAdd";
            this.TxtSueldoAdd.Size = new System.Drawing.Size(164, 27);
            this.TxtSueldoAdd.TabIndex = 11;
            // 
            // LblSueldoAdd
            // 
            this.LblSueldoAdd.AutoSize = true;
            this.LblSueldoAdd.Location = new System.Drawing.Point(483, 153);
            this.LblSueldoAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSueldoAdd.Name = "LblSueldoAdd";
            this.LblSueldoAdd.Size = new System.Drawing.Size(62, 21);
            this.LblSueldoAdd.TabIndex = 10;
            this.LblSueldoAdd.Text = "Sueldo";
            // 
            // CmbAreaAdd
            // 
            this.CmbAreaAdd.FormattingEnabled = true;
            this.CmbAreaAdd.Location = new System.Drawing.Point(49, 179);
            this.CmbAreaAdd.Name = "CmbAreaAdd";
            this.CmbAreaAdd.Size = new System.Drawing.Size(164, 29);
            this.CmbAreaAdd.TabIndex = 12;
            // 
            // DTPFechaNacAdd
            // 
            this.DTPFechaNacAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaNacAdd.Location = new System.Drawing.Point(268, 181);
            this.DTPFechaNacAdd.Name = "DTPFechaNacAdd";
            this.DTPFechaNacAdd.Size = new System.Drawing.Size(164, 27);
            this.DTPFechaNacAdd.TabIndex = 13;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(284, 278);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 46);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // PnlUpdate
            // 
            this.PnlUpdate.Controls.Add(this.LblIdUp);
            this.PnlUpdate.Controls.Add(this.TxtIdUp);
            this.PnlUpdate.Controls.Add(this.LblNameUp);
            this.PnlUpdate.Controls.Add(this.TxtNameUp);
            this.PnlUpdate.Controls.Add(this.LblApePatUp);
            this.PnlUpdate.Controls.Add(this.TxtApePatUp);
            this.PnlUpdate.Controls.Add(this.LblApeMatUp);
            this.PnlUpdate.Controls.Add(this.TxtApeMatUp);
            this.PnlUpdate.Controls.Add(this.LblAreaUp);
            this.PnlUpdate.Controls.Add(this.CmbAreaUp);
            this.PnlUpdate.Controls.Add(this.LblFechaNacUp);
            this.PnlUpdate.Controls.Add(this.DTPFechaNacUp);
            this.PnlUpdate.Controls.Add(this.LblSueldoUp);
            this.PnlUpdate.Controls.Add(this.TxtSueldoUp);
            this.PnlUpdate.Controls.Add(this.BtnUp);
            this.PnlUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlUpdate.Location = new System.Drawing.Point(6, 5);
            this.PnlUpdate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PnlUpdate.Name = "PnlUpdate";
            this.PnlUpdate.Size = new System.Drawing.Size(696, 401);
            this.PnlUpdate.TabIndex = 1;
            // 
            // LblNameUp
            // 
            this.LblNameUp.AutoSize = true;
            this.LblNameUp.Location = new System.Drawing.Point(42, 105);
            this.LblNameUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblNameUp.Name = "LblNameUp";
            this.LblNameUp.Size = new System.Drawing.Size(73, 21);
            this.LblNameUp.TabIndex = 0;
            this.LblNameUp.Text = "Nombre";
            // 
            // TxtNameUp
            // 
            this.TxtNameUp.Location = new System.Drawing.Point(46, 131);
            this.TxtNameUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtNameUp.Name = "TxtNameUp";
            this.TxtNameUp.Size = new System.Drawing.Size(164, 27);
            this.TxtNameUp.TabIndex = 1;
            // 
            // LblApePatUp
            // 
            this.LblApePatUp.AutoSize = true;
            this.LblApePatUp.Location = new System.Drawing.Point(261, 105);
            this.LblApePatUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblApePatUp.Name = "LblApePatUp";
            this.LblApePatUp.Size = new System.Drawing.Size(140, 21);
            this.LblApePatUp.TabIndex = 2;
            this.LblApePatUp.Text = "Apellido Paterno";
            // 
            // TxtApePatUp
            // 
            this.TxtApePatUp.Location = new System.Drawing.Point(265, 131);
            this.TxtApePatUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtApePatUp.Name = "TxtApePatUp";
            this.TxtApePatUp.Size = new System.Drawing.Size(164, 27);
            this.TxtApePatUp.TabIndex = 3;
            // 
            // LblApeMatUp
            // 
            this.LblApeMatUp.AutoSize = true;
            this.LblApeMatUp.Location = new System.Drawing.Point(479, 105);
            this.LblApeMatUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblApeMatUp.Name = "LblApeMatUp";
            this.LblApeMatUp.Size = new System.Drawing.Size(146, 21);
            this.LblApeMatUp.TabIndex = 4;
            this.LblApeMatUp.Text = "Apellido Materno";
            // 
            // TxtApeMatUp
            // 
            this.TxtApeMatUp.Location = new System.Drawing.Point(483, 131);
            this.TxtApeMatUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtApeMatUp.Name = "TxtApeMatUp";
            this.TxtApeMatUp.Size = new System.Drawing.Size(164, 27);
            this.TxtApeMatUp.TabIndex = 5;
            // 
            // LblAreaUp
            // 
            this.LblAreaUp.AutoSize = true;
            this.LblAreaUp.Location = new System.Drawing.Point(42, 202);
            this.LblAreaUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblAreaUp.Name = "LblAreaUp";
            this.LblAreaUp.Size = new System.Drawing.Size(49, 21);
            this.LblAreaUp.TabIndex = 6;
            this.LblAreaUp.Text = "Área";
            // 
            // CmbAreaUp
            // 
            this.CmbAreaUp.FormattingEnabled = true;
            this.CmbAreaUp.Location = new System.Drawing.Point(46, 228);
            this.CmbAreaUp.Name = "CmbAreaUp";
            this.CmbAreaUp.Size = new System.Drawing.Size(164, 29);
            this.CmbAreaUp.TabIndex = 12;
            // 
            // LblFechaNacUp
            // 
            this.LblFechaNacUp.AutoSize = true;
            this.LblFechaNacUp.Location = new System.Drawing.Point(261, 202);
            this.LblFechaNacUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblFechaNacUp.Name = "LblFechaNacUp";
            this.LblFechaNacUp.Size = new System.Drawing.Size(179, 21);
            this.LblFechaNacUp.TabIndex = 8;
            this.LblFechaNacUp.Text = "Fecha de Nacimiento";
            // 
            // DTPFechaNacUp
            // 
            this.DTPFechaNacUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaNacUp.Location = new System.Drawing.Point(265, 230);
            this.DTPFechaNacUp.Name = "DTPFechaNacUp";
            this.DTPFechaNacUp.Size = new System.Drawing.Size(164, 27);
            this.DTPFechaNacUp.TabIndex = 13;
            // 
            // LblSueldoUp
            // 
            this.LblSueldoUp.AutoSize = true;
            this.LblSueldoUp.Location = new System.Drawing.Point(480, 202);
            this.LblSueldoUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSueldoUp.Name = "LblSueldoUp";
            this.LblSueldoUp.Size = new System.Drawing.Size(62, 21);
            this.LblSueldoUp.TabIndex = 10;
            this.LblSueldoUp.Text = "Sueldo";
            // 
            // TxtSueldoUp
            // 
            this.TxtSueldoUp.Location = new System.Drawing.Point(483, 230);
            this.TxtSueldoUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtSueldoUp.Name = "TxtSueldoUp";
            this.TxtSueldoUp.Size = new System.Drawing.Size(164, 27);
            this.TxtSueldoUp.TabIndex = 11;
            // 
            // BtnUp
            // 
            this.BtnUp.Location = new System.Drawing.Point(281, 327);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(110, 46);
            this.BtnUp.TabIndex = 14;
            this.BtnUp.Text = "Actualizar";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // LblIdUp
            // 
            this.LblIdUp.AutoSize = true;
            this.LblIdUp.Location = new System.Drawing.Point(261, 20);
            this.LblIdUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblIdUp.Name = "LblIdUp";
            this.LblIdUp.Size = new System.Drawing.Size(26, 21);
            this.LblIdUp.TabIndex = 15;
            this.LblIdUp.Text = "Id";
            // 
            // TxtIdUp
            // 
            this.TxtIdUp.Location = new System.Drawing.Point(265, 46);
            this.TxtIdUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtIdUp.Name = "TxtIdUp";
            this.TxtIdUp.Size = new System.Drawing.Size(164, 27);
            this.TxtIdUp.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblIdDel);
            this.panel1.Controls.Add(this.TxtIdDel);
            this.panel1.Controls.Add(this.BtnDel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 401);
            this.panel1.TabIndex = 2;
            // 
            // LblIdDel
            // 
            this.LblIdDel.AutoSize = true;
            this.LblIdDel.Location = new System.Drawing.Point(253, 108);
            this.LblIdDel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblIdDel.Name = "LblIdDel";
            this.LblIdDel.Size = new System.Drawing.Size(26, 21);
            this.LblIdDel.TabIndex = 15;
            this.LblIdDel.Text = "Id";
            // 
            // TxtIdDel
            // 
            this.TxtIdDel.Location = new System.Drawing.Point(257, 134);
            this.TxtIdDel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtIdDel.Name = "TxtIdDel";
            this.TxtIdDel.Size = new System.Drawing.Size(164, 27);
            this.TxtIdDel.TabIndex = 16;
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(273, 217);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(110, 46);
            this.BtnDel.TabIndex = 14;
            this.BtnDel.Text = "Actualizar";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // TPShow
            // 
            this.TPShow.Controls.Add(this.PnlShow);
            this.TPShow.Location = new System.Drawing.Point(4, 30);
            this.TPShow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TPShow.Name = "TPShow";
            this.TPShow.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.TPShow.Size = new System.Drawing.Size(708, 411);
            this.TPShow.TabIndex = 4;
            this.TPShow.Text = "Mostrar";
            this.TPShow.UseVisualStyleBackColor = true;
            // 
            // PnlShow
            // 
            this.PnlShow.Controls.Add(this.DGVShow);
            this.PnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlShow.Location = new System.Drawing.Point(9, 8);
            this.PnlShow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PnlShow.Name = "PnlShow";
            this.PnlShow.Size = new System.Drawing.Size(690, 395);
            this.PnlShow.TabIndex = 0;
            // 
            // DGVShow
            // 
            this.DGVShow.AllowUserToAddRows = false;
            this.DGVShow.AllowUserToDeleteRows = false;
            this.DGVShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVShow.Location = new System.Drawing.Point(0, 0);
            this.DGVShow.Name = "DGVShow";
            this.DGVShow.ReadOnly = true;
            this.DGVShow.Size = new System.Drawing.Size(690, 395);
            this.DGVShow.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.TCMain);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Principal";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.TCMain.ResumeLayout(false);
            this.TPAdd.ResumeLayout(false);
            this.TPUpdate.ResumeLayout(false);
            this.TPDelete.ResumeLayout(false);
            this.PnlAdd.ResumeLayout(false);
            this.PnlAdd.PerformLayout();
            this.PnlUpdate.ResumeLayout(false);
            this.PnlUpdate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TPShow.ResumeLayout(false);
            this.PnlShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCMain;
        private System.Windows.Forms.TabPage TPAdd;
        private System.Windows.Forms.TabPage TPUpdate;
        private System.Windows.Forms.TabPage TPDelete;
        private System.Windows.Forms.Panel PnlAdd;
        private System.Windows.Forms.Label LblNameAdd;
        private System.Windows.Forms.Label LblSueldoAdd;
        private System.Windows.Forms.Label LblFechaNacAdd;
        private System.Windows.Forms.Label LblAreaAdd;
        private System.Windows.Forms.Label LblApeMatAdd;
        private System.Windows.Forms.Label LblApePatAdd;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel PnlUpdate;
        private System.Windows.Forms.Label LblNameUp;
        private System.Windows.Forms.Label LblApePatUp;
        private System.Windows.Forms.Label LblApeMatUp;
        private System.Windows.Forms.Label LblAreaUp;
        private System.Windows.Forms.Label LblFechaNacUp;
        private System.Windows.Forms.Label LblSueldoUp;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Label LblIdUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblIdDel;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.TabPage TPShow;
        private System.Windows.Forms.Panel PnlShow;
        internal System.Windows.Forms.DataGridView DGVShow;
        internal System.Windows.Forms.TextBox TxtNameAdd;
        internal System.Windows.Forms.TextBox TxtSueldoAdd;
        internal System.Windows.Forms.TextBox TxtApeMatAdd;
        internal System.Windows.Forms.TextBox TxtApePatAdd;
        internal System.Windows.Forms.ComboBox CmbAreaAdd;
        internal System.Windows.Forms.DateTimePicker DTPFechaNacAdd;
        internal System.Windows.Forms.TextBox TxtNameUp;
        internal System.Windows.Forms.TextBox TxtApePatUp;
        internal System.Windows.Forms.TextBox TxtApeMatUp;
        internal System.Windows.Forms.ComboBox CmbAreaUp;
        internal System.Windows.Forms.DateTimePicker DTPFechaNacUp;
        internal System.Windows.Forms.TextBox TxtSueldoUp;
        internal System.Windows.Forms.TextBox TxtIdUp;
        internal System.Windows.Forms.TextBox TxtIdDel;
    }
}

