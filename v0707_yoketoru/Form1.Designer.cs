﻿
namespace v0707_yoketoru
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startbutton = new System.Windows.Forms.Button();
            this.titlelabel = new System.Windows.Forms.Label();
            this.Copyrightlabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.highlabel = new System.Windows.Forms.Label();
            this.starlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameOverlabel = new System.Windows.Forms.Label();
            this.CLEARlabel = new System.Windows.Forms.Label();
            this.titlebutton = new System.Windows.Forms.Button();
            this.templabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startbutton.Location = new System.Drawing.Point(303, 262);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(194, 82);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "スタート";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titlelabel.ForeColor = System.Drawing.Color.Blue;
            this.titlelabel.Location = new System.Drawing.Point(265, 76);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(271, 63);
            this.titlelabel.TabIndex = 1;
            this.titlelabel.Text = "よけとる2022";
            // 
            // Copyrightlabel
            // 
            this.Copyrightlabel.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Copyrightlabel.Location = new System.Drawing.Point(267, 387);
            this.Copyrightlabel.Name = "Copyrightlabel";
            this.Copyrightlabel.Size = new System.Drawing.Size(266, 34);
            this.Copyrightlabel.TabIndex = 2;
            this.Copyrightlabel.Text = "Copyright © 2022 中村";
            // 
            // timelabel
            // 
            this.timelabel.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(13, 13);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(170, 34);
            this.timelabel.TabIndex = 3;
            this.timelabel.Text = "Time 100";
            // 
            // highlabel
            // 
            this.highlabel.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlabel.Location = new System.Drawing.Point(258, 167);
            this.highlabel.Name = "highlabel";
            this.highlabel.Size = new System.Drawing.Size(251, 38);
            this.highlabel.TabIndex = 4;
            this.highlabel.Text = "Highscore 100";
            // 
            // starlabel
            // 
            this.starlabel.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starlabel.Location = new System.Drawing.Point(673, 13);
            this.starlabel.Name = "starlabel";
            this.starlabel.Size = new System.Drawing.Size(100, 35);
            this.starlabel.TabIndex = 5;
            this.starlabel.Text = "★:10";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameOverlabel
            // 
            this.GameOverlabel.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GameOverlabel.ForeColor = System.Drawing.Color.Red;
            this.GameOverlabel.Location = new System.Drawing.Point(242, 136);
            this.GameOverlabel.Name = "GameOverlabel";
            this.GameOverlabel.Size = new System.Drawing.Size(316, 69);
            this.GameOverlabel.TabIndex = 6;
            this.GameOverlabel.Text = "GameOver";
            // 
            // CLEARlabel
            // 
            this.CLEARlabel.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CLEARlabel.ForeColor = System.Drawing.Color.Blue;
            this.CLEARlabel.Location = new System.Drawing.Point(270, 139);
            this.CLEARlabel.Name = "CLEARlabel";
            this.CLEARlabel.Size = new System.Drawing.Size(261, 68);
            this.CLEARlabel.TabIndex = 7;
            this.CLEARlabel.Text = "CLEAR!!";
            // 
            // titlebutton
            // 
            this.titlebutton.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titlebutton.Location = new System.Drawing.Point(271, 262);
            this.titlebutton.Name = "titlebutton";
            this.titlebutton.Size = new System.Drawing.Size(249, 83);
            this.titlebutton.TabIndex = 8;
            this.titlebutton.Text = "タイトルへ";
            this.titlebutton.UseVisualStyleBackColor = true;
            this.titlebutton.Click += new System.EventHandler(this.titlebotton_Click);
            // 
            // templabel
            // 
            this.templabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.templabel.Location = new System.Drawing.Point(71, 136);
            this.templabel.Name = "templabel";
            this.templabel.Size = new System.Drawing.Size(30, 23);
            this.templabel.TabIndex = 9;
            this.templabel.Text = "★";
            this.templabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.templabel);
            this.Controls.Add(this.titlebutton);
            this.Controls.Add(this.CLEARlabel);
            this.Controls.Add(this.GameOverlabel);
            this.Controls.Add(this.starlabel);
            this.Controls.Add(this.highlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.Copyrightlabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.startbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label Copyrightlabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label highlabel;
        private System.Windows.Forms.Label starlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label GameOverlabel;
        private System.Windows.Forms.Label CLEARlabel;
        private System.Windows.Forms.Button titlebutton;
        private System.Windows.Forms.Label templabel;
    }
}

