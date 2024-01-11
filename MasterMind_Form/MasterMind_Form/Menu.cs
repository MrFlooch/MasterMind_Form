using System;
using System.Drawing;
using System.Windows.Forms;

namespace MasterMind_Form
{
    public partial class Menu : Form
    {
        #region Form Fields
        // Instance of the Options class to manage language settings
        readonly Options optionsBG;
        #endregion

        #region Form Constructor

        public Menu()
        {
            InitializeComponent();

            // Set the initial position of the window to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Initialize the Options class, which manages language and background color settings
            optionsBG = new Options(this);
        }
        #endregion

        #region Form Events
        /// <summary>
        /// Handles the event when the "Quit" button is clicked, exiting the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the event when the "Rules" button is clicked, navigating to the Rules form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RulesBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the Rules form
            Rules rules = new Rules(this, optionsBG);

            // Hide the current form and show the Rules form
            this.Hide();
            rules.Show();
        }

        /// <summary>
        /// Handles the event when the "Options" button is clicked, navigating to the Options form.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void OptionBtn_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the Options form
            this.Hide();
            optionsBG.Show();
        }

        /// <summary>
        /// Handles the event when the "Play" button is clicked, navigating to the Difficulty form.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the Difficulty form
            Difficulty difficulty = new Difficulty(this, optionsBG);

            // Show the Difficulty form
            difficulty.Show();
        }

        /// <summary>
        /// Handles the Form Closing event, ensuring the application is exited.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit the application when the form is closing
            Application.Exit();
        }

        /// <summary>
        /// Handles the VisibleChanged event, updating the UI based on language and background settings.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void Menu_VisibleChanged(object sender, EventArgs e)
        {
            bool IsEnglishChecked = optionsBG.IsEnglishChecked;
            bool IsGermanChecked = optionsBG.IsGermanChecked;
            bool IsItalianChecked = optionsBG.IsItalianChecked;

            foregroundImagePnl.BackgroundImage = optionsBG.GetImageBackground();
            backgroundImagePnl.BackColor = optionsBG.GetColor();

            if (IsEnglishChecked)
            {
                titleCard.Text = "Welcome to MasterMind";
                playBtn.Text = "Play";
                rulesBtn.Text = "Rules";
                optionBtn.Text = "Options";
                quitBtn.Text = "Quit";
                this.Text = "MasterMind - Menu";
            }
            else if (IsGermanChecked)
            {
                titleCard.Text = "Willkommen bei MasterMind";
                playBtn.Text = "Spielen";
                rulesBtn.Text = "Regeln";
                optionBtn.Text = "Optionen";
                quitBtn.Text = "Beenden";
                this.Text = "MasterMind - Menü";
            }
            else if (IsItalianChecked)
            {
                titleCard.Text = "Benvenuto in MasterMind";
                playBtn.Text = "Giocare";
                rulesBtn.Text = "Regole";
                optionBtn.Text = "Opzioni";
                quitBtn.Text = "Esci";
                this.Text = "MasterMind - Menu";
            }
            else
            {
                titleCard.Text = "Bienvenue sur MasterMind";
                playBtn.Text = "Jouer";
                rulesBtn.Text = "Règles";
                optionBtn.Text = "Options";
                quitBtn.Text = "Quitter";
                this.Text = "MasterMind - Menu";
            }
            if (backgroundImagePnl.BackColor == Color.Brown)
            {
                titleCard.ForeColor = Color.Black;
                playBtn.ForeColor = Color.Black;
                rulesBtn.ForeColor = Color.Black;
                optionBtn.ForeColor = Color.Black;
                quitBtn.ForeColor = Color.Black;
            }
            else
            {
                titleCard.ForeColor = Color.White;
                playBtn.ForeColor = Color.White;
                rulesBtn.ForeColor = Color.White;
                optionBtn.ForeColor = Color.White;
                quitBtn.ForeColor = Color.White;
            }
        } // Fin Menu_VisibleChanged
        #endregion
    }
}
