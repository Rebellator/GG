namespace Oskars
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSeries = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnMovieFigures = new System.Windows.Forms.Button();
            this.btnSerieFigures = new System.Windows.Forms.Button();
            this.btnSerieNominants = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getMoviesWinnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getMoviesWinnersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getSeriesNominantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSeriesSeasonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getFiguresInMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getNominantsInMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getNominantsInSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getGGInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getNominationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getProfessionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnMovieNominants = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nominantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 649);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSeries
            // 
            this.btnSeries.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSeries.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries.Location = new System.Drawing.Point(12, 36);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(186, 40);
            this.btnSeries.TabIndex = 1;
            this.btnSeries.Tag = "0";
            this.btnSeries.Text = "Series";
            this.btnSeries.UseVisualStyleBackColor = false;
            this.btnSeries.Click += new System.EventHandler(this.selectTable);
            // 
            // btnMovies
            // 
            this.btnMovies.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMovies.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.Location = new System.Drawing.Point(12, 82);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(186, 40);
            this.btnMovies.TabIndex = 1;
            this.btnMovies.Tag = "1";
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = false;
            this.btnMovies.Click += new System.EventHandler(this.selectTable);
            // 
            // btnMovieFigures
            // 
            this.btnMovieFigures.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMovieFigures.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieFigures.Location = new System.Drawing.Point(12, 128);
            this.btnMovieFigures.Name = "btnMovieFigures";
            this.btnMovieFigures.Size = new System.Drawing.Size(186, 40);
            this.btnMovieFigures.TabIndex = 1;
            this.btnMovieFigures.Tag = "2";
            this.btnMovieFigures.Text = "Movie Figures";
            this.btnMovieFigures.UseVisualStyleBackColor = false;
            this.btnMovieFigures.Click += new System.EventHandler(this.selectTable);
            // 
            // btnSerieFigures
            // 
            this.btnSerieFigures.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSerieFigures.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerieFigures.Location = new System.Drawing.Point(12, 174);
            this.btnSerieFigures.Name = "btnSerieFigures";
            this.btnSerieFigures.Size = new System.Drawing.Size(186, 40);
            this.btnSerieFigures.TabIndex = 1;
            this.btnSerieFigures.Tag = "3";
            this.btnSerieFigures.Text = "Serie Figures";
            this.btnSerieFigures.UseVisualStyleBackColor = false;
            this.btnSerieFigures.Click += new System.EventHandler(this.selectTable);
            // 
            // btnSerieNominants
            // 
            this.btnSerieNominants.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSerieNominants.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerieNominants.Location = new System.Drawing.Point(12, 266);
            this.btnSerieNominants.Name = "btnSerieNominants";
            this.btnSerieNominants.Size = new System.Drawing.Size(186, 40);
            this.btnSerieNominants.TabIndex = 1;
            this.btnSerieNominants.Tag = "5";
            this.btnSerieNominants.Text = "Serie Nominants";
            this.btnSerieNominants.UseVisualStyleBackColor = false;
            this.btnSerieNominants.Click += new System.EventHandler(this.selectTable);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getMoviesWinnersToolStripMenuItem,
            this.getMoviesWinnersToolStripMenuItem1,
            this.getSeriesNominantsToolStripMenuItem,
            this.getSeriesSeasonsToolStripMenuItem,
            this.getFiguresInMoviesToolStripMenuItem,
            this.getNominantsInMoviesToolStripMenuItem,
            this.getNominantsInSeriesToolStripMenuItem,
            this.getGGInfoToolStripMenuItem,
            this.getNominationInfoToolStripMenuItem,
            this.getProfessionInfoToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // getMoviesWinnersToolStripMenuItem
            // 
            this.getMoviesWinnersToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.getMoviesWinnersToolStripMenuItem.Name = "getMoviesWinnersToolStripMenuItem";
            this.getMoviesWinnersToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getMoviesWinnersToolStripMenuItem.Text = "Get Movie Figures Winners";
            this.getMoviesWinnersToolStripMenuItem.Click += new System.EventHandler(this.getMoviesWinnersToolStripMenuItem_Click);
            // 
            // getMoviesWinnersToolStripMenuItem1
            // 
            this.getMoviesWinnersToolStripMenuItem1.BackColor = System.Drawing.Color.Cornsilk;
            this.getMoviesWinnersToolStripMenuItem1.Name = "getMoviesWinnersToolStripMenuItem1";
            this.getMoviesWinnersToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.getMoviesWinnersToolStripMenuItem1.Text = "Get Movies Winners";
            this.getMoviesWinnersToolStripMenuItem1.Click += new System.EventHandler(this.getMoviesWinnersToolStripMenuItem1_Click);
            // 
            // getSeriesNominantsToolStripMenuItem
            // 
            this.getSeriesNominantsToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.getSeriesNominantsToolStripMenuItem.Name = "getSeriesNominantsToolStripMenuItem";
            this.getSeriesNominantsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getSeriesNominantsToolStripMenuItem.Text = "Get Series Nominants";
            this.getSeriesNominantsToolStripMenuItem.Click += new System.EventHandler(this.getSeriesNominantsToolStripMenuItem_Click);
            // 
            // getSeriesSeasonsToolStripMenuItem
            // 
            this.getSeriesSeasonsToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.getSeriesSeasonsToolStripMenuItem.Name = "getSeriesSeasonsToolStripMenuItem";
            this.getSeriesSeasonsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getSeriesSeasonsToolStripMenuItem.Text = "Get Series Seasons";
            this.getSeriesSeasonsToolStripMenuItem.Click += new System.EventHandler(this.getSeriesSeasonsToolStripMenuItem_Click);
            // 
            // getFiguresInMoviesToolStripMenuItem
            // 
            this.getFiguresInMoviesToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.getFiguresInMoviesToolStripMenuItem.Name = "getFiguresInMoviesToolStripMenuItem";
            this.getFiguresInMoviesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getFiguresInMoviesToolStripMenuItem.Text = "Get Figures In Movies";
            this.getFiguresInMoviesToolStripMenuItem.Click += new System.EventHandler(this.getFiguresInMoviesToolStripMenuItem_Click);
            // 
            // getNominantsInMoviesToolStripMenuItem
            // 
            this.getNominantsInMoviesToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.getNominantsInMoviesToolStripMenuItem.Name = "getNominantsInMoviesToolStripMenuItem";
            this.getNominantsInMoviesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getNominantsInMoviesToolStripMenuItem.Text = "Get Nominants In Movies";
            this.getNominantsInMoviesToolStripMenuItem.Click += new System.EventHandler(this.getNominantsInMoviesToolStripMenuItem_Click);
            // 
            // getNominantsInSeriesToolStripMenuItem
            // 
            this.getNominantsInSeriesToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.getNominantsInSeriesToolStripMenuItem.Name = "getNominantsInSeriesToolStripMenuItem";
            this.getNominantsInSeriesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getNominantsInSeriesToolStripMenuItem.Text = "Get Nominants in Series";
            this.getNominantsInSeriesToolStripMenuItem.Click += new System.EventHandler(this.getNominantsInSeriesToolStripMenuItem_Click);
            // 
            // getGGInfoToolStripMenuItem
            // 
            this.getGGInfoToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.getGGInfoToolStripMenuItem.Name = "getGGInfoToolStripMenuItem";
            this.getGGInfoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getGGInfoToolStripMenuItem.Text = "Get GG Info";
            this.getGGInfoToolStripMenuItem.Click += new System.EventHandler(this.getGGInfoToolStripMenuItem_Click);
            // 
            // getNominationInfoToolStripMenuItem
            // 
            this.getNominationInfoToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.getNominationInfoToolStripMenuItem.Name = "getNominationInfoToolStripMenuItem";
            this.getNominationInfoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getNominationInfoToolStripMenuItem.Text = "Get Nomination Info";
            this.getNominationInfoToolStripMenuItem.Click += new System.EventHandler(this.getNominationInfoToolStripMenuItem_Click);
            // 
            // getProfessionInfoToolStripMenuItem
            // 
            this.getProfessionInfoToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.getProfessionInfoToolStripMenuItem.Name = "getProfessionInfoToolStripMenuItem";
            this.getProfessionInfoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getProfessionInfoToolStripMenuItem.Text = "Get Profession Info";
            this.getProfessionInfoToolStripMenuItem.Click += new System.EventHandler(this.getProfessionInfoToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(204, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(571, 393);
            this.dataGridView.TabIndex = 3;
            // 
            // btnMovieNominants
            // 
            this.btnMovieNominants.BackColor = System.Drawing.Color.Goldenrod;
            this.btnMovieNominants.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieNominants.Location = new System.Drawing.Point(12, 220);
            this.btnMovieNominants.Name = "btnMovieNominants";
            this.btnMovieNominants.Size = new System.Drawing.Size(186, 40);
            this.btnMovieNominants.TabIndex = 1;
            this.btnMovieNominants.Tag = "4";
            this.btnMovieNominants.Text = "Movie Nominants";
            this.btnMovieNominants.UseVisualStyleBackColor = false;
            this.btnMovieNominants.Click += new System.EventHandler(this.selectTable);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(118, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nominantBindingSource
            // 
            this.nominantBindingSource.DataSource = typeof(Oskars.Nominant);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 441);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSerieNominants);
            this.Controls.Add(this.btnMovieNominants);
            this.Controls.Add(this.btnSerieFigures);
            this.Controls.Add(this.btnMovieFigures);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnSeries);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(803, 480);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource nominantBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnMovieFigures;
        private System.Windows.Forms.Button btnSerieFigures;
        private System.Windows.Forms.Button btnSerieNominants;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getMoviesWinnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getMoviesWinnersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getSeriesNominantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getSeriesSeasonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getFiguresInMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getNominantsInMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getNominantsInSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getGGInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getNominationInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getProfessionInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnMovieNominants;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
    }
}

