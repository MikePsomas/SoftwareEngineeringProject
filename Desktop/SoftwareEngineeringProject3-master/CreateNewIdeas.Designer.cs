
using System;

namespace WindowsFormsApp1
{
    partial class NewIdeas
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
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtIdeaTitle = new System.Windows.Forms.TextBox();
            this.TxtAbstract = new System.Windows.Forms.TextBox();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.TxtRegion = new System.Windows.Forms.TextBox();
            this.TxtCurrency = new System.Windows.Forms.TextBox();
            this.TxtIdealType = new System.Windows.Forms.TextBox();
            this.BtnCreateIdea = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.TxtMinor = new System.Windows.Forms.TextBox();
            this.TxtMajor = new System.Windows.Forms.TextBox();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtInsertIdea = new System.Windows.Forms.TextBox();
            this.lbRiskrating = new System.Windows.Forms.Label();
            this.cbRiskrating = new System.Windows.Forms.ComboBox();
            this.tbPublishDate = new System.Windows.Forms.TextBox();
            this.tbExpireDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Title.Location = new System.Drawing.Point(282, 2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(265, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "ENTER YOUR IDEA";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idea Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(7, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abstract";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(-3, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country Availability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(-3, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Regional Availability";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(-2, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Currency Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(-2, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Idea Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(-3, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Expire Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(-2, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Publish Date";
            // 
            // TxtIdeaTitle
            // 
            this.TxtIdeaTitle.Location = new System.Drawing.Point(126, 37);
            this.TxtIdeaTitle.Name = "TxtIdeaTitle";
            this.TxtIdeaTitle.Size = new System.Drawing.Size(568, 20);
            this.TxtIdeaTitle.TabIndex = 9;
            this.TxtIdeaTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtAbstract
            // 
            this.TxtAbstract.Location = new System.Drawing.Point(126, 145);
            this.TxtAbstract.Name = "TxtAbstract";
            this.TxtAbstract.Size = new System.Drawing.Size(568, 20);
            this.TxtAbstract.TabIndex = 10;
            this.TxtAbstract.TextChanged += new System.EventHandler(this.TxtAbstract_TextChanged);
            // 
            // TxtCountry
            // 
            this.TxtCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "B",
            "The Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "C",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "D",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "E",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "F",
            "Fiji",
            "Finland",
            "France",
            "G",
            "Gabon",
            "The Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "H",
            "Haiti",
            "Honduras",
            "Hungary",
            "I",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "J",
            "Jamaica",
            "Japan",
            "Jordan",
            "K",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "L",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "M",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "N",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia",
            "Norway",
            "O",
            "Oman",
            "P",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Q",
            "Qatar",
            "R",
            "Romania",
            "Russia",
            "Rwanda",
            "S",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sudan, South",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "T",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "U",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "V",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Y",
            "Yemen",
            "Z",
            "Zambia",
            "Zimbabwe"});
            this.TxtCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtCountry.Location = new System.Drawing.Point(171, 171);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(523, 20);
            this.TxtCountry.TabIndex = 11;
            this.TxtCountry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtRegion
            // 
            this.TxtRegion.Location = new System.Drawing.Point(171, 201);
            this.TxtRegion.Name = "TxtRegion";
            this.TxtRegion.Size = new System.Drawing.Size(523, 20);
            this.TxtRegion.TabIndex = 12;
            // 
            // TxtCurrency
            // 
            this.TxtCurrency.AutoCompleteCustomSource.AddRange(new string[] {
            "GBP £",
            "EUR €",
            "USD $"});
            this.TxtCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtCurrency.Location = new System.Drawing.Point(171, 235);
            this.TxtCurrency.Name = "TxtCurrency";
            this.TxtCurrency.Size = new System.Drawing.Size(523, 20);
            this.TxtCurrency.TabIndex = 13;
            // 
            // TxtIdealType
            // 
            this.TxtIdealType.Location = new System.Drawing.Point(171, 270);
            this.TxtIdealType.Name = "TxtIdealType";
            this.TxtIdealType.Size = new System.Drawing.Size(523, 20);
            this.TxtIdealType.TabIndex = 14;
            // 
            // BtnCreateIdea
            // 
            this.BtnCreateIdea.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCreateIdea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateIdea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCreateIdea.Location = new System.Drawing.Point(238, 401);
            this.BtnCreateIdea.Name = "BtnCreateIdea";
            this.BtnCreateIdea.Size = new System.Drawing.Size(354, 48);
            this.BtnCreateIdea.TabIndex = 17;
            this.BtnCreateIdea.Text = "CREATE IDEA";
            this.BtnCreateIdea.UseVisualStyleBackColor = false;
            this.BtnCreateIdea.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(708, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(92, 43);
            this.btnGoBack.TabIndex = 18;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtMinor
            // 
            this.TxtMinor.Location = new System.Drawing.Point(126, 117);
            this.TxtMinor.Name = "TxtMinor";
            this.TxtMinor.Size = new System.Drawing.Size(568, 20);
            this.TxtMinor.TabIndex = 19;
            // 
            // TxtMajor
            // 
            this.TxtMajor.Location = new System.Drawing.Point(126, 91);
            this.TxtMajor.Name = "TxtMajor";
            this.TxtMajor.Size = new System.Drawing.Size(568, 20);
            this.TxtMajor.TabIndex = 20;
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(126, 65);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(568, 20);
            this.TxtAuthor.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(3, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Author";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(3, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Major Sector";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(3, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Minor Sector";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(285, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Insert Idea:";
            // 
            // TxtInsertIdea
            // 
            this.TxtInsertIdea.Location = new System.Drawing.Point(288, 314);
            this.TxtInsertIdea.Multiline = true;
            this.TxtInsertIdea.Name = "TxtInsertIdea";
            this.TxtInsertIdea.Size = new System.Drawing.Size(406, 80);
            this.TxtInsertIdea.TabIndex = 25;
            // 
            // lbRiskrating
            // 
            this.lbRiskrating.AutoSize = true;
            this.lbRiskrating.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRiskrating.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbRiskrating.Location = new System.Drawing.Point(-2, 375);
            this.lbRiskrating.Name = "lbRiskrating";
            this.lbRiskrating.Size = new System.Drawing.Size(98, 18);
            this.lbRiskrating.TabIndex = 27;
            this.lbRiskrating.Text = "Risk Rating";
            // 
            // cbRiskrating
            // 
            this.cbRiskrating.FormattingEnabled = true;
            this.cbRiskrating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRiskrating.Location = new System.Drawing.Point(172, 374);
            this.cbRiskrating.Margin = new System.Windows.Forms.Padding(2);
            this.cbRiskrating.Name = "cbRiskrating";
            this.cbRiskrating.Size = new System.Drawing.Size(102, 21);
            this.cbRiskrating.TabIndex = 28;
            // 
            // tbPublishDate
            // 
            this.tbPublishDate.Location = new System.Drawing.Point(172, 315);
            this.tbPublishDate.Margin = new System.Windows.Forms.Padding(2);
            this.tbPublishDate.Name = "tbPublishDate";
            this.tbPublishDate.Size = new System.Drawing.Size(102, 20);
            this.tbPublishDate.TabIndex = 29;
            // 
            // tbExpireDate
            // 
            this.tbExpireDate.Location = new System.Drawing.Point(171, 346);
            this.tbExpireDate.Margin = new System.Windows.Forms.Padding(2);
            this.tbExpireDate.Name = "tbExpireDate";
            this.tbExpireDate.Size = new System.Drawing.Size(102, 20);
            this.tbExpireDate.TabIndex = 30;
            // 
            // NewIdeas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbExpireDate);
            this.Controls.Add(this.tbPublishDate);
            this.Controls.Add(this.cbRiskrating);
            this.Controls.Add(this.lbRiskrating);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtInsertIdea);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.TxtMajor);
            this.Controls.Add(this.TxtMinor);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.BtnCreateIdea);
            this.Controls.Add(this.TxtIdealType);
            this.Controls.Add(this.TxtCurrency);
            this.Controls.Add(this.TxtRegion);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.TxtAbstract);
            this.Controls.Add(this.TxtIdeaTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "NewIdeas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Ideas";
            this.Load += new System.EventHandler(this.NewIdeas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtAbstract_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtIdeaTitle;
        private System.Windows.Forms.TextBox TxtAbstract;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.TextBox TxtRegion;
        private System.Windows.Forms.TextBox TxtCurrency;
        private System.Windows.Forms.TextBox TxtIdealType;
        private System.Windows.Forms.Button BtnCreateIdea;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox TxtMinor;
        private System.Windows.Forms.TextBox TxtMajor;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtInsertIdea;
        private System.Windows.Forms.Label lbRiskrating;
        private System.Windows.Forms.ComboBox cbRiskrating;
        private System.Windows.Forms.TextBox tbPublishDate;
        private System.Windows.Forms.TextBox tbExpireDate;
    }
}