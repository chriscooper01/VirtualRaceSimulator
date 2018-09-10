using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinForm
{
    public partial class HorseRacingForm : Form
    {
        public HorseRacingForm()
        {
            InitializeComponent();
        }

        private bool validName = false;
        private bool validOdd = false;
        private int numerator = 0;
        private int denominator = 0;
        private void NameText_TextChanged(object sender, EventArgs e)
        {
            validName = RaceCore.HorseRacingHorseValidation.ValidateName(NameText.Text.Trim());
            enableAdd();
        }

        private void OddsText_TextChanged(object sender, EventArgs e)
        {

            numerator = 0;
            denominator = 0;
            bool valid = false;

            valid = int.TryParse(NumeratorTextBox.Text.Trim(), out numerator);

            valid = int.TryParse(DenominatorText.Text.Trim(), out denominator);
            validOdd = false;
            if (valid)
                validOdd = RaceCore.HorseRacingHorseValidation.ValidateOdd(numerator, denominator);
            
            enableAdd();
        }

              

        private void AddHorseButton_Click(object sender, EventArgs e)
        {            
            
            DataClasses.HorseDataClass horse = new DataClasses.HorseDataClass();
            if (RaceCore.HorseRacing.CreateHorse(NameText.Text, numerator, denominator, ref horse))
            {
                setHorse(horse);
                clearFields();
                ClearAllButton.Enabled = true;
                enableRace();
                NameText.Focus();
            }
            else
                MessageBox.Show("Horse creation failed", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void setHorse(DataClasses.HorseDataClass horse)
        {
            HorsesList.Items.Add(horse);
            HorsesList.DisplayMember = "Name";

        }

        private List<DataClasses.HorseDataClass> getHorses()
        {
            List<DataClasses.HorseDataClass> horses = new List<DataClasses.HorseDataClass>();
            foreach (var item in HorsesList.Items)
                horses.Add((DataClasses.HorseDataClass)item);

            return horses;
        }

        private void enableAdd()
        {
            AddHorseButton.Enabled = (validName && validOdd);
        }

        private void enableRace()
        {


            var horses = getHorses();
            decimal margin =  RaceCore.HorseRacingMargin.CalculateMargin(horses);

            RaceButton.Enabled = RaceCore.HorseRacingHorseValidation.ValidateMargin(margin);
        }

        private void clearFields()
        {
            NameText.Text = String.Empty;
            NumeratorTextBox.Text = String.Empty;
            DenominatorText.Text = String.Empty;
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            HorsesList.Items.Clear();
            clearFields();
            ClearAllButton.Enabled = false;
            RaceButton.Enabled = false;
        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            DataClasses.HorseDataClass winner = new DataClasses.HorseDataClass();
            var horses = getHorses();
            RaceCore.HorseRacing.Race(horses, ref winner);

            string message =  String.Format(" Horse {0} WON. {3} He had a {1}% chance of winning, with the Odds of {2} ", winner.Name, winner.Odds, Math.Round(winner.PercentageChance, 1),Environment.NewLine);
            MessageBox.Show(message, "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
