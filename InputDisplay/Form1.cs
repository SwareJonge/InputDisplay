﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics; //testing

namespace InputDisplay
{
    public partial class Form1 : Form
    {
        private Animator Animator;
        private bool GhostLoaded = false;
        private bool Animate = false;

        private Stopwatch stopWatch = new Stopwatch();
        private AccurateTimer timer;

        private AdvancedWindow AdvancedWindow;

        private bool DisplayExternal = false;

        public Form1()
        {
            InitializeComponent();
            this.Animator = new Animator(50);
            this.AdvancedWindow = new AdvancedWindow(this);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Options = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = global::InputDisplay.Properties.Settings.Default.BackgroundColour;
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 295);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.numericUpDown2);
            this.Options.Controls.Add(this.button6);
            this.Options.Controls.Add(this.label4);
            this.Options.Controls.Add(this.numericUpDown1);
            this.Options.Controls.Add(this.checkBox1);
            this.Options.Controls.Add(this.label3);
            this.Options.Controls.Add(this.button2);
            this.Options.Controls.Add(this.label2);
            this.Options.Controls.Add(this.button1);
            this.Options.Controls.Add(this.label1);
            this.Options.Location = new System.Drawing.Point(12, 54);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(239, 261);
            this.Options.TabIndex = 2;
            this.Options.TabStop = false;
            this.Options.Text = "General Options";
            this.Options.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(189, 91);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 223);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Advanced";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Line Width";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(189, 117);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::InputDisplay.Properties.Settings.Default.DisplayTimer;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBox1.Location = new System.Drawing.Point(6, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Display Timer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Playback Speed";
            // 
            // button2
            // 
            this.button2.BackColor = global::InputDisplay.Properties.Settings.Default.ButtonColour;
            this.button2.Location = new System.Drawing.Point(176, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 20);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Button Colour";
            // 
            // button1
            // 
            this.button1.BackColor = global::InputDisplay.Properties.Settings.Default.BackgroundColour;
            this.button1.Location = new System.Drawing.Point(176, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 20);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background Colour";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(81, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Play";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 48);
            this.button4.TabIndex = 4;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 28);
            this.button5.TabIndex = 0;
            this.button5.Text = "Open File";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(257, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 314);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Time";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "MiiName";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "No File Selected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "File";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(257, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 47);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(729, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Options);
            this.MinimumSize = new System.Drawing.Size(745, 420);
            this.Name = "Form1";
            this.Text = "Input Display";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer = new AccurateTimer(this, new Action(TimerCallback), 20);
            if (this.checkBox1.Checked)
            {
                this.checkBox1.CheckState = CheckState.Checked;
            }
            else
            {
                this.checkBox1.CheckState = CheckState.Unchecked;
            }
            if (Config.CustomColours)
            {
                this.button2.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer.Stop();
        }

        public void Redraw()
        {
            this.pictureBox1.Invalidate();
        }

        public void SwitchButtonColourButton()
        {
            this.button2.Enabled = !this.button2.Enabled;
        }

        public void SwitchEnableControls()
        {
            this.groupBox1.Enabled = !this.groupBox1.Enabled;
            this.Options.Enabled = !this.Options.Enabled;
            this.button3.Enabled = !this.button3.Enabled;
            this.button4.Enabled = !this.button4.Enabled;
        }

        private void TimerCallback()
        {
            this.stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            //Console.WriteLine(stopWatch.Elapsed);

            //this.stopWatch.Restart();
            if (this.Animate)
            {
                if (this.Animator.Update())
                {
                    this.pictureBox1.Invalidate();
                } else
                {
                    this.Animator.Clear();
                    this.Button3_Click(null, null);
                }
                
            }
            //this.stopWatch.Stop();
            //Console.WriteLine(stopWatch.Elapsed);


            this.stopWatch.Restart();

            return;
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "rkg files (*.rkg)|*.rkg",
                RestoreDirectory = true,
                Title = ("Open File")
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.Animator.ReadFile(ofd.FileName);
                this.GhostLoaded = true;
                this.button3.Enabled = true;
                this.button4.Enabled = true;
                this.label6.Visible = false;

                (string time, string name) info = this.Animator.GetGhostInfo();
                this.label5.Text = Path.GetFileName(ofd.FileName);
                this.label7.Text = "Mii: " + info.name;
                this.label8.Text = "Time: " + info.time;
                this.label5.Visible = true;
                this.label7.Visible = true;
                this.label8.Visible = true;
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            this.Animator.Draw(ref g);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.button1.BackColor = this.colorDialog1.Color;
                this.pictureBox1.BackColor = this.button1.BackColor;
                Config.BackgroundColour = this.button1.BackColor;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.button2.BackColor = this.colorDialog1.Color;
                Config.ButtonColour = this.button2.BackColor;
                this.pictureBox1.Invalidate();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.GhostLoaded)
            {
                if (this.Animate)
                {
                    this.Animate = false;
                    this.button3.Text = "Play";
                    this.button3.BackColor = Color.LightGreen;

                } else
                {
                    this.Animate = true;
                    this.button3.Text = "Pause";
                    this.button3.BackColor = Color.LightGoldenrodYellow;
                }
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (this.GhostLoaded)
            {
                this.Animate = false;
                this.button3.Text = "Play";
                this.button3.BackColor = Color.LightGreen;
                this.Animator.Clear();
                this.pictureBox1.Invalidate();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Config.DisplayTimer = this.checkBox1.Checked;
            this.pictureBox1.Invalidate();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Config.LineWidth = (int) this.numericUpDown1.Value;
            this.pictureBox1.Invalidate();
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Config.PlaybackSpeed = (int) this.numericUpDown2.Value;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.AdvancedWindow.Show();
        }

        

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            int widthChange = control.Size.Width - 745;
            this.groupBox2.Width = 460 + widthChange;
            this.pictureBox1.Width = 448 + widthChange;
            this.panel1.Width = 460 + widthChange;

            int heightChange = control.Size.Height - 420;
            this.groupBox2.Height = 314 + heightChange;
            this.pictureBox1.Height = 295 + heightChange;
            this.button3.Location = new Point(81, 321 + heightChange);
            this.button4.Location = new Point(12, 321 + heightChange);
            this.panel1.Location = new Point(257, 322 + heightChange);
        }

        //
        // Drag drop system for picturebox
        //

        private bool Dragging = false;

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point pos = this.pictureBox1.PointToClient(Cursor.Position);
            Cursor.Current = Cursors.Hand;
            this.Dragging = this.Animator.EvaluateCursor(pos);
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dragging = false;
            Cursor.Current = Cursors.Default;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Dragging)
            {
                this.Animator.MoveShapes(this.pictureBox1.PointToClient(Cursor.Position));
                this.pictureBox1.Invalidate();
            }
        }
    }
}
