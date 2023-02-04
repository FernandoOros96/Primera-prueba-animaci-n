namespace Pt2pt
{
    partial class MyForm
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
            this.components = new System.ComponentModel.Container();
            this.PNL_HEADER = new System.Windows.Forms.Panel();
            this.LBL_TITLE = new System.Windows.Forms.Label();
            this.PNL_BOTTOM = new System.Windows.Forms.Panel();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.PNL_LEFT = new System.Windows.Forms.Panel();
            this.NORMAL = new System.Windows.Forms.Button();
            this.REPRODUCE = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            this.BTN_EXE = new System.Windows.Forms.Button();
            this.TREE = new System.Windows.Forms.TreeView();
            this.PNL_RIGHT = new System.Windows.Forms.Panel();
            this.PCT_SLIDEER_Y = new System.Windows.Forms.PictureBox();
            this.PCT_SLIDEER_X = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.TIMER2 = new System.Windows.Forms.Timer(this.components);
            this.TIMER3 = new System.Windows.Forms.Timer(this.components);
            this.seconds = new System.Windows.Forms.Label();
            this.PNL_HEADER.SuspendLayout();
            this.PNL_BOTTOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.PNL_LEFT.SuspendLayout();
            this.PNL_RIGHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_HEADER.Controls.Add(this.LBL_TITLE);
            this.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(1924, 64);
            this.PNL_HEADER.TabIndex = 0;
            // 
            // LBL_TITLE
            // 
            this.LBL_TITLE.AutoSize = true;
            this.LBL_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITLE.Location = new System.Drawing.Point(16, 11);
            this.LBL_TITLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_TITLE.Name = "LBL_TITLE";
            this.LBL_TITLE.Size = new System.Drawing.Size(381, 39);
            this.LBL_TITLE.TabIndex = 0;
            this.LBL_TITLE.Text = "GRAPHIX 2023 UDLAP";
            // 
            // PNL_BOTTOM
            // 
            this.PNL_BOTTOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_BOTTOM.Controls.Add(this.LBL_STATUS);
            this.PNL_BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_BOTTOM.Location = new System.Drawing.Point(0, 835);
            this.PNL_BOTTOM.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_BOTTOM.Name = "PNL_BOTTOM";
            this.PNL_BOTTOM.Size = new System.Drawing.Size(1924, 36);
            this.PNL_BOTTOM.TabIndex = 1;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.ForeColor = System.Drawing.Color.Gray;
            this.LBL_STATUS.Location = new System.Drawing.Point(9, 6);
            this.LBL_STATUS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(117, 25);
            this.LBL_STATUS.TabIndex = 0;
            this.LBL_STATUS.Text = "WELCOME";
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(211, 124);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1533, 652);
            this.PCT_CANVAS.TabIndex = 2;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseClick);
            this.PCT_CANVAS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDoubleClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // PNL_LEFT
            // 
            this.PNL_LEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_LEFT.Controls.Add(this.NORMAL);
            this.PNL_LEFT.Controls.Add(this.REPRODUCE);
            this.PNL_LEFT.Controls.Add(this.START);
            this.PNL_LEFT.Controls.Add(this.BTN_EXE);
            this.PNL_LEFT.Controls.Add(this.TREE);
            this.PNL_LEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNL_LEFT.Location = new System.Drawing.Point(0, 64);
            this.PNL_LEFT.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_LEFT.Name = "PNL_LEFT";
            this.PNL_LEFT.Size = new System.Drawing.Size(200, 771);
            this.PNL_LEFT.TabIndex = 3;
            // 
            // NORMAL
            // 
            this.NORMAL.Location = new System.Drawing.Point(14, 583);
            this.NORMAL.Name = "NORMAL";
            this.NORMAL.Size = new System.Drawing.Size(162, 38);
            this.NORMAL.TabIndex = 5;
            this.NORMAL.Text = "NORMAL";
            this.NORMAL.UseVisualStyleBackColor = true;
            this.NORMAL.Click += new System.EventHandler(this.NORMAL_Click);
            // 
            // REPRODUCE
            // 
            this.REPRODUCE.Location = new System.Drawing.Point(12, 688);
            this.REPRODUCE.Name = "REPRODUCE";
            this.REPRODUCE.Size = new System.Drawing.Size(164, 35);
            this.REPRODUCE.TabIndex = 4;
            this.REPRODUCE.Text = "REPRODUCE";
            this.REPRODUCE.UseVisualStyleBackColor = true;
            this.REPRODUCE.Click += new System.EventHandler(this.REPRODUCE_Click);
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(12, 636);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(164, 37);
            this.START.TabIndex = 3;
            this.START.Text = "RECORD 5 SEG";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_EXE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.BTN_EXE.FlatAppearance.BorderSize = 0;
            this.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXE.ForeColor = System.Drawing.Color.Snow;
            this.BTN_EXE.Location = new System.Drawing.Point(12, 730);
            this.BTN_EXE.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(164, 33);
            this.BTN_EXE.TabIndex = 1;
            this.BTN_EXE.Text = "ADD";
            this.BTN_EXE.UseVisualStyleBackColor = false;
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // TREE
            // 
            this.TREE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TREE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TREE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TREE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TREE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TREE.Location = new System.Drawing.Point(0, 0);
            this.TREE.Margin = new System.Windows.Forms.Padding(4);
            this.TREE.Name = "TREE";
            this.TREE.Size = new System.Drawing.Size(192, 474);
            this.TREE.TabIndex = 0;
            this.TREE.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TREE_AfterSelect);
            this.TREE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TREE_KeyPress);
            // 
            // PNL_RIGHT
            // 
            this.PNL_RIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PNL_RIGHT.Controls.Add(this.seconds);
            this.PNL_RIGHT.Controls.Add(this.PCT_SLIDEER_Y);
            this.PNL_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.PNL_RIGHT.Location = new System.Drawing.Point(1724, 64);
            this.PNL_RIGHT.Margin = new System.Windows.Forms.Padding(4);
            this.PNL_RIGHT.Name = "PNL_RIGHT";
            this.PNL_RIGHT.Size = new System.Drawing.Size(200, 771);
            this.PNL_RIGHT.TabIndex = 4;
            // 
            // PCT_SLIDEER_Y
            // 
            this.PCT_SLIDEER_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCT_SLIDEER_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PCT_SLIDEER_Y.Location = new System.Drawing.Point(25, 59);
            this.PCT_SLIDEER_Y.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_SLIDEER_Y.Name = "PCT_SLIDEER_Y";
            this.PCT_SLIDEER_Y.Size = new System.Drawing.Size(20, 704);
            this.PCT_SLIDEER_Y.TabIndex = 6;
            this.PCT_SLIDEER_Y.TabStop = false;
            this.PCT_SLIDEER_Y.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_Y_MouseDown);
            this.PCT_SLIDEER_Y.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_Y_MouseMove);
            this.PCT_SLIDEER_Y.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_Y_MouseUp);
            // 
            // PCT_SLIDEER_X
            // 
            this.PCT_SLIDEER_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCT_SLIDEER_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PCT_SLIDEER_X.Location = new System.Drawing.Point(19, 14);
            this.PCT_SLIDEER_X.Margin = new System.Windows.Forms.Padding(4);
            this.PCT_SLIDEER_X.Name = "PCT_SLIDEER_X";
            this.PCT_SLIDEER_X.Size = new System.Drawing.Size(1492, 18);
            this.PCT_SLIDEER_X.TabIndex = 5;
            this.PCT_SLIDEER_X.TabStop = false;
            this.PCT_SLIDEER_X.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_X_MouseDown);
            this.PCT_SLIDEER_X.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_X_MouseMove);
            this.PCT_SLIDEER_X.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_SLIDEER_X_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.PCT_SLIDEER_X);
            this.panel3.Location = new System.Drawing.Point(211, 782);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1531, 47);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Location = new System.Drawing.Point(213, 71);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1531, 47);
            this.panel4.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1531, 47);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 30;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // TIMER2
            // 
            this.TIMER2.Enabled = true;
            this.TIMER2.Interval = 40;
            this.TIMER2.Tick += new System.EventHandler(this.TIMER2_Tick);
            // 
            // TIMER3
            // 
            this.TIMER3.Enabled = true;
            this.TIMER3.Interval = 10;
            this.TIMER3.Tick += new System.EventHandler(this.TIMER3_Tick);
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Location = new System.Drawing.Point(102, 172);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(14, 16);
            this.seconds.TabIndex = 7;
            this.seconds.Text = "0";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1924, 871);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PNL_RIGHT);
            this.Controls.Add(this.PNL_LEFT);
            this.Controls.Add(this.PCT_CANVAS);
            this.Controls.Add(this.PNL_BOTTOM);
            this.Controls.Add(this.PNL_HEADER);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.MyForm_Resize);
            this.PNL_HEADER.ResumeLayout(false);
            this.PNL_HEADER.PerformLayout();
            this.PNL_BOTTOM.ResumeLayout(false);
            this.PNL_BOTTOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.PNL_LEFT.ResumeLayout(false);
            this.PNL_RIGHT.ResumeLayout(false);
            this.PNL_RIGHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SLIDEER_X)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_HEADER;
        private System.Windows.Forms.Panel PNL_BOTTOM;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Panel PNL_LEFT;
        private System.Windows.Forms.Panel PNL_RIGHT;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_X;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView TREE;
        private System.Windows.Forms.Button BTN_EXE;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.PictureBox PCT_SLIDEER_Y;
        private System.Windows.Forms.Label LBL_TITLE;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button REPRODUCE;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button NORMAL;
        private System.Windows.Forms.Timer TIMER2;
        private System.Windows.Forms.Timer TIMER3;
        private System.Windows.Forms.Label seconds;
    }
}