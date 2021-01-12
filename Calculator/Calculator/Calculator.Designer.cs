namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.label_app_name = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.clear_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_equal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_point = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_plus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_0 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_divide = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_minus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_multiple = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_pow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label_app_name
            // 
            this.label_app_name.AutoSize = true;
            this.label_app_name.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label_app_name.ForeColor = System.Drawing.Color.LightGray;
            this.label_app_name.Location = new System.Drawing.Point(13, 18);
            this.label_app_name.Name = "label_app_name";
            this.label_app_name.Size = new System.Drawing.Size(148, 30);
            this.label_app_name.TabIndex = 90;
            this.label_app_name.Text = "CALCULATOR";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(401, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 89;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.Image = ((System.Drawing.Image)(resources.GetObject("clear_btn.Image")));
            this.clear_btn.ImageActive = null;
            this.clear_btn.Location = new System.Drawing.Point(401, 70);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(36, 30);
            this.clear_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clear_btn.TabIndex = 92;
            this.clear_btn.TabStop = false;
            this.clear_btn.Zoom = 10;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // txt_1
            // 
            this.txt_1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.txt_1.BorderColorIdle = System.Drawing.Color.DodgerBlue;
            this.txt_1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.txt_1.BorderThickness = 1;
            this.txt_1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.ForeColor = System.Drawing.Color.White;
            this.txt_1.isPassword = false;
            this.txt_1.Location = new System.Drawing.Point(19, 70);
            this.txt_1.Margin = new System.Windows.Forms.Padding(0);
            this.txt_1.MaxLength = 32767;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(365, 30);
            this.txt_1.TabIndex = 91;
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_equal
            // 
            this.btn_equal.Active = true;
            this.btn_equal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_equal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_equal.BorderRadius = 0;
            this.btn_equal.ButtonText = "=";
            this.btn_equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_equal.DisabledColor = System.Drawing.Color.Gray;
            this.btn_equal.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_equal.Iconimage = null;
            this.btn_equal.Iconimage_right = null;
            this.btn_equal.Iconimage_right_Selected = null;
            this.btn_equal.Iconimage_Selected = null;
            this.btn_equal.IconMarginLeft = 0;
            this.btn_equal.IconMarginRight = 0;
            this.btn_equal.IconRightVisible = true;
            this.btn_equal.IconRightZoom = 0D;
            this.btn_equal.IconVisible = true;
            this.btn_equal.IconZoom = 50D;
            this.btn_equal.IsTab = true;
            this.btn_equal.Location = new System.Drawing.Point(19, 552);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_equal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_equal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_equal.selected = true;
            this.btn_equal.Size = new System.Drawing.Size(312, 100);
            this.btn_equal.TabIndex = 105;
            this.btn_equal.Text = "=";
            this.btn_equal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_equal.Textcolor = System.Drawing.Color.LightGray;
            this.btn_equal.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_point
            // 
            this.btn_point.Active = true;
            this.btn_point.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_point.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_point.BorderRadius = 0;
            this.btn_point.ButtonText = ".";
            this.btn_point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_point.DisabledColor = System.Drawing.Color.Gray;
            this.btn_point.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_point.Iconimage = null;
            this.btn_point.Iconimage_right = null;
            this.btn_point.Iconimage_right_Selected = null;
            this.btn_point.Iconimage_Selected = null;
            this.btn_point.IconMarginLeft = 0;
            this.btn_point.IconMarginRight = 0;
            this.btn_point.IconRightVisible = true;
            this.btn_point.IconRightZoom = 0D;
            this.btn_point.IconVisible = true;
            this.btn_point.IconZoom = 50D;
            this.btn_point.IsTab = true;
            this.btn_point.Location = new System.Drawing.Point(19, 445);
            this.btn_point.Name = "btn_point";
            this.btn_point.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_point.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_point.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_point.selected = true;
            this.btn_point.Size = new System.Drawing.Size(100, 100);
            this.btn_point.TabIndex = 104;
            this.btn_point.Text = ".";
            this.btn_point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_point.Textcolor = System.Drawing.Color.LightGray;
            this.btn_point.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Active = true;
            this.btn_plus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_plus.BorderRadius = 0;
            this.btn_plus.ButtonText = "+";
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus.DisabledColor = System.Drawing.Color.Gray;
            this.btn_plus.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_plus.Iconimage = null;
            this.btn_plus.Iconimage_right = null;
            this.btn_plus.Iconimage_right_Selected = null;
            this.btn_plus.Iconimage_Selected = null;
            this.btn_plus.IconMarginLeft = 0;
            this.btn_plus.IconMarginRight = 0;
            this.btn_plus.IconRightVisible = true;
            this.btn_plus.IconRightZoom = 0D;
            this.btn_plus.IconVisible = true;
            this.btn_plus.IconZoom = 50D;
            this.btn_plus.IsTab = true;
            this.btn_plus.Location = new System.Drawing.Point(337, 127);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_plus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_plus.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_plus.selected = true;
            this.btn_plus.Size = new System.Drawing.Size(100, 100);
            this.btn_plus.TabIndex = 103;
            this.btn_plus.Text = "+";
            this.btn_plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_plus.Textcolor = System.Drawing.Color.LightGray;
            this.btn_plus.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_0
            // 
            this.btn_0.Active = true;
            this.btn_0.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_0.BorderRadius = 0;
            this.btn_0.ButtonText = "0";
            this.btn_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_0.DisabledColor = System.Drawing.Color.Gray;
            this.btn_0.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_0.Iconimage = null;
            this.btn_0.Iconimage_right = null;
            this.btn_0.Iconimage_right_Selected = null;
            this.btn_0.Iconimage_Selected = null;
            this.btn_0.IconMarginLeft = 0;
            this.btn_0.IconMarginRight = 0;
            this.btn_0.IconRightVisible = true;
            this.btn_0.IconRightZoom = 0D;
            this.btn_0.IconVisible = true;
            this.btn_0.IconZoom = 50D;
            this.btn_0.IsTab = true;
            this.btn_0.Location = new System.Drawing.Point(125, 445);
            this.btn_0.Name = "btn_0";
            this.btn_0.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_0.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_0.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_0.selected = true;
            this.btn_0.Size = new System.Drawing.Size(206, 100);
            this.btn_0.TabIndex = 102;
            this.btn_0.Text = "0";
            this.btn_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_0.Textcolor = System.Drawing.Color.LightGray;
            this.btn_0.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_9
            // 
            this.btn_9.Active = true;
            this.btn_9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_9.BorderRadius = 0;
            this.btn_9.ButtonText = "9";
            this.btn_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_9.DisabledColor = System.Drawing.Color.Gray;
            this.btn_9.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_9.Iconimage = null;
            this.btn_9.Iconimage_right = null;
            this.btn_9.Iconimage_right_Selected = null;
            this.btn_9.Iconimage_Selected = null;
            this.btn_9.IconMarginLeft = 0;
            this.btn_9.IconMarginRight = 0;
            this.btn_9.IconRightVisible = true;
            this.btn_9.IconRightZoom = 0D;
            this.btn_9.IconVisible = true;
            this.btn_9.IconZoom = 50D;
            this.btn_9.IsTab = true;
            this.btn_9.Location = new System.Drawing.Point(231, 339);
            this.btn_9.Name = "btn_9";
            this.btn_9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_9.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_9.selected = true;
            this.btn_9.Size = new System.Drawing.Size(100, 100);
            this.btn_9.TabIndex = 101;
            this.btn_9.Text = "9";
            this.btn_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_9.Textcolor = System.Drawing.Color.LightGray;
            this.btn_9.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Active = true;
            this.btn_8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_8.BorderRadius = 0;
            this.btn_8.ButtonText = "8";
            this.btn_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_8.DisabledColor = System.Drawing.Color.Gray;
            this.btn_8.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_8.Iconimage = null;
            this.btn_8.Iconimage_right = null;
            this.btn_8.Iconimage_right_Selected = null;
            this.btn_8.Iconimage_Selected = null;
            this.btn_8.IconMarginLeft = 0;
            this.btn_8.IconMarginRight = 0;
            this.btn_8.IconRightVisible = true;
            this.btn_8.IconRightZoom = 0D;
            this.btn_8.IconVisible = true;
            this.btn_8.IconZoom = 50D;
            this.btn_8.IsTab = true;
            this.btn_8.Location = new System.Drawing.Point(125, 339);
            this.btn_8.Name = "btn_8";
            this.btn_8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_8.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_8.selected = true;
            this.btn_8.Size = new System.Drawing.Size(100, 100);
            this.btn_8.TabIndex = 100;
            this.btn_8.Text = "8";
            this.btn_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_8.Textcolor = System.Drawing.Color.LightGray;
            this.btn_8.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Active = true;
            this.btn_7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_7.BorderRadius = 0;
            this.btn_7.ButtonText = "7";
            this.btn_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_7.DisabledColor = System.Drawing.Color.Gray;
            this.btn_7.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_7.Iconimage = null;
            this.btn_7.Iconimage_right = null;
            this.btn_7.Iconimage_right_Selected = null;
            this.btn_7.Iconimage_Selected = null;
            this.btn_7.IconMarginLeft = 0;
            this.btn_7.IconMarginRight = 0;
            this.btn_7.IconRightVisible = true;
            this.btn_7.IconRightZoom = 0D;
            this.btn_7.IconVisible = true;
            this.btn_7.IconZoom = 50D;
            this.btn_7.IsTab = true;
            this.btn_7.Location = new System.Drawing.Point(19, 339);
            this.btn_7.Name = "btn_7";
            this.btn_7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_7.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_7.selected = true;
            this.btn_7.Size = new System.Drawing.Size(100, 100);
            this.btn_7.TabIndex = 99;
            this.btn_7.Text = "7";
            this.btn_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_7.Textcolor = System.Drawing.Color.LightGray;
            this.btn_7.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_6
            // 
            this.btn_6.Active = true;
            this.btn_6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_6.BorderRadius = 0;
            this.btn_6.ButtonText = "6";
            this.btn_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_6.DisabledColor = System.Drawing.Color.Gray;
            this.btn_6.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_6.Iconimage = null;
            this.btn_6.Iconimage_right = null;
            this.btn_6.Iconimage_right_Selected = null;
            this.btn_6.Iconimage_Selected = null;
            this.btn_6.IconMarginLeft = 0;
            this.btn_6.IconMarginRight = 0;
            this.btn_6.IconRightVisible = true;
            this.btn_6.IconRightZoom = 0D;
            this.btn_6.IconVisible = true;
            this.btn_6.IconZoom = 50D;
            this.btn_6.IsTab = true;
            this.btn_6.Location = new System.Drawing.Point(231, 233);
            this.btn_6.Name = "btn_6";
            this.btn_6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_6.selected = true;
            this.btn_6.Size = new System.Drawing.Size(100, 100);
            this.btn_6.TabIndex = 98;
            this.btn_6.Text = "6";
            this.btn_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_6.Textcolor = System.Drawing.Color.LightGray;
            this.btn_6.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Active = true;
            this.btn_5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_5.BorderRadius = 0;
            this.btn_5.ButtonText = "5";
            this.btn_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_5.DisabledColor = System.Drawing.Color.Gray;
            this.btn_5.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_5.Iconimage = null;
            this.btn_5.Iconimage_right = null;
            this.btn_5.Iconimage_right_Selected = null;
            this.btn_5.Iconimage_Selected = null;
            this.btn_5.IconMarginLeft = 0;
            this.btn_5.IconMarginRight = 0;
            this.btn_5.IconRightVisible = true;
            this.btn_5.IconRightZoom = 0D;
            this.btn_5.IconVisible = true;
            this.btn_5.IconZoom = 50D;
            this.btn_5.IsTab = true;
            this.btn_5.Location = new System.Drawing.Point(125, 233);
            this.btn_5.Name = "btn_5";
            this.btn_5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_5.selected = true;
            this.btn_5.Size = new System.Drawing.Size(100, 100);
            this.btn_5.TabIndex = 97;
            this.btn_5.Text = "5";
            this.btn_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_5.Textcolor = System.Drawing.Color.LightGray;
            this.btn_5.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Active = true;
            this.btn_4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_4.BorderRadius = 0;
            this.btn_4.ButtonText = "4";
            this.btn_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4.DisabledColor = System.Drawing.Color.Gray;
            this.btn_4.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_4.Iconimage = null;
            this.btn_4.Iconimage_right = null;
            this.btn_4.Iconimage_right_Selected = null;
            this.btn_4.Iconimage_Selected = null;
            this.btn_4.IconMarginLeft = 0;
            this.btn_4.IconMarginRight = 0;
            this.btn_4.IconRightVisible = true;
            this.btn_4.IconRightZoom = 0D;
            this.btn_4.IconVisible = true;
            this.btn_4.IconZoom = 50D;
            this.btn_4.IsTab = true;
            this.btn_4.Location = new System.Drawing.Point(19, 233);
            this.btn_4.Name = "btn_4";
            this.btn_4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_4.selected = true;
            this.btn_4.Size = new System.Drawing.Size(100, 100);
            this.btn_4.TabIndex = 96;
            this.btn_4.Text = "4";
            this.btn_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_4.Textcolor = System.Drawing.Color.LightGray;
            this.btn_4.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_3
            // 
            this.btn_3.Active = true;
            this.btn_3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_3.BorderRadius = 0;
            this.btn_3.ButtonText = "3";
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3.DisabledColor = System.Drawing.Color.Gray;
            this.btn_3.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_3.Iconimage = null;
            this.btn_3.Iconimage_right = null;
            this.btn_3.Iconimage_right_Selected = null;
            this.btn_3.Iconimage_Selected = null;
            this.btn_3.IconMarginLeft = 0;
            this.btn_3.IconMarginRight = 0;
            this.btn_3.IconRightVisible = true;
            this.btn_3.IconRightZoom = 0D;
            this.btn_3.IconVisible = true;
            this.btn_3.IconZoom = 50D;
            this.btn_3.IsTab = true;
            this.btn_3.Location = new System.Drawing.Point(231, 127);
            this.btn_3.Name = "btn_3";
            this.btn_3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_3.selected = true;
            this.btn_3.Size = new System.Drawing.Size(100, 100);
            this.btn_3.TabIndex = 95;
            this.btn_3.Text = "3";
            this.btn_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_3.Textcolor = System.Drawing.Color.LightGray;
            this.btn_3.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Active = true;
            this.btn_2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_2.BorderRadius = 0;
            this.btn_2.ButtonText = "2";
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2.DisabledColor = System.Drawing.Color.Gray;
            this.btn_2.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_2.Iconimage = null;
            this.btn_2.Iconimage_right = null;
            this.btn_2.Iconimage_right_Selected = null;
            this.btn_2.Iconimage_Selected = null;
            this.btn_2.IconMarginLeft = 0;
            this.btn_2.IconMarginRight = 0;
            this.btn_2.IconRightVisible = true;
            this.btn_2.IconRightZoom = 0D;
            this.btn_2.IconVisible = true;
            this.btn_2.IconZoom = 50D;
            this.btn_2.IsTab = true;
            this.btn_2.Location = new System.Drawing.Point(125, 127);
            this.btn_2.Name = "btn_2";
            this.btn_2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_2.selected = true;
            this.btn_2.Size = new System.Drawing.Size(100, 100);
            this.btn_2.TabIndex = 94;
            this.btn_2.Text = "2";
            this.btn_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_2.Textcolor = System.Drawing.Color.LightGray;
            this.btn_2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.Active = true;
            this.btn_1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1.BorderRadius = 0;
            this.btn_1.ButtonText = "1";
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1.DisabledColor = System.Drawing.Color.Gray;
            this.btn_1.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_1.Iconimage = null;
            this.btn_1.Iconimage_right = null;
            this.btn_1.Iconimage_right_Selected = null;
            this.btn_1.Iconimage_Selected = null;
            this.btn_1.IconMarginLeft = 0;
            this.btn_1.IconMarginRight = 0;
            this.btn_1.IconRightVisible = true;
            this.btn_1.IconRightZoom = 0D;
            this.btn_1.IconVisible = true;
            this.btn_1.IconZoom = 50D;
            this.btn_1.IsTab = true;
            this.btn_1.Location = new System.Drawing.Point(18, 127);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_1.Name = "btn_1";
            this.btn_1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_1.selected = true;
            this.btn_1.Size = new System.Drawing.Size(100, 100);
            this.btn_1.TabIndex = 93;
            this.btn_1.Text = "1";
            this.btn_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_1.Textcolor = System.Drawing.Color.LightGray;
            this.btn_1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Active = true;
            this.btn_divide.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_divide.BorderRadius = 0;
            this.btn_divide.ButtonText = "/";
            this.btn_divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_divide.DisabledColor = System.Drawing.Color.Gray;
            this.btn_divide.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_divide.Iconimage = null;
            this.btn_divide.Iconimage_right = null;
            this.btn_divide.Iconimage_right_Selected = null;
            this.btn_divide.Iconimage_Selected = null;
            this.btn_divide.IconMarginLeft = 0;
            this.btn_divide.IconMarginRight = 0;
            this.btn_divide.IconRightVisible = true;
            this.btn_divide.IconRightZoom = 0D;
            this.btn_divide.IconVisible = true;
            this.btn_divide.IconZoom = 50D;
            this.btn_divide.IsTab = true;
            this.btn_divide.Location = new System.Drawing.Point(337, 445);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_divide.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_divide.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_divide.selected = true;
            this.btn_divide.Size = new System.Drawing.Size(100, 100);
            this.btn_divide.TabIndex = 106;
            this.btn_divide.Text = "/";
            this.btn_divide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_divide.Textcolor = System.Drawing.Color.LightGray;
            this.btn_divide.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Active = true;
            this.btn_minus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minus.BorderRadius = 0;
            this.btn_minus.ButtonText = "-";
            this.btn_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minus.DisabledColor = System.Drawing.Color.Gray;
            this.btn_minus.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_minus.Iconimage = null;
            this.btn_minus.Iconimage_right = null;
            this.btn_minus.Iconimage_right_Selected = null;
            this.btn_minus.Iconimage_Selected = null;
            this.btn_minus.IconMarginLeft = 0;
            this.btn_minus.IconMarginRight = 0;
            this.btn_minus.IconRightVisible = true;
            this.btn_minus.IconRightZoom = 0D;
            this.btn_minus.IconVisible = true;
            this.btn_minus.IconZoom = 50D;
            this.btn_minus.IsTab = true;
            this.btn_minus.Location = new System.Drawing.Point(337, 233);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_minus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_minus.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_minus.selected = true;
            this.btn_minus.Size = new System.Drawing.Size(100, 100);
            this.btn_minus.TabIndex = 107;
            this.btn_minus.Text = "-";
            this.btn_minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_minus.Textcolor = System.Drawing.Color.LightGray;
            this.btn_minus.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_multiple
            // 
            this.btn_multiple.Active = true;
            this.btn_multiple.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_multiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_multiple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_multiple.BorderRadius = 0;
            this.btn_multiple.ButtonText = "*";
            this.btn_multiple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_multiple.DisabledColor = System.Drawing.Color.Gray;
            this.btn_multiple.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_multiple.Iconimage = null;
            this.btn_multiple.Iconimage_right = null;
            this.btn_multiple.Iconimage_right_Selected = null;
            this.btn_multiple.Iconimage_Selected = null;
            this.btn_multiple.IconMarginLeft = 0;
            this.btn_multiple.IconMarginRight = 0;
            this.btn_multiple.IconRightVisible = true;
            this.btn_multiple.IconRightZoom = 0D;
            this.btn_multiple.IconVisible = true;
            this.btn_multiple.IconZoom = 50D;
            this.btn_multiple.IsTab = true;
            this.btn_multiple.Location = new System.Drawing.Point(337, 339);
            this.btn_multiple.Name = "btn_multiple";
            this.btn_multiple.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_multiple.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_multiple.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_multiple.selected = true;
            this.btn_multiple.Size = new System.Drawing.Size(100, 100);
            this.btn_multiple.TabIndex = 108;
            this.btn_multiple.Text = "*";
            this.btn_multiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_multiple.Textcolor = System.Drawing.Color.LightGray;
            this.btn_multiple.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_multiple.Click += new System.EventHandler(this.btn_multiple_Click);
            // 
            // btn_pow
            // 
            this.btn_pow.Active = true;
            this.btn_pow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_pow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_pow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pow.BorderRadius = 0;
            this.btn_pow.ButtonText = "^";
            this.btn_pow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pow.DisabledColor = System.Drawing.Color.Gray;
            this.btn_pow.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_pow.Iconimage = null;
            this.btn_pow.Iconimage_right = null;
            this.btn_pow.Iconimage_right_Selected = null;
            this.btn_pow.Iconimage_Selected = null;
            this.btn_pow.IconMarginLeft = 0;
            this.btn_pow.IconMarginRight = 0;
            this.btn_pow.IconRightVisible = true;
            this.btn_pow.IconRightZoom = 0D;
            this.btn_pow.IconVisible = true;
            this.btn_pow.IconZoom = 50D;
            this.btn_pow.IsTab = true;
            this.btn_pow.Location = new System.Drawing.Point(337, 552);
            this.btn_pow.Name = "btn_pow";
            this.btn_pow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_pow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_pow.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btn_pow.selected = true;
            this.btn_pow.Size = new System.Drawing.Size(100, 100);
            this.btn_pow.TabIndex = 109;
            this.btn_pow.Text = "^";
            this.btn_pow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pow.Textcolor = System.Drawing.Color.LightGray;
            this.btn_pow.TextFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_pow.Click += new System.EventHandler(this.btn_pow_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(458, 664);
            this.Controls.Add(this.btn_pow);
            this.Controls.Add(this.btn_multiple);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label_app_name);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_app_name;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton clear_btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_1;
        public Bunifu.Framework.UI.BunifuFlatButton btn_equal;
        public Bunifu.Framework.UI.BunifuFlatButton btn_point;
        public Bunifu.Framework.UI.BunifuFlatButton btn_plus;
        public Bunifu.Framework.UI.BunifuFlatButton btn_0;
        public Bunifu.Framework.UI.BunifuFlatButton btn_9;
        public Bunifu.Framework.UI.BunifuFlatButton btn_8;
        public Bunifu.Framework.UI.BunifuFlatButton btn_7;
        public Bunifu.Framework.UI.BunifuFlatButton btn_6;
        public Bunifu.Framework.UI.BunifuFlatButton btn_5;
        public Bunifu.Framework.UI.BunifuFlatButton btn_4;
        public Bunifu.Framework.UI.BunifuFlatButton btn_3;
        public Bunifu.Framework.UI.BunifuFlatButton btn_2;
        public Bunifu.Framework.UI.BunifuFlatButton btn_1;
        public Bunifu.Framework.UI.BunifuFlatButton btn_divide;
        public Bunifu.Framework.UI.BunifuFlatButton btn_minus;
        public Bunifu.Framework.UI.BunifuFlatButton btn_multiple;
        public Bunifu.Framework.UI.BunifuFlatButton btn_pow;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

