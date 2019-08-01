﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using InputDisplay.Entities;
using InputDisplay.Controllers;

namespace InputDisplay
{
    class Animator
    {

        public Animator(double fps) {
            this.Fps = fps;
            this.Controller = new Classic();
            this.Timer = new Timer();
        }

        public void ReadFile(String FileName)
        {
            this.GhostReader.ReadFile(FileName);
        }

        public void Clear()
        {
            this.FaceIndex = 0;
            this.AnalogIndex = 0;
            this.TrickIndex = 0;
            this.CurrentFrame = 0;

            this.Controller.Clear();
        }

        public bool Update()
        {
            int roundedFrame = (int) Math.Floor(this.CurrentFrame);

            //end of inputs reached
            if (roundedFrame >= this.GhostReader.TotalFrames)
            {
                return false;
            }

            if (roundedFrame >= this.GhostReader.Face_inputs[this.FaceIndex].endFrame)
            {
                this.FaceIndex += 1;
            }
            
            if (roundedFrame >= this.GhostReader.Analog_inputs[this.AnalogIndex].endFrame)
            {
                this.AnalogIndex += 1;
            }

            if (roundedFrame >= this.GhostReader.Trick_inputs[this.TrickIndex].endFrame)
            {
                this.TrickIndex += 1;
            }

            (bool accelerator, bool drift, bool item) actions = this.GhostReader.Face_inputs[this.FaceIndex].values;
            (double x, double y) coords = this.GhostReader.Analog_inputs[this.AnalogIndex].values;
            int trick = this.GhostReader.Trick_inputs[this.TrickIndex].values;

            this.Controller.Update(actions.accelerator, actions.drift, actions.item, coords, trick);

            this.CurrentFrame += (double) Config.PlaybackSpeed / this.Fps;
            return true;
        }

        public void Draw(ref Graphics g)
        {
            if (Config.DisplayTimer) { this.Timer.Draw(ref g, this.CurrentFrame); }

            this.Controller.Draw(ref g);
        }

        public (string, string) GetGhostInfo()
        {
            return (this.GhostReader.CompletionTime, this.GhostReader.MiiName);
        }

        public (string, Color, double) EvaluateCursor(Point cursor)
        {
            this.MousePos = cursor;
            return this.Controller.EvaluateCursor(cursor);
        }

        public void Highlight()
        {
            this.Controller.Highlight();
        }

        public void MoveShapes(Point cursor)
        {
            int xChange = cursor.X - this.MousePos.X;
            int yChange = cursor.Y - this.MousePos.Y;
            this.Controller.MoveShapes(xChange, yChange);
            this.MousePos = cursor;
        }

        public void Scale(double scale)
        {
            this.Controller.Scale(scale);
        }

        public void ChangeColour(Color colour)
        {
            this.Controller.ChangeColour(colour);
        }

        private GhostReader GhostReader = new GhostReader();
        private BaseController Controller;
        private Timer Timer;

        private int FaceIndex = 0;
        private int AnalogIndex = 0;
        private int TrickIndex = 0;
        private double Fps;
        private double CurrentFrame = 0;

        private Point MousePos;
    }
}
