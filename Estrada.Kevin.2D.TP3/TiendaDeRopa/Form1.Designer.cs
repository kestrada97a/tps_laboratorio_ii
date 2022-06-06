namespace TiendaDeRopa
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
            this.btn_AgregarPedido = new System.Windows.Forms.Button();
            this.btn_EliminarPedido = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lst_Pedidos = new System.Windows.Forms.ListBox();
            this.btn_MostrarPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.Location = new System.Drawing.Point(3, 56);
            this.btn_AgregarPedido.Name = "btn_AgregarPedido";
            this.btn_AgregarPedido.Size = new System.Drawing.Size(158, 23);
            this.btn_AgregarPedido.TabIndex = 0;
            this.btn_AgregarPedido.Text = "Agregar Pedido";
            this.btn_AgregarPedido.UseVisualStyleBackColor = true;
            // 
            // btn_EliminarPedido
            // 
            this.btn_EliminarPedido.Location = new System.Drawing.Point(167, 56);
            this.btn_EliminarPedido.Name = "btn_EliminarPedido";
            this.btn_EliminarPedido.Size = new System.Drawing.Size(157, 23);
            this.btn_EliminarPedido.TabIndex = 1;
            this.btn_EliminarPedido.Text = "Eliminar Pedido";
            this.btn_EliminarPedido.UseVisualStyleBackColor = true;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(13, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(311, 33);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Bienvenido a Ropas_UTN";
            // 
            // lst_Pedidos
            // 
            this.lst_Pedidos.FormattingEnabled = true;
            this.lst_Pedidos.ItemHeight = 15;
            this.lst_Pedidos.Location = new System.Drawing.Point(3, 126);
            this.lst_Pedidos.Name = "lst_Pedidos";
            this.lst_Pedidos.Size = new System.Drawing.Size(321, 274);
            this.lst_Pedidos.TabIndex = 3;
            // 
            // btn_MostrarPedidos
            // 
            this.btn_MostrarPedidos.Location = new System.Drawing.Point(83, 85);
            this.btn_MostrarPedidos.Name = "btn_MostrarPedidos";
            this.btn_MostrarPedidos.Size = new System.Drawing.Size(158, 23);
            this.btn_MostrarPedidos.TabIndex = 4;
            this.btn_MostrarPedidos.Text = "Mostrar Pedidos";
            this.btn_MostrarPedidos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(330, 434);
            this.Controls.Add(this.btn_MostrarPedidos);
            this.Controls.Add(this.lst_Pedidos);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_EliminarPedido);
            this.Controls.Add(this.btn_AgregarPedido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarPedido;
        private System.Windows.Forms.Button btn_EliminarPedido;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ListBox lst_Pedidos;
        private System.Windows.Forms.Button btn_MostrarPedidos;
    }
}
