using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
        }

       

        private void start2_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = " 2 старт";
            LandmarkName.Text = "5 км до Реки";
            Landmark.Visible = false; ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }


        private void start1_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Начало старта";
            LandmarkName.Text = "Часовой чонго марофон";
            Landmark.Visible = false; ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }

        private void point1_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 1";
            LandmarkName.Text = "МЦК Лужники";
            Landmark.Visible = true; ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;

        }

        private void point2_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 2";
            LandmarkName.Text = "Новодевичей монастырь";
            Landmark.Visible = true; ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = true; MedicalText.Visible = true;

            MedicalPaint.Location = new Point(16, 341); MedicalText.Location = new Point(62, 348);

        }

        private void point3_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 3";
            LandmarkName.Text = "Метро Киевская";
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;

        }

        private void point4_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 4";
            LandmarkName.Text = "МИД";
            Landmark.Visible = true; ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = true; MedicalText.Visible = true;

            MedicalPaint.Location = new Point(16, 292); MedicalText.Location = new Point(62, 307);
 
        }

        private void point5_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 5";
            LandmarkName.Text = "Парк Горького";
            Landmark.Visible = true; ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
 
        }

        private void point6_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 6";
            LandmarkName.Text = "Здания РАН";
            Landmark.Visible = true; ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;

        }

        private void point7_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 7";
            LandmarkName.Text = "Метро Воробевы горы";
            Landmark.Visible = true; ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = true; MedicalText.Visible = true;

            MedicalPaint.Location = new Point(16, 341); MedicalText.Location = new Point(62, 348);

        }

        private void start3_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Веселый старт";
            LandmarkName.Text = "5 км веселого бега";
            Landmark.Visible = false; ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;

        }

        private void point8_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Checkpoint 8";
            LandmarkName.Text = "Стадион Лужники";
            Landmark.Visible = true; ServicesProvided.Visible = true;
            DrinksPaint.Visible = true; DrinksText.Visible = true;
            ToiletsPaint.Visible = true; ToiletsText.Visible = true;
            EnergyBarsPaint.Visible = true; EnergyBarsText.Visible = true;
            InfaPaint.Visible = true; InfaText.Visible = true;
            MedicalPaint.Visible = true; MedicalText.Visible = true;

            MedicalPaint.Location = new Point(16, 341); MedicalText.Location = new Point(62, 348);

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            Checkpoint.Text = "Финиш";
            LandmarkName.Text = "Ура! Забег окончен. Поздравняем!";
            Landmark.Visible = false; ServicesProvided.Visible = false;
            DrinksPaint.Visible = false; DrinksText.Visible = false;
            EnergyBarsPaint.Visible = false; EnergyBarsText.Visible = false;
            ToiletsPaint.Visible = false; ToiletsText.Visible = false;
            InfaPaint.Visible = false; InfaText.Visible = false;
            MedicalPaint.Visible = false; MedicalText.Visible = false;
        }
    }
}