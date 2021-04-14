namespace ClienteMqtt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.lblQos = new System.Windows.Forms.Label();
            this.lblRetain = new System.Windows.Forms.Label();
            this.RetainCheckBox = new System.Windows.Forms.CheckBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.SubTopicTextBox = new System.Windows.Forms.TextBox();
            this.lblTopicPublish = new System.Windows.Forms.Label();
            this.PubTopicTextBox = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.PubMessageTextBox = new System.Windows.Forms.TextBox();
            this.PublishButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.SubListBox = new System.Windows.Forms.ListBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UnsubscribeButton = new System.Windows.Forms.Button();
            this.QosComboBox = new System.Windows.Forms.ComboBox();
            this.lblConect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(12, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(154, 13);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Envia dados via protocolo Mqtt";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(12, 52);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Host:";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(50, 49);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(243, 20);
            this.HostTextBox.TabIndex = 2;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(15, 78);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(50, 75);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(83, 20);
            this.PortTextBox.TabIndex = 5;
            this.PortTextBox.Text = "1883";
            // 
            // lblQos
            // 
            this.lblQos.AutoSize = true;
            this.lblQos.Location = new System.Drawing.Point(164, 79);
            this.lblQos.Name = "lblQos";
            this.lblQos.Size = new System.Drawing.Size(29, 13);
            this.lblQos.TabIndex = 6;
            this.lblQos.Text = "Qos:";
            // 
            // lblRetain
            // 
            this.lblRetain.AutoSize = true;
            this.lblRetain.Location = new System.Drawing.Point(309, 78);
            this.lblRetain.Name = "lblRetain";
            this.lblRetain.Size = new System.Drawing.Size(41, 13);
            this.lblRetain.TabIndex = 8;
            this.lblRetain.Text = "Retain:";
            // 
            // RetainCheckBox
            // 
            this.RetainCheckBox.AutoSize = true;
            this.RetainCheckBox.Location = new System.Drawing.Point(356, 78);
            this.RetainCheckBox.Name = "RetainCheckBox";
            this.RetainCheckBox.Size = new System.Drawing.Size(15, 14);
            this.RetainCheckBox.TabIndex = 9;
            this.RetainCheckBox.UseVisualStyleBackColor = true;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(15, 112);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(102, 13);
            this.lblTopic.TabIndex = 10;
            this.lblTopic.Text = "Topic for Subscribe:";
            // 
            // SubTopicTextBox
            // 
            this.SubTopicTextBox.Location = new System.Drawing.Point(124, 110);
            this.SubTopicTextBox.Name = "SubTopicTextBox";
            this.SubTopicTextBox.Size = new System.Drawing.Size(168, 20);
            this.SubTopicTextBox.TabIndex = 11;
            // 
            // lblTopicPublish
            // 
            this.lblTopicPublish.AutoSize = true;
            this.lblTopicPublish.Location = new System.Drawing.Point(15, 144);
            this.lblTopicPublish.Name = "lblTopicPublish";
            this.lblTopicPublish.Size = new System.Drawing.Size(89, 13);
            this.lblTopicPublish.TabIndex = 13;
            this.lblTopicPublish.Text = "Topic for Publish:";
            // 
            // PubTopicTextBox
            // 
            this.PubTopicTextBox.Location = new System.Drawing.Point(124, 142);
            this.PubTopicTextBox.Name = "PubTopicTextBox";
            this.PubTopicTextBox.Size = new System.Drawing.Size(169, 20);
            this.PubTopicTextBox.TabIndex = 14;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(15, 173);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "Message:";
            // 
            // PubMessageTextBox
            // 
            this.PubMessageTextBox.Location = new System.Drawing.Point(75, 171);
            this.PubMessageTextBox.Multiline = true;
            this.PubMessageTextBox.Name = "PubMessageTextBox";
            this.PubMessageTextBox.Size = new System.Drawing.Size(297, 52);
            this.PubMessageTextBox.TabIndex = 17;
            // 
            // PublishButton
            // 
            this.PublishButton.Location = new System.Drawing.Point(18, 229);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(346, 23);
            this.PublishButton.TabIndex = 18;
            this.PublishButton.Text = "Publish";
            this.PublishButton.UseVisualStyleBackColor = true;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(18, 268);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(346, 180);
            this.MessageTextBox.TabIndex = 19;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(299, 48);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(72, 23);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(299, 108);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(72, 23);
            this.DisconnectButton.TabIndex = 12;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(299, 140);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(72, 23);
            this.SubscribeButton.TabIndex = 15;
            this.SubscribeButton.Text = "Subscribe";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // SubListBox
            // 
            this.SubListBox.FormattingEnabled = true;
            this.SubListBox.Location = new System.Drawing.Point(389, 13);
            this.SubListBox.Name = "SubListBox";
            this.SubListBox.Size = new System.Drawing.Size(138, 433);
            this.SubListBox.TabIndex = 21;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(18, 454);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(346, 23);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // UnsubscribeButton
            // 
            this.UnsubscribeButton.Location = new System.Drawing.Point(389, 454);
            this.UnsubscribeButton.Name = "UnsubscribeButton";
            this.UnsubscribeButton.Size = new System.Drawing.Size(138, 23);
            this.UnsubscribeButton.TabIndex = 22;
            this.UnsubscribeButton.Text = "Unsubscribe";
            this.UnsubscribeButton.UseVisualStyleBackColor = true;
            // 
            // QosComboBox
            // 
            this.QosComboBox.FormattingEnabled = true;
            this.QosComboBox.Location = new System.Drawing.Point(199, 75);
            this.QosComboBox.Name = "QosComboBox";
            this.QosComboBox.Size = new System.Drawing.Size(93, 21);
            this.QosComboBox.TabIndex = 7;
            // 
            // lblConect
            // 
            this.lblConect.AutoSize = true;
            this.lblConect.Location = new System.Drawing.Point(196, 22);
            this.lblConect.Name = "lblConect";
            this.lblConect.Size = new System.Drawing.Size(16, 13);
            this.lblConect.TabIndex = 23;
            this.lblConect.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 487);
            this.Controls.Add(this.lblConect);
            this.Controls.Add(this.QosComboBox);
            this.Controls.Add(this.UnsubscribeButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SubListBox);
            this.Controls.Add(this.SubscribeButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.PublishButton);
            this.Controls.Add(this.PubMessageTextBox);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.PubTopicTextBox);
            this.Controls.Add(this.lblTopicPublish);
            this.Controls.Add(this.SubTopicTextBox);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.RetainCheckBox);
            this.Controls.Add(this.lblRetain);
            this.Controls.Add(this.lblQos);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.HostTextBox);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ClientMqtt - Envia Dados Protocolo MqTT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label lblQos;
        private System.Windows.Forms.Label lblRetain;
        private System.Windows.Forms.CheckBox RetainCheckBox;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox SubTopicTextBox;
        private System.Windows.Forms.Label lblTopicPublish;
        private System.Windows.Forms.TextBox PubTopicTextBox;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox PubMessageTextBox;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button SubscribeButton;
        private System.Windows.Forms.ListBox SubListBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UnsubscribeButton;
        private System.Windows.Forms.ComboBox QosComboBox;
        private System.Windows.Forms.Label lblConect;
    }
}

