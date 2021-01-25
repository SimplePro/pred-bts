
namespace PRED_BTS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.load_button = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.result_label = new System.Windows.Forms.Label();
            this.load_image_dialog = new System.Windows.Forms.OpenFileDialog();
            this.loaded_image = new System.Windows.Forms.PictureBox();
            this.python_path_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loaded_image)).BeginInit();
            this.SuspendLayout();
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(95, 351);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(226, 41);
            this.load_button.TabIndex = 0;
            this.load_button.Text = "이미지 불러오기";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // result_label
            // 
            this.result_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.result_label.Location = new System.Drawing.Point(95, 44);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(226, 31);
            this.result_label.TabIndex = 2;
            this.result_label.Text = "예측결과: ";
            this.result_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // load_image_dialog
            // 
            this.load_image_dialog.FileName = "openFileDialog1";
            // 
            // loaded_image
            // 
            this.loaded_image.InitialImage = null;
            this.loaded_image.Location = new System.Drawing.Point(95, 108);
            this.loaded_image.Name = "loaded_image";
            this.loaded_image.Size = new System.Drawing.Size(226, 217);
            this.loaded_image.TabIndex = 3;
            this.loaded_image.TabStop = false;
            // 
            // python_path_box
            // 
            this.python_path_box.Location = new System.Drawing.Point(52, 13);
            this.python_path_box.Name = "python_path_box";
            this.python_path_box.Size = new System.Drawing.Size(308, 21);
            this.python_path_box.TabIndex = 4;
            this.python_path_box.Tag = "";
            this.python_path_box.Text = "파이썬 디렉토리";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 429);
            this.Controls.Add(this.python_path_box);
            this.Controls.Add(this.loaded_image);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.load_button);
            this.Name = "Form1";
            this.Text = "PREDICT BTS";
            ((System.ComponentModel.ISupportInitialize)(this.loaded_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.PictureBox loaded_image;
        private System.Windows.Forms.OpenFileDialog load_image_dialog;
        private System.Windows.Forms.TextBox python_path_box;
    }
}

