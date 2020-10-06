namespace StartOpenCV
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
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBoxIpl2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그림읽기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVI읽기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.웹캠실행ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.필터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그레이ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이진화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.캐니엣지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.소벨엣지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.라플레스엣지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn동영상PLAY = new System.Windows.Forms.Button();
            this.btn동영상STOP = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIpl1.Location = new System.Drawing.Point(42, 65);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxIpl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            this.pictureBoxIpl1.Click += new System.EventHandler(this.pictureBoxIpl1_Click);
            // 
            // pictureBoxIpl2
            // 
            this.pictureBoxIpl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIpl2.Location = new System.Drawing.Point(389, 65);
            this.pictureBoxIpl2.Name = "pictureBoxIpl2";
            this.pictureBoxIpl2.Size = new System.Drawing.Size(320, 240);
            this.pictureBoxIpl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl2.TabIndex = 0;
            this.pictureBoxIpl2.TabStop = false;
            this.pictureBoxIpl2.Click += new System.EventHandler(this.pictureBoxIpl2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "원본그림";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "결과그림";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.필터ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그림읽기ToolStripMenuItem,
            this.aVI읽기ToolStripMenuItem,
            this.웹캠실행ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 그림읽기ToolStripMenuItem
            // 
            this.그림읽기ToolStripMenuItem.Name = "그림읽기ToolStripMenuItem";
            this.그림읽기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.그림읽기ToolStripMenuItem.Text = "그림읽기";
            this.그림읽기ToolStripMenuItem.Click += new System.EventHandler(this.그림읽기ToolStripMenuItem_Click);
            // 
            // aVI읽기ToolStripMenuItem
            // 
            this.aVI읽기ToolStripMenuItem.Name = "aVI읽기ToolStripMenuItem";
            this.aVI읽기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aVI읽기ToolStripMenuItem.Text = "AVI읽기";
            // 
            // 웹캠실행ToolStripMenuItem
            // 
            this.웹캠실행ToolStripMenuItem.Name = "웹캠실행ToolStripMenuItem";
            this.웹캠실행ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.웹캠실행ToolStripMenuItem.Text = "웹캠실행";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // 필터ToolStripMenuItem
            // 
            this.필터ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그레이ToolStripMenuItem,
            this.이진화ToolStripMenuItem,
            this.캐니엣지ToolStripMenuItem,
            this.소벨엣지ToolStripMenuItem,
            this.라플레스엣지ToolStripMenuItem});
            this.필터ToolStripMenuItem.Name = "필터ToolStripMenuItem";
            this.필터ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.필터ToolStripMenuItem.Text = "필터";
            // 
            // 그레이ToolStripMenuItem
            // 
            this.그레이ToolStripMenuItem.Name = "그레이ToolStripMenuItem";
            this.그레이ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.그레이ToolStripMenuItem.Text = "그레이";
            this.그레이ToolStripMenuItem.Click += new System.EventHandler(this.그레이ToolStripMenuItem_Click);
            // 
            // 이진화ToolStripMenuItem
            // 
            this.이진화ToolStripMenuItem.Name = "이진화ToolStripMenuItem";
            this.이진화ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.이진화ToolStripMenuItem.Text = "이진화";
            this.이진화ToolStripMenuItem.Click += new System.EventHandler(this.이진화ToolStripMenuItem_Click);
            // 
            // 캐니엣지ToolStripMenuItem
            // 
            this.캐니엣지ToolStripMenuItem.Name = "캐니엣지ToolStripMenuItem";
            this.캐니엣지ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.캐니엣지ToolStripMenuItem.Text = "캐니엣지";
            this.캐니엣지ToolStripMenuItem.Click += new System.EventHandler(this.캐니엣지ToolStripMenuItem_Click);
            // 
            // 소벨엣지ToolStripMenuItem
            // 
            this.소벨엣지ToolStripMenuItem.Name = "소벨엣지ToolStripMenuItem";
            this.소벨엣지ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.소벨엣지ToolStripMenuItem.Text = "소벨엣지";
            this.소벨엣지ToolStripMenuItem.Click += new System.EventHandler(this.소벨엣지ToolStripMenuItem_Click);
            // 
            // 라플레스엣지ToolStripMenuItem
            // 
            this.라플레스엣지ToolStripMenuItem.Name = "라플레스엣지ToolStripMenuItem";
            this.라플레스엣지ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.라플레스엣지ToolStripMenuItem.Text = "라플레스엣지";
            this.라플레스엣지ToolStripMenuItem.Click += new System.EventHandler(this.라플레스엣지ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn동영상PLAY
            // 
            this.btn동영상PLAY.Location = new System.Drawing.Point(728, 65);
            this.btn동영상PLAY.Name = "btn동영상PLAY";
            this.btn동영상PLAY.Size = new System.Drawing.Size(116, 23);
            this.btn동영상PLAY.TabIndex = 3;
            this.btn동영상PLAY.Text = "동영상 PLAY";
            this.btn동영상PLAY.UseVisualStyleBackColor = true;
            this.btn동영상PLAY.Click += new System.EventHandler(this.btn동영상PLAY_Click);
            // 
            // btn동영상STOP
            // 
            this.btn동영상STOP.Location = new System.Drawing.Point(728, 94);
            this.btn동영상STOP.Name = "btn동영상STOP";
            this.btn동영상STOP.Size = new System.Drawing.Size(116, 23);
            this.btn동영상STOP.TabIndex = 3;
            this.btn동영상STOP.Text = "동영상 STOP";
            this.btn동영상STOP.UseVisualStyleBackColor = true;
            this.btn동영상STOP.Click += new System.EventHandler(this.btn동영상STOP_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "* 크로마키영상과 배경이미지 합성";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn동영상STOP);
            this.Controls.Add(this.btn동영상PLAY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxIpl2);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start OpenCV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그림읽기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVI읽기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 웹캠실행ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 필터ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그레이ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이진화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 캐니엣지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 소벨엣지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 라플레스엣지ToolStripMenuItem;
        private System.Windows.Forms.Button btn동영상PLAY;
        private System.Windows.Forms.Button btn동영상STOP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

