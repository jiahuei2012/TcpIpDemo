namespace TcpIpDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.labHP = new System.Windows.Forms.Label();
            this.labMP = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.labMHP = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(23, 233);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 29);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "普通攻擊";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab1.Location = new System.Drawing.Point(305, 242);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(73, 20);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "血量(HP)";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab2.Location = new System.Drawing.Point(305, 275);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(76, 20);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "魔量(MP)";
            // 
            // labHP
            // 
            this.labHP.AutoSize = true;
            this.labHP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labHP.Location = new System.Drawing.Point(384, 242);
            this.labHP.Name = "labHP";
            this.labHP.Size = new System.Drawing.Size(49, 20);
            this.labHP.TabIndex = 3;
            this.labHP.Text = "XXXX";
            // 
            // labMP
            // 
            this.labMP.AutoSize = true;
            this.labMP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMP.Location = new System.Drawing.Point(384, 275);
            this.labMP.Name = "labMP";
            this.labMP.Size = new System.Drawing.Size(49, 20);
            this.labMP.TabIndex = 4;
            this.labMP.Text = "XXXX";
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(128, 233);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 29);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "強力攻擊";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn3.Location = new System.Drawing.Point(23, 275);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 29);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "魔法攻擊";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn4.Location = new System.Drawing.Point(128, 275);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 29);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "防禦";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // tbContent
            // 
            this.tbContent.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbContent.Location = new System.Drawing.Point(23, 12);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ReadOnly = true;
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(220, 198);
            this.tbContent.TabIndex = 8;
            this.tbContent.TabStop = false;
            // 
            // labMHP
            // 
            this.labMHP.AutoSize = true;
            this.labMHP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMHP.Location = new System.Drawing.Point(384, 43);
            this.labMHP.Name = "labMHP";
            this.labMHP.Size = new System.Drawing.Size(49, 20);
            this.labMHP.TabIndex = 10;
            this.labMHP.Text = "XXXX";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab3.Location = new System.Drawing.Point(305, 43);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(73, 20);
            this.lab3.TabIndex = 9;
            this.lab3.Text = "血量(HP)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 326);
            this.Controls.Add(this.labMHP);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.labMP);
            this.Controls.Add(this.labHP);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label labHP;
        private System.Windows.Forms.Label labMP;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label labMHP;
        private System.Windows.Forms.Label lab3;
    }
}

