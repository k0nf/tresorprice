
namespace TresorPrice
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
            this.components = new System.ComponentModel.Container();
            this.metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.usdAmount = new MetroSet_UI.Controls.MetroSetTextBox();
            this.usdgive = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.eurgivet = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox4 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.mkdeurl = new MetroSet_UI.Controls.MetroSetLabel();
            this.usdeurl = new MetroSet_UI.Controls.MetroSetLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.usdmkdl = new MetroSet_UI.Controls.MetroSetLabel();
            this.feeBadge = new MetroSet_UI.Controls.MetroSetBadge();
            this.label1 = new System.Windows.Forms.Label();
            this.lastupdated = new System.Windows.Forms.Label();
            this.pbar = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.SuspendLayout();
            // 
            // metroSetDivider1
            // 
            this.metroSetDivider1.IsDerivedStyle = true;
            this.metroSetDivider1.Location = new System.Drawing.Point(405, 8);
            this.metroSetDivider1.Name = "metroSetDivider1";
            this.metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Vertical;
            this.metroSetDivider1.Size = new System.Drawing.Size(4, 336);
            this.metroSetDivider1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDivider1.StyleManager = null;
            this.metroSetDivider1.TabIndex = 1;
            this.metroSetDivider1.Text = "metroSetDivider1";
            this.metroSetDivider1.ThemeAuthor = "Narwin";
            this.metroSetDivider1.ThemeName = "MetroLite";
            this.metroSetDivider1.Thickness = 1;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(26, 42);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(363, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 3;
            this.metroSetLabel1.Text = "Amount to get (USDT)";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // usdAmount
            // 
            this.usdAmount.AutoCompleteCustomSource = null;
            this.usdAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usdAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usdAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.usdAmount.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.usdAmount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.usdAmount.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.usdAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usdAmount.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.usdAmount.Image = null;
            this.usdAmount.IsDerivedStyle = true;
            this.usdAmount.Lines = null;
            this.usdAmount.Location = new System.Drawing.Point(26, 68);
            this.usdAmount.MaxLength = 32767;
            this.usdAmount.Multiline = false;
            this.usdAmount.Name = "usdAmount";
            this.usdAmount.ReadOnly = false;
            this.usdAmount.Size = new System.Drawing.Size(363, 30);
            this.usdAmount.Style = MetroSet_UI.Enums.Style.Light;
            this.usdAmount.StyleManager = null;
            this.usdAmount.TabIndex = 4;
            this.usdAmount.Text = "0";
            this.usdAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usdAmount.ThemeAuthor = "Narwin";
            this.usdAmount.ThemeName = "MetroLite";
            this.usdAmount.UseSystemPasswordChar = false;
            this.usdAmount.WatermarkText = "";
            this.usdAmount.TextChanged += new System.EventHandler(this.usdAmount_TextChanged);
            // 
            // usdgive
            // 
            this.usdgive.AutoCompleteCustomSource = null;
            this.usdgive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usdgive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usdgive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.usdgive.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.usdgive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.usdgive.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.usdgive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usdgive.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.usdgive.Image = null;
            this.usdgive.IsDerivedStyle = true;
            this.usdgive.Lines = null;
            this.usdgive.Location = new System.Drawing.Point(26, 142);
            this.usdgive.MaxLength = 32767;
            this.usdgive.Multiline = false;
            this.usdgive.Name = "usdgive";
            this.usdgive.ReadOnly = true;
            this.usdgive.Size = new System.Drawing.Size(363, 30);
            this.usdgive.Style = MetroSet_UI.Enums.Style.Light;
            this.usdgive.StyleManager = null;
            this.usdgive.TabIndex = 6;
            this.usdgive.Text = "0";
            this.usdgive.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usdgive.ThemeAuthor = "Narwin";
            this.usdgive.ThemeName = "MetroLite";
            this.usdgive.UseSystemPasswordChar = false;
            this.usdgive.WatermarkText = "";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Enabled = false;
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(26, 116);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(363, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 5;
            this.metroSetLabel2.Text = "Amount to give (USD)";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // eurgivet
            // 
            this.eurgivet.AutoCompleteCustomSource = null;
            this.eurgivet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.eurgivet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.eurgivet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.eurgivet.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.eurgivet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.eurgivet.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.eurgivet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eurgivet.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.eurgivet.Image = null;
            this.eurgivet.IsDerivedStyle = true;
            this.eurgivet.Lines = null;
            this.eurgivet.Location = new System.Drawing.Point(26, 211);
            this.eurgivet.MaxLength = 32767;
            this.eurgivet.Multiline = false;
            this.eurgivet.Name = "eurgivet";
            this.eurgivet.ReadOnly = true;
            this.eurgivet.Size = new System.Drawing.Size(363, 30);
            this.eurgivet.Style = MetroSet_UI.Enums.Style.Light;
            this.eurgivet.StyleManager = null;
            this.eurgivet.TabIndex = 8;
            this.eurgivet.Text = "0";
            this.eurgivet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.eurgivet.ThemeAuthor = "Narwin";
            this.eurgivet.ThemeName = "MetroLite";
            this.eurgivet.UseSystemPasswordChar = false;
            this.eurgivet.WatermarkText = "";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Enabled = false;
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(26, 185);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(363, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 7;
            this.metroSetLabel3.Text = "Amount to give (EUR)";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetTextBox4
            // 
            this.metroSetTextBox4.AutoCompleteCustomSource = null;
            this.metroSetTextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBox4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBox4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBox4.Image = null;
            this.metroSetTextBox4.IsDerivedStyle = true;
            this.metroSetTextBox4.Lines = null;
            this.metroSetTextBox4.Location = new System.Drawing.Point(26, 290);
            this.metroSetTextBox4.MaxLength = 32767;
            this.metroSetTextBox4.Multiline = false;
            this.metroSetTextBox4.Name = "metroSetTextBox4";
            this.metroSetTextBox4.ReadOnly = true;
            this.metroSetTextBox4.Size = new System.Drawing.Size(363, 30);
            this.metroSetTextBox4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBox4.StyleManager = null;
            this.metroSetTextBox4.TabIndex = 10;
            this.metroSetTextBox4.Text = "0";
            this.metroSetTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox4.ThemeAuthor = "Narwin";
            this.metroSetTextBox4.ThemeName = "MetroLite";
            this.metroSetTextBox4.UseSystemPasswordChar = false;
            this.metroSetTextBox4.WatermarkText = "";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Enabled = false;
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(26, 264);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(363, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 9;
            this.metroSetLabel4.Text = "Amount to give (MKD)";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(435, 68);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 11;
            this.metroSetLabel5.Text = "EUR/USD:";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(435, 104);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 12;
            this.metroSetLabel6.Text = "EUR/MKD:";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // mkdeurl
            // 
            this.mkdeurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mkdeurl.IsDerivedStyle = true;
            this.mkdeurl.Location = new System.Drawing.Point(515, 104);
            this.mkdeurl.Name = "mkdeurl";
            this.mkdeurl.Size = new System.Drawing.Size(100, 23);
            this.mkdeurl.Style = MetroSet_UI.Enums.Style.Light;
            this.mkdeurl.StyleManager = null;
            this.mkdeurl.TabIndex = 13;
            this.mkdeurl.Text = "0";
            this.mkdeurl.ThemeAuthor = "Narwin";
            this.mkdeurl.ThemeName = "MetroLite";
            // 
            // usdeurl
            // 
            this.usdeurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usdeurl.IsDerivedStyle = true;
            this.usdeurl.Location = new System.Drawing.Point(515, 68);
            this.usdeurl.Name = "usdeurl";
            this.usdeurl.Size = new System.Drawing.Size(100, 23);
            this.usdeurl.Style = MetroSet_UI.Enums.Style.Light;
            this.usdeurl.StyleManager = null;
            this.usdeurl.TabIndex = 14;
            this.usdeurl.Text = "0";
            this.usdeurl.ThemeAuthor = "Narwin";
            this.usdeurl.ThemeName = "MetroLite";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(435, 142);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(74, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 15;
            this.metroSetLabel7.Text = "USD/MKD:";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // usdmkdl
            // 
            this.usdmkdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usdmkdl.IsDerivedStyle = true;
            this.usdmkdl.Location = new System.Drawing.Point(515, 142);
            this.usdmkdl.Name = "usdmkdl";
            this.usdmkdl.Size = new System.Drawing.Size(74, 23);
            this.usdmkdl.Style = MetroSet_UI.Enums.Style.Light;
            this.usdmkdl.StyleManager = null;
            this.usdmkdl.TabIndex = 13;
            this.usdmkdl.Text = "0";
            this.usdmkdl.ThemeAuthor = "Narwin";
            this.usdmkdl.ThemeName = "MetroLite";
            // 
            // feeBadge
            // 
            this.feeBadge.BackColor = System.Drawing.Color.Transparent;
            this.feeBadge.BadgeAlignment = MetroSet_UI.Enums.BadgeAlign.BottomRight;
            this.feeBadge.BadgeText = "5";
            this.feeBadge.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.feeBadge.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.feeBadge.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.feeBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.feeBadge.HoverBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(187)))), ((int)(((byte)(245)))));
            this.feeBadge.HoverBadgeTextColor = System.Drawing.Color.White;
            this.feeBadge.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.feeBadge.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.feeBadge.HoverTextColor = System.Drawing.Color.White;
            this.feeBadge.IsDerivedStyle = true;
            this.feeBadge.Location = new System.Drawing.Point(314, 16);
            this.feeBadge.Name = "feeBadge";
            this.feeBadge.NormalBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.feeBadge.NormalBadgeTextColor = System.Drawing.Color.White;
            this.feeBadge.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.feeBadge.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.feeBadge.NormalTextColor = System.Drawing.Color.Black;
            this.feeBadge.PressBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(147)))), ((int)(((byte)(205)))));
            this.feeBadge.PressBadgeTextColor = System.Drawing.Color.White;
            this.feeBadge.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.feeBadge.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.feeBadge.PressTextColor = System.Drawing.Color.White;
            this.feeBadge.Size = new System.Drawing.Size(75, 46);
            this.feeBadge.Style = MetroSet_UI.Enums.Style.Light;
            this.feeBadge.StyleManager = null;
            this.feeBadge.TabIndex = 16;
            this.feeBadge.Text = "Fee";
            this.feeBadge.ThemeAuthor = "Narwin";
            this.feeBadge.ThemeName = "MetroLite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Last Updated:";
            // 
            // lastupdated
            // 
            this.lastupdated.AutoSize = true;
            this.lastupdated.Location = new System.Drawing.Point(531, 330);
            this.lastupdated.Name = "lastupdated";
            this.lastupdated.Size = new System.Drawing.Size(77, 13);
            this.lastupdated.TabIndex = 18;
            this.lastupdated.Text = "0 seconds ago";
            // 
            // pbar
            // 
            this.pbar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pbar.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pbar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pbar.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.pbar.IsDerivedStyle = true;
            this.pbar.Location = new System.Drawing.Point(415, 290);
            this.pbar.Maximum = 10;
            this.pbar.Minimum = 0;
            this.pbar.Name = "pbar";
            this.pbar.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.pbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.pbar.Size = new System.Drawing.Size(249, 23);
            this.pbar.Style = MetroSet_UI.Enums.Style.Light;
            this.pbar.StyleManager = null;
            this.pbar.TabIndex = 19;
            this.pbar.Text = "metroSetProgressBar1";
            this.pbar.ThemeAuthor = "Narwin";
            this.pbar.ThemeName = "MetroLite";
            this.pbar.Value = 0;
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.IsDerivedStyle = true;
            this.metroSetButton1.Location = new System.Drawing.Point(460, 196);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(155, 31);
            this.metroSetButton1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 20;
            this.metroSetButton1.Text = "Manual Refresh";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 352);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.lastupdated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feeBadge);
            this.Controls.Add(this.metroSetLabel7);
            this.Controls.Add(this.usdeurl);
            this.Controls.Add(this.usdmkdl);
            this.Controls.Add(this.mkdeurl);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetTextBox4);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.eurgivet);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.usdgive);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.usdAmount);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetDivider1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox usdgive;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox eurgivet;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        public MetroSet_UI.Controls.MetroSetTextBox usdAmount;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel mkdeurl;
        private MetroSet_UI.Controls.MetroSetLabel usdeurl;
        private System.Windows.Forms.Timer timer1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel usdmkdl;
        private MetroSet_UI.Controls.MetroSetBadge feeBadge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lastupdated;
        private MetroSet_UI.Controls.MetroSetProgressBar pbar;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
    }
}

