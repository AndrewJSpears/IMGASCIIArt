namespace ASCII_Art
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
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileLocation = new System.Windows.Forms.TextBox();
         this.btnSearch = new System.Windows.Forms.Button();
         this.btnConvert = new System.Windows.Forms.Button();
         this.imgPreview = new System.Windows.Forms.PictureBox();
         this.greyScaleBox = new System.Windows.Forms.PictureBox();
         this.rdioBtnAvg = new System.Windows.Forms.RadioButton();
         this.label1 = new System.Windows.Forms.Label();
         this.RedLabel = new System.Windows.Forms.Label();
         this.redTrackBar = new System.Windows.Forms.TrackBar();
         this.greenLabel = new System.Windows.Forms.Label();
         this.greenTrackBar = new System.Windows.Forms.TrackBar();
         this.blueLabel = new System.Windows.Forms.Label();
         this.blueTrackBar = new System.Windows.Forms.TrackBar();
         this.freshImage = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.greyScaleBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(731, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileLocation
         // 
         this.fileLocation.Location = new System.Drawing.Point(83, 25);
         this.fileLocation.Name = "fileLocation";
         this.fileLocation.Size = new System.Drawing.Size(398, 22);
         this.fileLocation.TabIndex = 0;
         // 
         // btnSearch
         // 
         this.btnSearch.Location = new System.Drawing.Point(487, 12);
         this.btnSearch.Name = "btnSearch";
         this.btnSearch.Size = new System.Drawing.Size(116, 40);
         this.btnSearch.TabIndex = 1;
         this.btnSearch.Text = "Search";
         this.btnSearch.UseVisualStyleBackColor = true;
         this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
         // 
         // btnConvert
         // 
         this.btnConvert.Location = new System.Drawing.Point(609, 12);
         this.btnConvert.Name = "btnConvert";
         this.btnConvert.Size = new System.Drawing.Size(116, 40);
         this.btnConvert.TabIndex = 2;
         this.btnConvert.Text = "Convert";
         this.btnConvert.UseVisualStyleBackColor = true;
         this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
         // 
         // imgPreview
         // 
         this.imgPreview.Location = new System.Drawing.Point(15, 53);
         this.imgPreview.Name = "imgPreview";
         this.imgPreview.Size = new System.Drawing.Size(413, 306);
         this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.imgPreview.TabIndex = 3;
         this.imgPreview.TabStop = false;
         // 
         // greyScaleBox
         // 
         this.greyScaleBox.Location = new System.Drawing.Point(443, 58);
         this.greyScaleBox.Name = "greyScaleBox";
         this.greyScaleBox.Size = new System.Drawing.Size(595, 602);
         this.greyScaleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.greyScaleBox.TabIndex = 4;
         this.greyScaleBox.TabStop = false;
         // 
         // rdioBtnAvg
         // 
         this.rdioBtnAvg.AutoSize = true;
         this.rdioBtnAvg.Location = new System.Drawing.Point(15, 365);
         this.rdioBtnAvg.Name = "rdioBtnAvg";
         this.rdioBtnAvg.Size = new System.Drawing.Size(107, 21);
         this.rdioBtnAvg.TabIndex = 6;
         this.rdioBtnAvg.TabStop = true;
         this.rdioBtnAvg.Text = "Black & White";
         this.rdioBtnAvg.UseVisualStyleBackColor = true;
         this.rdioBtnAvg.CheckedChanged += new System.EventHandler(this.rdioBtn1_CheckedChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(65, 17);
         this.label1.TabIndex = 8;
         this.label1.Text = "Input File";
         // 
         // RedLabel
         // 
         this.RedLabel.AutoSize = true;
         this.RedLabel.Location = new System.Drawing.Point(12, 409);
         this.RedLabel.Name = "RedLabel";
         this.RedLabel.Size = new System.Drawing.Size(34, 17);
         this.RedLabel.TabIndex = 12;
         this.RedLabel.Text = "Red";
         // 
         // redTrackBar
         // 
         this.redTrackBar.Location = new System.Drawing.Point(66, 406);
         this.redTrackBar.Name = "redTrackBar";
         this.redTrackBar.Size = new System.Drawing.Size(190, 56);
         this.redTrackBar.TabIndex = 11;
         this.redTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.redTrackBar_MouseUp);
         // 
         // greenLabel
         // 
         this.greenLabel.AutoSize = true;
         this.greenLabel.Location = new System.Drawing.Point(12, 445);
         this.greenLabel.Name = "greenLabel";
         this.greenLabel.Size = new System.Drawing.Size(48, 17);
         this.greenLabel.TabIndex = 14;
         this.greenLabel.Text = "Green";
         // 
         // greenTrackBar
         // 
         this.greenTrackBar.Location = new System.Drawing.Point(66, 442);
         this.greenTrackBar.Name = "greenTrackBar";
         this.greenTrackBar.Size = new System.Drawing.Size(190, 56);
         this.greenTrackBar.TabIndex = 13;
         this.greenTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.greenTrackBar_MouseUp);
         // 
         // blueLabel
         // 
         this.blueLabel.AutoSize = true;
         this.blueLabel.Location = new System.Drawing.Point(12, 484);
         this.blueLabel.Name = "blueLabel";
         this.blueLabel.Size = new System.Drawing.Size(36, 17);
         this.blueLabel.TabIndex = 16;
         this.blueLabel.Text = "Blue";
         // 
         // blueTrackBar
         // 
         this.blueTrackBar.Location = new System.Drawing.Point(66, 481);
         this.blueTrackBar.Name = "blueTrackBar";
         this.blueTrackBar.Size = new System.Drawing.Size(190, 56);
         this.blueTrackBar.TabIndex = 15;
         this.blueTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.blueTrackBar_MouseUp);
         // 
         // freshImage
         // 
         this.freshImage.Location = new System.Drawing.Point(731, 12);
         this.freshImage.Name = "freshImage";
         this.freshImage.Size = new System.Drawing.Size(116, 40);
         this.freshImage.TabIndex = 17;
         this.freshImage.Text = "Fresh Image";
         this.freshImage.UseVisualStyleBackColor = true;
         this.freshImage.Click += new System.EventHandler(this.freshImage_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1050, 672);
         this.Controls.Add(this.freshImage);
         this.Controls.Add(this.blueLabel);
         this.Controls.Add(this.blueTrackBar);
         this.Controls.Add(this.greenLabel);
         this.Controls.Add(this.greenTrackBar);
         this.Controls.Add(this.RedLabel);
         this.Controls.Add(this.redTrackBar);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.rdioBtnAvg);
         this.Controls.Add(this.greyScaleBox);
         this.Controls.Add(this.imgPreview);
         this.Controls.Add(this.btnConvert);
         this.Controls.Add(this.btnSearch);
         this.Controls.Add(this.fileLocation);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Form1";
         this.ShowIcon = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ASCII Machine";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.greyScaleBox)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.TextBox fileLocation;
      private System.Windows.Forms.Button btnSearch;
      private System.Windows.Forms.Button btnConvert;
      private System.Windows.Forms.PictureBox imgPreview;
      private System.Windows.Forms.PictureBox greyScaleBox;
      private System.Windows.Forms.RadioButton rdioBtnAvg;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label RedLabel;
      private System.Windows.Forms.TrackBar redTrackBar;
      private System.Windows.Forms.Label greenLabel;
      private System.Windows.Forms.TrackBar greenTrackBar;
      private System.Windows.Forms.Label blueLabel;
      private System.Windows.Forms.TrackBar blueTrackBar;
      private System.Windows.Forms.Button freshImage;
   }
}

