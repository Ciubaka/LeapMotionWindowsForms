
namespace LeapMotionWindowsForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.displayID = new System.Windows.Forms.Label();
            this.displayTimestamp = new System.Windows.Forms.Label();
            this.displayFPS = new System.Windows.Forms.Label();
            this.displayHandCount = new System.Windows.Forms.Label();
            this.displayImages = new System.Windows.Forms.PictureBox();
            this.debugText = new System.Windows.Forms.RichTextBox();
            this.Latitude = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.Longitude = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.btnLoadIntoMap = new System.Windows.Forms.Button();
            this.txtPitch = new System.Windows.Forms.TextBox();
            this.txtYaw = new System.Windows.Forms.TextBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrzyklad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetectHand = new System.Windows.Forms.TextBox();
            this.txtGetRoute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).BeginInit();
            this.SuspendLayout();
            // 
            // displayID
            // 
            this.displayID.AutoSize = true;
            this.displayID.Location = new System.Drawing.Point(18, 14);
            this.displayID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayID.Name = "displayID";
            this.displayID.Size = new System.Drawing.Size(51, 20);
            this.displayID.TabIndex = 0;
            this.displayID.Text = "label1";
            // 
            // displayTimestamp
            // 
            this.displayTimestamp.AutoSize = true;
            this.displayTimestamp.Location = new System.Drawing.Point(166, 14);
            this.displayTimestamp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayTimestamp.Name = "displayTimestamp";
            this.displayTimestamp.Size = new System.Drawing.Size(51, 20);
            this.displayTimestamp.TabIndex = 1;
            this.displayTimestamp.Text = "label2";
            // 
            // displayFPS
            // 
            this.displayFPS.AutoSize = true;
            this.displayFPS.Location = new System.Drawing.Point(333, 14);
            this.displayFPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(51, 20);
            this.displayFPS.TabIndex = 2;
            this.displayFPS.Text = "label3";
            // 
            // displayHandCount
            // 
            this.displayHandCount.AutoSize = true;
            this.displayHandCount.Location = new System.Drawing.Point(465, 14);
            this.displayHandCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayHandCount.Name = "displayHandCount";
            this.displayHandCount.Size = new System.Drawing.Size(51, 20);
            this.displayHandCount.TabIndex = 3;
            this.displayHandCount.Text = "label4";
            // 
            // displayImages
            // 
            this.displayImages.Location = new System.Drawing.Point(22, 98);
            this.displayImages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayImages.Name = "displayImages";
            this.displayImages.Size = new System.Drawing.Size(322, 678);
            this.displayImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.displayImages.TabIndex = 4;
            this.displayImages.TabStop = false;
            // 
            // debugText
            // 
            this.debugText.Location = new System.Drawing.Point(22, 786);
            this.debugText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.debugText.Name = "debugText";
            this.debugText.Size = new System.Drawing.Size(958, 252);
            this.debugText.TabIndex = 5;
            this.debugText.Text = "";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(646, 14);
            this.Latitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(67, 20);
            this.Latitude.TabIndex = 6;
            this.Latitude.Text = "Latitude";
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(650, 82);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(946, 696);
            this.map.TabIndex = 8;
            this.map.Zoom = 0D;
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.Location = new System.Drawing.Point(869, 14);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(80, 20);
            this.Longitude.TabIndex = 9;
            this.Longitude.Text = "Longitude";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(650, 50);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 26);
            this.txtLat.TabIndex = 10;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(873, 50);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 26);
            this.txtLong.TabIndex = 11;
            // 
            // btnLoadIntoMap
            // 
            this.btnLoadIntoMap.Location = new System.Drawing.Point(469, 171);
            this.btnLoadIntoMap.Name = "btnLoadIntoMap";
            this.btnLoadIntoMap.Size = new System.Drawing.Size(97, 47);
            this.btnLoadIntoMap.TabIndex = 12;
            this.btnLoadIntoMap.Text = "Load Map";
            this.btnLoadIntoMap.UseVisualStyleBackColor = true;
            this.btnLoadIntoMap.Click += new System.EventHandler(this.btnLoadIntoMap_Click);
            // 
            // txtPitch
            // 
            this.txtPitch.Location = new System.Drawing.Point(438, 356);
            this.txtPitch.Name = "txtPitch";
            this.txtPitch.Size = new System.Drawing.Size(100, 26);
            this.txtPitch.TabIndex = 13;
            // 
            // txtYaw
            // 
            this.txtYaw.Location = new System.Drawing.Point(438, 423);
            this.txtYaw.Name = "txtYaw";
            this.txtYaw.Size = new System.Drawing.Size(100, 26);
            this.txtYaw.TabIndex = 14;
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(438, 506);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(100, 26);
            this.txtRoll.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "PItch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yaw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Roll";
            // 
            // txtPrzyklad
            // 
            this.txtPrzyklad.Location = new System.Drawing.Point(351, 607);
            this.txtPrzyklad.Name = "txtPrzyklad";
            this.txtPrzyklad.Size = new System.Drawing.Size(293, 26);
            this.txtPrzyklad.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1084, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Zoom";
            // 
            // txtZoom
            // 
            this.txtZoom.Location = new System.Drawing.Point(1088, 50);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(100, 26);
            this.txtZoom.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1265, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Wykryta dłoń";
            // 
            // txtDetectHand
            // 
            this.txtDetectHand.Location = new System.Drawing.Point(1269, 50);
            this.txtDetectHand.Name = "txtDetectHand";
            this.txtDetectHand.Size = new System.Drawing.Size(100, 26);
            this.txtDetectHand.TabIndex = 23;
            // 
            // txtGetRoute
            // 
            this.txtGetRoute.Location = new System.Drawing.Point(1456, 33);
            this.txtGetRoute.Name = "txtGetRoute";
            this.txtGetRoute.Size = new System.Drawing.Size(92, 43);
            this.txtGetRoute.TabIndex = 24;
            this.txtGetRoute.Text = "button1";
            this.txtGetRoute.UseVisualStyleBackColor = true;
            this.txtGetRoute.Click += new System.EventHandler(this.txtGetRoute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 1066);
            this.Controls.Add(this.txtGetRoute);
            this.Controls.Add(this.txtDetectHand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtZoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrzyklad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.txtYaw);
            this.Controls.Add(this.txtPitch);
            this.Controls.Add(this.btnLoadIntoMap);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.map);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.displayImages);
            this.Controls.Add(this.displayHandCount);
            this.Controls.Add(this.displayFPS);
            this.Controls.Add(this.displayTimestamp);
            this.Controls.Add(this.displayID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Frame Data";
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayID;
        private System.Windows.Forms.Label displayTimestamp;
        private System.Windows.Forms.Label displayFPS;
        private System.Windows.Forms.Label displayHandCount;
        private System.Windows.Forms.PictureBox displayImages;
        private System.Windows.Forms.RichTextBox debugText;
        private System.Windows.Forms.Label przyklad;
        private System.Windows.Forms.Label Latitude;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Button btnLoadIntoMap;
        private System.Windows.Forms.TextBox txtPitch;
        private System.Windows.Forms.TextBox txtYaw;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrzyklad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetectHand;
        private System.Windows.Forms.Button txtGetRoute;
    }
}