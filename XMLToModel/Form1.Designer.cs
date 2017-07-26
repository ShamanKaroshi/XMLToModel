namespace XMLToModel
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
            this.cmdSelectXMLInputFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXMLInputFile = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtParserCodeNamespace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.txtModelFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSelectModelFile = new System.Windows.Forms.Button();
            this.cmdParseXML = new System.Windows.Forms.Button();
            this.txtXMLNode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkFixUpNames = new System.Windows.Forms.CheckBox();
            this.txtModelNamespace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelClassName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFunctionName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNodeListPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtParserOutputFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmdSelectParserFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSelectXMLInputFile
            // 
            this.cmdSelectXMLInputFile.Location = new System.Drawing.Point(620, 6);
            this.cmdSelectXMLInputFile.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSelectXMLInputFile.Name = "cmdSelectXMLInputFile";
            this.cmdSelectXMLInputFile.Size = new System.Drawing.Size(30, 19);
            this.cmdSelectXMLInputFile.TabIndex = 0;
            this.cmdSelectXMLInputFile.Text = "...";
            this.cmdSelectXMLInputFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "XML Input File:";
            // 
            // txtXMLInputFile
            // 
            this.txtXMLInputFile.Location = new System.Drawing.Point(81, 6);
            this.txtXMLInputFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtXMLInputFile.Name = "txtXMLInputFile";
            this.txtXMLInputFile.Size = new System.Drawing.Size(536, 20);
            this.txtXMLInputFile.TabIndex = 2;
            this.txtXMLInputFile.Text = "G:\\Projects\\HubX\\DataModel\\MOD-Sorts\\InfoLib-LENKS-WE-03-18-2017-Actual.Sorts.xml" +
    "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 558);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(458, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 563);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 557);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 523);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(458, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 528);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 522);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtParserCodeNamespace
            // 
            this.txtParserCodeNamespace.Location = new System.Drawing.Point(136, 257);
            this.txtParserCodeNamespace.Margin = new System.Windows.Forms.Padding(2);
            this.txtParserCodeNamespace.Name = "txtParserCodeNamespace";
            this.txtParserCodeNamespace.Size = new System.Drawing.Size(425, 20);
            this.txtParserCodeNamespace.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Parser Code Namespace:";
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(481, 397);
            this.cmdGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(80, 19);
            this.cmdGenerate.TabIndex = 9;
            this.cmdGenerate.Text = "Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // txtModelFileName
            // 
            this.txtModelFileName.Location = new System.Drawing.Point(81, 72);
            this.txtModelFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelFileName.Name = "txtModelFileName";
            this.txtModelFileName.Size = new System.Drawing.Size(536, 20);
            this.txtModelFileName.TabIndex = 14;
            this.txtModelFileName.Text = "E:\\Projects\\Utilities\\XMLToModel\\Models\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Model Filename:";
            // 
            // cmdSelectModelFile
            // 
            this.cmdSelectModelFile.Location = new System.Drawing.Point(620, 72);
            this.cmdSelectModelFile.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSelectModelFile.Name = "cmdSelectModelFile";
            this.cmdSelectModelFile.Size = new System.Drawing.Size(37, 19);
            this.cmdSelectModelFile.TabIndex = 12;
            this.cmdSelectModelFile.Text = "...";
            this.cmdSelectModelFile.UseVisualStyleBackColor = true;
            // 
            // cmdParseXML
            // 
            this.cmdParseXML.Location = new System.Drawing.Point(594, 37);
            this.cmdParseXML.Margin = new System.Windows.Forms.Padding(2);
            this.cmdParseXML.Name = "cmdParseXML";
            this.cmdParseXML.Size = new System.Drawing.Size(56, 19);
            this.cmdParseXML.TabIndex = 15;
            this.cmdParseXML.Text = "Parse";
            this.cmdParseXML.UseVisualStyleBackColor = true;
            this.cmdParseXML.Click += new System.EventHandler(this.cmdParseXML_Click);
            // 
            // txtXMLNode
            // 
            this.txtXMLNode.Location = new System.Drawing.Point(81, 37);
            this.txtXMLNode.Margin = new System.Windows.Forms.Padding(2);
            this.txtXMLNode.Name = "txtXMLNode";
            this.txtXMLNode.Size = new System.Drawing.Size(503, 20);
            this.txtXMLNode.TabIndex = 17;
            this.txtXMLNode.Text = "DATA_RECORD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "XML Node:";
            // 
            // chkFixUpNames
            // 
            this.chkFixUpNames.AutoSize = true;
            this.chkFixUpNames.Location = new System.Drawing.Point(81, 94);
            this.chkFixUpNames.Margin = new System.Windows.Forms.Padding(2);
            this.chkFixUpNames.Name = "chkFixUpNames";
            this.chkFixUpNames.Size = new System.Drawing.Size(137, 17);
            this.chkFixUpNames.TabIndex = 18;
            this.chkFixUpNames.Text = "Normalize Node Names";
            this.chkFixUpNames.UseVisualStyleBackColor = true;
            // 
            // txtModelNamespace
            // 
            this.txtModelNamespace.Location = new System.Drawing.Point(105, 122);
            this.txtModelNamespace.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelNamespace.Name = "txtModelNamespace";
            this.txtModelNamespace.Size = new System.Drawing.Size(458, 20);
            this.txtModelNamespace.TabIndex = 20;
            this.txtModelNamespace.Text = "Facility";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Model Namespace:";
            // 
            // txtModelClassName
            // 
            this.txtModelClassName.Location = new System.Drawing.Point(105, 153);
            this.txtModelClassName.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelClassName.Name = "txtModelClassName";
            this.txtModelClassName.Size = new System.Drawing.Size(458, 20);
            this.txtModelClassName.TabIndex = 22;
            this.txtModelClassName.Text = "FacilitySortPlan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Model Class Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(136, 291);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(2);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(425, 20);
            this.txtClassName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Parser Code Classname:";
            // 
            // txtFunctionName
            // 
            this.txtFunctionName.Location = new System.Drawing.Point(136, 327);
            this.txtFunctionName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFunctionName.Name = "txtFunctionName";
            this.txtFunctionName.Size = new System.Drawing.Size(425, 20);
            this.txtFunctionName.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 330);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Parser Function Name:";
            // 
            // txtNodeListPath
            // 
            this.txtNodeListPath.Location = new System.Drawing.Point(136, 362);
            this.txtNodeListPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodeListPath.Name = "txtNodeListPath";
            this.txtNodeListPath.Size = new System.Drawing.Size(425, 20);
            this.txtNodeListPath.TabIndex = 28;
            this.txtNodeListPath.Text = "/main/DATA_RECORD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 365);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "NodeList Path:";
            // 
            // txtParserOutputFile
            // 
            this.txtParserOutputFile.Location = new System.Drawing.Point(136, 228);
            this.txtParserOutputFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtParserOutputFile.Name = "txtParserOutputFile";
            this.txtParserOutputFile.Size = new System.Drawing.Size(425, 20);
            this.txtParserOutputFile.TabIndex = 31;
            this.txtParserOutputFile.Text = "E:\\Projects\\Utilities\\XMLToModel\\Models\\";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 230);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Filename:";
            // 
            // cmdSelectParserFile
            // 
            this.cmdSelectParserFile.Location = new System.Drawing.Point(564, 228);
            this.cmdSelectParserFile.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSelectParserFile.Name = "cmdSelectParserFile";
            this.cmdSelectParserFile.Size = new System.Drawing.Size(37, 19);
            this.cmdSelectParserFile.TabIndex = 29;
            this.cmdSelectParserFile.Text = "...";
            this.cmdSelectParserFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 613);
            this.Controls.Add(this.txtParserOutputFile);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmdSelectParserFile);
            this.Controls.Add(this.txtNodeListPath);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFunctionName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtModelClassName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModelNamespace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkFixUpNames);
            this.Controls.Add(this.txtXMLNode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdParseXML);
            this.Controls.Add(this.txtModelFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdSelectModelFile);
            this.Controls.Add(this.txtParserCodeNamespace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtXMLInputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSelectXMLInputFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSelectXMLInputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXMLInputFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtParserCodeNamespace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdGenerate;
        private System.Windows.Forms.TextBox txtModelFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdSelectModelFile;
        private System.Windows.Forms.Button cmdParseXML;
        private System.Windows.Forms.TextBox txtXMLNode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkFixUpNames;
        private System.Windows.Forms.TextBox txtModelNamespace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelClassName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFunctionName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNodeListPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtParserOutputFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cmdSelectParserFile;
    }
}

