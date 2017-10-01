﻿namespace myoddweb.classifier.forms
{
  partial class OptionsForm
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
      this.reCheckCategories = new System.Windows.Forms.CheckBox();
      this.ok = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.reCheckIfCtrl = new System.Windows.Forms.CheckBox();
      this.checkCategoryIfUnknown = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.comboUser = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.comboMagnets = new System.Windows.Forms.ComboBox();
      this.Categories = new System.Windows.Forms.Button();
      this.Magnets = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.labelUserTrained = new System.Windows.Forms.Label();
      this.labelMagnets = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label8 = new System.Windows.Forms.Label();
      this.labelDefaultClassifyDelay = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.numericUpDownClassifyDelay = new System.Windows.Forms.NumericUpDown();
      this.checkAutomaticallyMagnetTrain = new System.Windows.Forms.CheckBox();
      this.checkAutomaticallyTrain = new System.Windows.Forms.CheckBox();
      this.numericCommonPercent = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.labelCommonWord = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.labelDisplaySizeDefault = new System.Windows.Forms.Label();
      this.comboDisplaySize = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.Log = new System.Windows.Forms.Button();
      this.labelDefaultRetention = new System.Windows.Forms.Label();
      this.comboRetention = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.labelDefaultLogLevel = new System.Windows.Forms.Label();
      this.comboLogLevel = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.checkUnProcessedEmails = new System.Windows.Forms.CheckBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassifyDelay)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericCommonPercent)).BeginInit();
      this.groupBox4.SuspendLayout();
      this.SuspendLayout();
      // 
      // reCheckCategories
      // 
      this.reCheckCategories.AutoSize = true;
      this.reCheckCategories.Location = new System.Drawing.Point(6, 19);
      this.reCheckCategories.Name = "reCheckCategories";
      this.reCheckCategories.Size = new System.Drawing.Size(278, 17);
      this.reCheckCategories.TabIndex = 0;
      this.reCheckCategories.Text = "Always re-check possible new category (can be slow)";
      this.reCheckCategories.UseVisualStyleBackColor = true;
      this.reCheckCategories.CheckedChanged += new System.EventHandler(this.reCheckCategories_CheckedChanged);
      // 
      // ok
      // 
      this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.ok.Location = new System.Drawing.Point(267, 465);
      this.ok.Name = "ok";
      this.ok.Size = new System.Drawing.Size(75, 23);
      this.ok.TabIndex = 8;
      this.ok.Text = "&Ok";
      this.ok.UseVisualStyleBackColor = true;
      this.ok.Click += new System.EventHandler(this.Ok_Click);
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button1.Location = new System.Drawing.Point(348, 465);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(79, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "&Cancel";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.reCheckIfCtrl);
      this.groupBox1.Controls.Add(this.checkCategoryIfUnknown);
      this.groupBox1.Controls.Add(this.reCheckCategories);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(414, 100);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Debug";
      // 
      // reCheckIfCtrl
      // 
      this.reCheckIfCtrl.AutoSize = true;
      this.reCheckIfCtrl.Location = new System.Drawing.Point(6, 65);
      this.reCheckIfCtrl.Name = "reCheckIfCtrl";
      this.reCheckIfCtrl.Size = new System.Drawing.Size(207, 17);
      this.reCheckIfCtrl.TabIndex = 2;
      this.reCheckIfCtrl.Text = "Always re-check if the Ctrl key is down";
      this.reCheckIfCtrl.UseVisualStyleBackColor = true;
      // 
      // checkCategoryIfUnknown
      // 
      this.checkCategoryIfUnknown.AutoSize = true;
      this.checkCategoryIfUnknown.Location = new System.Drawing.Point(23, 42);
      this.checkCategoryIfUnknown.Name = "checkCategoryIfUnknown";
      this.checkCategoryIfUnknown.Size = new System.Drawing.Size(192, 17);
      this.checkCategoryIfUnknown.TabIndex = 1;
      this.checkCategoryIfUnknown.Text = "Only if current category is unknown";
      this.checkCategoryIfUnknown.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 48);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "User trained";
      // 
      // comboUser
      // 
      this.comboUser.FormattingEnabled = true;
      this.comboUser.Location = new System.Drawing.Point(115, 45);
      this.comboUser.Name = "comboUser";
      this.comboUser.Size = new System.Drawing.Size(98, 21);
      this.comboUser.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Magnets";
      // 
      // comboMagnets
      // 
      this.comboMagnets.FormattingEnabled = true;
      this.comboMagnets.Location = new System.Drawing.Point(115, 16);
      this.comboMagnets.Name = "comboMagnets";
      this.comboMagnets.Size = new System.Drawing.Size(98, 21);
      this.comboMagnets.TabIndex = 3;
      // 
      // Categories
      // 
      this.Categories.Location = new System.Drawing.Point(12, 465);
      this.Categories.Name = "Categories";
      this.Categories.Size = new System.Drawing.Size(79, 23);
      this.Categories.TabIndex = 6;
      this.Categories.Text = "C&ategories ...";
      this.Categories.UseVisualStyleBackColor = true;
      this.Categories.Click += new System.EventHandler(this.Categories_Click);
      // 
      // Magnets
      // 
      this.Magnets.Location = new System.Drawing.Point(97, 465);
      this.Magnets.Name = "Magnets";
      this.Magnets.Size = new System.Drawing.Size(79, 23);
      this.Magnets.TabIndex = 7;
      this.Magnets.Text = "&Magnets ...";
      this.Magnets.UseVisualStyleBackColor = true;
      this.Magnets.Click += new System.EventHandler(this.Magnets_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.labelUserTrained);
      this.groupBox2.Controls.Add(this.labelMagnets);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.comboMagnets);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.comboUser);
      this.groupBox2.Location = new System.Drawing.Point(13, 118);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(414, 83);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Weights";
      // 
      // labelUserTrained
      // 
      this.labelUserTrained.AutoSize = true;
      this.labelUserTrained.Location = new System.Drawing.Point(254, 48);
      this.labelUserTrained.Name = "labelUserTrained";
      this.labelUserTrained.Size = new System.Drawing.Size(45, 13);
      this.labelUserTrained.TabIndex = 9;
      this.labelUserTrained.Text = "[default]";
      // 
      // labelMagnets
      // 
      this.labelMagnets.AutoSize = true;
      this.labelMagnets.Location = new System.Drawing.Point(254, 19);
      this.labelMagnets.Name = "labelMagnets";
      this.labelMagnets.Size = new System.Drawing.Size(45, 13);
      this.labelMagnets.TabIndex = 8;
      this.labelMagnets.Text = "[default]";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.checkUnProcessedEmails);
      this.groupBox3.Controls.Add(this.label8);
      this.groupBox3.Controls.Add(this.labelDefaultClassifyDelay);
      this.groupBox3.Controls.Add(this.label6);
      this.groupBox3.Controls.Add(this.numericUpDownClassifyDelay);
      this.groupBox3.Controls.Add(this.checkAutomaticallyMagnetTrain);
      this.groupBox3.Controls.Add(this.checkAutomaticallyTrain);
      this.groupBox3.Controls.Add(this.numericCommonPercent);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.labelCommonWord);
      this.groupBox3.Controls.Add(this.label1);
      this.groupBox3.Location = new System.Drawing.Point(12, 207);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(414, 143);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Misc";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(84, 93);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(27, 13);
      this.label8.TabIndex = 18;
      this.label8.Text = "sec.";
      // 
      // labelDefaultClassifyDelay
      // 
      this.labelDefaultClassifyDelay.AutoSize = true;
      this.labelDefaultClassifyDelay.Location = new System.Drawing.Point(255, 93);
      this.labelDefaultClassifyDelay.Name = "labelDefaultClassifyDelay";
      this.labelDefaultClassifyDelay.Size = new System.Drawing.Size(45, 13);
      this.labelDefaultClassifyDelay.TabIndex = 17;
      this.labelDefaultClassifyDelay.Text = "[default]";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(112, 93);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(130, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "Delay before classification";
      // 
      // numericUpDownClassifyDelay
      // 
      this.numericUpDownClassifyDelay.Location = new System.Drawing.Point(6, 91);
      this.numericUpDownClassifyDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDownClassifyDelay.Name = "numericUpDownClassifyDelay";
      this.numericUpDownClassifyDelay.Size = new System.Drawing.Size(72, 20);
      this.numericUpDownClassifyDelay.TabIndex = 15;
      this.numericUpDownClassifyDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // checkAutomaticallyMagnetTrain
      // 
      this.checkAutomaticallyMagnetTrain.AutoSize = true;
      this.checkAutomaticallyMagnetTrain.Location = new System.Drawing.Point(23, 68);
      this.checkAutomaticallyMagnetTrain.Name = "checkAutomaticallyMagnetTrain";
      this.checkAutomaticallyMagnetTrain.Size = new System.Drawing.Size(298, 17);
      this.checkAutomaticallyMagnetTrain.TabIndex = 14;
      this.checkAutomaticallyMagnetTrain.Text = "Automatically use new messages with magnets for training";
      this.checkAutomaticallyMagnetTrain.UseVisualStyleBackColor = true;
      // 
      // checkAutomaticallyTrain
      // 
      this.checkAutomaticallyTrain.AutoSize = true;
      this.checkAutomaticallyTrain.Location = new System.Drawing.Point(6, 45);
      this.checkAutomaticallyTrain.Name = "checkAutomaticallyTrain";
      this.checkAutomaticallyTrain.Size = new System.Drawing.Size(233, 17);
      this.checkAutomaticallyTrain.TabIndex = 13;
      this.checkAutomaticallyTrain.Text = "Automatically use new messages for training";
      this.checkAutomaticallyTrain.UseVisualStyleBackColor = true;
      this.checkAutomaticallyTrain.CheckedChanged += new System.EventHandler(this.checkAutomaticallyTrain_CheckedChanged);
      // 
      // numericCommonPercent
      // 
      this.numericCommonPercent.Location = new System.Drawing.Point(6, 19);
      this.numericCommonPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericCommonPercent.Name = "numericCommonPercent";
      this.numericCommonPercent.Size = new System.Drawing.Size(72, 20);
      this.numericCommonPercent.TabIndex = 12;
      this.numericCommonPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(82, 22);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(15, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "%";
      // 
      // labelCommonWord
      // 
      this.labelCommonWord.AutoSize = true;
      this.labelCommonWord.Location = new System.Drawing.Point(255, 22);
      this.labelCommonWord.Name = "labelCommonWord";
      this.labelCommonWord.Size = new System.Drawing.Size(45, 13);
      this.labelCommonWord.TabIndex = 10;
      this.labelCommonWord.Text = "[default]";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(112, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(130, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Delay before classification";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.labelDisplaySizeDefault);
      this.groupBox4.Controls.Add(this.comboDisplaySize);
      this.groupBox4.Controls.Add(this.label9);
      this.groupBox4.Controls.Add(this.Log);
      this.groupBox4.Controls.Add(this.labelDefaultRetention);
      this.groupBox4.Controls.Add(this.comboRetention);
      this.groupBox4.Controls.Add(this.label7);
      this.groupBox4.Controls.Add(this.labelDefaultLogLevel);
      this.groupBox4.Controls.Add(this.comboLogLevel);
      this.groupBox4.Controls.Add(this.label5);
      this.groupBox4.Location = new System.Drawing.Point(13, 356);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(414, 103);
      this.groupBox4.TabIndex = 15;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Log";
      // 
      // labelDisplaySizeDefault
      // 
      this.labelDisplaySizeDefault.AutoSize = true;
      this.labelDisplaySizeDefault.Location = new System.Drawing.Point(254, 73);
      this.labelDisplaySizeDefault.Name = "labelDisplaySizeDefault";
      this.labelDisplaySizeDefault.Size = new System.Drawing.Size(45, 13);
      this.labelDisplaySizeDefault.TabIndex = 21;
      this.labelDisplaySizeDefault.Text = "[default]";
      // 
      // comboDisplaySize
      // 
      this.comboDisplaySize.FormattingEnabled = true;
      this.comboDisplaySize.Location = new System.Drawing.Point(115, 70);
      this.comboDisplaySize.Name = "comboDisplaySize";
      this.comboDisplaySize.Size = new System.Drawing.Size(98, 21);
      this.comboDisplaySize.TabIndex = 20;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 73);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(85, 13);
      this.label9.TabIndex = 19;
      this.label9.Text = "Display Log Size";
      // 
      // Log
      // 
      this.Log.Location = new System.Drawing.Point(329, 41);
      this.Log.Name = "Log";
      this.Log.Size = new System.Drawing.Size(79, 23);
      this.Log.TabIndex = 16;
      this.Log.Text = "&Log ...";
      this.Log.UseVisualStyleBackColor = true;
      this.Log.Click += new System.EventHandler(this.Log_Click);
      // 
      // labelDefaultRetention
      // 
      this.labelDefaultRetention.AutoSize = true;
      this.labelDefaultRetention.Location = new System.Drawing.Point(254, 46);
      this.labelDefaultRetention.Name = "labelDefaultRetention";
      this.labelDefaultRetention.Size = new System.Drawing.Size(45, 13);
      this.labelDefaultRetention.TabIndex = 18;
      this.labelDefaultRetention.Text = "[default]";
      // 
      // comboRetention
      // 
      this.comboRetention.FormattingEnabled = true;
      this.comboRetention.Location = new System.Drawing.Point(115, 43);
      this.comboRetention.Name = "comboRetention";
      this.comboRetention.Size = new System.Drawing.Size(98, 21);
      this.comboRetention.TabIndex = 17;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 46);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(83, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "Retention policy";
      // 
      // labelDefaultLogLevel
      // 
      this.labelDefaultLogLevel.AutoSize = true;
      this.labelDefaultLogLevel.Location = new System.Drawing.Point(254, 19);
      this.labelDefaultLogLevel.Name = "labelDefaultLogLevel";
      this.labelDefaultLogLevel.Size = new System.Drawing.Size(45, 13);
      this.labelDefaultLogLevel.TabIndex = 15;
      this.labelDefaultLogLevel.Text = "[default]";
      // 
      // comboLogLevel
      // 
      this.comboLogLevel.FormattingEnabled = true;
      this.comboLogLevel.Location = new System.Drawing.Point(115, 16);
      this.comboLogLevel.Name = "comboLogLevel";
      this.comboLogLevel.Size = new System.Drawing.Size(121, 21);
      this.comboLogLevel.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 19);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Level";
      // 
      // checkUnProcessedEmails
      // 
      this.checkUnProcessedEmails.AutoSize = true;
      this.checkUnProcessedEmails.Location = new System.Drawing.Point(6, 117);
      this.checkUnProcessedEmails.Name = "checkUnProcessedEmails";
      this.checkUnProcessedEmails.Size = new System.Drawing.Size(203, 17);
      this.checkUnProcessedEmails.TabIndex = 19;
      this.checkUnProcessedEmails.Text = "Check unprocessed emails on startup";
      this.checkUnProcessedEmails.UseVisualStyleBackColor = true;
      // 
      // OptionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(437, 497);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.Magnets);
      this.Controls.Add(this.Categories);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.ok);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptionsForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Text = "Options";
      this.Load += new System.EventHandler(this.OnLoad);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClassifyDelay)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericCommonPercent)).EndInit();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.CheckBox reCheckCategories;
    private System.Windows.Forms.Button ok;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox checkCategoryIfUnknown;
    private System.Windows.Forms.CheckBox reCheckIfCtrl;
    private System.Windows.Forms.Button Categories;
    private System.Windows.Forms.Button Magnets;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboUser;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboMagnets;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelUserTrained;
    private System.Windows.Forms.Label labelMagnets;
    private System.Windows.Forms.Label labelCommonWord;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numericCommonPercent;
    private System.Windows.Forms.CheckBox checkAutomaticallyTrain;
    private System.Windows.Forms.CheckBox checkAutomaticallyMagnetTrain;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label labelDefaultRetention;
    private System.Windows.Forms.ComboBox comboRetention;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label labelDefaultLogLevel;
    private System.Windows.Forms.ComboBox comboLogLevel;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button Log;
    private System.Windows.Forms.NumericUpDown numericUpDownClassifyDelay;
    private System.Windows.Forms.Label labelDefaultClassifyDelay;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label labelDisplaySizeDefault;
    private System.Windows.Forms.ComboBox comboDisplaySize;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.CheckBox checkUnProcessedEmails;
  }
}