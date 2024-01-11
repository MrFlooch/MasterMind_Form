using System;
using System.Windows.Forms;

namespace MasterMind_Form
{
    public partial class Difficulty : Form
    {
        #region Form Variables
        // Link to the other forms
        private readonly Menu mainMenu;
        private readonly Options optionsBG;

        // Default values for code length and number of colors
        public int codeLength = 4;
        public int colorLength = 7;
        #endregion

        #region Form Initialize
        public Difficulty(Menu menu, Options options)
        {
            InitializeComponent();

            // Set the minimum and maximum values for the TrackBar controls
            trackBarLength.Minimum = 3;
            trackBarColors.Minimum = 2;            
            trackBarLength.Maximum = 8;
            trackBarColors.Maximum = 7;

            // Store references to other forms
            mainMenu = menu;
            optionsBG = options;
            // Set the initial position of the window to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Handles the Load event of the Difficulty form.
        /// Initializes form elements based on language settings.
        /// </summary>
        private void Difficulty_Load(object sender, EventArgs e)
        {
            // Check the selected language in the "options" form
            bool IsEnglishChecked = optionsBG.IsEnglishChecked;
            bool IsGermanChecked = optionsBG.IsGermanChecked;
            bool IsItalianChecked = optionsBG.IsItalianChecked;
            //bool IsFrenchChecked = optionsBG.IsFrenchChecked;

            // Set labels based on the selected language
            if (IsEnglishChecked)
            {
                lenghtLbl.Text = "Code length";
                colorLbl.Text = "Number of colors";
            }
            else if (IsGermanChecked)
            {
                lenghtLbl.Text = "Codelänge";
                colorLbl.Text = "Anzahl der Farben";
            }
            else if (IsItalianChecked)
            {
                lenghtLbl.Text = "Lunghezza del codice";
                colorLbl.Text = "Numero di colori";
            }
            else
            {
                lenghtLbl.Text = "Longueur du code";
                colorLbl.Text = "Nombre de couleurs";
            }
        }
        #endregion

        #region Form Buttons
        /// <summary>
        /// Handles the Click event of the "Validate" button.
        /// Transmits the values to the Game form and shows it.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void ValidBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of the Game form and transmit values
            Game game = new Game(mainMenu, this, optionsBG)
            {
                initCodeLength = codeLength
            };
            // Show the Game form
            game.Show();
        }
        #endregion

        #region Form trackBar
        /// <summary>
        /// Handles the Scroll event of the "Code Length" TrackBar.
        /// Initializes the length of the code based on the TrackBar value.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void TrackBarLength_Scroll(object sender, EventArgs e)
        {
            // Set the code length based on the TrackBar value
            codeLength = trackBarLength.Value;
        }

        /// <summary>
        /// Handles the Scroll event of the "Number of Colors" TrackBar.
        /// Initializes the length of usable colors based on the TrackBar value.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">Event arguments.</param>
        private void TrackBarColors_Scroll(object sender, EventArgs e)
        {
            // Set the number of usable colors based on the TrackBar value
            colorLength = trackBarColors.Value;
        }
        #endregion
    }
}
