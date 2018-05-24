namespace CircularLists
{
    partial class BusStation
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDeleteL = new System.Windows.Forms.Button();
            this.buttonDeleteF = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextPos = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextMinutes = new System.Windows.Forms.MaskedTextBox();
            this.buttonRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(93, 85);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(174, 86);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(123, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDeleteL
            // 
            this.buttonDeleteL.Location = new System.Drawing.Point(174, 143);
            this.buttonDeleteL.Name = "buttonDeleteL";
            this.buttonDeleteL.Size = new System.Drawing.Size(123, 23);
            this.buttonDeleteL.TabIndex = 2;
            this.buttonDeleteL.Text = "Eliminar Ultimo";
            this.buttonDeleteL.UseVisualStyleBackColor = true;
            this.buttonDeleteL.Click += new System.EventHandler(this.buttonDeleteL_Click);
            // 
            // buttonDeleteF
            // 
            this.buttonDeleteF.Location = new System.Drawing.Point(174, 172);
            this.buttonDeleteF.Name = "buttonDeleteF";
            this.buttonDeleteF.Size = new System.Drawing.Size(123, 23);
            this.buttonDeleteF.TabIndex = 3;
            this.buttonDeleteF.Text = "Eliminar inicio";
            this.buttonDeleteF.UseVisualStyleBackColor = true;
            this.buttonDeleteF.Click += new System.EventHandler(this.buttonDeleteF_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Eliminar por nombre";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(181, 5);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(116, 23);
            this.buttonList.TabIndex = 6;
            this.buttonList.Text = "Listar";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(181, 30);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(116, 23);
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.Text = "Insertar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeBegin.Location = new System.Drawing.Point(65, 5);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.ShowUpDown = true;
            this.dateTimeBegin.Size = new System.Drawing.Size(110, 20);
            this.dateTimeBegin.TabIndex = 8;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeEnd.Location = new System.Drawing.Point(65, 33);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.ShowUpDown = true;
            this.dateTimeEnd.Size = new System.Drawing.Size(110, 20);
            this.dateTimeEnd.TabIndex = 9;
            this.dateTimeEnd.Value = new System.DateTime(2018, 5, 23, 20, 57, 34, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hora inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hora final";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre base";
            // 
            // textBoxName
            // 
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Location = new System.Drawing.Point(74, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(13, 115);
            this.textBoxShow.Multiline = true;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(155, 179);
            this.textBoxShow.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pos";
            // 
            // maskedTextPos
            // 
            this.maskedTextPos.Location = new System.Drawing.Point(212, 58);
            this.maskedTextPos.Mask = "99999";
            this.maskedTextPos.Name = "maskedTextPos";
            this.maskedTextPos.Size = new System.Drawing.Size(85, 20);
            this.maskedTextPos.TabIndex = 16;
            this.maskedTextPos.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Minutos";
            // 
            // maskedTextMinutes
            // 
            this.maskedTextMinutes.Location = new System.Drawing.Point(52, 87);
            this.maskedTextMinutes.Mask = "99999";
            this.maskedTextMinutes.Name = "maskedTextMinutes";
            this.maskedTextMinutes.Size = new System.Drawing.Size(35, 20);
            this.maskedTextMinutes.TabIndex = 18;
            this.maskedTextMinutes.ValidatingType = typeof(int);
            // 
            // buttonRoute
            // 
            this.buttonRoute.Location = new System.Drawing.Point(175, 113);
            this.buttonRoute.Name = "buttonRoute";
            this.buttonRoute.Size = new System.Drawing.Size(123, 23);
            this.buttonRoute.TabIndex = 19;
            this.buttonRoute.Text = "Ruta";
            this.buttonRoute.UseVisualStyleBackColor = true;
            this.buttonRoute.Click += new System.EventHandler(this.buttonRoute_Click);
            // 
            // BusStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 306);
            this.Controls.Add(this.buttonRoute);
            this.Controls.Add(this.maskedTextMinutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeBegin);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonDeleteF);
            this.Controls.Add(this.buttonDeleteL);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAdd);
            this.Name = "BusStation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDeleteL;
        private System.Windows.Forms.Button buttonDeleteF;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextMinutes;
        private System.Windows.Forms.Button buttonRoute;
    }
}

